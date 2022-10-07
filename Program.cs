using System;

namespace Numero_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Limpiar pantalla
            Console.Clear();
            //Variables
            int alumnos,privado,publico,porcpublic,porcpriv;
            string select,pregunta;
            //Inicializo variables
            alumnos=0;
            privado=0;
            publico=0;
            select="";
            //Presentacion
            Console.WriteLine("Hola, bienvenido al sistema de encuestas!");
            Console.WriteLine("****Presione una tecla para continuar****");
            
            Console.ReadKey();
            Console.Clear();
            
            //Ciclo while para repetir el proceso indeterminadas veces, ya que no sabemos la cantidad exacta de encuestados.
            
            while(select!="n"){
            Console.WriteLine("Por favor ingrese la respuesta del alumno encuestado publico(p) o privado(v)");
            pregunta=Console.ReadLine();
            
            //Condicional if para sumarle a los contadores designados
            if(pregunta=="p"){
                publico=publico+1;
                alumnos=alumnos+1;
            }
            else if(pregunta=="v"){
                privado=privado+1;
                alumnos=alumnos+1;
            }
            else{
                Console.WriteLine("ERROR DE TIPEO,revise su ortografia! ");
            }
            Console.WriteLine("Si desea terminar la encuesta presione la tecla n, si desea continuar presione enter");
            select=Console.ReadLine();
            Console.Clear();
            //Termina o reinicia el ciclo while
            }
            
            Console.Clear();
            //Operaciones de porcentajes
            
            porcpublic=(100*publico)/alumnos;
            porcpriv=(100*privado)/alumnos;
            
            //Mensaje final mostrando los resultados de la encuesta
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("/////////////////////////////-En total se entrevistaron "+alumnos+" alumnos.-/////////////////////////////////////"); 
            Console.WriteLine(+publico+" alumno/s estudian en colegio publico, que representa un "+porcpublic+" porciento del total de alumnos.");
            Console.WriteLine(+privado+" alumno/s estudian en colegio privado, que representa un "+porcpriv+" porciento del total de alumnos.");


            




        }
    }
}
