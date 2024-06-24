namespace StackArray_Ishtuganov_Pibd13
{
    partial class FormInfo
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
            labelInfo = new Label();
            SuspendLayout();
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.Location = new Point(41, 36);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(261, 120);
            labelInfo.TabIndex = 0;
            labelInfo.Text = "Программа визуализация\r\nАТД Стек на массиве\r\n\r\nПрограмма позволяет создать стек\r\nРеализованы функции:\r\n-Добавить в стек\r\n-Удалить\r\n-Ввести размер/элементы стека с клавиатуры";
            // 
            // FormInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 214);
            Controls.Add(labelInfo);
            Name = "FormInfo";
            Text = "Форма информации";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelInfo;
    }
}