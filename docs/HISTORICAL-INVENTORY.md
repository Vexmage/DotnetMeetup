# EUG-003 Historical inventory

## Meetup records

The [repository assessment](REPOSITORY-ASSESSMENT.md) identified four 2025 records in the committed SQLite snapshot and the committed version of `DotnetMeetup.Client/Pages/Events.razor`. The working snapshot in `DotnetMeetup/DotnetMeetup/DotnetMeetup.db` and the empty-table seed in the host's `Program.cs` include the June session as a fifth record. The current Events page uses the database-backed API. The manual smoke test confirmed five insertions in an isolated database. Deployed coverage remains unknown.

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
- Assign stable archive identifiers and slugs after review. SQLite row IDs shifted when the June record was added, and populated databases skip the empty-table seed. Check completeness and deduplication before switching readers to the archive.
- Keep existing routes and assets accessible until the replacement archive is reviewed and approved. Review any route mappings or redirects before changing URLs. Keep past meetups visibly archival and discoverable through the proposed `/community/meetups` section. See the [site map](SITE-MAP.md#8-community) and [archive model](CONTENT-MODEL.md#12-meetup-archive-model).
