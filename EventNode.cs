using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra1262
{
    internal class EventNode : DialogNode
    {
        private List<EventSection> eventSection;

        public EventNode(string text,List<EventSection> eventSection) : base(text)
        {
            this.eventSection = eventSection;
        }

        public override void Execute()
        {
            base.Execute();
            for(int i=0;i<eventSection.Count;i++)
            {
                ShowText($"{i+1}. {eventSection[i].option}");
            }
            int choice = int.Parse(Console.ReadLine());
            if (choice > 0 && choice <= eventSection.Count)
            {
                ShowText($"{eventSection[choice-1].result}");
                ShowText("Presiona cualquier tecla para continuar...");
                Console.ReadKey();
            }
            else
            {
                ShowText($"Opción inválida");
            }
        }
    }
}
