# AGENTS.md

## Project and authority

EugDotNet is an independent technology publication, engineering laboratory, professional directory, and regional community resource rooted in Eugene, Oregon. The existing repository is DotnetMeetup.

- Preserve and adapt the existing application. Replacing it requires explicit human approval.
- The project owner controls architecture, priorities, dependencies, permissions, editorial approval, integrations, infrastructure spending, and deployment.
- Implement only the authorized assignment. Proposed features and agent recommendations do not grant authorization.
- Follow applicable instructions, the authorized task, this file, relevant specifications, and existing repository conventions in that order. Surface material conflicts for human resolution.
- Directory-level instructions may supplement these constraints but cannot expand permissions.

## Consult relevant documentation

Read only the supporting documents and sections relevant to the current assignment.

| Document | Consult for |
| --- | --- |
| [Project brief](docs/PROJECT-BRIEF.md) | Mission, identity, history, objectives, and scope |
| [Site map](docs/SITE-MAP.md) | Public routes and navigation |
| [Design system](docs/DESIGN-SYSTEM.md) | Visual identity, components, and accessibility |
| [Technical architecture](docs/TECHNICAL-ARCHITECTURE.md) | Engineering direction and open technical decisions |
| [Content model](docs/CONTENT-MODEL.md) | Schemas, metadata, and visibility |
| [Editorial guidelines](docs/EDITORIAL-GUIDELINES.md) | Editorial standards and publication integrity |
| [Development workflow](docs/DEVELOPMENT-WORKFLOW.md) | Git, testing, permissions, and engineering practices |
| [Implementation plan](docs/IMPLEMENTATION-PLAN.md) | Authoritative phase numbering, tasks, and acceptance criteria |
| [Project status](docs/PROJECT-STATUS.md) | Session handoff and next assignment |

## Before substantial work

- Inspect Git status and the active branch. Preserve existing uncommitted work.
- Identify the relevant solution and projects, SDK and target framework, hosting and rendering model, components, dependencies, tests, and historical content.
- Confirm the assignment boundaries and acceptance criteria. Establish the relevant build and test baseline where practical and authorized.
- Distinguish confirmed findings from assumptions.
- Phase 00 is repository discovery and assessment. Follow the implementation plan and consult relevant sections only.
- During assessment, do not begin redesign, edit application source, install dependencies, upgrade frameworks, commit, push, or deploy without separate authorization.
- Defer framework upgrades and decisions about storage architecture, rendering strategy, and legacy routing until repository assessment is complete.

## Assessment deliverable

- Record the current technical architecture, development requirements, and available deployment configuration without accessing production infrastructure.
- Inventory historical material and identify architectural gaps, technical risks, and a recommended implementation sequence.
- Follow the Phase 00 acceptance criteria in the implementation plan.

## Explicit approval

Obtain explicit human approval before:

- Adding any new dependency, including development and build tooling dependencies, or upgrading the target framework.
- Replacing the architecture, adding database infrastructure or authentication, or adopting an external API, CMS, frontend framework, or paid service.
- Modifying production configuration, deployment workflows, or repository permissions.
- Removing historical content or performing destructive filesystem or Git operations.
- Committing, pushing, merging, or deploying.
- Publishing editorial material or real developer profiles.

Approval applies to the specific operation. Keep ordinary implementation choices within scope and seek approval for material architectural decisions.

## Repository, security, and privacy

- Work within the authorized repository and approved development environment. Do not inspect unrelated repositories, neighboring projects, personal files, private correspondence, unrelated organizations, credentials, or production infrastructure.
- Do not transmit repository contents or private information to unauthorized services, including other AI services.
- Do not inspect, expose, or commit credential values. Use approved configuration and secret management.
- Do not connect development to production data or services without approval.
- Validate external input. Render Markdown safely and restrict unsafe markup and URL schemes.
- Directory participation is voluntary. Publish only explicitly approved professional information and keep private consent and correspondence out of public output and repository history.

Report suspected exposure without disclosing credential values or private information.

## Historical and editorial integrity

- Preserve historical event details, dates, speaker and organizer attribution, presentation materials, photos, pages, relevant assets, and public URLs where practical.
- Inventory historical content before migration. Maintain legacy access until replacement archive functionality is reviewed and approved.
- Do not fabricate historical facts, editorial content or attribution, developer profiles or credentials, testimonials, events, or affiliations.
- Clearly identify development fixtures and exclude them from public production output.
- Exclude drafts from public routes, listings, search, feeds, sitemaps, and distributed content bundles. Intentionally public archived material remains eligible for discovery and search.
- Distinguish editorial content, professional directory information, and historical records.

## Git and engineering

- Preserve unfamiliar changes. Do not reset, clean, force-push, rewrite shared history, or delete branches containing unmerged work without explicit authorization.
- Use scoped feature branches when authorized and keep changes small and reviewable. Prefer one active implementation agent per branch or working tree.
- Adapt working functionality. Avoid unrelated refactoring, upgrades, renames, repository restructuring, infrastructure changes, and scope expansion.
- Favor the existing .NET platform and a maintainable modular monolith where practical. Avoid microservices, distributed messaging, and speculative infrastructure or abstractions.
- Follow repository and .NET conventions. Keep code readable, responsibilities clear, errors explicit, and use appropriate dependency injection, asynchronous operations, reusable components, and semantic HTML.
- Document material behavior changes. Keep proposed architecture decisions distinguishable from decisions accepted by the project owner.
- Preserve the approved Pacific Northwest editorial direction and follow the design system. Individual palette adjustments require human approval after accessibility testing.

Use `docs/adr/` for proposed significant architectural decisions when the assignment calls for an ADR.

## Verification and completion

- Derive build and test commands from the existing solution. Build the affected application, run relevant tests, and verify affected functionality where authorized.
- Do not change dependencies to obtain a passing build. Distinguish pre-existing failures from regressions and report what actually ran.
- For frontend work, check semantics, keyboard access and visible focus, contrast in actual color combinations, responsive behavior, alternative text, accessible forms and links, and reduced motion where relevant.
- Use browser verification where practical and automated accessibility tools where available and authorized. Automated checks alone do not establish WCAG conformance.
- Report scope completed, files changed, verification and limitations, decisions and assumptions, blockers, follow-up, and branch and working-tree state for substantial assignments.
- Report specific blockers and alternatives, seek approval when required, and continue safe independent work.
- Report unrelated findings as follow-up work and keep fixes within the authorized scope.
- Record what remains unverified and who must resolve any pending approvals.
- Completion requires satisfying the authorized objective, preserving unrelated functionality and historical records, and making verified changes available for review. Integration, publication, and deployment require their own authorization.
