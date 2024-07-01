namespace StackArray_Ishtuganov_Pibd13;

/// <summary>
/// Класс-состояние
/// </summary>
[Serializable]
public class State
{
    public int[] Array { get; }

    public int TopItemIndex { get; }

    public State(int[] array, int topItemIndex) 
    {
        Array = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            this.Array[i] = array[i];
        }
        TopItemIndex = topItemIndex;
    }
}
