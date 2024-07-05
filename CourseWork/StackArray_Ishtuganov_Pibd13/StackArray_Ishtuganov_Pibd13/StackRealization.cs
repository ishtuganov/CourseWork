namespace StackArray_Ishtuganov_Pibd13;

public class StackRealization
{
    private int[] _array;

    private int _topItemIndex;

    public int Count => _topItemIndex + 1;

    public StackRealization(Parameters parameters)
    {
        _array = new int[parameters.Array.Length];
        parameters.Array.CopyTo(_array, 0);
        _topItemIndex = parameters.TopItemIndex;
    }

    public void Push(int value)
    {
        if (_topItemIndex + 1 == _array.Length) throw new InvalidOperationException();
        _array[++_topItemIndex] = value;
    }

    public int Pop()
    {
        if (Count == 0) throw new InvalidOperationException();
        int lastItem = _array[_topItemIndex];
        _array[_topItemIndex] = 0;
        _topItemIndex--;
        return lastItem;
    }

    public State GetState()
    {
        return new State(_array, _topItemIndex);
    }
}
