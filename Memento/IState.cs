namespace Memento
{
    public interface IState
    {
        string Content { get; }
        string FontName { get; }
        string FontSize { get; }
    }
}