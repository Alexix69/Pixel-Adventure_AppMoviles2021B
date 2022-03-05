## Escuela Politécnica Nacional
### Integrantes:

* Carlos Díaz 
* John Vasconez
* Alexis Yépez

# Pixel-Adventure
 Juego 2D creado en Unity

## Tabla de responsabilidades 

![image](https://user-images.githubusercontent.com/58191417/156854947-0fb0f335-a1e3-4804-9e06-d3732b5eb6b7.png)

### [Realización del proyecto (YouTube)](https://youtu.be/kpWgiHAqgZw)

### [Funcionamiento de la aplicación (YouTube)](https://youtu.be/jvkdKjWEtRs) 

## Código Fuente

Los proyectos creados en Unity se basan en dos principales partes, el código fuente y los componentes de la aplicación comúnmente conocidos como Assets.

### Menú principal de juego

* Cada pantalla del juego se maneja como una escena, para la selección de niveles se establece una nueva. Aquí es importante establecer un Canvas que reflejará los controles y detalles del jugador.

![image](https://user-images.githubusercontent.com/58191417/156856210-97327dc7-9980-4ea5-93d6-b2ff60564432.png)

* Se maqueta la ventana de acuerdo al resultado esperado con los componentes de la paleta, en este caso se establece una puerta para que el jugador ingrese a cada nivel (4 niveles) y otra para cambiar de skins al personaje.

![image](https://user-images.githubusercontent.com/58191417/156856606-ccbcc7ca-38a4-46eb-b7fc-fa74e936646e.png)

### Primer Nivel

* El juego está basado en la recolección de frutas por parte del personaje, el primer nivel es un mapa simple que cuenta con dos tipos de enemigos y dos tipos de frutas a recoger.

![image](https://user-images.githubusercontent.com/58191417/156857220-33e247ab-6157-480f-bb8a-0dd5c7878396.png)

*Los movimientos que puede hacer el personaje son moverse a la izquierda, a la derecha y saltar.* 

### Segundo Nivel

* La cantidad de frutas a recoger aumenta y los enemigos del personaje son diferentes, el jugador puede hacerles daño al saltar sobre estos. Este nivel cuenta con trampas que disminuye las vidas del personaje cuando este entra en contacto con ellas.

![image](https://user-images.githubusercontent.com/58191417/156857617-dd9c5201-5bab-494f-91e7-d27ddd115b58.png)

### Tercer Nivel

* La lógica es la misma por lo tanto el número de frutas a recoger es mayor que en el nivel anterior y los enemigos hacen más daño.

![image](https://user-images.githubusercontent.com/58191417/156858084-7b6d8a4c-667d-4509-bb23-5a6fab06581a.png)

### Último nivel

* Un detalle importante dentro de este nivel es que la cámara de la escena está adherida al personaje, esto se ha definido de esta manera puesto que el mapa es de una extensión mayor y no sería posible visualizarlo completamente.

![image](https://user-images.githubusercontent.com/58191417/156860874-3ee202f9-8e5d-4467-99cd-e4f3a42ea4d7.png)

*Como se observa,la cantidad de frutas a recoger es aún mayor y se presentan todos los enemigos existentes en el juego*

## Aspectos importantes

1. El diseño de los mapas de juego se lo realiza por medio de un componente **Palette** creado a partir de una serie de imágenes.

![image](https://user-images.githubusercontent.com/58191417/156863383-f745e504-cd48-4c62-b792-9188ed5f4a6f.png)

2. Unity permite crear moldes predefinidos para usar un componente en cualquier escena o pantalla de la aplicación, a estos se los conoce como **prefabs**

![image](https://user-images.githubusercontent.com/58191417/156863325-1f4257a0-55ca-4dc8-a02a-d06db3672234.png)

3. El comportamiento de cada elemento (personaje, enemigo, frutas, etc.) se define con uno o varios scripts que tienen código fuente en C#.

![image](https://user-images.githubusercontent.com/58191417/156863261-2c294934-7eb5-49d2-ab27-4b6aa166cf4f.png)

## Despliegue a tienda de aplicaciones

* Esta aplicación se ha desplegado en AppPure, es necesario completar el formulario y las descripciones de la aplicación que se va a subir.

![image](https://user-images.githubusercontent.com/58191417/156865273-69f5a638-2567-4020-9d2c-bc375026e867.png)

* Se observa que una vez completado los pasos, cambia el estado a *publishing* que indica que la aplicación pronto estará en producción.

![image](https://user-images.githubusercontent.com/58191417/156865284-a36a4184-8028-4335-96ea-ebf575e638e0.png)

