# EugDotNet — Design System and Visual Identity

## 1. Design Philosophy

EugDotNet should present itself as an independent technology publication, engineering laboratory, and regional professional resource.

Its visual identity should combine the qualities of:

- An independent literary magazine.

- A serious technical journal.

- A contemporary software engineering publication.

- A regional community institution.

- A practical developer resource.

The design should communicate intellectual curiosity, craftsmanship, accessibility, credibility, and independence.

Content should remain the central focus of the experience.

The website should not resemble a generic corporate marketing site, startup landing page, social media platform, or administrative dashboard.

## 2. Visual References

Potential sources of design inspiration include:

- MIT Technology Review

- A List Apart

- The New Atlantis

- Increment

- IEEE Spectrum

- Independent literary and cultural journals

- Contemporary newspaper and magazine editorial layouts

These references establish a general aesthetic direction. Their branding, proprietary assets, and specific designs must not be copied.

EugDotNet should develop its own recognizable visual identity.

## 3. Core Design Principles

### 3.1 Editorial hierarchy

Typography, spacing, alignment, and composition should establish hierarchy before decorative elements are introduced.

Readers should immediately understand:

- What publication they are visiting.

- Which content is featured.

- What kind of content they are reading.

- Who produced the content.

- Where they can find related material.

### 3.2 Content-first presentation

Articles, technical demonstrations, and professional profiles should not be visually overwhelmed by interface elements.

Prefer clear reading surfaces, restrained navigation, and meaningful imagery.

### 3.3 Visual restraint

Avoid excessive use of:

- Gradients

- Drop shadows

- Rounded cards

- Floating interface elements

- Decorative animations

- Oversized promotional headlines

- Glassmorphism

- Unnecessary icons

- Generic technology stock imagery

These techniques are not categorically prohibited, but their use must serve a clear purpose.

### 3.4 Regional identity

EugDotNet should retain a connection to Eugene, Springfield, Oregon, and the Pacific Northwest.

Regional identity may be expressed through photography, editorial subject matter, subtle color choices, and community coverage.

Avoid reducing regional identity to stereotypical imagery or decorative motifs.

### 3.5 Technical credibility

Code examples, diagrams, tables, project metadata, and technical documentation should be treated as first-class design elements.

The technical portions of the website should be as carefully designed as its editorial portions.

## 4. Proposed Color System

The initial palette should draw from editorial print design, natural materials, and the restrained colors of the Pacific Northwest.

The following colors are provisional design tokens and may be refined during visual development and accessibility testing.

| Token            | Proposed value | Purpose                               |
| ---------------- | -------------- | ------------------------------------- |
| background       | #F6F4EE        | Primary page background               |
| surface          | #FFFFFF        | Elevated or alternate reading surface |
| foreground       | #202522        | Primary text                          |
| foreground-muted | #59615C        | Secondary text                        |
| border           | #D4D8D0        | Rules, borders, and separators        |
| primary          | #244B3B        | Evergreen institutional accent        |
| primary-hover    | #18392B        | Interactive hover state               |
| accent           | #A34B2D        | Restrained editorial accent           |
| link             | #245B75        | Inline hyperlinks                     |
| focus            | #245B75        | Keyboard focus indicator              |
| code-background  | #EAEDE7        | Inline and block code surfaces        |
| dark-background  | #19221E        | Optional dark feature sections        |

Colors should be implemented through semantic design tokens rather than repeated hard-coded values.

The palette must be evaluated against WCAG 2.2 AA contrast requirements before production use.

Color alone must never communicate meaning or interactive state.

## 5. Typography

Typography is a principal component of EugDotNet's identity.

The website should distinguish editorial typography from interface typography and technical typography.

### 5.1 Editorial serif

Proposed candidates:

- Source Serif 4

- Spectral

- Libre Baskerville

Use for:

- Article body text

- Editorial headlines

- Feature introductions

- Pull quotations

- Long-form essays

### 5.2 Interface sans-serif

Proposed candidates:

- Inter

- Source Sans 3

- IBM Plex Sans

Use for:

- Navigation

- Buttons

- Form controls

- Metadata

- Directory filters

- Interface labels

### 5.3 Technical monospace

Proposed candidates:

- IBM Plex Mono

- JetBrains Mono

Use for:

- Code examples

- Commands

- File paths

- Technical identifiers

- Selected project metadata

Select one primary font family for each role during implementation.

Do not load every proposed font.

Prefer locally hosted fonts where practical, subject to licensing requirements.

### 5.4 Proposed typographic scale

| Role             | Size    |
| ---------------- | ------- |
| Masthead         | 40–64px |
| Display headline | 36–56px |
| Page heading     | 32–40px |
| Section heading  | 24–32px |
| Subheading       | 20–24px |
| Article body     | 18–20px |
| General body     | 16px    |
| Metadata         | 13–14px |
| Code             | 14–16px |

These sizes are starting points rather than rigid requirements.

Typography should scale appropriately across viewport sizes.

Long-form article text should generally use a line height between 1.55 and 1.75.

Article reading width should generally remain between 60 and 75 characters.

## 6. Layout System

### 6.1 Page width

Proposed maximum site container width: 1280px.

Individual content types may use narrower or wider containers according to their purpose.

### 6.2 Editorial grid

The desktop homepage should use a flexible editorial grid capable of supporting:

- Lead articles

- Secondary stories

- Article collections

- Laboratory features

- Community announcements

- Directory highlights

The grid should permit asymmetrical compositions rather than requiring every content item to occupy an identical card.

Layouts should collapse naturally into a single-column reading experience on narrow screens.

### 6.3 Article layout

Article pages should prioritize uninterrupted reading.

Possible supporting elements include:

- Article metadata

- Table of contents

- Author information

- Related material

- References

- Footnotes

- Technical callouts

Supporting elements must not unnecessarily reduce the primary reading area.

### 6.4 Spacing

Use a consistent spacing system based on multiples of four or eight pixels.

Proposed spacing tokens:

- 4px

- 8px

- 12px

- 16px

- 24px

- 32px

- 48px

- 64px

- 96px

Use generous whitespace between major editorial sections.

## 7. Masthead and Navigation

The publication masthead should establish a recognizable identity.

The masthead may include:

- EugDotNet wordmark

- Publication descriptor

- Primary navigation

- Optional publication date

- Optional search control

Proposed publication descriptor:

Technology, Engineering & Community

The masthead should resemble that of an independent publication rather than a corporate product header.

Navigation should remain usable without requiring complex interactions.

Mobile navigation must support keyboard operation, screen readers, and visible focus states.

Preserve the existing EugDotNet identity where appropriate, including historical branding assets.

## 8. Homepage Composition

The homepage should function as an editorial front page.

A possible initial composition includes:

1. Masthead and primary navigation.

2. Featured article with prominent headline and optional imagery.

3. Recent editorial articles.

4. Selected laboratory projects.

5. Developer directory feature.

6. Community news and meetup archive links.

7. Publication introduction and footer.

The homepage should avoid a large marketing hero that displaces substantive content below the fold.

Editorial sections should remain independently reusable.

The homepage must remain credible when the publication contains only a modest amount of content.

Do not populate the homepage with fabricated articles or community activity merely to create visual density.

## 9. Shared Components

Develop reusable components where supported by the existing application architecture.

### Editorial components

- Publication masthead

- Primary navigation

- Section heading

- Featured article

- Article preview

- Article metadata

- Author attribution

- Category label

- Pull quotation

- Figure and caption

- Related article list

- References section

### Technical components

- Code block

- Inline code

- Technical callout

- Project preview

- Technology stack

- Project status indicator

- Repository link

- Demonstration link

- Technical table

- Diagram container

### Directory components

- Developer preview

- Developer profile

- Specialty label

- Availability indicator

- Contact links

- Directory filter

- Last-confirmed date

### Community components

- Meetup archive entry

- Event preview

- Speaker attribution

- Presentation resource link

- Community announcement

### General components

- Button

- Text link

- Form field

- Breadcrumb navigation

- Pagination

- Empty state

- Error state

- Footer

Components should be designed around semantic purpose rather than arbitrary visual variation.

## 10. Article Presentation

Article pages should support:

- Clear heading hierarchy

- Comfortable paragraph spacing

- Ordered and unordered lists

- Block quotations

- Pull quotations

- Tables

- Inline hyperlinks

- Code examples

- Images with captions

- Footnotes and references

- Accessible embedded media

Editorial classifications such as reporting, opinion, tutorial, interview, review, and essay should be visible when applicable.

Publication dates and author attribution should be easy to locate.

Avoid decorative interruptions that compromise long-form reading.

## 11. Code and Technical Content

Code examples should use a consistent monospace typeface and accessible syntax highlighting.

Code blocks should support:

- Language identification

- Horizontal scrolling when necessary

- Optional copy controls

- Clear separation from surrounding prose

- Preservation of indentation and whitespace

Code blocks must not cause horizontal overflow of the entire page.

Technical diagrams should include appropriate text alternatives or accompanying explanations.

Interactive demonstrations should be clearly identified and must not interfere with ordinary page navigation.

## 12. Directory Presentation

The directory should prioritize useful professional information over promotional presentation.

Developer previews should clearly communicate:

- Name

- Professional role

- Technical specialties

- Regional connection

- Availability, when confirmed

- Link to further information

Availability indicators must include readable text and must not rely exclusively on color.

Developer profiles should not use artificial ratings, rankings, or popularity scores.

Profile photographs should be optional.

## 13. Imagery and Illustration

Images should serve editorial, documentary, or explanatory purposes.

Preferred imagery includes:

- Original photography

- Regional photography

- Original illustrations

- Software screenshots

- Technical diagrams

- Photographs of community events

- Contributor-provided project imagery

Avoid generic stock photographs of programmers, abstract circuitry, glowing artificial intelligence imagery, and decorative imagery unrelated to the accompanying content.

AI-generated illustrations may be used where appropriate but must not be presented as documentary photographs of actual people, places, or events.

Image attribution and licensing must be respected.

## 14. Interaction Design

Interactive behavior should be restrained, predictable, and accessible.

Prefer:

- Clear hover and focus states

- Immediate interaction feedback

- Standard navigation conventions

- Meaningful link labels

- Progressive enhancement

- Native browser behavior where appropriate

Avoid unnecessary animation and interaction complexity.

Respect the user's reduced-motion preference.

Core reading and navigation functionality should not depend on decorative JavaScript behavior.

## 15. Accessibility

Target WCAG 2.2 AA compliance.

Accessibility requirements include:

- Semantic HTML

- Logical heading hierarchy

- Keyboard-accessible navigation

- Visible keyboard focus

- Appropriate color contrast

- Descriptive alternative text

- Accessible form labels

- Accessible error messages

- Meaningful link text

- Responsive text scaling

- Reduced-motion support

- Appropriate touch target sizing

- Skip-to-content navigation

Use native HTML elements before introducing custom ARIA behavior.

Automated accessibility testing should be supplemented by manual keyboard and screen-reader testing.

Accessibility must be treated as an architectural requirement rather than a final cosmetic adjustment.

## 16. Responsive Design

The website must support:

- Mobile phones

- Tablets

- Laptop computers

- Desktop displays

Use content-driven responsive breakpoints rather than device-specific assumptions.

Desktop editorial compositions should adapt gracefully to narrower displays.

Avoid horizontal page overflow.

Technical tables and code examples may use localized scrolling where necessary.

Important content must not be hidden solely because the viewport is narrow.

## 17. Dark Mode

Dark mode is a possible future enhancement.

The initial design should use semantic color tokens so that an alternate theme can be introduced without restructuring components.

Do not prioritize dark mode over the completion of a coherent, accessible primary theme.

If dark mode is implemented, it must support the same accessibility and readability standards as the primary theme.

## 18. Performance

The visual system should remain lightweight.

Prefer:

- Optimized image formats

- Responsive images

- Limited font families and weights

- Reusable styles

- Minimal unnecessary JavaScript

- Stable content layouts

- Efficient component rendering

Avoid introducing large frontend dependencies solely for decorative effects.

The website should remain responsive on modest hardware and slower connections.

## 19. Implementation Guidance

Before implementing this design system:

1. Inspect the existing repository.

2. Identify the existing CSS architecture and styling conventions.

3. Identify reusable layouts and components.

4. Inventory existing branding assets.

5. Identify existing responsive behavior.

6. Determine how design tokens can be introduced incrementally.

Preserve existing framework conventions where practical.

Do not introduce Tailwind CSS, Bootstrap, a component library, or another styling framework without first evaluating the existing implementation and obtaining approval.

Prefer a coherent and maintainable styling architecture over unnecessary framework migration.

Design decisions that materially alter the established project architecture require explicit approval.

## 20. Design Deliverables

The initial design implementation should establish:

- Semantic color tokens

- Typography definitions

- Spacing tokens

- Shared page containers

- Masthead and navigation

- Footer

- Editorial article template

- Article preview components

- Laboratory project previews

- Developer directory previews

- Responsive behavior

- Accessible interactive states

A dedicated component reference or style-guide page may be developed to demonstrate these elements independently of production content.

## 21. Design Success Criteria

The design should be considered successful when:

- EugDotNet possesses a recognizable editorial identity.

- Long-form articles are comfortable to read.

- Technical content is clear and usable.

- Regional community information is easy to discover.

- Navigation is predictable and accessible.

- The website works across viewport sizes.

- Components can be maintained and extended without extensive duplication.

- The publication remains visually credible with a small initial content library.

The objective is not visual novelty for its own sake.

The objective is a durable, distinctive, accessible publication that readers can trust and developers can maintain.



## 22. Pacific Northwest Visual Identity

EugDotNet explicitly embraces a Pacific Northwest regional identity.

Its visual atmosphere should draw inspiration from:

- Evergreen forests and the Cascade landscape.

- Rain, mist, overcast skies, and subdued natural light.

- The Willamette Valley.

- Historic brick buildings and university architecture.

- Independent bookstores, coffee shops, and community gathering spaces.

- The region's traditions of craftsmanship, independent enterprise, intellectual inquiry, and technological experimentation.

The approved foundational palette consists of:

| Color             | Value   |
| ----------------- | ------- |
| Editorial Paper   | #F6F4EE |
| Forest Ink        | #202522 |
| Cascade Evergreen | #244B3B |
| Fired Clay        | #A34B2D |
| Rainwater Blue    | #245B75 |
| Coastal Mist      | #D4D8D0 |

These colors establish the intended visual identity. Individual applications remain subject to accessibility and contrast testing.

The guiding aesthetic may be described as Pacific Northwest editorial modernism: understated, intellectually engaged, regionally grounded, and contemporary.

Regional identity should be communicated through atmosphere, typography, photography, color, and editorial subject matter rather than through excessive decorative symbolism.

EugDotNet should feel like a publication produced within the Pacific Northwest, not a publication advertising the Pacific Northwest.

Its regional roots should complement, rather than limit, its broader technical and intellectual interests.


