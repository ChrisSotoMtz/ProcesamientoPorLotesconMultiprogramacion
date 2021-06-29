# Descripcion del proyecto
Algoritmo de planificación FCFS (First Come First Server)

# Especificaciones
1. El programa preguntará el número de trabajos inicial, para luego conformar lotes con
   capacidad máxima de 5 (ver Requerimientos programa 1).
2. En esta simulación la información de cada trabajo se generará internamente, es decir ya no
   será necesario introducir datos desde teclado, la información a generar es:
     a. Número de cada proceso, validar que sea único. (Puede ser consecutivo)
     b. Tiempo Máximo Estimado, se generará de forma aleatoria, validando que sea mayor 
        a 0 (rango entre 6 y 15).
     c. Operación (+, -, *, /, residuo) a realizar con sus operandos (validar operaciones),
        aleatoriamente.
     NOTA: En la práctica anterior se capturaba el nombre del programador, en esta práctica
     ya no se requiere ese dato (se elimina).
3. Los trabajos se ejecutarán conforme a su número asignado (ID).
4. Los procesos una vez en ejecución pueden ser Interrumpidos por Entrada/Salida o bien
   terminados por Error (Observar la diferencia en la tabla).
5. La interrupción y la terminación de los trabajos en ejecución, se generaran por medio de
   teclas.
6. Las teclas a utilizar son:
   <img src="https://cdn.discordapp.com/attachments/762088441314934794/859552834194243584/unknown.png" width="698" height="310">
7. Deberá mostrarse en pantalla:
    a. Procesos en Espera correspondientes al Lote en ejecución:
      i. Número de Programa (en el programa anterior se listaba nombre del
         programador ahora es número de programa).
      ii. Tiempo Máximo Estimado.
      iii. Mostrar el tiempo transcurrido. En el caso de que el proceso no se haya
           ejecutado aún se desplegara 0.
    b. Número de Lotes Pendientes: Especificar el número de lotes pendientes por ejecutar,
       si no hay se mostrará 0.
    c. Proceso en Ejecución:
      i. Se mostraran todos los datos correspondientes al proceso. 
      ii. Tiempo que ya ha sido ejecutado.
      iii. Tiempo restante por ejecutar 
    d. Trabajos Terminados:
      i. Número de Programa.
      ii. Operación
      iii. Resultado de la operación o bien ERROR cuando el proceso haya sido
           terminado con la tecla que genera error.
    e. Reloj (Contador General).
8. Al terminar el lote en ejecución, continuará con el siguiente lote en espera.
9. El programa terminará cuando todas las operaciones de todos los lotes se hayan realizado
   (Pausarlo).

# Contacto
christian.soto4752@alumnos.udg.mx  
