# Sci-Fi_Universe_Backend - ASP.NET Core Clean Architecture

API REST construida con **ASP.NET Core** siguiendo principios de **Clean Architecture**, enfocada en buenas prácticas, bajo acoplamiento y alta cohesión.

---

# Arquitectura

El proyecto está estructurado en capas siguiendo Clean Architecture:

Sci-Fi_Universe
- Domain
- Application
- Infrastructure
- API


## Domain
- Contiene entidades del negocio
- No depende de ninguna otra capa
- Ejemplo:
  - `Character`

## Application
- Contiene lógica de aplicación (casos de uso)
- Define interfaces (contratos)
- Usa DTOs para comunicación
- Componentes:
  - `CharacterService`
  - `ICharacterRepository`
  - `CharacterDto`

## Infrastructure
- Implementa acceso a datos
- Usa Entity Framework Core
- Componentes:
  - `ApplicationDbContext`
  - `CharacterRepository`

## API (Presentation)
- Expone endpoints REST
- Maneja HTTP
- Componentes:
  - `CharacterController`

---

# Funcionalidades

✔ CRUD completo de personajes  
✔ Arquitectura desacoplada  
✔ Uso de DTOs  
✔ Inyección de dependencias  
✔ Uso de Entity Framework Core  
✔ Base de datos InMemory  
✔ Swagger para documentación  

---

# Entidad Principal

## Character

```json
{
    "id": 1,
    "name": "Neo",
    "description": "Se ilumina digitalmente",
    "work": "The Matrix",
    "birthDate": "1962-03-11"
  }
```

---

# Mejoras 24-03-2026 17:00: AutoMapper + MongoDB

Este documento describe las mejoras aplicadas al proyecto para elevarlo a un nivel más profesional:

- ✔ Integración de AutoMapper
- ✔ Soporte para MongoDB como alternativa a EF Core

---
