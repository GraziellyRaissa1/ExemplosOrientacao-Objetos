using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Você também pode deixar os campos em branco e modificá-los ao criar o objeto:


namespace AulaPOO
{
    internal class Animais
    {
        string gato, cachorro, galinha;

        public static void Main(string[] args)
        {
            Animais animais1 = new Animais();

            animais1.gato = "Miau!";
            animais1.galinha = "po! po!";
            animais1.cachorro = "Au1 Au!";

            Console.WriteLine(animais1.gato);
            Console.WriteLine(animais1.cachorro);
            Console.WriteLine(animais1.galinha);

        }
    }
}
