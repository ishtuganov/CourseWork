namespace StackArray_Ishtuganov_Pibd13;

public class Manager
{
    public StackRealization Stack { get; }
    public StateStorage StateStorage { get; }

    public Manager(Parameters parameters)
    {
        Stack = new StackRealization(parameters);
        StateStorage = new StateStorage();
    }
}
