using System;

namespace OrdenamientoBurbuja
{
    class Program
    {
        //Hago los metodos y arreglos 'static' para poder ser llamasdos desde el metodo Main que es 'static' tambien
        static int[] numbers = new int[]{5,6,2,8,1,11,3,36,9,7};
        static void Main(string[] args)
        {
            Console.WriteLine("Inicio!");
            Show();
            int extIteracion =0;
            int intIteracion =0;
            bool flag =true;
            for(int i=0; i < numbers.Length && flag ; i++){
                /*El flag al ser false no cumplira la condicion del primer for, pero miestras se cumpla la condicion del segundo sera true y se cumnplira hastq eu llegue el momento que no se cumpla y paraparan */
                flag= false;
                /* El numbers.Length-i -1 ayuda a reducir la cola hasta los numeros mayores que ya estan ordenados al final de la fila.. esto nos ayuda a reducir las iteraciones y reducir tiempo*/
                extIteracion ++;
                for(int j=0; j< numbers.Length - i -1;j++){
                    
                    if(numbers[j]>numbers[j+1]){
                        flag=true;
                        int aux=numbers[j];
                        numbers[j]=numbers[j+1];
                        numbers[j+1]=aux;

                        
                    }
                    intIteracion++;
                }
                Show();
            }
            Console.WriteLine("Iteraciones Externas(primer for): "+ extIteracion);
            Console.WriteLine("Iteraciones Internas(Segundo for): "+ intIteracion);
            Console.WriteLine("Cola ordenada: ");
            Show();
            

        }
        public static void Show(){
            foreach(var number in numbers){
                Console.Write(number + ",");
            }
            Console.WriteLine("\n");
        }
    }
}
