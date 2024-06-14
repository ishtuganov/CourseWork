using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        Array = array;
        TopItemIndex = topItemIndex;
    }
}
