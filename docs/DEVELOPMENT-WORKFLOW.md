# EugDotNet — Development Workflow and Engineering Practices

## 1. Purpose

This document establishes the development workflow, repository management practices, AI-assisted engineering conventions, testing requirements, and approval boundaries for EugDotNet.

The objective is to support efficient development while preserving human oversight, architectural coherence, security, historical continuity, and maintainability.

This document complements:

- PROJECT-BRIEF.md

- SITE-MAP.md

- DESIGN-SYSTEM.md

- TECHNICAL-ARCHITECTURE.md

- CONTENT-MODEL.md

- EDITORIAL-GUIDELINES.md

## 2. Project Ownership

EugDotNet is a human-directed software and editorial project.

The project owner retains authority over:

- Architectural decisions.

- Technology selection.

- Repository permissions.

- Dependency approval.

- Feature prioritization.

- Editorial policy.

- Publication approval.

- Production deployment.

- Infrastructure expenditure.

- External integrations.

- Project direction.

AI systems may assist with substantial engineering and editorial work but do not possess independent project authority.

An AI-generated recommendation does not constitute an approved architectural decision.

## 3. Development Philosophy

Development should proceed through small, understandable, reviewable increments.

Prefer:

- Working software over speculative infrastructure.

- Explicit requirements over inferred requirements.

- Incremental improvements over uncontrolled rewrites.

- Readable code over unnecessary abstraction.

- Measured improvements over premature optimization.

- Established conventions over arbitrary novelty.

- Documented decisions over undocumented assumptions.

The application should remain understandable to a competent developer who did not participate in its original implementation.

## 4. Repository Scope

AI coding agents should receive access only to the repository required for EugDotNet development.

The existing repository is currently identified as DotnetMeetup.

The public identity of the application is EugDotNet.

Do not rename the repository, solution, project files, namespaces, deployment identifiers, or infrastructure resources solely to reconcile this naming difference.

Repository renaming may be considered separately.

AI agents must not access unrelated repositories, organizations, client projects, or personal files.

Access to one repository does not imply authorization to access the owner's other repositories.

## 5. Source of Truth

The Git repository is the authoritative source for:

- Application source code.

- Approved engineering documentation.

- Public content.

- Tests.

- Build configuration.

- Architectural decision records.

- Approved development conventions.

GitHub Issues may serve as the authoritative record of individual development tasks.

Pull requests should document proposed changes and their verification.

AI conversations, generated recommendations, and external planning documents are supporting materials rather than authoritative implementation specifications.

Important decisions made outside the repository should be incorporated into appropriate repository documentation.

## 6. Documentation Hierarchy

Project documentation should be maintained in the docs directory.

The proposed documentation structure is:

```
DotnetMeetup/├── AGENTS.md├── README.md└── docs/    ├── PROJECT-BRIEF.md    ├── SITE-MAP.md    ├── DESIGN-SYSTEM.md    ├── TECHNICAL-ARCHITECTURE.md    ├── CONTENT-MODEL.md    ├── EDITORIAL-GUIDELINES.md    ├── DEVELOPMENT-WORKFLOW.md    ├── IMPLEMENTATION-PLAN.md    └── adr/
```

AGENTS.md should provide concise repository-level instructions for AI coding agents and direct them to the relevant supporting documents.

README.md should explain the application, verified development prerequisites, local setup, and ordinary build and test commands.

Architectural decision records should document significant approved technical decisions.

If documentation conflicts with existing implementation, report the discrepancy.

Do not silently reinterpret project requirements or modify documentation to justify an unapproved implementation.

## 7. Initial Repository Assessment

Before substantial implementation work, perform a repository assessment.

The assessment should identify:

- Current Git branch.

- Working tree status.

- Existing solution and project files.

- Current .NET target framework.

- Application hosting and rendering model.

- Existing dependencies.

- Existing routes.

- Existing components and layouts.

- Existing content storage.

- Historical meetup material.

- Existing tests.

- Existing deployment configuration.

- Existing development documentation.

- Known technical debt.

- Potential migration risks.

Where practical, establish whether the application currently builds and runs.

Do not begin by replacing the existing application.

The assessment should distinguish:

- Confirmed observations.

- Inferred architectural characteristics.

- Unresolved questions.

- Recommended changes.

A repository assessment is not authorization to implement every recommendation it contains.

## 8. Local Development Environment

The application should support ordinary local development using the appropriate .NET SDK.

The project owner may develop on Windows or Linux.

Where practical, maintain compatibility across both environments.

Avoid unnecessary assumptions about:

- Absolute filesystem paths.

- Windows-specific directory conventions.

- Linux-specific shell utilities.

- Case-insensitive filesystems.

- Locally installed proprietary tools.

- Machine-specific environment variables.

Document required prerequisites in README.md.

Potential prerequisites include:

- Appropriate .NET SDK.

- Git.

- A suitable code editor or IDE.

- Required local services, if any.

Do not introduce Docker, Node.js, databases, or additional development services unless the application actually requires them.

## 9. Environment Configuration

Development, testing, and production environments should remain distinguishable.

Use appropriate ASP.NET Core environment configuration conventions.

Never commit:

- API keys.

- Passwords.

- Private certificates.

- Access tokens.

- Production connection strings containing credentials.

- Personal authentication information.

Use environment variables, .NET user secrets, or other approved secret-management mechanisms.

Example configuration files may contain placeholders but must not contain real credentials.

AI coding agents must not retrieve, expose, copy, or transmit secrets.

Do not connect local development to production data or services without explicit authorization.

## 10. Git Branching Strategy

The following branching strategy is proposed and must be reconciled with existing repository conventions.

### Main branch

The main branch should represent the stable, reviewed state of the application.

Direct modifications should ordinarily be avoided.

### Development branch

A dedicated development branch may be introduced if the project benefits from a separate integration environment.

For a small project, a main branch with short-lived feature branches may be sufficient.

Do not introduce unnecessary branching complexity.

### Feature branches

Substantial work should occur in appropriately named branches.

Examples:

```
feat/editorial-homepagefeat/markdown-contentfeat/developer-directoryfeat/meetup-archivefix/navigation-accessibilityfix/article-renderingdocs/repository-assessmentrefactor/shared-layouttest/content-validation
```

Use descriptive names that communicate the purpose of the work.

Avoid combining unrelated features in a single branch.

## 11. Working Tree Safety

Before modifying files, inspect the current working tree.

Typical commands include:

```
git status -sbgit branch --show-currentgit diffgit log -5 --oneline
```

Do not overwrite existing uncommitted work.

Do not assume that unfamiliar changes were generated by an AI system.

If existing changes overlap with the assigned task, report the conflict before proceeding.

AI agents must not independently perform destructive Git operations, including:

- git reset --hard

- git clean -fd

- Force-pushing branches.

- Rewriting shared history.

- Deleting branches containing unmerged work.

- Discarding user modifications.

- Automatically resolving conflicts by removing unfamiliar code.

Such operations require explicit authorization.

## 12. Commit Conventions

Prefer concise, descriptive commit messages.

Conventional Commit-style prefixes may be used where compatible with existing repository practices.

Examples:

```
feat(magazine): add article listing pagefeat(content): implement publication filteringfix(layout): improve mobile navigationfix(a11y): improve keyboard focus visibilitydocs(architecture): document rendering strategytest(content): validate duplicate slugsrefactor(styles): centralize semantic color tokenschore(deps): update approved dependencies
```

Each commit should represent a coherent change.

Avoid vague commit messages such as:

- update

- fixes

- changes

- stuff

- final version

AI agents should not commit or push changes unless the assigned task explicitly authorizes those operations.

## 13. GitHub Issues

GitHub Issues should provide a manageable record of development work.

An issue may include:

- Title.

- Context.

- Objective.

- Relevant documentation.

- Scope.

- Acceptance criteria.

- Dependencies.

- Known constraints.

- Testing requirements.

- Completion notes.

Potential issue categories include:

- Architecture.

- Frontend.

- Content.

- Accessibility.

- Historical preservation.

- Testing.

- Documentation.

- Security.

- Deployment.

Avoid creating excessive administrative work for minor implementation details.

Larger workstreams should be divided into independently reviewable tasks.

## 14. Pull Requests

Pull requests should explain what changed and why.

A proposed pull request structure is:

### Summary

Describe the purpose of the change.

### Related issue

Identify the relevant GitHub Issue, when applicable.

### Changes

Summarize important implementation changes.

### Verification

Identify commands executed, tests performed, and observed results.

### Visual changes

Include screenshots where useful.

### Accessibility

Describe relevant accessibility checks.

### Risks and limitations

Identify known issues, assumptions, and incomplete work.

### Architectural implications

Identify significant changes to dependencies, persistence, rendering, deployment, or application structure.

Do not claim that tests passed when they were not executed.

Do not claim that visual or accessibility requirements were verified when no corresponding evaluation occurred.

## 15. Human Review

The project owner should review substantive changes before they enter the stable application.

Review should consider:

- Alignment with project requirements.

- Architectural consistency.

- Code readability.

- Security.

- Accessibility.

- Performance.

- Dependency changes.

- Historical content preservation.

- Test coverage.

- Maintainability.

AI-generated code should receive the same scrutiny as human-generated code.

AI agents must not approve their own changes as a substitute for human review.

A successful build does not automatically establish that a feature is correct.

## 16. AI-Assisted Development Roles

EugDotNet may use multiple AI systems.

Potential tools include:

- ChatGPT.

- Codex.

- Gemini.

- Other explicitly approved development assistants.

These systems should operate within clearly defined task boundaries.

### 16.1 ChatGPT

Potential responsibilities include:

- Architectural planning.

- Requirements development.

- Documentation.

- Technical explanation.

- Troubleshooting.

- Code review.

- Editorial assistance.

- Development task preparation.

### 16.2 Codex

Potential responsibilities include:

- Repository inspection.

- Scoped code implementation.

- Refactoring.

- Test development.

- Build verification.

- Documentation updates.

- Preparation of reviewable changes.

Codex should follow repository-level AGENTS.md instructions.

### 16.3 Gemini

Potential responsibilities include:

- Independent architectural review.

- Alternative implementation proposals.

- Research assistance.

- Technical critique.

- Review of selected code or documentation.

- Identification of overlooked assumptions.

Gemini does not require unrestricted repository access merely to perform these responsibilities.

Provide only the information necessary for the assigned review.

### 16.4 Human project owner

The project owner coordinates the work of these systems and resolves conflicting recommendations.

The project owner determines which proposals become approved requirements.

## 17. AI Task Assignment

AI implementation tasks should be explicit and bounded.

A useful task description should establish:

- Objective.

- Relevant files or components.

- Relevant documentation.

- Permitted modifications.

- Prohibited modifications.

- Expected deliverables.

- Acceptance criteria.

- Verification requirements.

- Whether commits or pushes are authorized.

Example task:

```
Objective:Implement the shared editorial masthead.Read:- AGENTS.md- docs/PROJECT-BRIEF.md- docs/SITE-MAP.md- docs/DESIGN-SYSTEM.mdScope:- Existing shared layout components.- Relevant shared stylesheets.- Necessary component tests.Constraints:- Preserve existing routes.- Preserve historical meetup content.- Do not introduce dependencies.- Do not change deployment configuration.- Do not commit or push.Verification:- Build the application.- Test desktop and mobile navigation where possible.- Report accessibility checks and limitations.Deliverable:A reviewable implementation and concise change report.
```

Do not assign broad instructions such as "finish the entire website" when the required work can be divided into smaller tasks.

## 18. Multi-Agent Coordination

Multiple AI systems may contribute to the project, but their work must remain coordinated.

Prefer one active implementation agent per branch or working tree.

Independent review agents should ordinarily receive:

- Relevant documentation.

- Selected code.

- A Git diff.

- A proposed architectural decision.

- Test results.

- A specific review question.

Do not allow multiple agents to independently modify the same files without coordination.

If parallel implementation becomes useful, use isolated branches or Git worktrees.

Parallel changes must be reviewed and integrated deliberately.

Do not merge competing implementations merely because each was independently generated.

## 19. AI Permissions and Approval Boundaries

AI agents may perform ordinary repository inspection and scoped implementation work when authorized.

Separate approval is required for:

- Framework upgrades.

- New runtime dependencies.

- Major development dependencies.

- Database introduction.

- Authentication systems.

- External API integrations.

- Paid services.

- Changes to hosting infrastructure.

- CI/CD modifications affecting production.

- Repository permission changes.

- Production deployments.

- Destructive filesystem operations.

- Destructive Git operations.

- Publication of editorial content.

- Transmission of private material to external systems.

Approval must apply to the specific operation being performed.

General permission to work on the repository does not imply permission to perform every available action.

## 20. Dependency Management

Prefer the existing application dependencies where appropriate.

Before proposing a new dependency, consider:

- What problem it solves.

- Whether existing platform functionality is sufficient.

- Licensing.

- Maintenance activity.

- Security history.

- Compatibility.

- Transitive dependencies.

- Performance implications.

- Operational requirements.

Do not introduce dependencies solely to reduce a small amount of straightforward application code.

Document significant dependency decisions.

Do not automatically upgrade unrelated packages during feature implementation.

## 21. Coding Standards

Follow established repository conventions unless there is a demonstrated reason to change them.

C# code should generally use:

- Meaningful names.

- Appropriate access modifiers.

- Nullable reference types where supported.

- Explicit responsibility boundaries.

- Asynchronous operations where appropriate.

- Clear error handling.

- Appropriate dependency injection.

- Ordinary .NET conventions.

Avoid:

- Unnecessary inheritance.

- Excessive generic abstractions.

- Speculative design patterns.

- Large classes with unrelated responsibilities.

- Duplicated business logic.

- Silent exception handling.

- Hard-coded environment-specific values.

- Unnecessary global mutable state.

Comments should explain non-obvious reasoning rather than repeat the behavior already expressed by the code.

## 22. Frontend Development

Frontend implementation should follow DESIGN-SYSTEM.md.

Requirements include:

- Semantic HTML.

- Reusable components.

- Consistent design tokens.

- Responsive layouts.

- Accessible interactions.

- Predictable navigation.

- Appropriate typography.

- Minimal unnecessary JavaScript.

Avoid introducing inline styles throughout the application when shared styling conventions are more appropriate.

Do not reproduce the same component structure across multiple pages unnecessarily.

Visual changes should preserve ordinary application functionality.

Where practical, review visual changes in a running browser.

## 23. Accessibility Workflow

Accessibility should be evaluated throughout development.

Potential automated tools include:

- axe.

- Lighthouse.

- Existing accessibility test integrations.

Manual evaluation should include, where relevant:

- Keyboard navigation.

- Visible focus.

- Heading hierarchy.

- Landmark structure.

- Form labels.

- Color contrast.

- Responsive text scaling.

- Reduced-motion behavior.

- Screen-reader compatibility.

- Meaningful link text.

Automated accessibility checks do not establish complete WCAG compliance.

Report which checks were actually performed.

Do not claim accessibility conformance solely because an automated tool reported no violations.

## 24. Build and Test Workflow

Use verified commands appropriate to the existing solution.

Potential standard commands include:

```
dotnet restoredotnet builddotnet testdotnet run
```

The actual commands may require project or solution paths.

Do not assume that all commands are applicable before inspecting the repository.

### Before implementation

Where practical:

- Establish the current build state.

- Run relevant existing tests.

- Identify pre-existing failures.

### After implementation

Where practical:

- Build the application.

- Run relevant automated tests.

- Verify affected routes.

- Inspect changed behavior.

- Report remaining failures.

Distinguish pre-existing failures from failures introduced by the current work.

Do not conceal failed tests.

## 25. Test Development

Tests should address meaningful behavior.

Potential test categories include:

- Content metadata validation.

- Markdown rendering.

- Publication filtering.

- Route resolution.

- Missing content behavior.

- Slug uniqueness.

- Content relationships.

- Directory availability.

- Historical redirects.

- Component behavior.

- Accessibility-sensitive interactions.

Prefer tests that remain useful when implementation details change.

Do not write tests solely to increase a numerical coverage metric.

Avoid introducing a new testing framework without evaluating existing project conventions.

## 26. Visual Verification

Substantial frontend changes should receive visual review.

Potential viewport widths include:

- 375px.

- 768px.

- 1024px.

- 1440px.

These are representative test sizes rather than mandatory responsive breakpoints.

Visual verification should examine:

- Masthead.

- Navigation.

- Editorial hierarchy.

- Article readability.

- Responsive behavior.

- Code block overflow.

- Directory layout.

- Historical archive presentation.

- Footer.

- Empty states.

- Error states.

Screenshots may be attached to GitHub Issues or pull requests.

If browser-based verification is unavailable, state that limitation explicitly.

## 27. Content Development Workflow

Editorial content should follow CONTENT-MODEL.md and EDITORIAL-GUIDELINES.md.

The proposed repository-based workflow is:

1. Create a draft.

2. Add appropriate metadata.

3. Write and revise the content.

4. Verify sources and technical claims.

5. Preview locally.

6. Validate metadata.

7. Review media attribution.

8. Obtain editorial approval.

9. Mark the content as published.

10. Commit the approved changes.

11. Publish through an authorized deployment.

Code implementation and editorial approval are separate responsibilities.

AI-generated sample content must not be represented as approved publication material.

## 28. Historical Content Protection

Before modifying existing meetup pages or assets:

- Identify the original material.

- Determine whether it is referenced elsewhere.

- Preserve attribution.

- Preserve historical dates.

- Preserve relevant public URLs where practical.

- Establish an appropriate migration strategy.

Do not remove historical material merely because it is incompatible with a proposed new layout.

When necessary, retain legacy pages until an approved replacement is available.

Historical preservation should be included in relevant acceptance criteria.

## 29. Architectural Decision Records

Significant architectural decisions should be documented in docs/adr/.

A proposed ADR format is:

```
# ADR-0001: Decision Title## StatusProposed## ContextDescribe the problem and relevant constraints.## DecisionDescribe the proposed or approved decision.## AlternativesDescribe meaningful alternatives.## RationaleExplain why the decision is appropriate.## ConsequencesDescribe benefits, trade-offs, and limitations.## ApprovalRecord the approval status.
```

Potential ADR statuses include:

- Proposed.

- Accepted.

- Rejected.

- Superseded.

AI agents may propose ADRs.

Only authorized human approval should change a proposed architectural decision to accepted.

## 30. Continuous Integration

Existing CI configuration should be inspected before changes are proposed.

A future CI pipeline may include:

- Dependency restoration.

- Application compilation.

- Automated tests.

- Content validation.

- Accessibility checks where practical.

- Build artifact generation.

- Dependency security checks.

CI should provide useful feedback without creating unnecessary maintenance overhead.

A successful CI run is not automatic authorization to deploy to production.

## 31. Deployment Workflow

Production deployment must remain an explicitly authorized operation.

Before deployment:

- Review the intended changes.

- Verify build results.

- Review relevant test results.

- Confirm environment configuration.

- Review dependency changes.

- Verify historical content preservation.

- Confirm editorial approval where applicable.

- Identify rollback procedures.

Do not modify production infrastructure as an incidental part of ordinary feature development.

Do not publish private drafts or development fixtures.

Do not deploy automatically from an AI-generated branch without approved deployment controls.

## 32. Rollback and Recovery

Substantial changes should remain recoverable.

Use Git history, reviewed commits, appropriate backups, and documented deployment procedures.

Before introducing persistence infrastructure, establish appropriate backup and restoration practices.

Avoid destructive changes that cannot be reasonably reversed.

When a deployment introduces a significant regression, prefer a documented recovery process over uncontrolled emergency modifications.

## 33. Task Completion Reports

AI coding agents should conclude substantial tasks with a concise report.

The report should include:

### Summary

What was implemented.

### Files changed

Important modified, added, or removed files.

### Verification

Commands executed and their actual results.

### Decisions

Material implementation decisions made during the task.

### Assumptions

Any assumptions that influenced the implementation.

### Limitations

Known defects, incomplete verification, and unresolved issues.

### Follow-up

Recommended subsequent work.

### Repository state

Current branch, working tree status, and whether changes were committed or pushed.

Do not conceal incomplete work.

Do not claim that an issue is resolved when its acceptance criteria remain unmet.

## 34. Definition of Done

A development task may be considered complete when:

- Its approved objective has been satisfied.

- Its scope has been respected.

- Relevant documentation has been followed.

- Existing unrelated functionality remains intact.

- Historical material has been preserved.

- Appropriate tests have been executed where possible.

- Known failures have been disclosed.

- Relevant accessibility requirements have been considered.

- Significant decisions have been documented.

- The changes are available for human review.

A task may be implementation-complete while still awaiting human review, integration, or deployment.

These states should remain distinguishable.

## 35. Development Sustainability

EugDotNet should remain manageable as an independent project.

Do not introduce development processes that require disproportionate administrative effort.

Prefer lightweight issue tracking, concise documentation, practical testing, and incremental improvements.

The project owner may adjust workflow formality according to:

- Project size.

- Number of contributors.

- Technical complexity.

- Security requirements.

- Publication activity.

- Available development time.

The development process should support the publication rather than become an obstacle to it.

## 36. Definition of Workflow Success

The development workflow should be considered successful when:

- Changes remain understandable and reviewable.

- Human ownership remains clear.

- AI assistance improves productivity without compromising control.

- Repository access remains appropriately restricted.

- Architectural decisions remain documented.

- Tests provide meaningful feedback.

- Historical content remains protected.

- Production changes remain deliberate.

- Multiple tools can contribute without creating architectural fragmentation.

- Development remains sustainable over time.

EugDotNet should demonstrate that AI-assisted software development can be disciplined, transparent, secure, and compatible with responsible human engineering judgment.
