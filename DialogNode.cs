using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra1262
{
    internal class DialogNode : Node
    {
        private string text;

        public DialogNode(string text)
        {
            this.text = text;
        }

        public override void Execute()
        {
            Console.WriteLine(text);
            Console.WriteLine("Presiona cualquier tecla para continuar...");
            Console.ReadKey();
        }

    }
}
