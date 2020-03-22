namespace Memento
{
    public interface IDocumentMemento
    {
        string Content { get; }
        string FontName { get; }
        string FontSize { get; }

    }
}