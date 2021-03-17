using System;
using System.Linq;

namespace HW_1_16_03_21
{
    class Program
    {
        static void Main(string[] args)
        {
            //First Dz
            string myText = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Neque corrupti sint accusantium." +
                            "Asperiores culpa totam assumenda dicta natus illo rem. Officia similique possimus nulla assumenda ad " +
                            "iste odio quia dolor asperiores dolorum expedita id, eos libero eius minus beatae laborum ex repellat?";

            string coding = string.Join("", myText.Select(t => (t == 'a') ? '1' : (t == 'e') ? '2' : (t == 'i') ? '3' : (t == 'o') ? '4' :
                                                               (t == 'u') ? '5' : (t == 'y') ? '6': t));

            string decoding = string.Join("", myText.Select(t => (t == '1') ? 'a' : (t == '2') ? 'e' : (t == '3') ? 'i' : (t == '4') ? 'o' :
                                                                 (t == '5') ? 'u' : (t == '6') ? 'y' : t));
            
            //Second Dz
            string dirtyText = "gdfgdf234dg54gf*23oP42";
            int leftNumber = 0;
            int rightNumber = 0;
            double leftSide =  Convert.ToDouble(string.Join("", dirtyText.TakeWhile(t => t != '*' && t != '/' && t != '+' && t != '-').Where(t => int.TryParse(t.ToString(), out leftNumber)).ToArray()));
            double rightSide = Convert.ToDouble(string.Join("", dirtyText.SkipWhile(t => t != '*' && t != '/' && t != '+' && t != '-').Where(t => int.TryParse(t.ToString(), out rightNumber)).ToArray()));

          
            Console.WriteLine(coding);
            Console.WriteLine(decoding);
            Console.WriteLine(leftSide * rightSide);
        }
    }
}
