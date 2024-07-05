using System.Runtime.Serialization.Formatters.Binary;

namespace StackArray_Ishtuganov_Pibd13;


[Serializable]
public class StateStorage
{
    private List<State> states;
    public int CurrentIndex { get; private set; }
    public int StatesCount => states.Count;

    public StateStorage()
    {
        states = new List<State>();
        CurrentIndex = -1;
    }

    public void AddState(State state)
    {
        states.Add(state);
        CurrentIndex = StatesCount - 1;
    }

    public State GetNextState()
    {
        if (CurrentIndex < StatesCount - 1)
        {
            return states[++CurrentIndex];
        }
        return states[CurrentIndex];
    }

    public State GetPreviousState()
    {
        if (CurrentIndex > 0)
        {   
            CurrentIndex--;
            return states[CurrentIndex];
        }
        return states[CurrentIndex];
    }

    public State GetLastState()
    {
        return states[states.Count - 1];
    }

    public State? Reset()
    {
        if (states.Count > 0)
        {
            CurrentIndex = 0;
            return states[CurrentIndex];
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
            StateStorage storage = (StateStorage)formatter.Deserialize(fs);
            states = storage.states;
            CurrentIndex = storage.CurrentIndex;
            #pragma warning restore SYSLIB0011
        }
    }
}

