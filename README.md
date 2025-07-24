# 🧩 Dynamic Form Builder - Backend API (.NET 8)

Este proyecto es una API REST desarrollada en **ASP.NET Core** que permite gestionar formularios dinámicos construidos desde el frontend usando la librería **Form.io** (Angular). Su propósito principal es almacenar, consultar, actualizar y listar formularios definidos mediante estructuras JSON.

---

## 🚀 Características principales

- Recepción de formularios con estructura dinámica desde Angular/Form.io.
- Persistencia en base de datos con clases fuertemente tipadas (`FormDefinition`, `FormComponent`, `FormValidation`).
- Endpoints para CRUD completo de formularios.
- Soporte para paginación y búsquedas futuras.
- Preparado para integración con Frontend Angular (`http://localhost:4200`).
- Documentado con Swagger.

---

## 🛠️ Tecnologías utilizadas

- **.NET 8** / **ASP.NET Core Web API**
- **Entity Framework Core (EF Core)**
- **AutoMapper**
- **FluentValidation**
- **Swashbuckle (Swagger)**
- **SQL Server / SQLite** (dependiendo del entorno)
- **CORS** habilitado para Angular

---

## 📦 Estructura esperada del formulario

La API recibe formularios con la siguiente estructura JSON:

```json
{
  "title": "Formulario de Registro",
  "components": [
    {
      "key": "name",
      "type": "textfield",
      "label": "Nombre Completo",
      "placeholder": "Ingrese su nombre",
      "validate": {
        "required": true
      }
    }
  ]
}
