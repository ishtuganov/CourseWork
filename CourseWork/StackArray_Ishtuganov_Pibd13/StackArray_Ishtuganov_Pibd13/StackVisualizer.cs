namespace StackArray_Ishtuganov_Pibd13;

public class StackVisualizer
{
    Pen blackPen = new(Color.Black, 3);
    Pen redPen = new(Color.Red, 3);
    Pen greenPen = new(Color.Green, 3);

    public StackVisualizer() 
    { 
    }

    public void Visualize(Graphics g, State state)
    {
        DrawStack(g, state);
        DrawItems(g, state);
    }

    public void DrawStack(Graphics g, State state) 
    {
        g.DrawRectangle(blackPen, 30, 30, 720, 200);
        for (int i = 0; i < state.Array.Length; i++)
        {
            g.DrawRectangle(blackPen, 35 * (i + 1), 35, 30, 190);
        }
        
    }

    public void DrawItems(Graphics g, State state)
    {
        for (int i = 0; i <= state.TopItemIndex; i++)
        {
            g.DrawString(state.Array[i].ToString(), new Font("Arial", 15), Brushes.Black, 35 * (i + 1), 115);
        }
    }

    public void DrawLastDeleting(Graphics g, int index) 
    {
        g.DrawRectangle(redPen, 35 * (index + 2) + 3, 110, 24, 30);
    }

    public void DrawLastAdding(Graphics g, int index)
    {
        g.DrawRectangle(greenPen, 35 * (index + 1) + 3, 110, 24, 30);
    }
}
