using System;
using System.Collections.Generic;
namespace StackArray_Ishtuganov_Pibd13;

public class StackVisualizer
{

    public StackVisualizer() 
    { 
    }

    public void Visualize(Graphics g, State state)
    {
        Pen pen = new(Color.Black, 3);

        DrawStack(g, pen, state);
        DrawItems(g, pen, state);
    }

    public void DrawStack(Graphics g, Pen pen, State state) 
    {
        g.DrawRectangle(pen, 30, 30, 720, 200);
        for (int i = 0; i < state.Array.Length; i++)
        {
            g.DrawRectangle(pen, 35 * (i + 1), 35, 30, 190);
        }
        
    }

    public void DrawItems(Graphics g, Pen pen, State state)
    {
        for (int i = 0; i <= state.TopItemIndex; i++)
        {
            g.DrawString(state.Array[i].ToString(), new Font("Arial", 15), Brushes.Black, 35 * (i + 1), 115);
        }
    }
}
