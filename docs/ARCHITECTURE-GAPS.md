# EUG-004 Architecture gaps

The [repository assessment](REPOSITORY-ASSESSMENT.md) confirms a .NET 9 ASP.NET Core host, Blazor WebAssembly client, and Shared Razor component library. The host uses EF Core with SQLite for events and existing Identity data. The recommended foundation retains all three projects, Bootstrap, SCSS, and SQLite. Adapt the existing layout, navigation, event cards, calendar, and form components where they fit.

## Changes required by the specifications

| Specification | Gap and proposed direction |
| --- | --- |
| [Project brief](PROJECT-BRIEF.md) and [site map](SITE-MAP.md) | The meetup homepage and navigation need an editorial Home and a shared masthead. Add Magazine and Lab listings and detail pages, a voluntary Directory with profiles and listing requests, Community with a distinct meetup archive, and About with mission, history, and editorial principles. Keep unfinished sections out of launch navigation as appropriate. |
| [Design system](DESIGN-SYSTEM.md) | Extend the existing SCSS and shared Razor layouts with semantic tokens, editorial typography, reading layouts, and accessible components. Use the approved Pacific Northwest palette and verify actual color pairs, keyboard access, focus, and responsive layouts. Palette adjustments require approval after accessibility testing. |
| [Content model](CONTENT-MODEL.md) | Event records alone cannot represent articles, projects, contributor credits, consented profiles, and archival presentations. Add typed models with stable IDs and slugs, validated metadata and references, and publication states. Keep private consent records out of public artifacts. Exclude drafts from public routes, listings, search, feeds, sitemaps, and client bundles. Preserve deliberately public archived entries. |
| [Technical architecture](TECHNICAL-ARCHITECTURE.md) | Current public routes use Interactive WebAssembly with prerendering for eligible requests. Review static server rendering for reading pages and selective interactivity for navigation, calendars, forms, filtering, and demos. Verify initial HTML, metadata and previews, status codes, and direct navigation. Establish appropriate validation and regression checks for publishing and legacy access. |

## Proposals and migration risks

- **Editorial storage.** Evaluate repository-managed Markdown with structured metadata behind typed content services. Retain SQLite for its existing workloads. Review storage, the authoring workflow, safe rendering and URL validation, and any parser dependency before adoption.
- **Legacy routing and data.** Review route mappings and compatibility for `/events`, `/shared-resources`, contribution routes, and `/api/events`. Compare original descriptions and use stable archive identifiers independent of SQLite row IDs. Startup migration currently runs unconditionally, and the five-event seed runs only on an empty table. A populated database can therefore lack the June entry. Review migration ownership and backfill behavior before moving records. [Historical inventory](HISTORICAL-INVENTORY.md)
- **Existing Identity and contribution behavior.** Account routes and an authorized forum placeholder exist. The talk proposal endpoint logs submissions without a durable delivery workflow. Review their future role and the editorial and directory intake workflows before changing them. Directory publication requires explicit consent.
- **Delivery confidence.** Manual smoke testing establishes a local baseline. The assessment found no tracked automated test project or CI workflow, and live hosting and database configuration remain unverified. Route compatibility, archive completeness, draft exclusion, and accessible initial rendering need verification during implementation.

## Separate maintenance concerns

1. **Prerendering BaseAddress error.** The manual smoke test observed the anticipated error. Home and Events issue relative requests during server prerendering with no HTTP base address. The WebAssembly client supplies a same-origin base address. Initial HTML can omit event data. Track the observed local HTTPS warning separately from the event request failure.
2. **Nullable-reference warnings.** The SDK 9.0.102 baseline build reported ten CS8618 warnings in Shared components and one CS8604 warning in Events. Review component initialization and nullable arguments in a maintenance change.
3. **Future .NET 10 LTS migration.** Keep the current target for the assessment. Review SDK selection, matching ASP.NET Core and EF Core packages, WebAssembly workload and targeting packs, and deployment compatibility in a separately approved upgrade.

## Recommended sequence

Obtain owner approval for Phase 01, then adapt the shared shell and design tokens. Review editorial storage, rendering, and legacy route decisions before content implementation. Validate archive parity and direct-route behavior before switching routes, then add public sections in the implementation plan's order. Publication and deployment require their own approval.
