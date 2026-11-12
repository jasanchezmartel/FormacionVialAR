# Formación Vial AR — Mínimo Producto Viable (PMV)

Aplicación móvil de Realidad Aumentada (AR) diseñada para transformar y optimizar la enseñanza vial teórica para la obtención del permiso de conducir (permiso B). El proyecto sustituye la memorización pasiva de preguntas de test por una experiencia formativa visual, inmersiva y gamificada.

---

## 🔗 Repositorio del Proyecto en Unity Version Control (Plastic SCM)

El código fuente completo y los assets del proyecto de Unity se gestionan en **Unity Version Control**:

👉 **[Acceder al repositorio en Unity Version Control](https://cloud.unity.com/organizations/6872896029702/projects/70642980-c44d-4ef6-b827-34331f11da35/plastic-scm/organizations/6872896029702/repositories/FormacionVialAR%2FFormacionVialAR)**

URL directa:
```
https://cloud.unity.com/organizations/6872896029702/projects/70642980-c44d-4ef6-b827-34331f11da35/plastic-scm/organizations/6872896029702/repositories/FormacionVialAR%2FFormacionVialAR
```

---

## 👥 Autores
- **Samuel Corado Cañete**
- **Juan Antonio Sánchez Martel**  
*Módulo de Desarrollo de Videojuegos y Realidad Virtual (DVyRV) — IES El Rincón*

---

## 📌 Puntos Principales del Documento (PMV - UT1)

### 1. Idea del Proyecto y Justificación
* **Problema detectado:** El estudio teórico tradicional para el carnet de conducir se basa en la memorización mecánica de libros y baterías de tests, sin interiorizar realmente los motivos ni las consecuencias de las normas viales.
* **Solución propuesta:** Digitalizar y enriquecer el material de estudio con Realidad Aumentada sobre fichas físicas impresas, convirtiendo conceptos abstractos (como distancias de frenado o tiempos de reacción) en modelos 3D y elementos multimedia interactivos a escala.
* **Propósito formativo:** Reducir tiempos de preparación, facilitar el estudio intensivo y promover un cambio de actitud hacia una conducción prudente y responsable.

### 2. Público Objetivo y Formato
* **Público:** Personas de 15 a 30 años (estudiantes de autoescuela a partir de 18 años).
* **Temática:** Formación y Prevención vial.
* **Formato:** Experiencia gamificada tipo *escape room* educativo estructurada en estaciones de aprendizaje.
* **Dispositivo:** Móvil o tablet Android utilizando la cámara trasera (sin necesidad de visores ni hardware adicional).

### 3. Mecánica Central y Estaciones de Aprendizaje (AR)
La experiencia guía al usuario a través de una ruta de tres estaciones mediante fichas impresas (*Image Targets*):

| Estación | Ficha / Image Target | Elementos Activados | Aprendizaje Clave |
| :--- | :--- | :--- | :--- |
| **Estación 1** | **Señal de STOP en cruce** | Modelo 3D interactivo con rotación lenta, texto explicativo y feedback sonoro. | Prioridad de paso, detención obligatoria y visibilidad en intersecciones. |
| **Estación 2** | **Límite de velocidad** | Modelo 3D de vehículo a escala y texto explicativo. | Relación entre velocidad y distancia de detención/frenado en situaciones reales. |
| **Estación 3** | **Prohibición de uso del móvil** | Modelo 3D de smartphone, texto de concienciación y vídeo demostrativo (15-20 s). | Riesgos de la distracción al volante (ej.: a 90 km/h se recorren 25 metros por segundo; 2 segundos mirando el móvil equivalen a 50 metros a ciegas). |

### 4. Arquitectura de Escenas y Diseño de la Experiencia
* **Estructura de 3 escenas:**
  1. **Menú Principal:** Pantalla de bienvenida con título, música ambiente en bucle, acceso directo a la *Sala de juego AR* y a la pantalla de *Créditos*.
  2. **Sala de Juego AR:** Uso de la cámara del dispositivo para el tracking de las fichas. Al enfocar una ficha, el contenido 3D y multimedia aparece de forma animada; al apartar la cámara, se oculta mediante un fundido suave (*fade out*).
  3. **Créditos:** Información de los desarrolladores, centro educativo (*IES El Rincón*) y mensaje de cierre.
* **Navegación:** Botón intuitivo **VOLVER** disponible en todas las escenas secundarias para regresar al menú principal.
* **Estilo Visual e Identidad:**
  * Paleta inspirada en la señalización vial oficial: Azul oscuro (`#0B3D91`), Amarillo señal (`#FFC20E`), Rojo (`#C8102E`) y Blanco.
  * Tipografía **Montserrat** para garantizar alta legibilidad con una sola mano en pantallas de dispositivos móviles.

### 5. Tecnologías Utilizadas
* **Motor de desarrollo:** Unity.
* **Motor de Realidad Aumentada:** Vuforia Engine (reconocimiento por *Image Targets* validados en Target Manager).
* **Renderizado de texto:** TextMeshPro.
* **Audio y Vídeo:** Reproducción en bucle suave de música ambiental, efectos sonoros para botones e interacciones (*clic*, *reconocimiento*, *acierto*) y reproductor de vídeo integrado en AR.
* **Metodología y Gestión:** Tablero Kanban en GitHub Projects para planificación ágil y reparto de tareas.

### 6. Alcance (Matriz MoSCoW)
* **Debe tener (Must have):** Detección estable de fichas, información e imágenes actualizadas de la DGT, modelos 3D y textos claros.
* **Debería tener (Should have):** Tests interactivos de autoevaluación para el alumno.
* **Podría tener (Could have):** Lectura de texto a voz (*text-to-speech*), libros digitales integrados y dioramas 3D interactivos de situaciones de tráfico.
* **Futuras expansiones:** Adaptación a otros ámbitos formativos (náutico, aeronáutico) o pruebas visuales psicotécnicas.

---

## 📦 Enlaces y Recursos

* **Unity Version Control (Plastic SCM):** [Repositorio en la nube de Unity](https://cloud.unity.com/organizations/6872896029702/projects/70642980-c44d-4ef6-b827-34331f11da35/plastic-scm/organizations/6872896029702/repositories/FormacionVialAR%2FFormacionVialAR)
* **Descarga del APK (Android):** [Google Drive - FormacionVialAR.apk](https://drive.google.com/file/d/1hP9JOp2_333HIa19yjl7XJUI8TsU-9BC/view?usp=drive_link)
* **Documentación PDF completa:** En la raíz de este repositorio:  
  `DVyRV - Samuel Corado y Juan Antonio Sánchez - Mínimo producto viable - UT1.pdf`