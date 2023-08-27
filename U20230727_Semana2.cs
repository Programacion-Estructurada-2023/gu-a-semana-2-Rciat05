
using System;

namespace VariableDeclarator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare 4 variables de tipo string que representen su nombre completo, asigne valores desde la declaración.
            string nameCompleto = "Roberto Carlos Iglesias Álvarez";
            string DadName = "Juan Carlos Iglesias Díaz";
            string MomName = "Nora Imelda Álvarez de Iglesias";
            string SisName = "Kathia Julissa Iglesias Álvarez";

            // Declare 3 variables de tipo integer que tengan relación con la edad ya sea la suya y de sus padres, asigne valores desde la declaración
            int my_age = 18;
            int Mom_age = 41;
            int Dad_age = 42;

            // Declare 3 variables de tipo float que representen sus gastos más frecuentes como porejemplo queda a libre elección los gastos a representar, asigne valores desde la declaración.
            float gastos_pasajebus = 0.50f;
            float gastos_Comida = 4.50f;
            float gastos_ropa= 20.50f;

            // Declare 2 variables de tipo boolean para representar su estado como estudiante enesta materia y otra si es becado, asigne valores desde la declaración
            bool Estudiante = true;
            bool Becado = true;

            // Impresion para verificación =)
            Console.WriteLine("Nombre completo: " + nameCompleto);
            Console.WriteLine("Mi edad: " + my_age);
            Console.WriteLine("Gastos en comida: " + gastos_Comida);
            Console.WriteLine("Es estudiante: " + Estudiante);
            Console.WriteLine("Es becado: " + Becado);

            //Nota autoevaluación: 10/10
        }
    }
}