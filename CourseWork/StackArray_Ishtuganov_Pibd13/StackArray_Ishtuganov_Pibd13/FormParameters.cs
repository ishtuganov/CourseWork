using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StackArray_Ishtuganov_Pibd13
{
    public partial class FormParameters : Form
    {
        private Parameters _parameters;

        private event Action<Parameters> _parametersChanged;

        public FormParameters()
        {
            InitializeComponent();
        }

        public void AddEvent(Action<Parameters> action)
        {
            _parametersChanged += action;
        }

        private void ButtonCreateStack_Click(object sender, EventArgs e)
        {
            // TODO

            int size = 0;
            int[] items;
            int topItemIndex = -1;
            if (!checkBoxItems.Checked)
            {
                size = int.Parse(textBoxSize.Text);
                items = new int[size];
            }
            else
            {
                items = ParseTextBoxItems();
                topItemIndex = items.Length - 1;
            }
            _parameters = new Parameters(items, topItemIndex);
            _parametersChanged.Invoke(_parameters);
            Close();
        }

        private int[] ParseTextBoxItems()
        {
            string[] stringNums = textBoxItems.Text.Split(' ');
            int[] intNums = new int[stringNums.Length];
            for (int i = 0; i < stringNums.Length; i++)
            {
                intNums[i] = int.Parse(stringNums[i]);
            }
            return intNums;
        }

        private void CheckBoxItems_CheckedChanged(object sender, EventArgs e)
        {
            textBoxItems.Enabled = checkBoxItems.Checked;
            textBoxSize.Enabled = !checkBoxItems.Checked;
        }
    }
}
