#  Introducción

En el entorno universitario, la organización de archivos y tareas es clave para el éxito académico. Sin embargo, muchos estudiantes enfrentan dificultades para gestionar sus documentos, recordar fechas importantes y mantener el orden en su información.  

**UniVault** es una aplicación desarrollada en **Unity** que busca abordar este problema mediante una plataforma intuitiva que permite:
- Almacenar y organizar archivos por carpetas
- Establecer alarmas personalizadas y recordatorios
- Tomar notas rápidas
- Personalizar la experiencia del usuario

Todo esto, en una interfaz unificada, pensada para estudiantes universitarios.

---

##  Objetivo

Desarrollar una aplicación funcional y local que facilite la gestión de tareas y documentos académicos, con funcionalidades clave como:

- Almacenamiento de archivos en carpetas por materia o semestre
- Alarmas programadas por el usuario
- Notas rápidas y búsqueda por nombre
- Personalización básica de la experiencia
- Seguridad mediante PIN de acceso (opcional en la versión final)

---

##  Funcionalidades principales

-  **Gestión de archivos y carpetas**  
  Organización de archivos en una interfaz tipo explorador. Subida desde el dispositivo y visualización directa.

-  **Recordatorios y alarmas personalizadas**  
  El usuario puede programar alarmas con texto personalizado que se activan tras cierto tiempo.

-  **Notas rápidas**  
  Espacio para guardar apuntes, con opción de recuperación y edición rápida.

- **Buscador de archivos**  
  Filtro dinámico que permite encontrar archivos por nombre.

-  **Personalización de interfaz (idea futura)**  
  Avatares y fondos predefinidos seleccionables por el usuario.


---

##  Correcciones y definiciones del proyecto

### 1. ¿La aplicación funcionará de forma local o conectada a un servidor?
- Funciona de forma **totalmente local**. No requiere conexión a internet.

### 2. ¿Los recordatorios incluirán notificaciones push?
- No. Son alarmas **programadas** por tiempo que activan paneles emergentes.

### 3. ¿Qué servicio se usa para almacenamiento de archivos?
- Se utiliza el **almacenamiento local del sistema operativo**, vía rutas internas.

### 4. ¿Cómo se maneja la personalización de avatares/fondos?
- Por ahora, se ofrecen **opciones predefinidas**. Futuras versiones permitirán cargar imágenes propias.

### 5. ¿Cómo se valida el acceso mediante PIN?
- Se implementó un sistema de verificación de PIN. En la versión actual, el PIN fue eliminado para simplificar el flujo por sugerencia docente.

### 6. ¿El usuario puede definir carpetas personalizadas?
- Sí, el usuario puede **crear sus propias carpetas**, no hay estructura predeterminada.

---

## 🛠 Tecnologías utilizadas

| Componente | Herramienta actual |
|------------|---------------------|
|  Motor principal | Unity |
| 🖼UI | Unity Canvas + TextMesh Pro |
|  Lógica | C# (programación orientada a componentes) |
|  Gestión de archivos | Sistema local (con `StandaloneFileBrowser` en builds) |
|  Audio | AudioClip + AudioSource para alarmas |
|  Base de datos | *[No implementada]* (idea futura: SQLite o PlayerPrefs para guardar configuraciones) |

---

##  Integrantes del grupo

- **Armando Marulanda Rua** – ID: 000350736  
- **Jhohan Nicolás Sedano Correa** – ID: 000522547

---

##  Notas finales

El proyecto fue desarrollado como parte de la asignatura **Scripting**. Las funcionalidades fueron priorizadas con base en su utilidad académica, y se espera expandirlas en versiones futuras con almacenamiento persistente, interfaz adaptable, y sincronización en la nube.
