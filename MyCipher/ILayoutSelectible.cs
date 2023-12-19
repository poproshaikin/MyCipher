namespace MyCipher;

public interface ILayoutSelectible
{
    string CurrentLayout { get; }
    void SetLayout(string layout);
}