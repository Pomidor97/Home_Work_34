namespace HomeWork_34_task_1;

public class ArrayHelper<T> where T : IComparable<T>
{
    public void Sort(T[] array)
    {
        Array.Sort(array);
    }
    
    public void Reverse(T[] array)
    {
        Array.Reverse(array);
    }
}