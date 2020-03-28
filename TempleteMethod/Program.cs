using System;

namespace TempleteMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            SubLayerImpl1 subLayer = new SubLayerImpl1();
            subLayer.CreateDependencies();
        }
    }

    public class SubLayerImpl1 : SubLayer
    {
        protected override void OnCreateDependencies()
        {
            Console.WriteLine("Template Method. In variant parts of code");
        }
    }
}
