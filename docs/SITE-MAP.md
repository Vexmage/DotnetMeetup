# EugDotNet — Site Map and Information Architecture

## 1. Purpose

This document defines the proposed information architecture, navigation structure, page hierarchy, and functional organization of EugDotNet.

EugDotNet is evolving from a local .NET meetup website into an independent regional technology publication, software development laboratory, professional directory, and community resource.

The website should remain rooted in Eugene, Springfield, and the surrounding Pacific Northwest while publishing technical material relevant to a broader audience.

## 2. Primary Navigation

The primary navigation shall consist of:

- Home

- Magazine

- Lab

- Directory

- Community

- About

Navigation should remain concise, recognizable, accessible, and consistent across the website.

## 3. Site Hierarchy

```
EugDotNet│├── Home│├── Magazine│   ├── Latest Articles│   ├── Engineering│   ├── Languages & Frameworks│   ├── Infrastructure│   ├── Artificial Intelligence│   ├── Technology & Society│   ├── Interviews│   └── Article Detail│├── Lab│   ├── Projects│   ├── Experiments│   ├── Demonstrations│   ├── Open Source│   └── Project Detail│├── Directory│   ├── Developer Directory│   ├── Developer Profile│   └── Request a Listing│├── Community│   ├── Meetup Archive│   ├── Past Presentations│   ├── Local Technology Events│   └── Community Resources│├── About│   ├── Mission│   ├── History│   ├── Editorial Principles│   ├── Contributors│   └── Contact│└── Utility Pages    ├── Search    ├── Privacy Policy    ├── Accessibility    └── 404 / Not Found
```

The categories represented in this hierarchy are conceptual. They do not necessarily require independent pages or navigation entries during the initial implementation.

## 4. Homepage

**Proposed route:** `/`

The homepage should function as the front page of an independent technology publication rather than a conventional corporate landing page.

Its principal purpose is to introduce readers to current editorial content, technical projects, and regional technology resources.

### Homepage components

- Publication masthead

- Featured editorial article

- Recent articles

- Selected laboratory projects

- Featured local developer or community member

- Community announcements, when available

- Brief introduction to EugDotNet

- Links to the developer directory

- Footer navigation

The homepage should emphasize editorial content and avoid unnecessary marketing language.

Content sections should be modular so that their prominence can change as the publication develops.

## 5. Magazine

**Proposed route:** `/magazine`

The magazine is the principal editorial component of EugDotNet.

It should accommodate both practical technical writing and broader interdisciplinary inquiry.

### Editorial categories

| Category                | Subject matter                                                                  |
| ----------------------- | ------------------------------------------------------------------------------- |
| Engineering             | Software architecture, development practices, testing and accessibility         |
| Languages & Frameworks  | .NET, C#, Blazor, JavaScript, TypeScript and other ecosystems                   |
| Infrastructure          | Linux, hosting, networking, databases and deployment                            |
| Artificial Intelligence | AI-assisted development, tools, experimentation and emerging capabilities       |
| Technology & Society    | Philosophy, ethics, technological history, economics and culture                |
| Interviews              | Conversations with developers, researchers, entrepreneurs and community members |

### Article listing

The magazine landing page should support:

- Featured articles

- Recent articles

- Category filtering

- Article summaries

- Author attribution

- Publication dates

- Optional article imagery

### Article detail

**Proposed route:** `/magazine/{slug}`

Individual articles should support:

- Title and subtitle

- Author attribution

- Publication date

- Updated date, when applicable

- Editorial category

- Article body

- Code examples

- Images and diagrams

- References and external links

- Related articles

Article types may include tutorials, essays, interviews, reviews, reporting, opinion, and technical case studies.

Editorial classifications should help readers distinguish factual reporting from commentary and opinion.

## 6. Lab

**Proposed route:** `/lab`

The laboratory is the practical and experimental component of EugDotNet.

It provides a public space for demonstrating software development, exploring emerging technologies, documenting experiments, and showcasing independent projects.

### Supported content

- Software prototypes

- Interactive demonstrations

- Technical experiments

- Open-source projects

- Architecture explorations

- Development walkthroughs

- Proofs of concept

- Educational tools

### Project detail

**Proposed route:** `/lab/{slug}`

Each project may include:

- Project title

- Description

- Development status

- Technology stack

- Screenshots

- Architecture diagrams

- Technical documentation

- Repository links

- Live demonstration links

- Related magazine articles

Experimental projects should be clearly distinguished from production-ready software.

The Lab should not require every experiment to be hosted directly within the EugDotNet application.

## 7. Developer Directory

**Proposed route:** `/directory`

The directory connects regional software developers and independent technology professionals with potential clients, collaborators, employers, and community members.

Although EugDotNet originated as a .NET community, directory participation should not be restricted to .NET developers.

### Developer listing information

- Name or professional display name

- Professional title

- Location or service region

- Technical specialties

- Short professional biography

- Website or portfolio

- Public professional contact information

- GitHub or other relevant professional profiles

- Availability for employment, contract work, or collaboration

- Date information was last confirmed

### Developer profile

**Proposed route:** `/directory/{slug}`

Individual profiles may provide additional professional information, project examples, and links to relevant articles or interviews.

### Directory participation

Participation must be voluntary.

Developers must explicitly consent to the publication of their professional information.

The directory should provide a straightforward means of requesting additions, corrections, and removal.

Availability information must not be presented as verified when it has not been recently confirmed.

The directory should initially operate as a curated professional resource rather than a fully automated employment marketplace.

## 8. Community

**Proposed route:** `/community`

The community section preserves EugDotNet's origins and documents the continuing development of the regional technology community.

### Meetup archive

**Proposed route:** `/community/meetups`

Existing meetup records are historically significant and should be preserved.

Where available, the archive should retain:

- Meetup dates

- Presentation titles

- Speaker information

- Presentation descriptions

- Photographs

- Slides and presentation materials

- Relevant external links

- Historical announcements

Existing material must not be discarded merely because the website's primary purpose has changed.

Historical content should be clearly identified as archival rather than presented as upcoming activity.

### Local technology events

**Proposed route:** `/community/events`

This section may provide information about relevant technology events in Eugene, Springfield, and the surrounding region.

EugDotNet does not need to organize every event it covers.

### Community resources

**Proposed route:** `/community/resources`

This section may include links to local technology organizations, educational institutions, developer groups, professional resources, and relevant community initiatives.

## 9. About

**Proposed route:** `/about`

The About section should establish the publication's identity, origins, purpose, and editorial independence.

It should explain:

- The history of EugDotNet

- Its origins as a local .NET meetup

- Its evolution into a broader technology resource

- Its editorial mission

- Its relationship to the regional technology community

- Its founder, editor, and contributors

- Opportunities for participation

The website should provide clear contact information and a means of proposing articles, interviews, projects, or directory listings.

## 10. Cross-Section Relationships

The website should support meaningful relationships between its different content types.

Examples include:

- A magazine article discussing a laboratory project.

- A laboratory project linking to its technical walkthrough.

- An interview linking to a developer's directory profile.

- A developer profile linking to contributed articles.

- A meetup archive entry linking to a presentation or technical demonstration.

- A community event generating subsequent editorial coverage.

These relationships should develop naturally rather than requiring every content item to participate in every section.

## 11. Initial Implementation Priorities

The initial implementation should establish a functional foundation without requiring the complete realization of every proposed feature.

### Phase 1 — Publication foundation

- Shared site layout

- Primary navigation

- Editorial homepage

- Magazine landing page

- Article detail template

- Lab landing page

- Directory landing page

- Community landing page

- Preservation of existing meetup content

- About page

- Responsive and accessible presentation

### Phase 2 — Content expansion

- Article categories and filtering

- Laboratory project detail pages

- Individual developer profiles

- Directory participation requests

- Contributor attribution

- Related-content relationships

### Phase 3 — Extended functionality

- Site-wide search

- RSS feeds

- Expanded community event coverage

- Additional editorial tools

- Improved content management

- Additional functionality justified by demonstrated community demand

These phases represent proposed priorities rather than fixed delivery deadlines.

## 12. Implementation Constraints

Before making architectural changes, inspect the existing repository and determine:

- Current application framework and version

- Existing routing conventions

- Existing page and component structure

- Existing content storage mechanisms

- Existing meetup records and assets

- Existing deployment configuration

Preserve useful existing functionality wherever practical.

Do not replace the existing application framework, introduce a database, implement authentication, or add major external dependencies solely to satisfy this proposed site map.

Such architectural decisions require separate evaluation and explicit approval.

Do not delete historical content without approval.

Do not fabricate developer profiles, interviews, testimonials, or community participation.

Where development placeholders are necessary, clearly identify them as sample content.

## 13. Scope Philosophy

EugDotNet should grow incrementally.

The initial goal is a credible, useful, maintainable publication and technical resource, not a comprehensive social network, employment platform, or large-scale media organization.

Prefer a small number of well-executed features over a large number of incomplete features.

The information architecture should accommodate future growth without requiring that growth to occur immediately.
