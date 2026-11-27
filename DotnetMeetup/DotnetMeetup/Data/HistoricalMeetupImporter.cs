using System.Text.Json;
using DotnetMeetup.Shared.Models;

namespace DotnetMeetup.Data;

public static class HistoricalMeetupImporter
{
    public static int Import(ApplicationDbContext db)
    {
        using var archive = typeof(HistoricalMeetupImporter).Assembly
            .GetManifestResourceStream("HistoricalMeetups.json")
            ?? throw new InvalidOperationException("The historical meetup archive is missing.");
        var entries = JsonSerializer.Deserialize<ArchiveEntry[]>(archive, JsonSerializerOptions.Web)
            ?? throw new InvalidOperationException("The historical meetup archive is empty.");

        // SQLite's default write transaction serializes the lookup and insert across hosts.
        using var transaction = db.Database.BeginTransaction();
        var dates = entries.Select(entry => entry.Date).Distinct().ToArray();
        var existing = db.Events.Where(meetup => dates.Contains(meetup.Date))
            .Select(meetup => new { meetup.Date, meetup.Title, meetup.Location })
            .ToList()
            .Select(meetup => (meetup.Date, Title: NormalizeTitle(meetup.Title), meetup.Location))
            .ToHashSet();

        var inserted = 0;
        foreach (var entry in entries)
        {
            if (!existing.Add((entry.Date, NormalizeTitle(entry.Title), entry.Location)))
            {
                continue;
            }

            db.Events.Add(new Event
            {
                Title = entry.Title,
                Date = entry.Date,
                Location = entry.Location,
                Description = entry.Description
            });
            inserted++;
        }

        if (inserted > 0)
        {
            db.SaveChanges();
        }

        transaction.Commit();
        return inserted;
    }

    // Older seeds could decode the dinner titles' en dash as a replacement character.
    private static string NormalizeTitle(string title) => title.Replace(" \uFFFD ", " – ");

    private sealed record ArchiveEntry(string Title, DateTime Date, string Location, string Description);
}
