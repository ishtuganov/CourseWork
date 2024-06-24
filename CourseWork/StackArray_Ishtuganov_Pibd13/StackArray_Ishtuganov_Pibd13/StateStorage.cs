using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace StackArray_Ishtuganov_Pibd13;

/// <summary>
/// Класс-хранилище
/// </summary>
[Serializable]
public class StateStorage
{
    private List<State> states;
    private int currentIndex;

    public int StatesCount => states.Count;

    public StateStorage()
    {
        states = new List<State>();
        currentIndex = -1;
    }

    public void AddState(State state)
    {
        states.Add(state);
        currentIndex = StatesCount - 1;
    }

    public State GetNextState()
    {
        if (currentIndex < StatesCount - 1)
        {
            return states[++currentIndex];
        }
        return states[currentIndex];
    }

    public State GetPreviousState()
    {
        if (currentIndex > 0)
        {   
            currentIndex--;
            return states[currentIndex];
        }
        return states[currentIndex];
    }

    public State? Reset()
    {
        if (states.Count > 0)
        {
            currentIndex = 0;
            return states[currentIndex];
        }
        return null;
    }

    public void SaveToFile(string filePath)
    {
        using (FileStream fs = new(filePath, FileMode.Create))
        {
            #pragma warning disable SYSLIB0011
            BinaryFormatter formatter = new();
            formatter.Serialize(fs, this);
            #pragma warning restore SYSLIB0011
        }
    }

    public void LoadFromFile(string filePath)
    {
        using (FileStream fs = new FileStream(filePath, FileMode.Open))
        {
            #pragma warning disable SYSLIB0011
            BinaryFormatter formatter = new();
            states = ((StateStorage)formatter.Deserialize(fs)).states;
            #pragma warning restore SYSLIB0011
        }
    }
}

