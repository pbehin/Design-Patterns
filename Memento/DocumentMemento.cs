namespace Memento
{
    public class DocumentMemento : IDocumentMemento
    {
        public string Content { get; }
        public string FontName { get; }
        public string FontSize { get; }

        public DocumentMemento(IState state)
        {
            Content = state.Content;
            FontName = state.FontName;
            FontSize = state.FontSize;
        }
    }
}