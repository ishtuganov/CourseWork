using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace StackArray_Ishtuganov_Pibd13
{
    public partial class FormMain : Form
    {
        private StackVisualizer _visualizer = new StackVisualizer();
        private Manager _manager;
        public FormMain()
        {
            InitializeComponent();
        }

        private void ButtonOpenInputForm_Click(object sender, EventArgs e)
        {
            FormParameters form = new();
            form.AddEvent(CreateStack);
            form.Show();
        }

        private void CreateStack(Parameters parameters)
        {
            _visualizer = new StackVisualizer();
            _manager = new Manager(parameters);
            _manager.StateStorage.AddState(_manager.Stack.GetState());
            pictureBoxDrawingStack.Image = ShowStack(_manager.Stack.GetState());

        }

        private Bitmap? ShowStack(State state)
        {
            Bitmap bitmap = new(pictureBoxDrawingStack.Width, pictureBoxDrawingStack.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            _visualizer.Visualize(graphics, state);
            return bitmap;
        }

        private void ButtonPush_Click(object sender, EventArgs e)
        {
            try
            {
                _manager.Stack.Push(int.Parse(textBoxPush.Text));
                _manager.StateStorage.AddState(_manager.Stack.GetState());
                textBoxPush.Text = string.Empty;
                pictureBoxDrawingStack.Image = ShowStack(_manager.Stack.GetState());
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Стек полон");
            }
            catch (Exception)
            {
                MessageBox.Show("Некорректное значение");
            }
        }

        private void ButtonPop_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxOutput.Text = _manager.Stack.Pop().ToString();
                _manager.StateStorage.AddState(_manager.Stack.GetState());
                pictureBoxDrawingStack.Image = ShowStack(_manager.Stack.GetState());
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Стек пуст");
            }
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInfo info = new FormInfo();
            info.Show();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_manager == null)
            {
                MessageBox.Show("Данные для сохранения отсутствуют", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _manager.StateStorage.SaveToFile(saveFileDialog.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message, "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Parameters parameters = new Parameters(new int[1], 0);
                    _manager = new Manager(parameters);
                    _manager.StateStorage.LoadFromFile(openFileDialog.FileName);
                    _manager.StateStorage.Reset();
                    ShowStack(_manager.Stack.GetState());
                    MessageBox.Show("Загрузка прошла успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message, "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonPreviousState_Click(object sender, EventArgs e)
        {
            State state = _manager.StateStorage.GetPreviousState();
            pictureBoxDrawingStack.Image = ShowStack(state);
        }

        private void buttonNextState_Click(object sender, EventArgs e)
        {
            State state = _manager.StateStorage.GetNextState();
            pictureBoxDrawingStack.Image = ShowStack(state);
        }
    }
}
