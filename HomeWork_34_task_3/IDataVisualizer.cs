namespace ConsoleApp1HomeWork_34_task_3;

public interface IDataVisualizer<T>
{
    void Display(IEnumerable<T> items);
}