using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackArray_Ishtuganov_Pibd13;

public class StackRealization
{
    private int[] _array;

    private int _topItemIndex;

    public int Count => _topItemIndex + 1;

    public StackRealization(Parameters parameters)
    {
        _array = parameters.Array;
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

    public int Peek()
    {
        return _array[_topItemIndex];
    }

    public bool IsEmpty()
    {
        return Count == 0;
    }

    public void Step()
    {
        //TODO
    }

    public State GetState()
    {
        return new State(_array, _topItemIndex);
    }

    public void SetState(State state)
    {
        _array = state.Array; 
        _topItemIndex = state.TopItemIndex;
    }
}
