# Factory Pattern-Kata 
[based on](https://github.com/pdago/FactoryPatternKata)

### Contexto
El código se basa en el sistema de licencias de aviacion. Hay dos tipos de licencias:

* Con hardware check: se tiene en cuenta la identificacion del dispositivo, y si el numero maximo de dispositivos es limitado. Si el dispositivo solicitado ya está activo, la licencia se facilita de nuevo y la cuenta de dispositivos activos no se aumenta


* Con software check: el identificador del dispositivo no se toma en cuenta y el numero de dispositivos activos es ilimitado.

En ambos casos se comprueba si ha espirado la licencia.

### Instrucciones
Debes de refactorizar la clase **LicenseManager** (en particular el método _CheckActivation_ method) para hacer uso del patron factory. 
La solución ya tiene unas clases predefinidas para ayudarte con esta transición.
También tiene tests para ayudarte a entender la funcionalidad y ayudarte a comprobar que no se ha roto nada.

No tienes que modificar ningún tests (pero puedes añadir los que quieras)

> Deberias de ser capaz de entender qué hace el patrón y como afecta al código tener la funcionalidad deseada extraída.

Una vez que pase podéis:

- En *CheckActivation* podeis quitar alguna linea de código 
- No quiero ni lineas ni espacios en blanco, ni lineas innecesarias que no se utilicen
- Mover el código a proyectos de dominio (divido en carpetas de negocio)
- Mover los tests a un proyecto de tests
- Utilizar xunit para parametrizar los tedts que podais
