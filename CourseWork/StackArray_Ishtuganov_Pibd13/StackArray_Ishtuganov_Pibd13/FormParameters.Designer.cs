namespace StackArray_Ishtuganov_Pibd13
{
    partial class FormParameters
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxItems = new TextBox();
            textBoxSize = new TextBox();
            buttonCreateStack = new Button();
            labelSize = new Label();
            checkBoxItems = new CheckBox();
            SuspendLayout();
            // 
            // textBoxItems
            // 
            textBoxItems.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxItems.Enabled = false;
            textBoxItems.Location = new Point(20, 76);
            textBoxItems.Name = "textBoxItems";
            textBoxItems.Size = new Size(368, 23);
            textBoxItems.TabIndex = 0;
            // 
            // textBoxSize
            // 
            textBoxSize.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxSize.Location = new Point(81, 7);
            textBoxSize.Name = "textBoxSize";
            textBoxSize.Size = new Size(100, 23);
            textBoxSize.TabIndex = 1;
            // 
            // buttonCreateStack
            // 
            buttonCreateStack.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCreateStack.Location = new Point(129, 115);
            buttonCreateStack.Name = "buttonCreateStack";
            buttonCreateStack.Size = new Size(159, 38);
            buttonCreateStack.TabIndex = 2;
            buttonCreateStack.Text = "Создать";
            buttonCreateStack.UseVisualStyleBackColor = true;
            buttonCreateStack.Click += ButtonCreateStack_Click;
            // 
            // labelSize
            // 
            labelSize.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelSize.AutoSize = true;
            labelSize.Location = new Point(20, 15);
            labelSize.Name = "labelSize";
            labelSize.Size = new Size(47, 15);
            labelSize.TabIndex = 3;
            labelSize.Text = "Размер";
            // 
            // checkBoxItems
            // 
            checkBoxItems.AutoSize = true;
            checkBoxItems.Location = new Point(20, 51);
            checkBoxItems.Name = "checkBoxItems";
            checkBoxItems.Size = new Size(82, 19);
            checkBoxItems.TabIndex = 5;
            checkBoxItems.Text = "Элементы";
            checkBoxItems.UseVisualStyleBackColor = true;
            checkBoxItems.CheckedChanged += CheckBoxItems_CheckedChanged;
            // 
            // FormParameters
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 183);
            Controls.Add(checkBoxItems);
            Controls.Add(labelSize);
            Controls.Add(buttonCreateStack);
            Controls.Add(textBoxSize);
            Controls.Add(textBoxItems);
            Name = "FormParameters";
            Text = "Форма для ввода";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxItems;
        private TextBox textBoxSize;
        private Button buttonCreateStack;
        private Label labelSize;
        private CheckBox checkBoxItems;
    }
}