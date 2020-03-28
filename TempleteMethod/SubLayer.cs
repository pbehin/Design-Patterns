using System;

namespace TempleteMethod
{
    public abstract class SubLayer : ISubLayer
    {
        protected abstract void OnCreateDependencies();
        public void CreateDependencies()
        {
            Console.WriteLine("Template Method. Before Call variant parts of code method");
            OnCreateDependencies();
            DoSomeThingsInParent();
            OnGetSubLayerName();
            Console.WriteLine("Template Method. After Call variant parts of code Method");


        }

        protected virtual void OnGetSubLayerName()
        {

        }

        private void DoSomeThingsInParent()
        {
            Console.WriteLine("Template Method. In parent.");

        }
    }
}