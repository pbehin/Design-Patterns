using System;

namespace Memento
{
    public interface IOriginator: IDocumentMementoProvider
    {
        void GoToStep1();
        void GoToStep2();
        string GetStateAsString();
    }

    public class Originator : IOriginator
    {
        private IState _state;
        public Originator(string content, string fontName, string fontSize)
        {
            _state = new State(content, fontName, fontSize);
        }
        public IDocumentMemento CreateRestorePoint()
        {
            var restorePoint = new DocumentMemento(_state);
            return restorePoint;
        }

        public void Restore(IDocumentMemento state)
        {
            _state = new State(state.Content, state.FontName, state.FontSize);
        }

        public void GoToStep1()
        {
            _state = new State("Document is in Step one", "San Serif", "18");
        }

        public void GoToStep2()
        {
            _state= new State("Document is in Step two", "Tahoma", "15");
        }

        public string GetStateAsString()
        {
            return $"\"{_state.Content}\"\t{_state.FontName}\t{_state.FontSize}";
        }
    }
}