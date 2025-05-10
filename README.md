# AOLabs University System

**Open-source university management system for the Arab world.**

This project is part of [AOLabsOrg](https://github.com/AOLabsOrg) — an open-source initiative aimed at rebuilding and modernizing critical digital infrastructure across the Arab world, starting with education.

## 🎯 Project Goal

To build a scalable, modular, and open-source system that universities can use to manage students, courses, schedules, grades, and more — in a clean, developer-friendly way.

## 🧱 Tech Stack

- **Backend**: ASP.NET Core 8 (Clean Architecture)
- **Database**: PostgreSQL (Code First via EF Core)
- **Authentication**: JWT & Role-based access control
- **Reporting**: FastReport or PDF generation
- **Docs**: Markdown + Diagrams

## 📦 Layers

- `API`: ASP.NET Core Web API
- `Application`: Use Cases, DTOs, Interfaces
- `Domain`: Core Entities, ValueObjects
- `Infrastructure`: EF Core, Services, External APIs
- `Persistence`: DbContext, Repositories

## 📚 Documentation

See [`/docs`](./docs) folder for:
- [Architecture Overview](./docs/architecture.md)
- Roadmap (coming soon)
- ER Diagram (coming soon)

## 🤝 Contributing

Pull requests are welcome! Check out the [contributing guide](./CONTRIBUTING.md) to get started.

---

🛡️ Copyright

All contributions are the property of their respective authors.

This project is managed by the [AOLabs Organization](https://github.com/AOLabs) and governed under the MIT License.

Any major decisions (design, features, releases) are reviewed and approved by the maintainers of the organization.

---

Built with ❤️ by the Arab developer community.
