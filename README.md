# Práctica 3 - Delegados y Eventos

----------
> Gabriel García Jaubert  
>
> Universidad de La Laguna
>
> 6 noviembre 2021

### 1.  Cuando el jugador colisiona con un objeto de tipo B, el objeto A mostrará un texto en una UI de Unity. Cuando toca el objeto A se incrementará la fuerza del objeto B

Cuando el jugador (cubo) colisiona con el cilindro azul (objeto B), el objeto A transmite un mensaje por pantalla. Observamos que en esta colisión se le da un pequeño empujón al cilindro azul. Sin embargo, tras colisionar con el objeto naranja (objeto A), la fuerza con la que es impulsado el cilindro azul es mucho mayor como se aprecio en la segunda y tercera colisión con este objeto.

![FuerzaYMensaje](./Gifs/FuerzaYMensaje.gif)

```
Explicación para entender el uso de GameController:
Se utiliza la clase GameController que tiene un atributo estático de su misma clase. Dentro de esta clase 
tenemos funciones que activan eventos. En este caso, cuando el objeto A detecta la colisión, ejecuta la 
función de los objetos de la clase GameController "collisionWithA". Esta función activa el evento de 
collisionWithA a la que el objeto B está suscrito con la función addForce. De este modo, el objeto B 
ejecutará esa función, que hace que aumente su fuerza.
```

### Cuando el jugador se aproxima a los cilindros de tipo A, los cilindros de tipo B cambian su color y las esferas se orientan hacia un objetivo ubicado en la escena con ese propósito.

Al acercarse el jugador al cilindro naranja, observamos como la esfera con "gafas" comienza a rotar en mi dirección, debido a que estoy dentro del rango establecido. También se muestra como el cilindro tipo B cambia de color mientras el jugador se encuentra dentro de ese rango.  

![RotacionYColor](./Gifs/RotacionYColor.gif)

### Implementar un controlador que mueva el objeto con wasd

El controlador ya se implementó en la práctica anterior y se utiliza junto al movimiento de la cámara con el ratón para rotar al jugador.

### Depurar con Debug.DrawRay

Con esta simple línea de código en la función rotateSphere, podemos generar una línea roja que representa la dirección a la que apunta la esfera:

```
Debug.DrawRay(transform.position, transform.forward * 10, Color.red);
```

![DrawRay](./DrawRay.PNG)
