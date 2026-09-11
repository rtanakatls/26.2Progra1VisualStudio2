using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra1262
{
    internal class DialogNode : Node, IShowText
    {
        private string text;

        public DialogNode(string text)
        {
            this.text = text;
        }

        public override void Execute()
        {
            ShowText(text);
            ShowText("Presiona cualquier tecla para continuar...");
            Console.ReadKey();
        }

        public void ShowText(string text)
        {
            Console.WriteLine(text);
        }

    }
}
