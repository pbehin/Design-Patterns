namespace Memento
{
    public interface IDocumentMementoProvider
    {
        IDocumentMemento CreateRestorePoint();
        void Restore(IDocumentMemento state);
    }
}