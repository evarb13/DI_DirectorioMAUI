# DI_DirectorioMAUI

Aplicación móvil multiplataforma desarrollada con **.NET MAUI** que implementa un directorio de empleados y departamentos utilizando el patrón **MVVM** e **inyección de dependencias (DI)**.
# Descripción del Proyecto

DI_DirectorioMAUI es una aplicación desarrollada con **.NET Multi-platform App UI (.NET MAUI)** cuyo objetivo es demostrar la creación de una app multiplataforma moderna con arquitectura estructurada y buenas prácticas de desarrollo.

La aplicación permite visualizar empleados y departamentos, estructurando el código de forma desacoplada y mantenible.

Este proyecto tiene fines educativos y demuestra:

- Arquitectura MVVM
- Separación de responsabilidades
- Uso de servicios
- Consumo de API REST
- Desarrollo multiplataforma con una única base de código
# Funcionalidades principales

- Listado de empleados.
- Listado de departamentos.
- Vista de detalle de empleados.
- Consumo de datos desde API REST mediante HttpClient.
- Uso de servicios inyectados por Dependency Injection.
- Interfaz adaptable a distintos dispositivos.
# Tecnologías utilizadas

- **.NET MAUI**
- **C#**
- **XAML**
- **MVVM (Model-View-ViewModel)**
- **Inyección de Dependencias**
- **HttpClient**
- **.NET 8 SDK**
# Arquitectura del Proyecto

El proyecto sigue el patrón **MVVM**:

- **Models** → Representan las entidades (Empleado, Departamento).
- **Views** → Interfaces gráficas en XAML.
- **ViewModels** → Lógica de presentación.
- **Services** → Comunicación con API y acceso a datos.

Esto permite:

- Separación clara entre UI y lógica  
- Código mantenible  
- Mayor escalabilidad  
- Facilidad de pruebas  

# Vista previa de la aplicación

Reemplaza esta imagen por una captura real de la aplicación funcionando:

![DirectorioMAUI Screenshot](assets/DirectorioMAUI.png)

# Autor
evarb13
Proyecto desarrollado con fines educativos utilizando .NET MAUI.
