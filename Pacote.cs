using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Você também pode criar um objeto de uma classe e acessá-lo em outra classe.
//Isso geralmente é usado para melhor organização das classes (uma classe possui todos os campos e métodos, enquanto a outra classe contém o Main()método (código a ser executado)).

//°Class.cs
//°Pacote.cs

// Aqui chamamos as classes do arquivo 

namespace AulaPOO
{
    internal class Pacote
    {
        public static void Main(string[] args)
        {
            Car Car1 = new Car();

            Console.WriteLine(Car1.cor);
            Console.WriteLine(Car1.velocidadeMax);
        }
    }
}
