using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackArray_Ishtuganov_Pibd13;

public class StackVisualizer
{
    private State state;

    public StackVisualizer(State state) 
    { 
        this.state = state;
    }

    public void Visualize(Graphics g)
    {
        Pen pen = new(Color.Black, 3);

        DrawStack(g, pen);
        DrawItems(g, pen);
    }

    public void DrawStack(Graphics g, Pen pen) 
    {
        g.DrawRectangle(pen, 30, 30, 720, 200);
        for (int i = 0; i < state.Array.Length; i++)
        {
            g.DrawRectangle(pen, 35 * (i + 1), 35, 30, 190);
        }
        
    }

    public void DrawItems(Graphics g, Pen pen)
    {
        for (int i = 0; i <= state.TopItemIndex; i++)
        {
            g.DrawString(state.Array[i].ToString(), new Font("Arial", 15), Brushes.Black, 35 * (i + 1), 115);
        }
    }
}
