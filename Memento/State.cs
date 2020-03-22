namespace Memento
{
    public class State : IState
    {
        public State(string content, string fontName, string fontSize)
        {
            Content = content;
            FontName = fontName;
            FontSize = fontSize;
        }

        public string Content { get; private set; }
        public string FontName { get; private set; }
        public string FontSize { get; private set; }
    }
}