# EugDotNet — Content Model and Publishing Conventions

## 1. Purpose

This document defines the conceptual content models, metadata conventions, relationships, validation requirements, and publication lifecycle for EugDotNet.

It complements:

- PROJECT-BRIEF.md

- SITE-MAP.md

- DESIGN-SYSTEM.md

- TECHNICAL-ARCHITECTURE.md

EugDotNet is a content-oriented application serving four principal functions:

- Independent technology journalism and editorial publishing.

- Technical experimentation and project documentation.

- Regional professional discovery.

- Community documentation and historical preservation.

The content architecture should support these functions without introducing unnecessary operational complexity.

## 2. Content Modeling Principles

Content should be:

- Structured.

- Portable.

- Human-readable.

- Version-controlled where appropriate.

- Independently maintainable.

- Accessible.

- Explicitly attributed.

- Validated before publication.

- Capable of incremental expansion.

Content models should distinguish between editorial material, technical projects, professional information, and historical records.

Do not force unrelated content types into a single generic model merely to reduce the number of classes.

Shared metadata should be standardized where meaningful.

## 3. Proposed Content Storage

The preferred initial approach is repository-based content, subject to inspection of the existing application.

Use Markdown for substantial human-authored prose and structured metadata for content discovery, validation, and presentation.

Potential formats include:

- Markdown with YAML front matter.

- JSON for structured records.

- Existing application-native content formats.

- Static assets for intentionally public media.

The application should expose typed content models independently of the underlying storage format.

Do not assume that a database or content management system is required.

## 4. Proposed Content Directory

The following structure is illustrative and should be adapted to the existing repository.

```
Content/
├── Magazine/
│   └── example-article.md
├── Lab/
│   └── example-project.md
├── Directory/
│   └── example-developer.json
├── Contributors/
│   └── example-contributor.json
├── Community/
│   ├── Meetups/
│   ├── Events/
│   └── Resources/
└── Taxonomy/
    ├── categories.json
    └── technologies.json
```

Engineering documentation must remain separate from publication content.

Private editorial notes, confidential sources, consent records, credentials, and unpublished sensitive information must not be included in public content directories or public repository history.

## 5. Shared Metadata Conventions

Where appropriate, content entities should support the following shared metadata.

| Field       | Type              | Description                        |
| ----------- | ----------------- | ---------------------------------- |
| id          | String            | Stable unique content identifier   |
| slug        | String            | URL-compatible identifier          |
| title       | String            | Human-readable title               |
| summary     | String            | Concise description                |
| status      | Enum              | Publication lifecycle state        |
| publishedAt | Date or timestamp | Original publication date          |
| updatedAt   | Date or timestamp | Most recent substantive update     |
| tags        | String array      | Relevant descriptive tags          |
| featured    | Boolean           | Eligibility for featured placement |

Not every content type requires every shared field.

Use consistent naming conventions in serialized metadata.

C# model properties may follow ordinary PascalCase conventions.

## 6. Identifiers and Slugs

Every independently addressable content entity should have a stable identifier.

Identifiers must not change merely because titles, names, or descriptions change.

Slugs should:

- Use lowercase letters.

- Use hyphens between words.

- Avoid unnecessary punctuation.

- Remain reasonably concise.

- Be unique within their route namespace.

- Remain stable after publication.

Example:

```
id: article-0001
slug: building-maintainable-blazor-applications
```

The exact identifier generation strategy should be determined during implementation.

Avoid exposing internal database identifiers in public URLs if persistence is introduced later.

Published slug changes should be accompanied by redirects where practical.

## 7. Publication Lifecycle

The initial publication lifecycle should support:

| Status    | Meaning                                                             |
| --------- | ------------------------------------------------------------------- |
| draft     | Work in progress; not publicly accessible                           |
| published | Approved for public distribution                                    |
| archived  | Retained as historical material under an explicit visibility policy |

Archival status does not necessarily imply that content is private or removed.

Historical meetup records may remain publicly accessible while being clearly identified as archival.

Draft content must not appear in:

- Public listings.

- Direct public content routes.

- Search results.

- RSS or Atom feeds.

- XML sitemaps.

- Related-content recommendations.

- Publicly distributed content bundles.

Private drafts must not be committed to a public repository.

Future lifecycle states may include:

- In review.

- Scheduled.

- Withdrawn.

Do not implement these additional states until the editorial workflow requires them.

## 8. Article Model

Articles represent the primary editorial content of EugDotNet.

### 8.1 Article fields

| Field          | Type                    | Requirement              |
| -------------- | ----------------------- | ------------------------ |
| id             | String                  | Required                 |
| slug           | String                  | Required                 |
| title          | String                  | Required                 |
| subtitle       | String                  | Optional                 |
| summary        | String                  | Required for publication |
| authorIds      | String array            | Required for publication |
| editorIds      | String array            | Optional                 |
| category       | String                  | Required for publication |
| articleType    | Enum                    | Required for publication |
| tags           | String array            | Optional                 |
| status         | Enum                    | Required                 |
| publishedAt    | Date or timestamp       | Required when published  |
| updatedAt      | Date or timestamp       | Optional                 |
| featured       | Boolean                 | Optional; default false  |
| heroImage      | Media reference         | Optional                 |
| relatedContent | Content reference array | Optional                 |
| references     | Reference array         | Optional                 |
| corrections    | Correction array        | Optional                 |
| disclosure     | String                  | Optional                 |
| body           | Markdown                | Required for publication |

### 8.2 Article types

The initial article classifications should include:

| Type         | Description                                                 |
| ------------ | ----------------------------------------------------------- |
| reporting    | Factual coverage of events or developments                  |
| analysis     | Evidence-based interpretation                               |
| opinion      | Explicitly attributed personal argument                     |
| essay        | Extended intellectual or reflective writing                 |
| tutorial     | Instructional technical material                            |
| interview    | Conversation with an identified participant                 |
| review       | Evaluation of a technology, product, or resource            |
| case-study   | Documentation of a particular project or experience         |
| editorial    | Statement representing the publication's editorial position |
| announcement | Publication or community announcement                       |

Article type and subject category are separate concepts.

An article about artificial intelligence could be an interview, tutorial, essay, or piece of reporting.

### 8.3 Editorial categories

Initial proposed categories:

- Engineering

- Languages and Frameworks

- Infrastructure

- Artificial Intelligence

- Technology and Society

- Interviews and Community

Category identifiers should remain stable even if display labels change.

Prefer a controlled category taxonomy rather than unrestricted category creation.

### 8.4 Example article

The following example is illustrative development content and must not be automatically published.

```
---
id: article-0001
slug: building-maintainable-blazor-applications
title: Building Maintainable Blazor Applications
subtitle: Architectural restraint in small software projects
summary: An exploration of practical architectural decisions for small Blazor applications.
authorIds:
  - founder
category: engineering
articleType: essay
tags:
  - dotnet
  - blazor
  - architecture
status: draft
featured: false
---

The complexity of a software application should
reflect the complexity of the problem it solves.

## Introduction

Article content begins here.
```

The article title should ordinarily be rendered from metadata.

Avoid requiring authors to duplicate the primary heading within the Markdown body.

## 9. Contributor Model

Contributors represent people who participate in the publication through writing, editing, photography, illustration, technical demonstrations, or other credited work.

A contributor is not automatically a directory participant.

### 9.1 Contributor fields

| Field              | Type            | Requirement |
| ------------------ | --------------- | ----------- |
| id                 | String          | Required    |
| slug               | String          | Required    |
| displayName        | String          | Required    |
| biography          | String          | Optional    |
| roles              | String array    | Required    |
| website            | URL             | Optional    |
| professionalLinks  | Link array      | Optional    |
| portrait           | Media reference | Optional    |
| directoryProfileId | String          | Optional    |
| status             | Enum            | Required    |

### 9.2 Contributor roles

Potential contributor roles include:

- Founder

- Editor

- Writer

- Reporter

- Technical reviewer

- Photographer

- Illustrator

- Developer

- Guest contributor

A contributor may hold multiple roles.

Contributor records should contain only information approved for public display.

Do not fabricate contributors or professional credentials.

## 10. Laboratory Project Model

Laboratory projects document technical experimentation, software development, demonstrations, and independent engineering work.

### 10.1 Project fields

| Field            | Type                    | Requirement              |
| ---------------- | ----------------------- | ------------------------ |
| id               | String                  | Required                 |
| slug             | String                  | Required                 |
| title            | String                  | Required                 |
| summary          | String                  | Required                 |
| contributorIds   | String array            | Required for publication |
| technologies     | String array            | Optional                 |
| projectType      | Enum                    | Required                 |
| projectStatus    | Enum                    | Required                 |
| status           | Enum                    | Required                 |
| repositoryUrl    | URL                     | Optional                 |
| demonstrationUrl | URL                     | Optional                 |
| documentationUrl | URL                     | Optional                 |
| license          | String                  | Optional                 |
| screenshots      | Media reference array   | Optional                 |
| relatedContent   | Content reference array | Optional                 |
| publishedAt      | Date or timestamp       | Required when published  |
| updatedAt        | Date or timestamp       | Optional                 |
| body             | Markdown                | Required for publication |

### 10.2 Project types

Potential project types include:

- Application

- Library

- Developer tool

- Interactive demonstration

- Technical experiment

- Architecture prototype

- Educational resource

- Open-source contribution

### 10.3 Project status

Project development status is separate from publication status.

| Status       | Meaning                           |
| ------------ | --------------------------------- |
| conceptual   | Proposed or exploratory idea      |
| experimental | Active investigation              |
| prototype    | Demonstrable but incomplete       |
| active       | Under ongoing development         |
| maintained   | Available and actively maintained |
| completed    | Development objectives fulfilled  |
| archived     | No longer actively developed      |

A published article about an experimental project does not imply that the project is production-ready.

### 10.4 Example laboratory project

```
---
id: project-0001
slug: blazor-rendering-laboratory
title: Blazor Rendering Laboratory
summary: An exploration of rendering strategies in modern Blazor applications.
contributorIds:
  - founder
technologies:
  - dotnet
  - csharp
  - blazor
projectType: technical-experiment
projectStatus: experimental
status: draft
---

## Objective

Document the experiment and its intended outcomes.

## Architecture

Describe the technical approach.

## Findings

Record observations and limitations.
```

## 11. Developer Directory Model

The developer directory provides a curated, voluntary professional resource for Eugene, Springfield, and the surrounding region.

Directory participation must not be inferred from publicly available professional information.

### 11.1 Developer profile fields

| Field             | Type                    | Requirement                         |
| ----------------- | ----------------------- | ----------------------------------- |
| id                | String                  | Required                            |
| slug              | String                  | Required                            |
| displayName       | String                  | Required                            |
| professionalTitle | String                  | Required                            |
| region            | String                  | Required                            |
| biography         | String                  | Optional                            |
| specialties       | String array            | Optional                            |
| technologies      | String array            | Optional                            |
| services          | String array            | Optional                            |
| availability      | Enum                    | Required                            |
| availabilityTypes | String array            | Optional                            |
| lastConfirmedAt   | Date                    | Required for confirmed availability |
| website           | URL                     | Optional                            |
| professionalLinks | Link array              | Optional                            |
| publicContact     | Contact reference array | Optional                            |
| portrait          | Media reference         | Optional                            |
| contributorId     | String                  | Optional                            |
| relatedContent    | Content reference array | Optional                            |
| status            | Enum                    | Required                            |

### 11.2 Availability status

Initial availability states:

- available

- limited

- unavailable

- unknown

Availability must be presented as self-reported unless independently verified through an approved process.

Availability information should include a visible confirmation date.

A profile without recently confirmed availability should not continue to imply that the developer is actively accepting work.

A provisional freshness threshold of 90 days may be considered.

When availability information becomes stale, display an unknown or unconfirmed availability state.

Do not automatically remove the developer's entire profile solely because availability information has become stale.

### 11.3 Availability types

Potential availability types include:

- Contract work

- Freelance projects

- Consulting

- Part-time employment

- Full-time employment

- Collaboration

- Open-source participation

A developer may select multiple availability types.

### 11.4 Professional specialties

Potential specialties include:

- Frontend development

- Backend development

- Full-stack development

- Software architecture

- Web accessibility

- Database development

- Cloud infrastructure

- DevOps

- Linux administration

- Mobile development

- Game development

- Artificial intelligence

- Technical consulting

- UX and interface development

Specialties describe professional capabilities.

Technologies describe particular languages, frameworks, platforms, and tools.

### 11.5 Example developer profile

This example represents fictional development data only.

```
{
  "id": "developer-example",
  "slug": "example-developer",
  "displayName": "Example Developer",
  "professionalTitle": "Software Developer",
  "region": "Eugene, Oregon",
  "specialties": [
    "Web Development",
    "Software Architecture"
  ],
  "technologies": [
    "dotnet",
    "csharp",
    "blazor"
  ],
  "availability": "unknown",
  "availabilityTypes": [],
  "publicContact": [],
  "status": "draft"
}
```

Fictional profiles must not be published as real directory entries.

### 11.6 Consent and privacy

Directory participation requires explicit consent.

The public content model must contain only approved professional information.

Private consent records should be maintained separately from the publication repository.

Developers should have a straightforward mechanism for requesting:

- Corrections.

- Availability updates.

- Contact information changes.

- Profile removal.

Do not collect unnecessary personal information.

Do not publish home addresses, private telephone numbers, private email addresses, or unrelated personal information.

## 12. Meetup Archive Model

The meetup archive preserves EugDotNet's original community activities.

Historical records should be treated as documentary material rather than ordinary promotional content.

### 12.1 Meetup fields

| Field          | Type                    | Requirement         |
| -------------- | ----------------------- | ------------------- |
| id             | String                  | Required            |
| slug           | String                  | Required            |
| title          | String                  | Required            |
| eventDate      | Date                    | Required when known |
| location       | String                  | Optional            |
| description    | String                  | Optional            |
| presentations  | Presentation array      | Optional            |
| photographs    | Media reference array   | Optional            |
| organizers     | Attribution array       | Optional            |
| originalUrl    | URL                     | Optional            |
| externalLinks  | Link array              | Optional            |
| relatedContent | Content reference array | Optional            |
| archivalNotes  | String                  | Optional            |
| status         | Enum                    | Required            |

### 12.2 Presentation fields

A presentation record may include:

- Presentation title.

- Speaker name.

- Contributor identifier, when applicable.

- Presentation description.

- Slide deck reference.

- Repository link.

- Video link.

- Supporting materials.

Historical speakers do not need to be retroactively registered as active contributors.

Preserve their original attribution.

### 12.3 Historical integrity

Do not invent missing dates, names, locations, attendance figures, or presentation details.

Unknown information should remain unknown.

Where historical material has been corrected or reconstructed, distinguish the original record from later editorial additions.

Preserve existing historical assets and URLs where practical.

## 13. Community Event Model

Community events represent upcoming or past technology-related activities.

EugDotNet may cover events without being their organizer.

### 13.1 Event fields

| Field                | Type              | Requirement         |
| -------------------- | ----------------- | ------------------- |
| id                   | String            | Required            |
| slug                 | String            | Required            |
| title                | String            | Required            |
| summary              | String            | Required            |
| organizer            | String            | Required when known |
| location             | String            | Optional            |
| eventUrl             | URL               | Optional            |
| startsAt             | Timestamp         | Required            |
| endsAt               | Timestamp         | Optional            |
| timeZone             | String            | Required            |
| eventStatus          | Enum              | Required            |
| lastConfirmedAt      | Date or timestamp | Optional            |
| organizedByEugDotNet | Boolean           | Required            |
| status               | Enum              | Required            |

### 13.2 Event status

Potential event states include:

- scheduled

- postponed

- cancelled

- completed

- unconfirmed

Past events must not appear as upcoming events.

Event cancellation or postponement should be communicated clearly.

Do not imply an affiliation between EugDotNet and an external organizer without justification.

## 14. Community Resource Model

Community resources represent organizations, educational opportunities, developer groups, and useful regional technology resources.

Potential fields include:

- Stable identifier.

- Name.

- Description.

- Resource type.

- Region.

- Website.

- Public contact information.

- Relevant technologies or specialties.

- Last-confirmed date.

- Publication status.

Resource inclusion should not automatically imply endorsement, sponsorship, or formal affiliation.

## 15. Taxonomy

The publication should use a controlled vocabulary where consistency improves content discovery.

Distinguish between:

- Editorial categories.

- Article types.

- Technology identifiers.

- Professional specialties.

- Descriptive tags.

- Geographic regions.

These concepts should not be treated as interchangeable.

### 15.1 Technology identifiers

Example identifiers:

| Identifier  | Display label |
| ----------- | ------------- |
| dotnet      | .NET          |
| csharp      | C#            |
| blazor      | Blazor        |
| aspnet-core | ASP.NET Core  |
| javascript  | JavaScript    |
| typescript  | TypeScript    |
| python      | Python        |
| rust        | Rust          |
| go          | Go            |
| linux       | Linux         |
| postgresql  | PostgreSQL    |
| sqlite      | SQLite        |
| docker      | Docker        |

Technology identifiers should be stable and machine-readable.

Display labels should preserve conventional capitalization and punctuation.

### 15.2 Tags

Tags may be more flexible than controlled categories.

Avoid unnecessary duplication and near-identical tags.

For example, do not independently create tags for:

- dotnet

- .net

- DotNet

- Microsoft .NET

Normalize equivalent identifiers where appropriate.

Do not introduce elaborate hierarchical taxonomy management for the initial publication.

## 16. Media References

Media references should describe intentionally public assets.

Potential fields include:

| Field     | Type    | Description                   |
| --------- | ------- | ----------------------------- |
| src       | String  | Asset path or approved URL    |
| alt       | String  | Accessible alternative text   |
| caption   | String  | Optional editorial caption    |
| credit    | String  | Creator or source attribution |
| license   | String  | Licensing information         |
| width     | Integer | Optional intrinsic width      |
| height    | Integer | Optional intrinsic height     |
| mediaType | String  | Optional media classification |

Example:

```
heroImage:
  src: /images/magazine/example-image.webp
  alt: A laptop displaying a software architecture diagram
  caption: An illustrative development environment.
  credit: EugDotNet
```

Media must not be represented as documentary evidence when it is fictional, illustrative, or AI-generated.

Decorative images may use empty alternative text when appropriate.

Respect copyright, licensing, attribution, and consent requirements.

## 17. References and Sources

Articles should support structured references.

Potential reference fields include:

- Identifier.

- Title.

- Author or organization.

- Publication.

- Publication date.

- URL.

- Access date.

- DOI or other persistent identifier.

- Optional explanatory note.

Example:

```
references:
  - id: parnas-1972
    title: On the Criteria To Be Used in Decomposing Systems into Modules
    author: David L. Parnas
    publication: Communications of the ACM
    publicationDate: 1972-12
    doi: 10.1145/361598.361623
```

References should support journalistic, academic, and technical source attribution.

Do not fabricate references, quotations, publication dates, or source identifiers.

The exact citation presentation style should be established in EDITORIAL-GUIDELINES.md.

## 18. Corrections and Disclosures

Published articles should support transparent corrections and relevant disclosures.

### 18.1 Correction record

Potential fields include:

- Correction date.

- Description of the correction.

- Optional explanation.

- Optional reference to affected material.

Substantive factual corrections should be distinguishable from ordinary typographical changes.

The original publication date should remain intact.

### 18.2 Disclosure

Disclosure information may identify:

- Relevant professional relationships.

- Financial interests.

- Sponsorship.

- Author involvement in a reviewed project.

- Other circumstances relevant to editorial independence.

A disclosure is not automatically required for every article.

Editorial policy should determine when disclosure is necessary.

## 19. Content Relationships

Content entities may reference other published entities.

A relationship should identify:

- Target content type.

- Target content identifier.

- Optional relationship classification.

Example:

```
relatedContent:
  - type: lab-project
    id: project-0001
    relationship: accompanying-project
```

Potential relationships include:

- Accompanying project.

- Technical walkthrough.

- Interview subject.

- Related article.

- Historical presentation.

- Contributor profile.

- Developer profile.

- Follow-up coverage.

Relationships should resolve through stable identifiers rather than hard-coded public URLs wherever practical.

Broken references should be reported during validation.

Relationships must not expose unpublished or private content.

## 20. Dates and Time Zones

Use ISO 8601-compatible date and timestamp formats.

Examples:

```
publishedAt: 2026-11-26
updatedAt: 2026-12-03
startsAt: 2026-12-10T18:00:00-08:00
timeZone: America/Los_Angeles
```

Use date-only values where precise time is unnecessary.

Use offset-aware timestamps for scheduled events and time-sensitive publication operations.

Display regional event times in the appropriate local time zone.

Do not silently substitute the current date for unknown historical dates.

## 21. Content Validation

Content validation should occur before publication.

Potential validation requirements include:

- Required fields are present.

- Identifiers are unique.

- Slugs are valid and unique within their namespace.

- Publication states are recognized.

- Article types and categories are recognized.

- Dates are valid.

- Published content contains required attribution.

- Content relationships resolve correctly.

- Referenced media assets exist.

- External URL schemes are permitted.

- Directory records contain only approved public information.

- Draft content is excluded from public output.

- Historical records do not contain fabricated placeholder values.

Validation should produce understandable diagnostic messages.

Do not silently discard malformed content without reporting the problem.

Invalid published content should cause the appropriate publication validation process to fail.

Draft content may permit incomplete publication-specific fields while remaining structurally valid.

## 22. Content Discovery and Ordering

Default ordering should reflect the purpose of each content type.

### Magazine

- Featured content according to editorial selection.

- Recent articles by publication date.

- Category and tag filtering.

### Lab

- Featured projects according to editorial selection.

- Recent projects or substantive updates.

- Technology and project-status filtering.

### Directory

- Alphabetical ordering by default.

- Optional filtering by technology, specialty, region, and availability.

- No artificial popularity rankings.

### Community

- Upcoming events in chronological order.

- Historical events in reverse chronological order.

- Community resources grouped by meaningful classifications.

Editorially featured content should not automatically displace all recent content.

Do not infer quality or importance from arbitrary engagement metrics.

## 23. Content Portability

Content should remain portable across future application architectures.

Avoid embedding application-specific component syntax directly into ordinary editorial Markdown unless a documented extension mechanism is necessary.

Interactive demonstrations may be referenced through approved components or links.

Content identifiers and metadata should remain usable if storage eventually moves to a database or content management system.

Migration should not require rewriting the entire editorial archive.

## 24. Initial Publishing Workflow

The proposed initial workflow is:

1. Create content in the appropriate directory.

2. Assign a stable identifier and slug.

3. Set publication status to draft.

4. Write and revise the content.

5. Add references, attribution, and approved media.

6. Preview the content locally.

7. Validate metadata and relationships.

8. Perform editorial and technical review.

9. Set the approved publication status and date.

10. Commit the reviewed content.

11. Publish through the authorized deployment process.

AI-assisted drafting does not constitute editorial approval.

Only an authorized human editor may approve publication.

## 25. Implementation Priorities

The initial implementation should prioritize:

### Phase 1

- Shared content metadata conventions.

- Article model.

- Contributor model.

- Safe Markdown rendering.

- Publication filtering.

- Historical meetup preservation.

- Basic content validation.

### Phase 2

- Laboratory project model.

- Developer profile model.

- Controlled technology taxonomy.

- Content relationships.

- Directory availability handling.

### Phase 3

- Community event model.

- Community resource model.

- Structured corrections.

- Expanded reference presentation.

- Syndication and search integration.

These priorities should be reconciled with the existing repository and the approved implementation plan.

Do not implement every proposed field or content type before it is needed.

## 26. Implementation Constraints

The models described in this document are conceptual contracts.

Before implementation:

- Inspect existing C# models.

- Identify existing content formats.

- Identify historical data structures.

- Evaluate compatibility with existing application services.

- Determine the appropriate serialization strategy.

- Document material deviations from this proposal.

Do not introduce a database, ORM, CMS, or additional external service solely because structured content models have been defined.

Do not fabricate production content to populate newly created models.

Development fixtures must remain clearly identified and separate from published material.

## 27. Definition of Success

The content architecture should be considered successful when:

- Articles can be authored and maintained efficiently.

- Contributors receive accurate attribution.

- Technical projects can be documented consistently.

- Directory information remains voluntary and accurate.

- Historical meetup material is preserved.

- Content relationships resolve reliably.

- Drafts remain private from public application output.

- Publication metadata can be validated.

- Content remains portable.

- Future editorial growth does not require immediate architectural replacement.

The content system should serve the publication rather than becoming an unnecessarily elaborate software product of its own.
