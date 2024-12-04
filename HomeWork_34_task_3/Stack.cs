namespace ConsoleApp1HomeWork_34_task_3;

public class Stack<T> : IDataVisualizer<T>
{
    private List<T> _elements = new List<T>();

    public void Push(T element)
    {
        _elements.Add(element);
    }

    public T Pop()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Stack is empty. Cannot pop an element.");
        }

        T topElement = _elements[^1];
        _elements.RemoveAt(_elements.Count - 1);
        return topElement;
    }

    public bool IsEmpty()
    {
        return _elements.Count == 0;
    }

    public void Display(IEnumerable<T> items)
    {
        Console.WriteLine("\nCurrent stack state (top to bottom):");
        foreach (var item in items)
        {
            Console.WriteLine($"- {item}");
        }
    }

    public IEnumerable<T> GetStackState()
    {
        for (int i = _elements.Count - 1; i >= 0; i--)
        {
            yield return _elements[i];
        }
    }
}