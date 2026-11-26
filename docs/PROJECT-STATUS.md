# EugDotNet Project Status

## Direction

Evolve the existing DotnetMeetup application into EugDotNet, an independent Pacific Northwest technology publication, engineering laboratory, voluntary developer directory, and community resource. Preserve historical meetup material and access. All six primary destinations are planned. Public launch navigation may omit unfinished sections.

## Completed preparation

- Established the project specifications and repository operating instructions.
- Restored collapsed documentation examples, trees, diagrams, and templates.
- Reconciled the specifications and streamlined assignment-specific documentation guidance.
- Recorded the Phase 00 repository findings in [EUG-001](REPOSITORY-ASSESSMENT.md).
- Completed EUG-002 with the SDK 9.0.102 build and manual smoke test described below.
- Completed [EUG-003 historical inventory](HISTORICAL-INVENTORY.md) and [EUG-004 architecture gap analysis](ARCHITECTURE-GAPS.md).

## Working tree

The current branch is `feature/mvp-work`. Existing uncommitted application and database changes are present in:

- `DotnetMeetup/DotnetMeetup.Client/Pages/Events.razor`
- `DotnetMeetup/DotnetMeetup/Program.cs`
- `DotnetMeetup/DotnetMeetup/DotnetMeetup.db`

An untracked screenshot is also present. Preserve this existing work during assessment.

## EUG-002 local development baseline

- Installed SDKs are 7.0.100, 9.0.101, 9.0.102, and 10.0.400. The .NET and ASP.NET Core 9.0.1 runtimes are installed. All three solution projects target `net9.0`.
- `dotnet build DotnetMeetup.sln --no-restore` selected SDK 10.0.400 by default and failed with NETSDK1127 (Microsoft.NETCore.App targeting pack) and NETSDK1112 (Mono browser-wasm runtime pack). EUG-002 verified that all three projects have existing `obj/project.assets.json` files and repeated the solution build from a temporary directory with a `global.json` selecting SDK 9.0.102. This no-restore build succeeded (exit code 0). It reported 10 CS8618 warnings in Shared components and one CS8604 warning in Events, with zero errors.
- If restored assets are missing in another checkout, the restore command is `dotnet restore DotnetMeetup.sln` under SDK 9.0.102. Restore was unnecessary for this baseline and was not run. The solution has no test project, so no automated tests ran.

### Manual smoke test completed

The project owner reported a successful launch using SDK 9.0.102 and an isolated SQLite database. The smoke test verified migration, five event insertions, event API access, navigation, the homepage, Events and its calendar, Resources, and the contribution page. The anticipated prerendering BaseAddress error and a local HTTPS warning occurred.

## Phase 00 outcome and open decisions

Phase 00 is complete. The recommended direction retains the three Blazor projects, Bootstrap, SCSS, and SQLite. Editorial storage, public rendering modes, legacy route mappings, and archive identifiers remain open for owner review. External historical references and deployed data coverage remain unverified.

Track the prerendering failure, nullable-reference warnings, and a future .NET 10 LTS migration as separate maintenance items. The framework upgrade requires owner approval.

## Phase 01 design foundation

- Completed EUG-005 and EUG-006. The host stylesheet uses the approved palette, semantic tokens, and a two-tone keyboard focus indicator. The opt-in editorial classes provide responsive headings and reading text, a 68ch reading measure, metadata, and locally scrollable code blocks. Typography uses Georgia, system UI, and system monospace stacks. The new rules require no additional font assets or licenses.
- Compiled the tracked CSS with the locally installed Sass 1.87.0. The SDK 9.0.102 solution build with `--no-restore` passed with the 11 existing nullable-reference warnings and zero errors. A headless Edge stylesheet fixture verified the paper background, responsive reading scale, localized code scrolling, and the visible focus outline on a Bootstrap button at 492px and 1416px viewport widths.
- Representative contrast ratios from the compiled tokens include Forest Ink on Editorial Paper at 14.15:1, muted text at 5.80:1, and links and focus blue at 6.75:1. The light focus band against Cascade Evergreen measured 8.90:1. Coastal Mist on paper measured 1.31:1 and serves as a decorative divider. The separate control-border token measured 5.80:1 on paper.
- Completed EUG-007 and EUG-008. The shared masthead pairs the existing mountain logo with the EugDotNet wordmark, publication descriptor, and Eugene location. Primary navigation wraps at narrow widths and uses underlined current-page states with `aria-current`. It links to available pages and uses the existing account login route.
- The project owner completed manual visual review and approved the masthead and navigation's publication identity, typography, palette, and overall composition.
- The SDK 9.0.102 solution build passed with zero errors and the existing nullable-reference warnings. Headless Edge verified the live masthead at 1440px and 320px, including the logo, wrapping, 44px link targets, active styling, and keyboard focus. The homepage, Events, Resources, Contribute, talk proposal, and sign-in returned HTTP 200 using an isolated SQLite database.
- The protected `/forum` placeholder returns HTTP 500 on direct requests because authorization middleware is missing for that endpoint. It is omitted from the masthead. The existing route and authentication infrastructure remain in place for separate review.
- Completed EUG-009. The shared layout has an editorial footer with publication identity and links to existing meetup events, resources, and contribution pages. Contact, editorial policy, privacy, and accessibility links await approved content and working destinations.
- Completed EUG-010. The Shared Razor library provides section headings, article previews, category labels, publication metadata, featured content, editorial grids, and publication notices that also serve as empty states. The components are available for page composition. No sample publication content was added.
- Sass compilation succeeded. After the development server stopped, the SDK 9.0.102 solution build passed with `--no-restore` and standard output paths, reporting zero errors and one existing nullable-reference warning.
- Owner visual review of the footer and component compositions remains open. Homepage composition remains the EUG-011 assignment.
