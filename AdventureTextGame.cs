using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra1262
{
    internal class AdventureTextGame
    {
        private List<Node> nodes;

        public void Execute()
        {
            IShowText showText = new DialogNode("");
            List<IShowText> showTextList = new List<IShowText>();

            showTextList.Add(showText);
            showTextList.Add(new DialogNode("hola");

            nodes = new List<Node>();
            nodes.Add(new DialogNode("Inicio de clases"));
            nodes.Add(new DialogNode("El curso comienza mal"));
            List<EventSection> events = new List<EventSection>();
            events.Add(new EventSection("Estudiar", "Te quedaste dormido"));
            events.Add(new EventSection("Dormir", "Tuviste pesadillas"));
            nodes.Add(new EventNode("Dar el examen", events));
            nodes.Add(new DialogNode("Fin del curso, jalaste"));

            foreach (Node node in nodes)
            {
                node.Execute();
            }


        }
    }
}
