namespace StackArray_Ishtuganov_Pibd13;

[Serializable]
public class State
{
    public int[] Array { get; }

    public int TopItemIndex { get; }

    public State(int[] array, int topItemIndex) 
    {
        Array = new int[array.Length];
        array.CopyTo(Array, 0);
        TopItemIndex = topItemIndex;
    }
}
