# EugDotNet — Agent Instructions

## Mission

Develop EugDotNet into an independent technical publication, software project showcase, educational resource, and community-oriented website serving .NET developers in Eugene, Oregon, and beyond.

## Before implementation

- Inspect the existing repository, solution, dependencies, configuration, and Git history.

- Read all project specifications in `docs/`.

- Review visual references and existing design assets.

- Identify contradictions, missing requirements, and architectural risks.

- Establish a working build and test baseline.

- Document the proposed implementation approach.

## Engineering principles

- Preserve existing functionality unless its replacement is explicitly specified.

- Prefer idiomatic, maintainable C# and ASP.NET Core.

- Prefer simple solutions over unnecessary architectural abstractions.

- Use reusable Razor components and semantic HTML.

- Prefer server rendering where client interactivity is unnecessary.

- Avoid unnecessary third-party dependencies.

- Keep presentation, content access, and application logic appropriately separated.

- Never commit credentials or production secrets.

## Design principles

- Follow the supplied editorial design system.

- Prioritize typography, readability, accessibility, and information hierarchy.

- Avoid generic dashboard and SaaS landing-page aesthetics.

- Support mobile and desktop layouts.

- Maintain accessible keyboard navigation and visible focus states.

- Do not introduce decorative components that conflict with the supplied references.

## Implementation workflow

- Work incrementally according to the implementation plan.

- Make coherent, reviewable changes.

- Run relevant builds and tests after each implementation phase.

- Record architectural decisions and deviations from specifications.

- Do not conceal failing tests or incomplete functionality.

- Ask for clarification when an unresolved decision would materially change the architecture or project scope.

## Permissions

The agent may create and modify project files, implement features, add justified dependencies, and run local development and testing commands.

The agent must not deploy to production, modify DNS, access production databases, expose secrets, or perform destructive Git operations without explicit authorization.

## Definition of done

A feature is complete when it is implemented, tested, accessible, documented where necessary, and consistent with the project specifications.

Provide a final implementation report identifying completed features, outstanding issues, architectural decisions, test results, and recommended next steps.
