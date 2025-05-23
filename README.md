# DIGITALPRO Inventario de productos en C# con WinForms, SQL Server y Arquitectura en Capas
Aplicación desktop para el control de inventario de un emprendimiento dedicado a la venta de productos tecnológicos.

## 🚀 Descripción del Proyecto

Este proyecto consiste en una aplicación de escritorio desarrollada en **C#** utilizando **Windows Forms (WinForms)** y **SQL Server**. Su objetivo principal es implementar un sistema **CRUD** (Crear, Leer, Actualizar, Eliminar) para la gestión de productos.

La aplicación se ha diseñado siguiendo una **arquitectura en capas** bien definida, separando las responsabilidades en:

* **Capa de Presentación (`CapaDePresentacion`):** Interfaz de usuario desarrollada con WinForms, responsable de la interacción con el usuario (formularios como `Form1.cs`, `Login.cs`, `ModalAgregarProductos.cs`, etc.).
* **Capa de Lógica de Negocio (`CapaNegocio`):** Contiene la lógica de la aplicación y las reglas de negocio para la manipulación de las entidades (`CN_Productos.cs`, `CN_Usuarios.cs`).
* **Capa de Acceso a Datos (`CapaDatos`):** Encargada de la comunicación con la base de datos SQL Server, utilizando **ADO.NET** y **Stored Procedures** para una interacción eficiente y segura (`CD_Conexion.cs`, `CD_Usuarios.cs`, `CDConsultas_Productos.cs`).

Este proyecto ha sido una excelente oportunidad para practicar buenas prácticas de programación, el uso de procedimientos almacenados en SQL Server y el manejo de datos con ADO.NET dentro de una arquitectura en capas.

## ⚙️ Funcionalidades Principales

* **Autenticación de Usuarios:** Implementa un sistema de inicio de sesión (`Login.cs`) para controlar el acceso a la aplicación.
* **Listar Productos:** Muestra un listado de los productos existentes en el formulario principal (`Form1.cs`), con la opción de ver detalles.
* **Crear Producto:** Permite registrar nuevos productos en la base de datos a través de un formulario modal (`ModalAgregarProductos.cs`).
* **Eliminar Producto:** Permite eliminar un producto de la base de datos, gestionado desde la interfaz de usuario.
* **Acceso a SQL Server:** La capa de acceso a datos (`CapaDatos`) utiliza ADO.NET para conectar y manipular la base de datos SQL Server (`CD_Conexion.cs`).
* **Uso de Stored Procedures:** Se utilizan procedimientos almacenados en SQL Server para las operaciones CRUD, mejorando la seguridad y el rendimiento.
* **Separación por Capas:** El diseño modular facilita el mantenimiento, la escalabilidad y la separación de responsabilidades entre la interfaz de usuario, la lógica de negocio y el acceso a los datos.

## 📸 Capturas de Pantalla

* Formulario de login:
[![login.jpg](https://i.postimg.cc/pdYHZVwr/login.jpg)](https://postimg.cc/3yRVrhJQ)

* Formulario principal con la lista de productos:
[![inicio.jpg](https://i.postimg.cc/sx1CsYvG/inicio.jpg)](https://postimg.cc/gL9TK6yG)

* Formulario para agregar un nuevo producto:
[![registrar.jpg](https://i.postimg.cc/DZvKYkhg/registrar.jpg)](https://postimg.cc/Lqb7nWnY)

* Formulario para editar un producto:
[![editar.jpg](https://i.postimg.cc/wBdzLRbn/editar.jpg)](https://postimg.cc/VJ42cvwF)

* Formulario para ver datos de un producto:
[![verdatos.jpg](https://i.postimg.cc/cHFGp94N/verdatos.jpg)](https://postimg.cc/TL5smcDk)

## 🛠️ Tecnologías Utilizadas

* **Lenguaje de Programación:** C# (.NET Framework)
* **Interfaz de Usuario:** Windows Forms (WinForms)
* **Base de Datos:** SQL Server
* **Acceso a Datos:** ADO.NET
* **Procedimientos Almacenados:** Utilizados para la manipulación de datos en la base de datos.
* **Arquitectura:** En Capas (Presentación, Lógica de Negocio, Acceso a Datos)

