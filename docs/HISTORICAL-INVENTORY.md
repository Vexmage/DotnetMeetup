# EUG-003 Historical inventory

## Meetup records

The [repository assessment](REPOSITORY-ASSESSMENT.md) identified four 2025 records in the committed SQLite snapshot and the committed version of `DotnetMeetup.Client/Pages/Events.razor`. The working SQLite snapshot also contains the June session. The [JSON archive](../DotnetMeetup/DotnetMeetup/Data/HistoricalMeetups.json) preserves all five records and the credits verified in their descriptions. Dates retain the original Eugene wall-clock values without adding an offset. Archive IDs are stable and independent of SQLite IDs. The Events page continues to use the database-backed API. Deployed coverage remains unknown.

| Recorded date and local time | Event and attribution | Venue and recorded subject |
| --- | --- | --- |
| Jan 8, 2025, 5:30 PM | .NET Dinner – January, hosted by Mark Davis | Claim 52 Kitchen, Eugene. Informal networking and discussion of the local developer community. |
| Feb 28, 2025, 5:30 PM | .NET Dinner – February, hosted by Mark Davis | Claim 52 Kitchen, Eugene. Meetup updates, team introductions, and CodeChops mentoring for Blazor and Oqtane. |
| Mar 12, 2025, 6:00 PM | ASP.NET Core MVC Workshop, presented by Joel Southall | Deschutes Hall Room 220, UO. Hands-on MVC and CRUD with EF Core and SQLite. |
| Apr 23, 2025, 6:00 PM | Code Koans and Katas, led by Michael Birchmeier | Deschutes Hall Room 220, UO. Interactive coding exercises. |
| Jun 5, 2025, 6:00 PM | BlazorPhilosobot: Building a Chatbot with .NET and AI, presented by Joel Southall | Deschutes Hall Room 220, UO. A Blazor chatbot using OpenAI's API and conversational personas. |

Dinner host and session speaker credits come from the event descriptions. Additional event organizers remain unverified.

## Routes and external references

| Existing path | Material to account for |
| --- | --- |
| `/` | Meetup homepage and database-backed event content. |
| `/events` | Event listing and calendar. Git retains the earlier static past-event cards and their descriptions. |
| `/shared-resources` | Local community links, learning resources, tools, and project links in `Resources.razor`. |
| `/contribute`, `/contribute/talk` | Community participation and talk proposal pages. |
| `/api/events` | JSON event feed used by Home and Events. Assess consumers before changing the contract. |

Community references include [EugDotNet on Meetup](https://www.meetup.com/eugdotnet/), [LetsCode Discord](https://discord.gg/fw5YfbTYgC), the [DotnetMeetup repository](https://github.com/Dfreem/DotnetMeetup), and [Eugene Tech](https://eugtech.org). Link availability, particularly the Discord invite, and individual Meetup event permalinks remain unverified. The assessment identified no dedicated local event permalinks or verified slide decks, PDFs, recordings, event photographs, or session-specific repositories. Locate and verify any such references before adding them to the archive.

## Assets and preservation

- The host's `wwwroot/images/` contains the navbar logo, favicon variants, and `forrest_mountains.png`. Shared's `wwwroot/background.png` and the four timestamped PNGs linked from the root README are site and design assets. Preserve the files and record provenance for assets carried forward. The untracked screenshot was outside the assessment scope.
- Compare the full descriptions from Git, the seed, and SQLite before migration. Preserve original wording, dates, venue details, host and speaker credits, source URLs, and source differences. Label reconstructions and corrections. Record missing details as unknown.
- Keep archive IDs stable when editing metadata. SQLite row IDs shifted when the June record was added to the working snapshot. Review public slugs and route mappings before switching readers to the archive.
- Keep existing routes and assets accessible until the replacement archive is reviewed and approved. Review any route mappings or redirects before changing URLs. Keep past meetups visibly archival and discoverable through the proposed `/community/meetups` section. See the [site map](SITE-MAP.md#8-community) and [archive model](CONTENT-MODEL.md#12-meetup-archive-model).

## Import and migration strategy

The host embeds the JSON and imports missing events at startup after the schema is available. The importer matches on recorded date and time, title, and venue, allowing the replacement character found in legacy dinner titles. It inserts in a single SQLite write transaction and leaves existing rows and IDs intact. Archive IDs stay in the JSON. A legacy record with a changed title, time, or venue needs manual reconciliation before import to avoid a duplicate. An existing row with the same matching fields is preserved even if its description differs.

- **Development.** For a disposable SQLite database, set the database connection to the isolated file, select the Development environment, and explicitly set `Database__ApplyMigrationsOnStartup=true`. The setting defaults to off. A fresh database needs its schema before the importer can run.
- **Production.** Back up the persistent database and review and test the EF migration against a copy. Use a separate deployment step with a single runner to apply the reviewed migration before starting the host. The host then performs the insert-only archive import. The startup migration setting has no effect outside Development. Verify all five records through the event API after an approved release.
