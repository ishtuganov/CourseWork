namespace StackArray_Ishtuganov_Pibd13
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBoxDrawingStack = new PictureBox();
            buttonOpenInputForm = new Button();
            buttonPush = new Button();
            buttonPop = new Button();
            textBoxOutput = new TextBox();
            labelOutput = new Label();
            buttonPreviousState = new Button();
            buttonNextState = new Button();
            textBoxPush = new TextBox();
            ToolStripMenuItem = new ToolStripMenuItem();
            infoToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            saveFileDialog = new SaveFileDialog();
            openFileDialog = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDrawingStack).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxDrawingStack
            // 
            pictureBoxDrawingStack.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBoxDrawingStack.Location = new Point(12, 27);
            pictureBoxDrawingStack.Name = "pictureBoxDrawingStack";
            pictureBoxDrawingStack.Size = new Size(776, 309);
            pictureBoxDrawingStack.TabIndex = 0;
            pictureBoxDrawingStack.TabStop = false;
            // 
            // buttonOpenInputForm
            // 
            buttonOpenInputForm.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonOpenInputForm.Location = new Point(25, 342);
            buttonOpenInputForm.Name = "buttonOpenInputForm";
            buttonOpenInputForm.Size = new Size(95, 42);
            buttonOpenInputForm.TabIndex = 1;
            buttonOpenInputForm.Text = "Создать стек";
            buttonOpenInputForm.UseVisualStyleBackColor = true;
            buttonOpenInputForm.Click += ButtonOpenInputForm_Click;
            // 
            // buttonPush
            // 
            buttonPush.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonPush.Location = new Point(303, 343);
            buttonPush.Name = "buttonPush";
            buttonPush.Size = new Size(75, 40);
            buttonPush.TabIndex = 2;
            buttonPush.Text = "Push";
            buttonPush.UseVisualStyleBackColor = true;
            buttonPush.Click += ButtonPush_Click;
            // 
            // buttonPop
            // 
            buttonPop.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonPop.Location = new Point(514, 344);
            buttonPop.Name = "buttonPop";
            buttonPop.Size = new Size(74, 40);
            buttonPop.TabIndex = 3;
            buttonPop.Text = "Pop";
            buttonPop.UseVisualStyleBackColor = true;
            buttonPop.Click += ButtonPop_Click;
            // 
            // textBoxOutput
            // 
            textBoxOutput.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxOutput.Enabled = false;
            textBoxOutput.Location = new Point(594, 353);
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.Size = new Size(90, 23);
            textBoxOutput.TabIndex = 4;
            // 
            // labelOutput
            // 
            labelOutput.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelOutput.AutoSize = true;
            labelOutput.Location = new Point(619, 379);
            labelOutput.Name = "labelOutput";
            labelOutput.Size = new Size(42, 15);
            labelOutput.TabIndex = 5;
            labelOutput.Text = "Вывод";
            // 
            // buttonPreviousState
            // 
            buttonPreviousState.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonPreviousState.Location = new Point(184, 409);
            buttonPreviousState.Name = "buttonPreviousState";
            buttonPreviousState.Size = new Size(194, 23);
            buttonPreviousState.TabIndex = 6;
            buttonPreviousState.Text = "Предыдущее состояние";
            buttonPreviousState.UseVisualStyleBackColor = true;
            // 
            // buttonNextState
            // 
            buttonNextState.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonNextState.Location = new Point(396, 409);
            buttonNextState.Name = "buttonNextState";
            buttonNextState.Size = new Size(194, 23);
            buttonNextState.TabIndex = 7;
            buttonNextState.Text = "Следующее состояние";
            buttonNextState.UseVisualStyleBackColor = true;
            // 
            // textBoxPush
            // 
            textBoxPush.Location = new Point(209, 353);
            textBoxPush.Name = "textBoxPush";
            textBoxPush.Size = new Size(88, 23);
            textBoxPush.TabIndex = 8;
            // 
            // ToolStripMenuItem
            // 
            ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { infoToolStripMenuItem, saveToolStripMenuItem, loadToolStripMenuItem });
            ToolStripMenuItem.Name = "ToolStripMenuItem";
            ToolStripMenuItem.Size = new Size(53, 20);
            ToolStripMenuItem.Text = "Меню";
            // 
            // infoToolStripMenuItem
            // 
            infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            infoToolStripMenuItem.Size = new Size(133, 22);
            infoToolStripMenuItem.Text = "Инфо";
            infoToolStripMenuItem.Click += infoToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(133, 22);
            saveToolStripMenuItem.Text = "Сохранить";
            saveToolStripMenuItem.Click += SaveToolStripMenuItem_Click;
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(180, 22);
            loadToolStripMenuItem.Text = "Загрузить";
            loadToolStripMenuItem.Click += LoadToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 458);
            Controls.Add(textBoxPush);
            Controls.Add(buttonNextState);
            Controls.Add(buttonPreviousState);
            Controls.Add(labelOutput);
            Controls.Add(textBoxOutput);
            Controls.Add(buttonPop);
            Controls.Add(buttonPush);
            Controls.Add(buttonOpenInputForm);
            Controls.Add(pictureBoxDrawingStack);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormMain";
            Text = "Главная форма";
            ((System.ComponentModel.ISupportInitialize)pictureBoxDrawingStack).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxDrawingStack;
        private Button buttonOpenInputForm;
        private Button buttonPush;
        private Button buttonPop;
        private TextBox textBoxOutput;
        private Label labelOutput;
        private Button buttonPreviousState;
        private Button buttonNextState;
        private TextBox textBoxPush;
        private ToolStripMenuItem ToolStripMenuItem;
        private ToolStripMenuItem infoToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private MenuStrip menuStrip1;
        private SaveFileDialog saveFileDialog;
        private OpenFileDialog openFileDialog;
    }
}
