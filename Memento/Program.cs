using System;
using System.Collections.Generic;
using System.Linq;

namespace Memento
{
    class Program
    {
        static void Main()
        {
            IOriginator originator = new Originator("", "Arial", "10");

            var restorePoints = new List<IDocumentMemento> { originator.CreateRestorePoint() };

            originator.GoToStep1();
            restorePoints.Add(originator.CreateRestorePoint());
            Console.WriteLine(originator.GetStateAsString());

            originator.GoToStep2();
            restorePoints.Add(originator.CreateRestorePoint());
            Console.WriteLine(originator.GetStateAsString());

            originator.Restore(restorePoints.Skip(1).First());
            Console.WriteLine(originator.GetStateAsString());

        }
    }
}
