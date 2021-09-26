# TriviaConcurso
Este proyecto es un juego de preguntas que consta de cinco categorias asociadas a cinco niveles, donde cada categoria tiene cinco preguntas con cuatro respuestas y solo una verdadera.
Al momento de correr la aplicacion lo primero que se encuentran es un menu con dos opciones.
La primera es la administracion del juego donde se encontraran un menu que empieza por las categorias, cada categoria tiene asociado una descripcion, un nivel, un premio, un numero de preguntas y un identificador.
Luego se encuentra el menu de preguntas, el cual tiene asociado el identificador de la caategoria a la que pertenece, el texto de la pregunta, un contador de respuestas asociadas a cada pregunta y un identificador.
Por ultimo en este menu se encuentran las respuestas a las cuales se les asocia el identificador de la pregunta a la cual pertenece, el texto de la respuesta y un identificador.
Para añadir una nueva categoria solo se debe dar clic en el boton de nueva categoria, al igual que para las preguntas y respuestas, el identificador de las categorias empieza en cero y aumenta cada que se agrega una nueva, lo mismo pasa con el identificador de preguntas y respuestas.
Cuando se añade una nueva pregunta se debe seleccionar a que categoria pertenece, esto le asociara el identificador de la categoria, se añade el texto de la pregunta y se guarda.
Cuando se añade una nueva respuesta se debe seleccionar a que pregunta pertenece, esto le asociara el identificador de la pregunta, se añade el texto de la respuesta, cuando se agrega la respuesta correcta al lado del texto hay una casilla que dice "correcta", la cual solo se puede seleccionar una vez por pregunta asociada a la respuesta que se ingresa.
En el menu principal la segunda opcion es "Jugar", cuando esta opcion se selecciona ya no se puede ir a la seccion de de administracion para evitar que el usuario configure las preguntas y respuestas.
Al ingresar al juego lo primero es registrar el jugador, al cual se le pide un nombre y un identificador unico para cada jugador. luego de esto se selecciona la opcion de "continuar".
Ya adentro se muestra en la parte superior izquierda el nombre del jugador que esta en la seccion, debajo un menu donde se encuentra "Iniciar" y "Salir".
Al lado derecho de este menu se encuentra, la ronda, la categoria y el puntaje.
Si selecciona "Iniciar" el puntaje se marca como cero, aparecen las categorias asociadas al nivel y solo es selecionar la que quiere jugar. Despues de seleccionar la categoria le aparecera una pregunta al azar de las cinco asociadas a esa categoria y nivel, con sus cuatro opciones de respuestas. 
El jugador puede salir en cualquier momento del juego siempre y cuando no haya respondido la pregunta.
Si llega a la quinta pregunta y la responde correctamente ganara el juego.
Luego de terminar el juego por decision propia o por ganar, este sale hasta el menu principal donde se puede ir a la administracion o empezar un nuevo juego.
Para correr la aplicacion se debe ir a la carpeta "TriviaConcurso", abrir la sub carpeta "bin", luego la carpeta "Debug", luego la carpeta "netcoreapp3.1" y por ultimo el ejecutable "TriviaConcurso.ex e"
Correr minimo en visual studio 2019, con Netcore3 sdk
