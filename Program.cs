using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_menu_completo
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaracion de variables
            int op;
            //Menu
            System.Console.WriteLine("---------------------------------------------------------- M E N U ----------------------------------------------------------");
                System.Console.WriteLine("Elige el menu que deseas ocupar");
            System.Console.WriteLine(" 1. Menu de operaciones basicas\n 2.Menu de areas\n 3.Menu raro");
            op = int.Parse(System.Console.ReadLine());
            switch (op)
            {
                case 1:
                    //----------------------------------------------------------------------------menu de operaciones basicas-----------------------------------------------------------------
                    System.Console.WriteLine("------------------------------------------------MENU DE OPERACIONES BASICAS------------------------------------------------");
                    System.Console.WriteLine("Elige la operacion que deseas realizar");
                    System.Console.WriteLine(" 1. Suma\n 2. Resta\n 3. Multiplicacion\n 4. Division\n 5.formula general");
                    op = int.Parse(System.Console.ReadLine());
                    switch (op) 
                    {
                        case 1:
                            //-----------------------------------------------suma------------------------------------------------
                            System.Console.WriteLine("------------------------------------------------suma------------------------------------------------");
                            System.Console.WriteLine("Dame el primer numero");
                            int num1 = int.Parse(System.Console.ReadLine());
                            System.Console.WriteLine("Dame el segundo numero");
                            int num2 = int.Parse(System.Console.ReadLine());
                            int suma = num1 + num2;
                            System.Console.WriteLine("El resultado de la suma es: " + suma);
                            break;
                        case 2:
                            //-----------------------------------------------resta------------------------------------------------
                            System.Console.WriteLine("------------------------------------------------resta------------------------------------------------");
                            System.Console.WriteLine("Dame el primer numero");
                            num1 = int.Parse(System.Console.ReadLine());
                            System.Console.WriteLine("Dame el segundo numero");
                            num2 = int.Parse(System.Console.ReadLine());
                            int resta = num1 - num2;
                            System.Console.WriteLine("El resultado de la resta es: " + resta);
                            break;
                        case 3:
                            //-----------------------------------------------multiplicacion------------------------------------------------
                            System.Console.WriteLine("------------------------------------------------multiplicacion------------------------------------------------");
                            System.Console.WriteLine("Dame el primer numero");
                            num1 = int.Parse(System.Console.ReadLine());
                            System.Console.WriteLine("Dame el segundo numero");
                            num2 = int.Parse(System.Console.ReadLine());
                            int multiplicacion = num1 * num2;
                            System.Console.WriteLine("El resultado de la multiplicacion es: " + multiplicacion);
                            break;
                        case 4:
                            //-----------------------------------------------division------------------------------------------------
                            System.Console.WriteLine("------------------------------------------------division------------------------------------------------");
                            System.Console.WriteLine("Dame el primer numero");
                            num1 = int.Parse(System.Console.ReadLine());
                            System.Console.WriteLine("Dame el segundo numero");
                            num2 = int.Parse(System.Console.ReadLine());
                            int division = num1 / num2;
                            System.Console.WriteLine("El resultado de la division es: " + division);

                            break;
                        case 5:
                            //-----------------------------------------------formula general------------------------------------------------
                            System.Console.WriteLine("------------------------------------------------formula general------------------------------------------------");
                            System.Console.WriteLine("Dame el valor de a");
                            double a = double.Parse(System.Console.ReadLine());
                            System.Console.WriteLine("Dame el valor de b");
                            double b = double.Parse(System.Console.ReadLine());
                            System.Console.WriteLine("Dame el valor de c");
                            double c = double.Parse(System.Console.ReadLine());
                            double R1 = Math.Pow(b, 2);
                            double R2 = 4 * a;
                            double R3 = R2 * c;
                            double R5 = R1 - R3;
                            double R4 = Math.Sqrt(R5);
                            double x1 = (-b + R4) / (2 * a);
                            double x2 = (-b - R4) / (2 * a);
                            System.Console.WriteLine("el resultado es:" + x1);
                            System.Console.WriteLine("el resultado es:" + x2);
                            break;
                        default:
                            System.Console.WriteLine("Opcion no valida");
                            break;

                    }
                    break;
                case 2:
                    //----------------------------------------------------------------------------menu de areas--------------------------------------------------------------------
                    System.Console.WriteLine("------------------------------------------------MENU DE AREAS------------------------------------------------");
                    System.Console.WriteLine("Elige la operacion que deseas realizar");
                    System.Console.WriteLine(" 1.Circulo\n 2.Triangulo\n 3.Trapecio\n 4.Exagono\n 5.Rombo");
                    op = int.Parse(System.Console.ReadLine());
                    switch (op)
                    {
                        case 1:
                            //----------------------------------------------------------Circulo----------------------------------------------------------
                            System.Console.WriteLine("---------------------------------------------------Area de circulo------------------------------------------------------");
                            System.Console.WriteLine("Elige las opciones\n 1.Con el radio\n 2.Con el diametro");
                            op = int.Parse(Console.ReadLine());
                            switch (op)
                            {
                                case 1:
                                    //---------------------------------Con el radio---------------------------------------------
                                    System.Console.WriteLine("---------------------------------Con el radio---------------------------------------------");
                                    System.Console.WriteLine("Ingresa el radio");
                                    double radio = double.Parse(Console.ReadLine());
                                    double area = Math.PI * Math.Pow(radio, 2);
                                    System.Console.WriteLine("El area del circulo es: " + area);
                                    break;
                                case 2:
                                    //---------------------------------Con el diametro---------------------------------------------
                                    System.Console.WriteLine("---------------------------------Con el diametro---------------------------------------------");
                                    System.Console.WriteLine("Ingresa el diametro");
                                    double diametro = double.Parse(Console.ReadLine());
                                    double radio2 = diametro / 2;
                                    double area2 = Math.PI * Math.Pow(radio2, 2);
                                    System.Console.WriteLine("El area del circulo es: " + area2);
                                    break;
                                default:
                                    System.Console.WriteLine("La opcion no es valida");
                                    break;
                            }
                            break;
                        case 2:
                            //----------------------------------------------------------Triangulo----------------------------------------------------------
                            System.Console.WriteLine("--------------------------------------------------Area de triangulo-----------------------------------------------------");
                            System.Console.WriteLine("Ingresa la base");
                            double base1 = double.Parse(Console.ReadLine());
                            System.Console.WriteLine("Ingrese la altura");
                            double atura = double.Parse(Console.ReadLine());
                            double are3 = (base1 * atura) / 2;
                            System.Console.WriteLine("El area del triangulo es: " + are3);
                            break;
                        case 3:
                            //----------------------------------------------------------Trapecio----------------------------------------------------------
                            System.Console.WriteLine("--------------------------------------------------Area de trapecio-----------------------------------------------------");
                            System.Console.WriteLine("Ingresa la base mayor");
                            double ba = double.Parse(Console.ReadLine());
                            System.Console.WriteLine("Ingresa la base menor");
                            double bm = double.Parse(Console.ReadLine());
                            System.Console.WriteLine("Ingresa la altura");
                            double al = double.Parse(Console.ReadLine());
                            double are4 = ((ba + bm) * al) / 2;
                            System.Console.WriteLine("El area del trapecio es: " + are4);
                            break;
                        case 4:
                            //----------------------------------------------------------Exagono----------------------------------------------------------
                            System.Console.WriteLine("--------------------------------------------------Area de exagono-----------------------------------------------------");
                            System.Console.WriteLine("Ingresa el lado");
                            double lado = double.Parse(Console.ReadLine());
                            double are5 = (3 * Math.Sqrt(3) * Math.Pow(lado, 2)) / 2;
                            System.Console.WriteLine("el area del exagono es: " + are5);
                            break;
                        case 5:
                            //----------------------------------------------------------Rombo---------------------------------------------------------- 
                            System.Console.WriteLine("--------------------------------------------------Area de rombo-----------------------------------------------------");
                            System.Console.WriteLine("elija la operacion que mas le fuincione\n 1.con diagonal mayor y menor\n 2.con el lado y altura");
                            op = int.Parse(Console.ReadLine());
                            switch (op)
                            {
                                case 1:
                                    //---------------------------------Con la diagonal mayor y la diagonal menor---------------------------------------------
                                    System.Console.WriteLine("---------------------------------Con la diagonal mayor y la diagonal menor---------------------------------------------");
                                    System.Console.WriteLine("Ingresa la diagonal mayor");
                                    double dm = double.Parse(Console.ReadLine());
                                    System.Console.WriteLine("Ingresa la diagonal menor");
                                    double dme = double.Parse(Console.ReadLine());
                                    double are6 = (dm * dme) / 2;
                                    System.Console.WriteLine("El area del rombo es: " + are6);
                                    break;
                                case 2:
                                    //---------------------------------Con el lado y la altura---------------------------------------------
                                    System.Console.WriteLine("---------------------------------Con el lado y la altura---------------------------------------------");
                                    System.Console.WriteLine("Ingresa el lado");
                                    double lado2 = double.Parse(Console.ReadLine());
                                    System.Console.WriteLine("Ingresa la altura");
                                    double altura = double.Parse(Console.ReadLine());
                                    double are7 = lado2 * altura;
                                    System.Console.WriteLine("El area del rombo es: " + are7);
                                    break;
                                default:
                                    System.Console.WriteLine("La opcion no es valida");
                                    break;
                            }
                            break;
                        default:
                            System.Console.WriteLine("La opcion no es valida");
                            break;
                    }
                    break;
                case 3:
                    //-----------------------------------------------------------------------------------menu raro--------------------------------------------------------------------------------------
                    System.Console.WriteLine("------------------------------------------------MENU RARO------------------------------------------------");
                    System.Console.WriteLine("Elige la operacion que deseas realizar");
                    System.Console.WriteLine(" 1.Area Cuadrado\n 2.Promedio\n 3.Temperatura\n 4.Densidad\n 5.Masa\n 6.Volumen\n 7.Puntaje");
                    op = int.Parse(Console.ReadLine());
                    switch (op)
                    {
                        case 1:
                            //------------------------------------------------AREA DE CUADRADO------------------------------------------------
                            System.Console.WriteLine("----------------------------------------------------- AREA DECUADRADO -----------------------------------------------------");
                            System.Console.WriteLine("Ingrese la medida del lado al cuadrado");
                            double l = double.Parse(Console.ReadLine());
                            double a = Math.Pow(l, 2);
                            System.Console.WriteLine("EL area del cuadrado es: " + a);
                            break;
                        case 2:
                            //------------------------------------------------PROMEDIO------------------------------------------------
                            System.Console.WriteLine("----------------------------------------------------- PROMEDIO -----------------------------------------------------");
                            System.Console.WriteLine("Ingresa la calififacion 1");
                            double c1 = double.Parse(Console.ReadLine());
                            System.Console.WriteLine("Ingresa la calificacion 2");
                            double c2 = double.Parse(Console.ReadLine());
                            System.Console.WriteLine("Ingresa la calififacion 3");
                            double c3 = double.Parse(Console.ReadLine());
                            System.Console.WriteLine("Ingresa la calificacion 4");
                            double c4 = double.Parse(Console.ReadLine());
                            System.Console.WriteLine("Ingresa la calificacion 5");
                            double c5 = double.Parse(Console.ReadLine());
                            double p = (c1 + c2 + c3 + c4 + c5) / 5;
                            if (p >= 6)
                            {
                                System.Console.WriteLine("APROBASTE");
                            }
                            else
                            {
                                System.Console.WriteLine("Reprobaste...");
                            }
                            System.Console.WriteLine("Tu promedio es: " + p);
                            break;
                        case 3:
                            //------------------------------------------------TEMPERATURA------------------------------------------------
                            System.Console.WriteLine("------------------------------------------------TEMPERATURA------------------------------------------------");
                            System.Console.WriteLine("inserta la temperatura");
                            int Tm = int.Parse(Console.ReadLine());
                            if (Tm > 100)
                            {
                                System.Console.WriteLine("alarma");
                            }
                            else
                            {
                                System.Console.WriteLine("normal");
                            }
                            break;
                        case 4:
                            //------------------------------------------------DENSIDAD------------------------------------------------
                            System.Console.WriteLine("------------------------------------------------DENSIDAD------------------------------------------------");
                            System.Console.WriteLine("Inserte la masa");
                            double M = double.Parse(Console.ReadLine());
                            System.Console.WriteLine("Inserte el volumen");
                            double V = double.Parse(Console.ReadLine());
                            double P = (M / V);
                            System.Console.WriteLine("el resuLtado es:" + P);
                            break;
                        case 5:
                            //------------------------------------------------MASA------------------------------------------------
                            System.Console.WriteLine("------------------------------------------------MASA------------------------------------------------");
                            System.Console.WriteLine("Ingrese la densidad");
                            double De = double.Parse(Console.ReadLine());
                            System.Console.WriteLine("Ingrese el volumen");
                            double Vo = double.Parse(Console.ReadLine());
                            double R = De * Vo;
                            System.Console.WriteLine("El resultado es:" + R);

                            break;
                        case 6:
                            //------------------------------------------------VOLUMEN------------------------------------------------
                            System.Console.WriteLine("------------------------------------------------VOLUMEN------------------------------------------------");
                            System.Console.WriteLine("Elije el volumen que deseas realizar");
                            System.Console.WriteLine(" 1.cubo\n 2.cono\n 3.prisma rectangular\n 4.piramide\n 5.esfera\n 6.cilindro");
                            op = int.Parse(Console.ReadLine());
                            switch (op)
                            {
                                case 1:
                                    //------------------------------------------------cubo------------------------------------------------
                                    System.Console.WriteLine("------------------------------------------------cubo------------------------------------------------");
                                    System.Console.WriteLine("Ingrese el area");
                                    int A = int.Parse(Console.ReadLine());
                                    double F = Math.Pow(A, 3);
                                    System.Console.WriteLine("el aerea es:" + F);

                                    break;
                                case 2://------------------------------------------------cono------------------------------------------------
                                    System.Console.WriteLine("------------------------------------------------cono------------------------------------------------");
                                    System.Console.WriteLine("Inserte el radio de la base");
                                    double r = double.Parse(Console.ReadLine());
                                    System.Console.WriteLine("Ingrese la altura");
                                    double h = double.Parse(Console.ReadLine());
                                    System.Console.WriteLine("Ingrsa el valor de pi");
                                    double pi = Math.PI;
                                    double r2 = Math.Pow(r, 2);
                                    double hr = r2 * h;
                                    double hrp = hr * pi;
                                    double Vol = hrp / 3;
                                    System.Console.WriteLine("el resultado es:" + Vol);

                                    break;
                                case 3://-------------------------------------------prisma rectangular------------------------------------------
                                    System.Console.WriteLine("------------------------------------------------prisma rectangular------------------------------------------------");
                                    System.Console.WriteLine("Ingrese la longitud");
                                    double lon = double.Parse(Console.ReadLine());
                                    System.Console.WriteLine("Ingrese el ancho");
                                    double an = double.Parse(Console.ReadLine());
                                    System.Console.WriteLine("Ingrese la altura");
                                    double alt = double.Parse(Console.ReadLine());
                                    double vol = lon * an * alt;
                                    System.Console.WriteLine("El volumen del prisma rectangular es: " + vol);
                                    break;
                                case 4://------------------------------------------------piramide------------------------------------------------
                                    System.Console.WriteLine("------------------------------------------------piramide------------------------------------------------");
                                    System.Console.WriteLine("ingrese que tipo de base es\n 1.base cuadrada\n 2.base rectangular\n 3.base triangular");
                                    op = int.Parse(Console.ReadLine());
                                    switch (op)
                                    {
                                        case 1://--------------------------------------base cuadrada----------------------------------------------
                                            System.Console.WriteLine("------------------------------------------------base cuadrada------------------------------------------------");
                                            System.Console.WriteLine("Ingrese la base");
                                            double b = double.Parse(Console.ReadLine());
                                            System.Console.WriteLine("Ingrese la altura");
                                            double al = double.Parse(Console.ReadLine());
                                            double bf = Math.Pow(b, 2);
                                            double volu = (bf * al) / 3;
                                            System.Console.WriteLine("El volumen de la piramide es: " + volu);
                                            break;
                                        case 2://--------------------------------------base cuadrada----------------------------------------------
                                            System.Console.WriteLine("------------------------------------------------base rectangular------------------------------------------------");
                                            System.Console.WriteLine("Ingrese el largo");
                                            double lar = double.Parse(Console.ReadLine());
                                            System.Console.WriteLine("Ingrese el ancho");
                                            double anc = double.Parse(Console.ReadLine());
                                            System.Console.WriteLine("Ingrese la altura");
                                            double altu = double.Parse(Console.ReadLine());
                                            double bf2 = lar * anc;
                                            double volu2 = (bf2 * altu) / 3;
                                            System.Console.WriteLine("El volumen de la piramide es: " + volu2);
                                            break;
                                        case 3://--------------------------------------base cuadrada----------------------------------------------
                                            System.Console.WriteLine("------------------------------------------------base triangular------------------------------------------------");
                                            System.Console.WriteLine("Ingrese la base");
                                            double ba = double.Parse(Console.ReadLine());
                                            System.Console.WriteLine("Ingrese la altura");
                                            double al2 = double.Parse(Console.ReadLine());
                                            double bf3 = (ba * al2) / 2;
                                            System.Console.WriteLine("Ingrese la altura de la piramide");
                                            double altu2 = double.Parse(Console.ReadLine());
                                            double volu3 = (bf3 * altu2) / 3;
                                            System.Console.WriteLine("El volumen de la piramide es: " + volu3);
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 5://------------------------------------------------esfera------------------------------------------------
                                    System.Console.WriteLine("------------------------------------------------esfera------------------------------------------------");
                                    System.Console.WriteLine("Ingrese el radio");
                                    double ra = double.Parse(Console.ReadLine());
                                    double ra2 = Math.Pow(ra, 3);
                                    double volu4 = (4 * Math.PI * ra2) / 3;
                                    System.Console.WriteLine("El volumen de la esfera es: " + volu4);

                                    break;
                                case 6://------------------------------------------------cilindro------------------------------------------------
                                    System.Console.WriteLine("------------------------------------------------cilindro------------------------------------------------");
                                    System.Console.WriteLine("Ingrese el radio");
                                    double rad = double.Parse(Console.ReadLine());
                                    System.Console.WriteLine("Ingrese la altura");
                                    double altu3 = double.Parse(Console.ReadLine());
                                    double rad2 = Math.Pow(rad, 2);
                                    double PI = Math.PI;
                                    double volu5 = PI * rad2 * altu3;
                                    System.Console.WriteLine("el volumen del cilindro es:" + volu5);


                                    break;
                                default:
                                    System.Console.WriteLine("Opcion no valida");
                                    break;
                            }
                            break;
                        case 7:
                            //------------------------------------------------PUNTAJE------------------------------------------------
                            System.Console.WriteLine("------------------------------------------------PUNTAJE------------------------------------------------");
                            System.Console.WriteLine("Ingrese el puntaje");
                            int Puntaje = int.Parse(Console.ReadLine());
                            if (Puntaje >= 60)
                            {
                                System.Console.WriteLine("su punateje es alto");
                            }
                            else
                            {
                                System.Console.WriteLine("Su puntaje es bajo suerte la proxima");
                            }
                            break;
                        default:
                            //------------------------------------------------NONE------------------------------------------------
                            System.Console.WriteLine("Esta opcion no es valida");
                            break;
                    }
                    break;
                default:
                    System.Console.WriteLine("Opcion no valida");
                    break;
            }
            Console.ReadKey();
        }
    }
}
