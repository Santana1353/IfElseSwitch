using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Menú de Ejercicios Condicionales ---\n");

            Console.WriteLine("1. Número positivo, negativo o cero");
            Console.WriteLine("2. Número par o impar");
            Console.WriteLine("3. Mayor de edad");
            Console.WriteLine("4. Múltiplo de 5");
            Console.WriteLine("5. Descuento por edad");
            Console.WriteLine("6. Calificación aprobatoria");
            Console.WriteLine("7. Día de la semana");
            Console.WriteLine("8. Número mayor entre dos");
            Console.WriteLine("9. Mayor entre tres números");
            Console.WriteLine("10. Clasificación de ángulos");
            Console.WriteLine("11. Cálculo de impuestos");
            Console.WriteLine("12. Clasificación de números");
            Console.WriteLine("13. Verificación de año bisiesto");
            Console.WriteLine("14. Conversión de calificaciones");
            Console.WriteLine("15. Comparación de tres longitudes");
            Console.WriteLine("16. Calculadora de descuentos");
            Console.WriteLine("17. Tipo de triángulo");
            Console.WriteLine("18. Evaluación de temperatura");
            Console.WriteLine("19. Conversión de horas a turnos");
            Console.WriteLine("20. Clasificación de IMC");

            Console.Write("\nSeleccione una opción (1-20): ");
            int opcion = int.Parse(Console.ReadLine());

            Console.Clear();

            switch (opcion)
            {
                case 1: NumeroPositivoNegativoCero(); break;
                case 2: NumeroParOImpar(); break;
                case 3: MayorDeEdad(); break;
                case 4: MultiploDe5(); break;
                case 5: DescuentoPorEdad(); break;
                case 6: CalificacionAprobatoria(); break;
                case 7: DiaDeLaSemana(); break;
                case 8: NumeroMayorEntreDos(); break;
                case 9: MayorEntreTresNumeros(); break;
                case 10: ClasificacionDeAngulos(); break;
                case 11: CalculoDeImpuestos(); break;
                case 12: ClasificacionDeNumeros(); break;
                case 13: VerificacionAnoBisiesto(); break;
                case 14: ConversionDeCalificaciones(); break;
                case 15: ComparacionTresLongitudes(); break;
                case 16: CalculadoraDeDescuentos(); break;
                case 17: TipoDeTriangulo(); break;
                case 18: EvaluacionDeTemperatura(); break;
                case 19: ConversionHorasATurnos(); break;
                case 20: ClasificacionDeIMC(); break;
                default:
                    Console.WriteLine("⚠️ Opción no válida.");
                    break;
            }
        }

        // 1. Número positivo, negativo o cero
        static void NumeroPositivoNegativoCero()
        {
            Console.WriteLine("--- Número positivo, negativo o cero ---");
            Console.Write("Ingrese un número: ");
            double num = double.Parse(Console.ReadLine());

            if (num > 0)
                Console.WriteLine("✅ El número es positivo.");
            else if (num < 0)
                Console.WriteLine("⚠️ El número es negativo.");
            else
                Console.WriteLine("🔵 El número es cero.");
        }

        // 2. Número par o impar
        static void NumeroParOImpar()
        {
            Console.WriteLine("--- Número par o impar ---");
            Console.Write("Ingrese un número entero: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
                Console.WriteLine("✅ El número es par.");
            else
                Console.WriteLine("⚠️ El número es impar.");
        }

        // 3. Mayor de edad
        static void MayorDeEdad()
        {
            Console.WriteLine("--- Mayor o menor de edad ---");
            Console.Write("Ingrese su edad: ");
            int edad = int.Parse(Console.ReadLine());

            if (edad >= 18)
                Console.WriteLine("✅ Eres mayor de edad.");
            else
                Console.WriteLine("⚠️ Eres menor de edad.");
        }

        // 4. Múltiplo de 5
        static void MultiploDe5()
        {
            Console.WriteLine("--- Múltiplo de 5 ---");
            Console.Write("Ingrese un número: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 5 == 0)
                Console.WriteLine("✅ El número es múltiplo de 5.");
            else
                Console.WriteLine("⚠️ El número NO es múltiplo de 5.");
        }

        // 5. Descuento por edad
        static void DescuentoPorEdad()
        {
            Console.WriteLine("--- Descuento por edad ---");
            Console.Write("Ingrese su edad: ");
            int edad = int.Parse(Console.ReadLine());

            if (edad > 60)
                Console.WriteLine("✅ Aplica para descuento del 50%.");
            else
                Console.WriteLine("⚠️ No aplica para descuento.");
        }

        // 6. Calificación aprobatoria
        static void CalificacionAprobatoria()
        {
            Console.WriteLine("--- Calificación aprobatoria ---");
            Console.Write("Ingrese la calificación (0-100): ");
            int cal = int.Parse(Console.ReadLine());

            if (cal >= 60)
                Console.WriteLine("✅ Aprobado.");
            else
                Console.WriteLine("⚠️ Reprobado.");
        }

        // 7. Día de la semana
        static void DiaDeLaSemana()
        {
            Console.WriteLine("--- Día de la semana ---");
            Console.Write("Ingrese un número del 1 al 7: ");
            int dia = int.Parse(Console.ReadLine());

            switch (dia)
            {
                case 1: Console.WriteLine("Lunes"); break;
                case 2: Console.WriteLine("Martes"); break;
                case 3: Console.WriteLine("Miércoles"); break;
                case 4: Console.WriteLine("Jueves"); break;
                case 5: Console.WriteLine("Viernes"); break;
                case 6: Console.WriteLine("Sábado"); break;
                case 7: Console.WriteLine("Domingo"); break;
                default: Console.WriteLine("⚠️ Número inválido."); break;
            }
        }

        // 8. Número mayor entre dos
        static void NumeroMayorEntreDos()
        {
            Console.WriteLine("--- Número mayor entre dos ---");
            Console.Write("Ingrese el primer número: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            int n2 = int.Parse(Console.ReadLine());

            if (n1 > n2)
                Console.WriteLine($"✅ El mayor es: {n1}");
            else if (n2 > n1)
                Console.WriteLine($"✅ El mayor es: {n2}");
            else
                Console.WriteLine("🔵 Ambos números son iguales.");
        }

        // 9. Mayor entre tres números
        static void MayorEntreTresNumeros()
        {
            Console.WriteLine("--- Mayor entre tres números ---");
            Console.Write("Ingrese el primer número: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el tercer número: ");
            int n3 = int.Parse(Console.ReadLine());

            int mayor = n1;
            if (n2 > mayor) mayor = n2;
            if (n3 > mayor) mayor = n3;

            Console.WriteLine($"✅ El mayor es: {mayor}");
        }

        // 10. Clasificación de ángulos
        static void ClasificacionDeAngulos()
        {
            Console.WriteLine("--- Clasificación de ángulos ---");
            Console.Write("Ingrese el valor del ángulo en grados: ");
            int angulo = int.Parse(Console.ReadLine());

            if (angulo < 90)
                Console.WriteLine("Ángulo agudo");
            else if (angulo == 90)
                Console.WriteLine("Ángulo recto");
            else if (angulo > 90 && angulo < 180)
                Console.WriteLine("Ángulo obtuso");
            else if (angulo == 180)
                Console.WriteLine("Ángulo llano");
            else
                Console.WriteLine("Valor inválido");
        }

        // 11. Cálculo de impuestos
        static void CalculoDeImpuestos()
        {
            Console.WriteLine("--- Cálculo de impuestos ---");
            Console.Write("Ingrese su salario mensual: ");
            double salario = double.Parse(Console.ReadLine());

            double impuesto;

            if (salario < 10000)
                impuesto = 0;
            else if (salario <= 30000)
                impuesto = salario * 0.10;
            else
                impuesto = salario * 0.20;

            Console.WriteLine($"Impuesto a pagar: {impuesto:C2}");
        }

        // 12. Clasificación de números
        static void ClasificacionDeNumeros()
        {
            Console.WriteLine("--- Clasificación de números ---");
            Console.Write("Ingrese el primer número: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el tercer número: ");
            int n3 = int.Parse(Console.ReadLine());

            bool todosPositivos = n1 > 0 && n2 > 0 && n3 > 0;
            bool todosNegativos = n1 < 0 && n2 < 0 && n3 < 0;
            bool hayCeros = n1 == 0 || n2 == 0 || n3 == 0;

            if (hayCeros)
                Console.WriteLine("Hay ceros.");
            else if (todosPositivos)
                Console.WriteLine("Todos son positivos.");
            else if (todosNegativos)
                Console.WriteLine("Todos son negativos.");
            else
                Console.WriteLine("Números mixtos.");
        }

        // 13. Verificación de año bisiesto
        static void VerificacionAnoBisiesto()
        {
            Console.WriteLine("--- Verificación de año bisiesto ---");
            Console.Write("Ingrese un año: ");
            int año = int.Parse(Console.ReadLine());

            bool esBisiesto = (año % 4 == 0 && año % 100 != 0) || (año % 400 == 0);

            if (esBisiesto)
                Console.WriteLine("✅ El año es bisiesto.");
            else
                Console.WriteLine("⚠️ El año NO es bisiesto.");
        }

        // 14. Conversión de calificaciones
        static void ConversionDeCalificaciones()
        {
            Console.WriteLine("--- Conversión de calificaciones ---");
            Console.Write("Ingrese la calificación numérica (0-100): ");
            int cal = int.Parse(Console.ReadLine());

            char letra;

            if (cal >= 90 && cal <= 100)
                letra = 'A';
            else if (cal >= 80)
                letra = 'B';
            else if (cal >= 70)
                letra = 'C';
            else if (cal >= 60)
                letra = 'D';
            else
                letra = 'F';

            Console.WriteLine($"Calificación letra: {letra}");
        }

        // 15. Comparación de tres longitudes
        static void ComparacionTresLongitudes()
        {
            Console.WriteLine("--- Comparación de tres longitudes ---");
            Console.Write("Ingrese longitud 1: ");
            double l1 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese longitud 2: ");
            double l2 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese longitud 3: ");
            double l3 = double.Parse(Console.ReadLine());

            if (l1 + l2 > l3 && l1 + l3 > l2 && l2 + l3 > l1)
                Console.WriteLine("✅ Pueden formar un triángulo.");
            else
                Console.WriteLine("⚠️ No pueden formar un triángulo.");
        }

        // 16. Calculadora de descuentos
        static void CalculadoraDeDescuentos()
        {
            Console.WriteLine("--- Calculadora de descuentos ---");
            Console.Write("Ingrese el precio del producto: ");
            double precio = double.Parse(Console.ReadLine());

            double descuento = 0;

            if (precio >= 50 && precio <= 100)
                descuento = 0.05;
            else if (precio > 100)
                descuento = 0.10;

            double precioFinal = precio - (precio * descuento);
            Console.WriteLine($"Precio final con descuento: {precioFinal:C2}");
        }

        // 17. Tipo de triángulo
        static void TipoDeTriangulo()
        {
            Console.WriteLine("--- Tipo de triángulo ---");
            Console.Write("Ingrese lado 1: ");
            double l1 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese lado 2: ");
            double l2 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese lado 3: ");
            double l3 = double.Parse(Console.ReadLine());

            if (!(l1 + l2 > l3 && l1 + l3 > l2 && l2 + l3 > l1))
            {
                Console.WriteLine("⚠️ No forman un triángulo válido.");
                return;
            }

            if (l1 == l2 && l2 == l3)
                Console.WriteLine("Triángulo equilátero.");
            else if (l1 == l2 || l1 == l3 || l2 == l3)
                Console.WriteLine("Triángulo isósceles.");
            else
                Console.WriteLine("Triángulo escaleno.");
        }

        // 18. Evaluación de temperatura
        static void EvaluacionDeTemperatura()
        {
            Console.WriteLine("--- Evaluación de temperatura ---");
            Console.Write("Ingrese la temperatura en °C: ");
            int temp = int.Parse(Console.ReadLine());

            if (temp < 0)
                Console.WriteLine("Hace mucho frío.");
            else if (temp <= 20)
                Console.WriteLine("Clima fresco.");
            else if (temp <= 30)
                Console.WriteLine("Clima agradable.");
            else
                Console.WriteLine("Hace mucho calor.");
        }

        // 19. Conversión de horas a turnos
        static void ConversionHorasATurnos()
        {
            Console.WriteLine("--- Conversión de horas a turnos ---");
            Console.Write("Ingrese la hora (0-23): ");
            int hora = int.Parse(Console.ReadLine());

            if (hora >= 6 && hora <= 11)
                Console.WriteLine("Mañana");
            else if (hora >= 12 && hora <= 17)
                Console.WriteLine("Tarde");
            else if (hora >= 18 && hora <= 23)
                Console.WriteLine("Noche");
            else if (hora >= 0 && hora <= 5)
                Console.WriteLine("Madrugada");
            else
                Console.WriteLine("Hora inválida.");
        }

        // 20. Clasificación de IMC
        static void ClasificacionDeIMC()
        {
            Console.WriteLine("--- Clasificación de IMC ---");
            Console.Write("Ingrese su peso en kg: ");
            double peso = double.Parse(Console.ReadLine());
            Console.Write("Ingrese su altura en metros: ");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);

            Console.WriteLine($"IMC: {imc:F2}");

            if (imc < 18.5)
                Console.WriteLine("Bajo peso");
            else if (imc < 25)
                Console.WriteLine("Normal");
            else if (imc < 30)
                Console.WriteLine("Sobrepeso");
            else
                Console.WriteLine("Obesidad");
        }
    }
}

