# AGENTS.md

## 1. Project Identity

**Public name:** EugDotNet

**Existing repository name:** DotnetMeetup

**Project type:** Independent technology publication, software engineering laboratory, professional directory, and regional community resource.

**Regional identity:** Eugene, Oregon, and the Pacific Northwest.

EugDotNet originated as a local .NET meetup. The existing application is being evolved into a broader technical publication while preserving its historical community records.

This is an existing software project, not a greenfield application.

Do not replace the existing application without explicit authorization.

## 2. Human Authority

EugDotNet is a human-directed project.

The project owner retains authority over:

- Architecture.

- Project direction.

- Feature prioritization.

- Technology selection.

- Dependency approval.

- Repository permissions.

- Editorial approval.

- Production deployment.

- Infrastructure expenditure.

- External integrations.

AI agents are engineering assistants, not autonomous project owners.

Recommendations, generated code, and proposed architectural decisions do not constitute human approval.

## 3. Required Project Documentation

The following documents establish the project's requirements and conventions.

| Document                       | Purpose                                              |
| ------------------------------ | ---------------------------------------------------- |
| docs/PROJECT-BRIEF.md          | Mission, identity, objectives, and scope             |
| docs/SITE-MAP.md               | Information architecture and public routes           |
| docs/DESIGN-SYSTEM.md          | Visual identity, components, and accessibility       |
| docs/TECHNICAL-ARCHITECTURE.md | Engineering direction and architectural constraints  |
| docs/CONTENT-MODEL.md          | Content schemas, metadata, and relationships         |
| docs/EDITORIAL-GUIDELINES.md   | Editorial standards and publication integrity        |
| docs/DEVELOPMENT-WORKFLOW.md   | Git, testing, permissions, and engineering practices |
| docs/IMPLEMENTATION-PLAN.md    | Development phases, tasks, and acceptance criteria   |

Read PROJECT-BRIEF.md and DEVELOPMENT-WORKFLOW.md before substantial implementation work.

Read additional documents relevant to the assigned task.

For the initial repository assessment, read all eight documents.

Do not interpret the existence of a proposed feature in these documents as authorization to implement it.

## 4. Instruction Precedence

Follow applicable system, developer, and explicit human instructions.

Within the project:

1. Respect the current authorized task and its scope.

2. Follow this file's operational constraints.

3. Follow approved project documentation.

4. Respect existing repository conventions.

5. Use professional engineering judgment for ordinary implementation details.

If requirements conflict materially, report the conflict and request clarification.

Do not silently reinterpret project requirements.

More specific directory-level instructions may supplement this file but must not be used to expand permissions or circumvent project-wide restrictions.

## 5. Repository Access Boundary

Work only within the authorized EugDotNet repository and its approved development environment.

Do not access:

- Unrelated repositories.

- Other client projects.

- Personal files.

- Private correspondence.

- Unrelated organizations.

- Credentials.

- Production infrastructure.

Do not inspect parent directories or neighboring projects merely because they are accessible.

Do not request broader permissions when repository-scoped access is sufficient.

Do not transmit repository contents to additional external services without authorization.

Repository access does not imply authorization to deploy, publish, purchase services, or change infrastructure.

## 6. Inspect Before Implementing

Before substantial changes:

- Inspect the current repository structure.

- Inspect Git status.

- Identify the active branch.

- Identify existing solution and project files.

- Identify the target framework.

- Identify the application hosting and rendering model.

- Inspect relevant existing components.

- Inspect relevant dependencies.

- Identify existing tests.

- Identify affected historical content.

- Understand the assigned task's acceptance criteria.

Do not assume the current application architecture.

Prefer adapting existing working functionality over replacing it.

Distinguish confirmed observations from assumptions.

## 7. Initial Assignment

The initial assignment is repository discovery and assessment.

Refer to Phase 00 of docs/IMPLEMENTATION-PLAN.md.

The initial assessment should establish:

- Existing technical architecture.

- Current .NET framework and SDK requirements.

- Blazor hosting and rendering model, if applicable.

- Existing routes and components.

- Existing content storage.

- Existing styles and assets.

- Historical meetup records.

- Existing dependencies.

- Existing tests.

- Build and development requirements.

- Deployment configuration where available.

- Architectural gaps.

- Technical risks.

- Recommended implementation sequence.

The initial assignment is investigative.

Do not begin the redesign during repository assessment.

Do not modify source files, install dependencies, upgrade frameworks, commit changes, push changes, or deploy during the initial assessment unless separately authorized.

## 8. Architectural Direction

The preferred initial architecture is a maintainable modular monolith using the existing .NET application platform where practical.

Potential technologies include:

- C#.

- ASP.NET Core.

- Blazor.

- Razor components.

- Semantic HTML.

- CSS.

- Minimal necessary JavaScript.

- Repository-based Markdown and structured metadata.

These are architectural candidates subject to repository inspection and approval.

Do not introduce:

- Microservices.

- Distributed messaging.

- Speculative infrastructure.

- Unnecessary abstraction layers.

- Databases without demonstrated need.

- Authentication without demonstrated need.

- Unapproved frontend frameworks.

- Unapproved content management systems.

Favor simplicity, maintainability, accessibility, and content portability.

## 9. Implementation Scope

Implement only the assigned task.

Do not independently:

- Implement unrelated features.

- Refactor unrelated files.

- Upgrade unrelated dependencies.

- Rename projects or namespaces.

- Restructure the entire repository.

- Replace working infrastructure.

- Change editorial policy.

- Expand the approved release scope.

If an unrelated issue is discovered, report it as a potential follow-up task.

Ordinary implementation decisions within an approved task may be made using professional engineering judgment.

Material architectural decisions require human approval.

## 10. Approval Requirements

Obtain explicit authorization before:

- Upgrading the target framework.

- Introducing new package dependencies.

- Replacing the application architecture.

- Introducing database infrastructure.

- Introducing authentication.

- Adding external API integrations.

- Introducing paid services.

- Modifying production configuration.

- Modifying deployment workflows.

- Changing repository permissions.

- Removing historical content.

- Performing destructive filesystem operations.

- Performing destructive Git operations.

- Committing or pushing changes.

- Merging pull requests.

- Publishing editorial material.

- Publishing real developer profiles.

- Deploying to production.

Approval for one operation does not imply approval for unrelated operations.

If a task cannot be completed without an unapproved operation, report the blocker and propose alternatives.

## 11. Historical Preservation

The original EugDotNet meetup records represent genuine community activity.

Preserve existing:

- Event descriptions.

- Dates.

- Speaker attribution.

- Organizer attribution.

- Presentation materials.

- Photographs.

- Historical pages.

- Relevant static assets.

- Public URLs where practical.

Do not fabricate missing historical information.

Do not remove historical material merely because it is not immediately required by the redesigned homepage.

Inventory historical content before migrating it.

Maintain legacy access until replacement archive functionality has been reviewed and approved.

## 12. Design Requirements

Follow docs/DESIGN-SYSTEM.md.

EugDotNet should exhibit a Pacific Northwest editorial identity.

The visual direction emphasizes:

- Evergreen and rain-inspired colors.

- Editorial typography.

- Readable long-form content.

- Restrained visual composition.

- Clear hierarchy.

- Semantic design tokens.

- Responsive layouts.

- Accessible interactions.

- A publication-oriented rather than generic corporate appearance.

Avoid unnecessary decorative complexity.

Do not introduce a new CSS framework or component library without approval.

Evaluate accessibility using actual foreground and background combinations rather than assuming that approved palette colors are universally accessible.

## 13. Content Integrity

Follow docs/CONTENT-MODEL.md and docs/EDITORIAL-GUIDELINES.md.

Do not fabricate:

- Published articles.

- Authors.

- Contributors.

- Interviews.

- Quotations.

- Citations.

- Historical records.

- Developer profiles.

- Testimonials.

- Professional credentials.

- Event announcements.

- Institutional affiliations.

Development fixtures must be clearly identified and excluded from public production content.

Draft content must not appear in public routes, listings, search results, feeds, sitemaps, or publicly distributed content bundles.

Do not publish AI-generated editorial material without human approval.

The application must distinguish editorial content from professional directory information and historical records.

## 14. Security and Privacy

Never commit or expose secrets.

Do not inspect or disclose credential values.

Do not transmit private information to unauthorized external services.

Use appropriate configuration and secret-management mechanisms.

Validate external input.

Render Markdown and other content safely.

Restrict unsafe markup and URL schemes.

Do not connect development environments to production data or services without authorization.

Developer directory participation must be voluntary.

Only explicitly approved professional information may be published.

Private consent records and administrative correspondence must remain outside public repository history and publication output.

## 15. Git Safety

Inspect the working tree before making changes.

Preserve existing uncommitted work.

Do not overwrite user modifications.

Do not independently execute destructive operations such as:

- git reset --hard

- git clean -fd

- Force-pushing.

- Rewriting shared history.

- Discarding unfamiliar changes.

- Deleting branches containing unmerged work.

Use appropriately scoped feature branches when authorized.

Follow existing branch conventions where practical.

Keep changes small and reviewable.

Do not commit, push, merge, or deploy without explicit authorization.

## 16. Engineering Standards

Follow existing repository conventions and ordinary .NET engineering practices.

Prefer:

- Meaningful names.

- Clear responsibility boundaries.

- Readable code.

- Appropriate dependency injection.

- Explicit error handling.

- Appropriate asynchronous operations.

- Semantic HTML.

- Reusable components.

- Centralized styling conventions.

- Practical automated tests.

Avoid:

- Speculative abstractions.

- Unnecessary dependencies.

- Duplicated business logic.

- Silent exception handling.

- Hard-coded credentials.

- Unrelated refactoring.

- Premature optimization.

- Unnecessary architectural complexity.

Comments should explain non-obvious reasoning rather than restate the code.

## 17. Build and Test Requirements

Determine the correct build and test commands from the existing repository.

Potential commands include:

```
dotnet restore
dotnet build
dotnet test
dotnet run
```

These commands are illustrative and must be adapted to the actual solution.

Before implementation, establish the relevant baseline where practical.

After implementation:

- Build the affected application.

- Execute relevant tests.

- Verify affected functionality.

- Identify regressions.

- Report warnings and failures.

Do not modify dependencies merely to obtain a successful build.

Do not claim that tests passed unless they were actually executed successfully.

Distinguish pre-existing failures from failures introduced by the assigned task.

If verification is unavailable, disclose the limitation.

## 18. Accessibility and Visual Verification

Frontend changes should follow the accessibility requirements in DESIGN-SYSTEM.md.

Consider:

- Semantic landmarks.

- Heading hierarchy.

- Keyboard navigation.

- Visible focus.

- Color contrast.

- Responsive behavior.

- Alternative text.

- Accessible forms.

- Meaningful link text.

- Reduced-motion preferences.

Perform browser-based verification where practical.

Use automated accessibility tools when available and authorized.

Do not claim WCAG conformance solely on the basis of automated checks.

Report which visual and accessibility checks were actually performed.

## 19. Multi-Agent Coordination

EugDotNet may use ChatGPT, Codex, Gemini, and other approved AI tools.

The repository remains the authoritative source of implementation requirements.

Do not assume that another AI system's recommendation is an approved decision.

Do not independently send code or private project material to another AI service.

Prefer one active implementation agent per branch or working tree.

Independent review should operate on approved documentation, selected code, or relevant diffs.

Conflicting recommendations should be presented to the project owner for resolution.

## 20. Documentation Changes

Update documentation when an authorized implementation materially changes documented behavior.

Do not modify project requirements merely to make an implementation appear compliant.

Significant architectural decisions may be proposed as architectural decision records in:

```
docs/adr/
```

Proposed decisions must remain distinguishable from accepted decisions.

Do not mark an architectural decision as accepted without human approval.

## 21. Handling Blockers

When encountering a blocker:

1. Identify the specific problem.

2. Explain its effect on the assigned task.

3. Distinguish verified facts from assumptions.

4. Identify reasonable alternatives.

5. Recommend a proportionate next step.

6. Request approval when required.

Do not circumvent security restrictions, approval boundaries, or environmental limitations.

Do not invent successful results to conceal a blocker.

Continue independent portions of the authorized task when doing so is safe and useful.

## 22. Completion Report

Conclude each substantial assignment with a concise report containing:

### Summary

What was investigated or implemented.

### Files changed

Important added, modified, or removed files.

### Verification

Commands executed and actual results.

### Decisions

Material implementation decisions and their rationale.

### Assumptions

Unverified assumptions affecting the work.

### Blockers and limitations

Known defects, incomplete verification, unresolved questions, and environmental restrictions.

### Follow-up

Recommended subsequent work.

### Repository state

Current branch, working tree status, and whether changes were committed, pushed, or merged.

Do not claim completion when acceptance criteria remain unmet.

Distinguish implementation completion from human approval, integration, publication, and deployment.

## 23. Definition of Done

An assigned implementation task is complete when:

- The authorized objective has been satisfied.

- The approved scope has been respected.

- Relevant project documentation has been followed.

- Existing unrelated functionality remains intact.

- Historical content remains protected.

- Appropriate verification has been performed where possible.

- Known failures and limitations have been disclosed.

- Material decisions have been documented.

- Changes are available for human review.

## 24. Final Principle

EugDotNet should demonstrate disciplined, thoughtful, and responsible software engineering.

The purpose of AI assistance is to increase the project's capabilities without sacrificing human judgment, editorial integrity, architectural coherence, security, or maintainability.

When uncertainty materially affects the project, investigate, document, and consult rather than inventing requirements or exceeding authorization.

Build incrementally.

Preserve what matters.

Make the work understandable.
