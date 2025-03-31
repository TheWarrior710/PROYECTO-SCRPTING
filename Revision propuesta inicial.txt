# Introducción


En el entorno universitario, la organización de archivos y tareas es clave para el éxito académico. Sin embargo, muchos estudiantes enfrentan dificultades para gestionar sus documentos, recordar fechas importantes y mantener el orden en su información. UniVault es una aplicación diseñada para abordar este problema, ofreciendo una plataforma intuitiva para almacenar y organizar archivos, establecer recordatorios y tomar notas rápidas, todo en un solo lugar.


## Objetivo



Desarrollar una aplicación que facilite la gestión de documentos y tareas universitarias mediante una interfaz intuitiva y funciones clave como almacenamiento de archivos, recordatorios, notas rápidas, personalización de avatares y seguridad con acceso mediante PIN.
Funcionalidades


•	Gestión de carpetas y archivos: Creación de carpetas organizadas por materia o semestre, con la opción de subir archivos.
•	Recordatorios: alarmas programadas por el usuario.
•	Notas rápidas: Espacio dentro de cada carpeta para tomar apuntes.
•	Personalización: Selección de avatares y fondos para mejorar la experiencia del usuario.
•	Seguridad con PIN: Protección del acceso a la aplicación para mayor privacidad.


Correcciones propuesta anterior
Para definir mejor la arquitectura del proyecto, se deben resolver los siguientes aspectos:


1.	¿La aplicación funcionará de forma local o se conectará a un servidor?
-	La aplicación funcionara de forma local, ya que no es necesario conectarla a un servidor.

2.	¿Los recordatorios serán alarmas programadas o incluirán notificaciones push?
-	Los recordatorios son programados dependiendo de que feche y hora necesite el usuario acordarse.

3.	¿Qué servicio se usará para el almacenamiento de archivos?
-	Para el almacenamiento de archivos se utilizará el propio almacenamiento del dispositivo.

4.	¿Los avatares y fondos serán predefinidos o se permitirá su creación personalizada?
-	Serán predefinidos para que el usuario solo tenga que escoger el que mas le guste, pero una idea es que se puedan subir imágenes para que el usuario las pueda poner de fondo o de foto de usuario.

5.	¿Cómo se validará la autenticación mediante PIN?
-	Se validará a través de un PIN que se definirá cuando inicie la sesión.

6.	¿El usuario podrá definir sus propias carpetas o habrá una estructura predeterminada?
-	El usuario crea las carpetas que necesite, así que no habrá estructura predeterminada

## Tecnologías Por Utilizar


##### Las herramientas específicas se definirán conforme avance el desarrollo, evaluando cuáles se ajustan mejor a los requerimientos del proyecto. Sin embargo, algunas opciones preliminares incluyen:


•	Base de datos: SQLite para almacenamiento local.

•	Framework de desarrollo: Flutter para compatibilidad en Android e iOS.

•	Gestión de preferencias: SharedPreferences para almacenamiento del PIN.

•	Diseño de interfaz: Se utilizara unity para realizar todo el diseño y para lanzar el ejecutable

#### Integrantes del Grupo

•	Armando Marulanda Rua - ID: 000350736
•	Jhohan Nicolás Sedano - ID: 000522547