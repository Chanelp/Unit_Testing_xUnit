## Pruebas unitarias en .NET y C# con xUnit
Las pruebas unitarias son un tipo de prueba de software que se utiliza para comprobar el correcto funcionamiento de las unidades más pequeñas de código, que suelen ser funciones o métodos. El objetivo de las pruebas unitarias es detectar errores en el código lo antes posible, durante el proceso de desarrollo, para que sean más fáciles y baratos de corregir.

### Test Drive Development (TDD)
Test-Driven Development (Desarrollo Guiado por Pruebas, TDD) es una metodología de desarrollo de software que se basa en el ciclo iterativo de escribir pruebas automatizadas antes de escribir la implementación del código. Este ciclo se conoce como el ciclo Red-Green-Refactor

### Estructura AAA (Arrange, Act, Assert)
La estructura AAA es un patrón comúnmente utilizado en el desarrollo de pruebas unitarias, especialmente en el contexto del Desarrollo Guiado por Pruebas (TDD, por sus siglas en inglés). 

Proporciona una guía clara sobre cómo organizar y escribir pruebas unitarias de manera efectiva. A continuación, describiré cada parte de la estructura AAA:

1. Arrange (Preparar): En esta fase, se prepara el entorno de la prueba. Esto implica configurar cualquier estado necesario, inicializar objetos, establecer variables y configurar el contexto necesario para ejecutar la prueba. Esencialmente, se crean las condiciones iniciales requeridas para probar el comportamiento del sistema bajo prueba.
    
2. Act (Actuar): En esta fase, se realiza la acción que se va a probar. Esto implica invocar el método o la función que se está probando con los datos de entrada adecuados, o bien, llevar a cabo la operación que se desea evaluar.
    
3. Assert (Afirmar): En esta fase, se verifica el resultado o el comportamiento esperado después de realizar la acción. Se utilizan declaraciones de aserción (assertions) para comparar el resultado real de la acción con el resultado esperado. Si la afirmación falla, la prueba indica que el sistema bajo prueba no se comporta como se espera.

### Principio F.I.R.S.T
FIRST es el acrónimo de las cinco características que deben tener nuestros tests unitarios para ser considerados tests con calidad:

- Fast (rápido)
- Independent (independiente)
- Repeatable (repetible)
- Self-validating (auto evaluable)
- Timely (oportuno)