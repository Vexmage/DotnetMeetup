# EugDotNet — Technical Architecture

## 1. Purpose

This document establishes the technical direction, architectural principles, engineering constraints, and implementation expectations for the EugDotNet application.

EugDotNet is an existing website originally developed to support a regional .NET meetup.

The application is evolving into an independent technology publication, software development laboratory, professional directory, and community resource.

The existing application should be evolved incrementally rather than replaced without justification.

This document describes a proposed architecture. Existing repository conditions must be verified before implementation.

## 2. Architectural Principles

The application should prioritize:

- Maintainability

- Simplicity

- Accessibility

- Security

- Performance

- Content portability

- Incremental development

- Low operational overhead

- Clear separation of responsibilities

- Compatibility with existing infrastructure

Architectural complexity must be justified by actual requirements.

Do not introduce infrastructure merely because it is fashionable, technically interesting, or potentially useful in a hypothetical future.

EugDotNet should itself demonstrate thoughtful software engineering.

## 3. Existing Repository Assessment

Before implementing substantial changes, inspect the repository and establish its current technical state.

Identify:

- Solution and project files

- Target .NET framework

- Installed SDK requirements

- ASP.NET Core configuration

- Blazor application type

- Existing rendering modes

- Routing conventions

- Layout components

- Dependency injection configuration

- Existing services

- Existing data models

- Content storage mechanisms

- CSS architecture

- Static assets

- Historical meetup content

- Existing tests

- NuGet dependencies

- Build configuration

- Deployment configuration

- Environment-specific settings

Inspect relevant files such as:

- Solution files

- Project files

- Program.cs

- global.json, if present

- appsettings.json

- Environment-specific configuration files

- Existing Razor components

- Existing layout components

- Existing stylesheets

- README.md

- Deployment manifests

- GitHub Actions workflows

Produce a concise repository assessment before proposing significant architectural changes.

Do not assume that the existing application uses a particular Blazor hosting model or rendering mode.

## 4. Technology Stack

### 4.1 Primary platform

The preferred application platform is:

- C#

- .NET

- ASP.NET Core

- Blazor and Razor components, where appropriate

- Semantic HTML

- CSS

- Minimal JavaScript where necessary

Preserve the existing framework unless there is a demonstrated reason to migrate.

### 4.2 Framework version

Determine the current target framework from the repository.

.NET 10 LTS is a preferred candidate for modernization if the existing application uses an older framework.

A framework upgrade must be evaluated separately from the editorial redesign.

Do not perform an automatic framework upgrade without documenting:

- Current framework version

- Proposed framework version

- Compatibility considerations

- Dependency implications

- Deployment requirements

- Expected benefits

- Migration risks

### 4.3 Additional technologies

EugDotNet may publish content about technologies outside the .NET ecosystem.

Laboratory projects may use:

- JavaScript

- TypeScript

- Python

- Rust

- Go

- SQL

- Linux tooling

- Other languages and frameworks

These projects do not need to become dependencies of the primary EugDotNet application.

The publication platform and the technologies it discusses are separate concerns.

## 5. Application Architecture

Prefer a modular monolithic architecture for the initial application.

The application should remain a single maintainable deployment unit unless specific requirements justify additional services.

Conceptual functional areas include:

- Magazine

- Laboratory

- Developer Directory

- Community

- Shared presentation

- Content management

- Application infrastructure

Functional boundaries should be reflected in the codebase without unnecessarily multiplying projects, assemblies, or abstraction layers.

Do not introduce microservices, distributed messaging, or complex orchestration for the initial publication.

## 6. Proposed Repository Organization

The following structure illustrates a possible organization.

It is not a mandatory replacement for the existing repository structure.

```
DotnetMeetup/
├── docs/
│   ├── PROJECT-BRIEF.md
│   ├── SITE-MAP.md
│   ├── DESIGN-SYSTEM.md
│   └── TECHNICAL-ARCHITECTURE.md
│
├── Content/
│   ├── Magazine/
│   ├── Lab/
│   ├── Directory/
│   └── Community/
│
├── Components/
│   ├── Layout/
│   ├── Pages/
│   ├── Editorial/
│   ├── Lab/
│   ├── Directory/
│   ├── Community/
│   └── Shared/
│
├── Models/
├── Services/
├── wwwroot/
│   ├── css/
│   ├── images/
│   ├── fonts/
│   └── js/
│
├── Tests/
├── Program.cs
├── appsettings.json
└── README.md
```

Adapt these conceptual directories to the existing solution and project structure.

Application content should remain distinguishable from engineering documentation.

The docs directory contains instructions and project documentation.

The Content directory contains material intended for publication.

The wwwroot directory contains intentionally public static assets.

Private drafts, configuration secrets, and internal documentation must not be placed in publicly accessible directories.

## 7. Content Architecture

### 7.1 Content-first approach

EugDotNet is primarily a publication.

Its architecture should reflect the importance of:

- Editorial content

- Technical documentation

- Project descriptions

- Professional profiles

- Historical records

- Community information

Content should remain portable and independently maintainable.

Avoid embedding substantial editorial material directly into Razor components when a suitable structured content mechanism is available.

### 7.2 Proposed initial storage

For the initial implementation, consider repository-based content using:

- Markdown for articles and long-form material

- YAML front matter or another consistent metadata format

- JSON for structured records where appropriate

- Static assets for images and downloadable materials

This approach provides:

- Version-controlled editorial history

- Straightforward backups

- Human-readable source material

- Compatibility with ordinary text editors

- Low infrastructure requirements

- Reviewable content changes

- Portability between future content management systems

Do not introduce a database solely to store a modest initial collection of articles.

If the existing application already has a suitable content storage mechanism, evaluate its continued use before introducing another.

### 7.3 Content lifecycle

Content should support a distinction between:

- Draft

- Published

- Archived

Future scheduling and editorial workflows may be introduced when justified.

Draft content must not appear in public listings, public search results, feeds, or direct public content routes.

Publication filtering must occur at the appropriate application or build boundary.

Do not rely solely on hiding draft content in the user interface.

### 7.4 Content identifiers

Published content should have stable identifiers and URL slugs.

Changing an article title should not automatically change its published URL.

Slug uniqueness must be validated within the appropriate content type.

Where published URLs change, provide redirects when practical.

## 8. Conceptual Content Models

The following models establish conceptual requirements rather than mandatory C# class definitions.

### 8.1 Article

An article may contain:

- Stable identifier

- Slug

- Title

- Subtitle

- Summary

- Author identifier

- Publication date

- Updated date

- Editorial category

- Article type

- Tags

- Publication status

- Featured status

- Optional image reference

- Article body

- References

- Related content identifiers

### 8.2 Laboratory project

A laboratory project may contain:

- Stable identifier

- Slug

- Title

- Summary

- Description

- Contributors

- Technology stack

- Project status

- Repository URL

- Demonstration URL

- Documentation URL

- Screenshots

- Related article identifiers

- Publication date

- Updated date

Project status should distinguish experimental work from maintained or production-ready software.

### 8.3 Developer profile

A developer profile may contain:

- Stable identifier

- Slug

- Professional display name

- Professional title

- Region

- Biography

- Technical specialties

- Portfolio URL

- Professional profile links

- Approved public contact information

- Availability status

- Last-confirmed date

- Optional profile image

- Related content identifiers

- Publication status

Only information explicitly approved for public display should enter the public content model.

Private consent records and administrative communications must remain outside public content files and public repository history.

### 8.4 Meetup archive entry

A meetup archive entry may contain:

- Stable identifier

- Slug

- Event title

- Event date

- Location

- Speaker information

- Description

- Presentation materials

- Photographs

- External links

- Related content identifiers

Existing historical information should be preserved even when it does not conform perfectly to a new content model.

Do not fabricate missing historical details.

### 8.5 Community event

A community event may contain:

- Stable identifier

- Event title

- Description

- Organizer

- Location

- Start date and time

- End date and time

- External event URL

- Event status

- Last-confirmed date

Distinguish events organized by EugDotNet from events merely listed or covered by the publication.

## 9. Content Services

Application services should provide a consistent means of accessing and presenting content.

Potential responsibilities include:

- Discovering content

- Parsing metadata

- Validating content

- Retrieving content by identifier or slug

- Filtering published content

- Sorting content

- Resolving related content

- Rendering Markdown

- Producing content summaries

- Supporting future search and syndication

Use dependency injection where consistent with the existing ASP.NET Core architecture.

Introduce service interfaces where they provide a meaningful boundary, improve testability, or permit future storage changes.

Avoid creating interfaces and abstraction layers for every class without a demonstrated benefit.

Content services should not contain presentation-specific HTML layout decisions.

## 10. Markdown Rendering

Markdown is the preferred candidate for long-form editorial content.

Evaluate existing Markdown support before introducing a new dependency.

Markdig is a potential .NET Markdown rendering library, subject to dependency review and approval.

Markdown rendering should support:

- Headings

- Paragraphs

- Lists

- Block quotations

- Tables

- Fenced code blocks

- Inline code

- Images

- Hyperlinks

- Footnotes where supported

Rendered content must be handled safely.

Raw HTML should be disabled or sanitized according to the content trust model.

Do not assume that Markdown rendering automatically prevents cross-site scripting.

Validate or restrict unsafe link schemes and embedded content.

Third-party submitted content must not be treated as trusted executable markup.

## 11. Rendering Strategy

Inspect the existing Blazor application before selecting rendering modes.

Prefer server-rendered or statically rendered content for public editorial pages where supported by the application.

Most publication pages do not require persistent interactive sessions.

Use interactive components selectively for features such as:

- Directory filtering

- Interactive laboratory demonstrations

- Search interfaces

- Navigation controls

- Other interactions that genuinely require application state

Do not make the entire publication dependent on client-side interactivity without justification.

Public editorial content should be readily accessible to:

- Ordinary web browsers

- Search engines

- Assistive technologies

- Link preview services

- Archival tools

Laboratory demonstrations may use specialized rendering strategies without imposing those requirements on the entire application.

## 12. Routing

Follow the information architecture established in SITE-MAP.md.

Proposed public routes include:

- /

- /magazine

- /magazine/{slug}

- /lab

- /lab/{slug}

- /directory

- /directory/{slug}

- /community

- /community/meetups

- /community/events

- /community/resources

- /about

Existing routes should be inventoried before modification.

Preserve existing public URLs where practical.

Introduce redirects for important historical routes when their destinations change.

Provide appropriate HTTP status codes for missing or unavailable content.

Do not present missing content as a successful page response merely containing an error message.

## 13. Frontend Architecture

Follow DESIGN-SYSTEM.md for visual and interaction requirements.

The frontend should use:

- Shared layouts

- Reusable Razor components

- Semantic HTML

- Semantic CSS design tokens

- Responsive layouts

- Accessible interaction patterns

Prefer the existing CSS architecture where it remains suitable.

Evaluate Blazor CSS isolation for component-specific styling.

Shared typography, color, spacing, and layout definitions should remain centralized.

Do not introduce a frontend framework or large component library solely to reproduce standard HTML and CSS behavior.

JavaScript interoperability should be limited to functionality that benefits from it.

## 14. Search and Filtering

The initial publication may use straightforward in-memory filtering of a modest content collection.

Potential searchable fields include:

- Titles

- Summaries

- Categories

- Tags

- Author names

- Technology specialties

- Published article text

Only published and intentionally public content may be included in search results.

Evaluate search requirements as the content collection grows.

Do not introduce Elasticsearch, OpenSearch, or an external search service for the initial implementation without a demonstrated need.

## 15. Database and Persistence Strategy

A database is not an automatic requirement for the initial publication.

Potential reasons to introduce persistent database storage later include:

- Substantial growth in content volume

- Multiple editorial contributors

- Browser-based content management

- Authenticated administrative workflows

- Directory submission processing

- Complex content relationships

- User-managed profiles

SQLite may be considered for modest single-instance deployments with suitable persistent storage.

PostgreSQL may be considered when requirements justify a separate relational database service.

Entity Framework Core may be evaluated if relational persistence becomes necessary.

Database selection must account for:

- Existing hosting infrastructure

- Deployment model

- Backup requirements

- Concurrency

- Maintenance overhead

- Operational cost

- Data migration requirements

Do not implement speculative persistence infrastructure.

## 16. Authentication and Administration

The initial publication should not require public user accounts.

Public reading, directory browsing, and laboratory exploration should remain accessible without authentication.

Editorial content may initially be maintained through version-controlled files.

Directory participation requests may initially be handled through an approved contact mechanism.

Do not introduce:

- Public registration

- Password management

- Social login

- User dashboards

- Messaging systems

- Comment systems

- Administrative portals

These features require separate approval and security evaluation.

If authentication becomes necessary, prefer established ASP.NET Core authentication mechanisms rather than custom authentication implementations.

## 17. Security and Privacy

Security must be considered throughout development.

Requirements include:

- Never commit credentials or API keys.

- Keep secrets outside source control.

- Use environment variables or appropriate secret-management mechanisms.

- Validate external input.

- Safely render editorial content.

- Restrict public exposure of internal files.

- Avoid unnecessary collection of personal information.

- Review third-party dependencies.

- Maintain supported framework versions.

- Use HTTPS in production.

- Apply appropriate security headers.

- Protect any future forms against abuse.

- Avoid logging sensitive information.

Evaluate security headers against the application's actual rendering and hosting requirements.

Public developer directory information must be voluntary and approved.

Do not expose private email addresses, personal addresses, consent records, or administrative notes.

No external AI service should receive private repository content, unpublished material, secrets, or personal information without explicit approval.

## 18. AI-Assisted Development

EugDotNet may be developed with assistance from AI tools, including Codex, ChatGPT, Gemini, and other approved systems.

AI tools are development assistants rather than autonomous project owners.

Repository access should be limited to the specific EugDotNet repository.

AI-assisted changes must:

- Respect existing architecture.

- Follow project documentation.

- Remain reviewable.

- Avoid unrelated modifications.

- Preserve historical content.

- Avoid introducing unapproved dependencies.

- Include appropriate testing.

- Disclose assumptions and unresolved issues.

AI tools must not independently:

- Access unrelated repositories.

- Retrieve private credentials.

- Modify production infrastructure.

- Deploy to production.

- Purchase services.

- Introduce paid dependencies.

- Publish editorial material.

- Submit personal information to external services.

- Grant additional permissions.

- Remove historical records.

External services and integrations require explicit approval.

## 19. Testing Strategy

Use the existing testing framework where appropriate.

Potential testing areas include:

### Unit testing

- Content metadata parsing

- Content validation

- Slug validation

- Publication filtering

- Content sorting

- Related-content resolution

- Date handling

### Integration testing

- Public routes

- Article retrieval

- Missing content behavior

- Draft content exclusion

- Historical redirects

- Application startup

### Frontend testing

- Responsive layouts

- Navigation behavior

- Keyboard accessibility

- Color contrast

- Heading structure

- Form accessibility

- Code block behavior

- Broken links

Potential tools include:

- xUnit

- ASP.NET Core integration testing

- bUnit

- Playwright

- axe

- Lighthouse

These are candidates rather than mandatory dependencies.

Select tools according to actual testing requirements and existing project conventions.

## 20. Performance

The application should remain lightweight and efficient.

Prioritize:

- Efficient server rendering

- Appropriate content caching

- Optimized images

- Limited JavaScript

- Limited font loading

- Stable layouts

- Efficient content discovery

- Appropriate HTTP caching

For repository-based content, avoid repeatedly parsing the entire content collection for every request when a simpler caching strategy is appropriate.

Do not introduce distributed caching or specialized performance infrastructure prematurely.

Performance improvements should respond to measured problems.

## 21. Search Engine Optimization and Syndication

Public content should support:

- Meaningful page titles

- Page-specific descriptions

- Canonical URLs

- Semantic headings

- Appropriate Open Graph metadata

- Descriptive image alternatives

- Stable public URLs

- XML sitemap generation

- Appropriate robots.txt configuration

RSS or Atom feeds are desirable future publication features.

Structured metadata may be introduced where appropriate for:

- Articles

- Authors

- Organizations

- Events

Do not fabricate publication dates, author identities, ratings, or other structured metadata.

## 22. Deployment

Inspect the existing deployment configuration before proposing changes.

Determine:

- Current hosting provider

- Current production environment

- Existing deployment process

- Domain configuration

- HTTPS configuration

- Runtime requirements

- Environment variables

- Backup procedures

- Existing CI/CD workflows

Preserve working deployment infrastructure where practical.

The initial architecture should support a modest hosting footprint.

Docker, reverse proxies, Linux hosting, and automated deployment may be considered when compatible with existing infrastructure.

Do not modify production infrastructure or initiate deployment without explicit authorization.

## 23. Build and Continuous Integration

Document the verified local development process.

Where applicable, standard .NET commands may include:

```
dotnet restore
dotnet build
dotnet test
dotnet run
```

The exact commands must reflect the actual solution and project structure.

Continuous integration should eventually validate:

- Dependency restoration

- Compilation

- Automated tests

- Content metadata

- Duplicate slugs

- Required content fields

- Other critical publication constraints

Do not replace an existing working CI/CD process without justification.

Production deployment should remain a separately authorized operation.

## 24. Historical Content Preservation

The original EugDotNet meetup website represents actual community activity and must be treated as a historical resource.

Before restructuring historical content:

- Inventory existing pages.

- Inventory presentation materials.

- Inventory photographs and images.

- Identify existing public URLs.

- Identify associated metadata.

- Determine an appropriate preservation strategy.

Historical material should be migrated or retained without unnecessary loss.

Do not delete existing assets merely because they are not immediately referenced by the redesigned homepage.

Preserve attribution and original event dates.

## 25. Implementation Sequence

### Stage 1 — Repository assessment

- Inspect the existing application.

- Document its architecture.

- Identify existing content and assets.

- Verify local build behavior.

- Identify technical constraints.

### Stage 2 — Shared application foundation

- Establish or refine shared layouts.

- Implement semantic design tokens.

- Establish navigation.

- Preserve existing routes where appropriate.

- Implement the editorial visual foundation.

### Stage 3 — Content foundation

- Evaluate existing content mechanisms.

- Establish approved content models.

- Implement content discovery and validation.

- Implement safe content rendering.

- Establish publication filtering.

### Stage 4 — Public sections

- Magazine

- Lab

- Directory

- Community

- About

### Stage 5 — Quality assurance

- Automated tests

- Accessibility evaluation

- Responsive testing

- Content validation

- Link validation

- Performance evaluation

- Security review

### Stage 6 — Deployment preparation

- Verify production compatibility.

- Document deployment requirements.

- Review configuration.

- Establish rollback procedures.

- Obtain deployment approval.

Each stage should produce a coherent, reviewable result.

Do not attempt to implement the entire proposed platform in a single uncontrolled change.

## 26. Architectural Decision Records

Significant technical decisions should be documented.

Potential decisions requiring documentation include:

- Framework upgrades

- Rendering strategy

- Content storage

- Markdown rendering

- Database introduction

- Authentication

- Deployment changes

- External integrations

- Major dependency additions

Architectural decision records may be stored in:

```
docs/adr/
```

Each record should describe:

- Context

- Decision

- Alternatives considered

- Rationale

- Consequences

- Approval status

Do not create architectural decision records for trivial implementation details.

## 27. Definition of Technical Success

The initial technical architecture should be considered successful when:

- The application builds reliably.

- Existing historical material is preserved.

- Public content can be maintained efficiently.

- Editorial pages render correctly.

- Navigation is accessible.

- Published and draft content are properly separated.

- The application remains secure and maintainable.

- Infrastructure requirements remain modest.

- The architecture supports incremental expansion.

- Another competent .NET developer can understand and maintain the application.

EugDotNet should demonstrate engineering judgment through simplicity, clarity, and durability rather than unnecessary technical complexity.
