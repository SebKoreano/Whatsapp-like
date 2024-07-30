El siguiente programa utiliza C# 12.0 y .NET 8.0

Este proyecto se encarga de enviar y recibir mensajes (whatsap-like) mediante sockets utilizando el protocolo Tcp.

Instrucciones de uso desde la terminal: 
1.Ubicar la terminal en la direccion del proyecto
2.Ejecutar el proyecto con el siguiente comando dotnet run <nombre-del-proyecto> -port <puerto-escucha> (se recomienda usar puertos arriba de 4 digitos)
3.En la seccion de "Puerto Destino:" ingresar el numero de puerto al que le quiere enviar el mensaje (Se puede enviar el mensaje a usted mismo, o puede crear otra instancia de este mismo proyecto con un puerto distinto para recibir el mensaje)
4.Al terminar de redactar su mensaje presionar el boton "ENVIAR" para enviar el mensaje a su destino

Eso es todo, muchas gracias!

PD: Si los mensajes dejan de verse en el remitente intente bajar con el mouse en la caja de texto, puede ser que si esten llegando los mensajes pero simplemente no se estan viendo