# Inventory Management API 📦

Una API RESTful robusta diseñada para la gestión eficiente de productos e inventario. Desarrollada con las últimas tecnologías del ecosistema .NET, implementando patrones de diseño modernos y buenas prácticas de arquitectura de software.

Este proyecto demuestra competencias en **Desarrollo Backend con C#**, **Manejo de Base de Datos Relacionales** y **Arquitectura de Software**.

## ✨ Características Principales

* **CRUD Completo:** Operaciones de Crear, Leer, Actualizar y Eliminar productos.
* **Buscador Integrado:** Filtrado de productos por nombre mediante Query Parameters (Case Insensitive).
* **Arquitectura en Capas:** Separación clara de responsabilidades (Controllers, Models, Data, DTOs).
* **Data Transfer Objects (DTOs):** Uso de DTOs para la entrada de datos, desacoplando la entidad de base de datos de la API pública y mejorando la seguridad.
* **Validaciones:** Reglas de negocio aplicadas mediante Data Annotations (precios positivos, campos obligatorios, límites de caracteres).
* **Documentación Interactiva:** Integración con **Swagger UI** para probar los endpoints visualmente.

## 🛠️ Tecnologías Utilizadas

* **Lenguaje:** C# 12
* **Framework:** .NET 8.0 (LTS)
* **Tipo de Proyecto:** ASP.NET Core Web API
* **ORM:** Entity Framework Core 8
* **Base de Datos:** SQLite (Portátil y ligera)
* **Documentación:** Swagger / OpenAPI

## 📂 Estructura del Proyecto

El código sigue una estructura limpia y organizada:

```text
Inventory.API/
├── Controllers/       # Controladores de la API (Endpoints)
│   └── ProductsController.cs
├── Data/              # Contexto de base de datos (EF Core)
│   └── ApplicationDbContext.cs
├── DTOs/              # Objetos de Transferencia de Datos
│   └── CreateProductDto.cs
├── Models/            # Entidades de dominio (Base de datos)
│   └── Product.cs
├── appsettings.json   # Configuración y Connection Strings
└── Program.cs         # Configuración de servicios y pipeline HTTP
```

## ⚙️ Instalación y Ejecución

Sigue estos pasos para correr el proyecto en tu entorno local:

### 1. Prerrequisitos
* Tener instalado el **.NET 8.0 SDK**.
* (Opcional) Visual Studio 2022 o VS Code.

### 2. Clonar el repositorio
```bash
git clone [https://github.com/ryakimovicz/inventory-api.git](https://github.com/ryakimovicz/inventory-api.git)
cd inventory-api
```

### 3. Restaurar dependencias y Base de Datos
El proyecto utiliza SQLite, por lo que la base de datos es un archivo local.

```bash
# Restaurar paquetes NuGet
dotnet restore

# Crear la base de datos y aplicar migraciones
dotnet ef database update
```
*(Nota: Si no tienes la herramienta `dotnet ef` instalada globalmente, puedes instalarla con `dotnet tool install --global dotnet-ef`)*.

### 4. Ejecutar la API
```bash
dotnet run --project Inventory.API
```

La aplicación iniciará y podrás ver la documentación en:
`https://localhost:7150/swagger` (o el puerto que indique tu consola).

## 🧪 Ejemplos de Uso

### Crear un Producto (POST)
**Endpoint:** `/api/Products`
```json
{
  "name": "Laptop Gamer",
  "description": "16GB RAM, RTX 3060",
  "price": 1500.00,
  "stock": 10
}
```

### Buscar Productos (GET)
**Endpoint:** `/api/Products?search=laptop`
Devuelve todos los productos que contengan "laptop" en su nombre (sin distinguir mayúsculas).

---
**Autor:** Román Yakimovicz  
Desarrollado como parte de mi portfolio profesional de Backend.

💼 **LinkedIn:** [linkedin.com/in/ryakimovicz](https://www.linkedin.com/in/ryakimovicz/)  
🐙 **GitHub:** [@ryakimovicz](https://github.com/ryakimovicz)  
📧 **Email:** [ryakimovicz@gmail.com](mailto:ryakimovicz@gmail.com)
