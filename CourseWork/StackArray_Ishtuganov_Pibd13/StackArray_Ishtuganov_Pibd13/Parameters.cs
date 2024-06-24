using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackArray_Ishtuganov_Pibd13;

public class Parameters
{
    public int[] Array { get; private set; }

    public int TopItemIndex { get; private set; }

    public Parameters(int[] array, int topItemIndex) 
    {
        Array = array;
        TopItemIndex = topItemIndex;
    }
}
