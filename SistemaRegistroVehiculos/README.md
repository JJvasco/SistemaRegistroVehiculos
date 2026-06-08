# Sistema de Registro de Vehículos

## 📋 Descripción
Sistema completo de gestión de vehículos desarrollado con ASP.NET Core MVC (Code First) y WebAPI (Database First).

## 🚀 Tecnologías Utilizadas
- **Backend**: C# .NET 6/7/8
- **Frontend**: Bootstrap 5, JavaScript, FontAwesome
- **ORM**: Entity Framework Core (Code First y Database First)
- **Base de Datos**: SQL Server
- **Control de Versiones**: Git/GitHub

## 📁 Estructura del Proyecto
```
SistemaRegistroVehiculos/
├── RegistroVehiculos.MVC/      # Proyecto MVC (Code First)
├── RegistroVehiculos.WebAPI/   # Proyecto WebAPI (Database First)
└── Scripts/                    # Scripts SQL
```

## 🛠️ Instalación y Configuración

### Requisitos Previos
- .NET SDK 6.0 o superior
- SQL Server
- Visual Studio 2022 o VS Code

### Paso 1: Clonar el repositorio
```bash
git clone https://github.com/tu-usuario/SistemaRegistroVehiculos.git
cd SistemaRegistroVehiculos
```

### Paso 2: Configurar bases de datos
Ejecutar los scripts SQL en las carpetas respectivas:
- `Scripts/CreateDatabase_MVC.sql` para la base de datos MVC
- `Scripts/CreateDatabase_API.sql` para la base de datos API

### Paso 3: Configurar cadenas de conexión
Actualizar `appsettings.json` en ambos proyectos con las credenciales de tu servidor SQL.

### Paso 4: Ejecutar migraciones (MVC)
```bash
cd RegistroVehiculos.MVC
dotnet ef migrations add InitialCreate
dotnet ef database update
```

### Paso 5: Ejecutar los proyectos
- **MVC**: `dotnet run --project RegistroVehiculos.MVC`
- **WebAPI**: `dotnet run --project RegistroVehiculos.WebAPI`

## 📡 Endpoints API

| Método | Endpoint | Descripción |
|--------|----------|-------------|
| GET | /api/Vehiculos | Obtener todos los vehículos |
| GET | /api/Vehiculos/{id} | Obtener vehículo por ID |
| GET | /api/Vehiculos/activos | Obtener vehículos activos |
| POST | /api/Vehiculos | Crear nuevo vehículo |
| PUT | /api/Vehiculos/{id} | Actualizar vehículo |
| DELETE | /api/Vehiculos/{id} | Eliminar vehículo |
| PATCH | /api/Vehiculos/{id}/toggle-status | Cambiar estado del vehículo |

## 🎯 Funcionalidades
- ✅ CRUD completo de vehículos
- ✅ Interfaz responsiva con Bootstrap 5
- ✅ Validaciones del lado del cliente y servidor
- ✅ Cambio de estado (Activo/Inactivo)
- ✅ Eliminación con confirmación modal
- ✅ API RESTful documentada

## 🎨 Características de UI
- Diseño con gradientes modernos
- Animaciones CSS (fade-in)
- Iconos de FontAwesome
- Tablas responsivas
- Alerts con Bootstrap
- Modal de confirmación

## 📝 Video de Explicación
[Enlace al video de YouTube]

## 👨‍💻 Autor
Tu Nombre - [GitHub](https://github.com/tu-usuario)

## 📄 Licencia
MIT
