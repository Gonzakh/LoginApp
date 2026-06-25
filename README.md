# LoginApp

Proyecto personal de aprendizaje enfocado en el desarrollo backend y la evolución de arquitectura de software utilizando el mismo dominio de negocio: autenticación y gestión de usuarios.

El objetivo es construir una aplicación que evolucione progresivamente desde una aplicación de consola hasta una arquitectura distribuida, reutilizando el dominio y aplicando buenas prácticas de desarrollo.

---

## Objetivos

- Aprender arquitectura de software en .NET.
- Aplicar principios SOLID y separación de responsabilidades.
- Mantener un dominio reutilizable entre distintas tecnologías.
- Incorporar patrones de diseño únicamente cuando sean necesarios.
- Evolucionar el proyecto sin reescribir la lógica de negocio.

---

## Roadmap

- [x] Consola
- [ ] WPF
- [ ] ASP.NET MVC
- [ ] Minimal API
- [ ] Blazor
- [ ] JWT Authentication
- [ ] Roles & Policies
- [ ] Clean Architecture
- [ ] Auth Server / Microservices

---

## Arquitectura (v1)

```
Console
    │
Application
    │
Domain
    │
Infrastructure
```

### Responsabilidades

| Proyecto | Responsabilidad |
|----------|-----------------|
| LoginApp.Console | Interfaz de usuario (Consola) |
| LoginApp.Application | Casos de uso y coordinación |
| LoginApp.Domain | Entidades y reglas de negocio |
| LoginApp.Infrastructure | Persistencia e implementaciones técnicas |

---

## Estructura

```text
src/
│
├── LoginApp.Console
├── LoginApp.Application
├── LoginApp.Domain
└── LoginApp.Infrastructure

tests/
│
├── LoginApp.Domain.Tests
└── LoginApp.Application.Tests
```

---

## Tecnologías

- .NET
- C#
- xUnit
- Git

---

## Principios aplicados

- SOLID
- Separation of Concerns
- Dependency Inversion
- Domain First
- Arquitectura evolutiva
- Refactorización incremental

---

## Estado actual

Versión inicial en consola con las funcionalidades básicas de:

- Registro de usuarios
- Inicio de sesión
- Logout
- Persistencia en memoria

---

## Próximos pasos

- Persistencia con Entity Framework Core
- Testing de integración
- ASP.NET MVC
- Minimal API
- Blazor
