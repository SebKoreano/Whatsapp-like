# Proyecto de Chat TCP (Estilo WhatsApp)

Este programa, escrito en **C# 12.0** y **.NET 8.0**, permite enviar y recibir mensajes en tiempo real entre aplicaciones mediante sockets utilizando el protocolo **TCP**, similar a un chat estilo WhatsApp.

## Instrucciones de Uso

### Requisitos:
- **C# 12.0** y **.NET 8.0** instalados en tu sistema.

### Pasos:

1. **Abrir la Terminal**:
   - Navega hasta la carpeta del proyecto donde se encuentra el archivo `.csproj` usando la terminal.

2. **Ejecutar el Proyecto**:
   - Usa el siguiente comando para iniciar la aplicación en un puerto específico:
     ```bash
     dotnet run <nombre-del-proyecto> -port <puerto-escucha>
     ```
   - Asegúrate de usar un puerto con más de cuatro dígitos (ej. 5000 o superior) para evitar conflictos.

3. **Enviar Mensajes**:
   - En la sección **Puerto Destino**, ingresa el número de puerto al cual deseas enviar el mensaje.
   - Puedes enviarte mensajes a ti mismo utilizando el mismo puerto de escucha, o abrir una segunda instancia del proyecto en otro puerto para simular la comunicación entre dos aplicaciones.

4. **Enviar el Mensaje**:
   - Escribe tu mensaje en la caja de texto correspondiente y presiona el botón **ENVIAR** para transmitirlo.

### Notas Adicionales:
- Si los mensajes no se ven de inmediato, intenta desplazarte hacia abajo en la caja de texto de mensajes recibidos. Los mensajes pueden estar llegando correctamente, pero simplemente no se están mostrando por completo.

---

¡Gracias por utilizar este programa!
