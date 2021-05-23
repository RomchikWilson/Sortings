namespace Sortings
{
    partial class Sortings
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sortings));
            this.textBox_Console = new System.Windows.Forms.TextBox();
            this.button_Random = new System.Windows.Forms.Button();
            this.textBox_IncomingData = new System.Windows.Forms.TextBox();
            this.radioButton_BubbleSort = new System.Windows.Forms.RadioButton();
            this.groupBox_Types = new System.Windows.Forms.GroupBox();
            this.groupBox_Output = new System.Windows.Forms.GroupBox();
            this.label_Answer = new System.Windows.Forms.Label();
            this.textBox_Answer = new System.Windows.Forms.TextBox();
            this.label_Console = new System.Windows.Forms.Label();
            this.groupBox_Input = new System.Windows.Forms.GroupBox();
            this.label_IncomingData = new System.Windows.Forms.Label();
            this.button_Sort = new System.Windows.Forms.Button();
            this.radioButton_CombSort = new System.Windows.Forms.RadioButton();
            this.radioButton_ShakerSort = new System.Windows.Forms.RadioButton();
            this.groupBox_Types.SuspendLayout();
            this.groupBox_Output.SuspendLayout();
            this.groupBox_Input.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_Console
            // 
            this.textBox_Console.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.textBox_Console.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Console.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_Console.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Console.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textBox_Console.Location = new System.Drawing.Point(10, 46);
            this.textBox_Console.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Console.Multiline = true;
            this.textBox_Console.Name = "textBox_Console";
            this.textBox_Console.ReadOnly = true;
            this.textBox_Console.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Console.Size = new System.Drawing.Size(393, 372);
            this.textBox_Console.TabIndex = 0;
            // 
            // button_Random
            // 
            this.button_Random.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Random.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_Random.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Random.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Random.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_Random.Location = new System.Drawing.Point(317, 46);
            this.button_Random.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Random.Name = "button_Random";
            this.button_Random.Size = new System.Drawing.Size(87, 26);
            this.button_Random.TabIndex = 1;
            this.button_Random.Text = "Random";
            this.button_Random.UseMnemonic = false;
            this.button_Random.UseVisualStyleBackColor = false;
            // 
            // textBox_IncomingData
            // 
            this.textBox_IncomingData.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_IncomingData.Location = new System.Drawing.Point(10, 46);
            this.textBox_IncomingData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_IncomingData.MaxLength = 20;
            this.textBox_IncomingData.Name = "textBox_IncomingData";
            this.textBox_IncomingData.Size = new System.Drawing.Size(301, 31);
            this.textBox_IncomingData.TabIndex = 2;
            this.textBox_IncomingData.Text = "12543689754682135964";
            this.textBox_IncomingData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radioButton_BubbleSort
            // 
            this.radioButton_BubbleSort.AutoSize = true;
            this.radioButton_BubbleSort.Checked = true;
            this.radioButton_BubbleSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton_BubbleSort.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_BubbleSort.Location = new System.Drawing.Point(25, 38);
            this.radioButton_BubbleSort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton_BubbleSort.Name = "radioButton_BubbleSort";
            this.radioButton_BubbleSort.Size = new System.Drawing.Size(85, 28);
            this.radioButton_BubbleSort.TabIndex = 3;
            this.radioButton_BubbleSort.TabStop = true;
            this.radioButton_BubbleSort.Text = "Bubble";
            this.radioButton_BubbleSort.UseVisualStyleBackColor = true;
            // 
            // groupBox_Types
            // 
            this.groupBox_Types.Controls.Add(this.radioButton_CombSort);
            this.groupBox_Types.Controls.Add(this.radioButton_ShakerSort);
            this.groupBox_Types.Controls.Add(this.radioButton_BubbleSort);
            this.groupBox_Types.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_Types.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox_Types.Location = new System.Drawing.Point(6, 80);
            this.groupBox_Types.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_Types.Name = "groupBox_Types";
            this.groupBox_Types.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_Types.Size = new System.Drawing.Size(401, 367);
            this.groupBox_Types.TabIndex = 4;
            this.groupBox_Types.TabStop = false;
            this.groupBox_Types.Text = "Types sorting";
            // 
            // groupBox_Output
            // 
            this.groupBox_Output.Controls.Add(this.label_Answer);
            this.groupBox_Output.Controls.Add(this.textBox_Answer);
            this.groupBox_Output.Controls.Add(this.label_Console);
            this.groupBox_Output.Controls.Add(this.textBox_Console);
            this.groupBox_Output.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_Output.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox_Output.Location = new System.Drawing.Point(431, 12);
            this.groupBox_Output.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_Output.Name = "groupBox_Output";
            this.groupBox_Output.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_Output.Size = new System.Drawing.Size(413, 485);
            this.groupBox_Output.TabIndex = 7;
            this.groupBox_Output.TabStop = false;
            this.groupBox_Output.Text = "Output";
            // 
            // label_Answer
            // 
            this.label_Answer.AutoSize = true;
            this.label_Answer.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Answer.Location = new System.Drawing.Point(6, 428);
            this.label_Answer.Name = "label_Answer";
            this.label_Answer.Size = new System.Drawing.Size(70, 24);
            this.label_Answer.TabIndex = 8;
            this.label_Answer.Text = "Answer";
            // 
            // textBox_Answer
            // 
            this.textBox_Answer.Enabled = false;
            this.textBox_Answer.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Answer.Location = new System.Drawing.Point(10, 451);
            this.textBox_Answer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Answer.MaxLength = 20;
            this.textBox_Answer.Name = "textBox_Answer";
            this.textBox_Answer.Size = new System.Drawing.Size(393, 31);
            this.textBox_Answer.TabIndex = 7;
            this.textBox_Answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_Console
            // 
            this.label_Console.AutoSize = true;
            this.label_Console.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Console.Location = new System.Drawing.Point(6, 23);
            this.label_Console.Name = "label_Console";
            this.label_Console.Size = new System.Drawing.Size(72, 24);
            this.label_Console.TabIndex = 1;
            this.label_Console.Text = "Console";
            // 
            // groupBox_Input
            // 
            this.groupBox_Input.Controls.Add(this.label_IncomingData);
            this.groupBox_Input.Controls.Add(this.button_Sort);
            this.groupBox_Input.Controls.Add(this.groupBox_Types);
            this.groupBox_Input.Controls.Add(this.button_Random);
            this.groupBox_Input.Controls.Add(this.textBox_IncomingData);
            this.groupBox_Input.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_Input.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox_Input.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Input.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_Input.Name = "groupBox_Input";
            this.groupBox_Input.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_Input.Size = new System.Drawing.Size(413, 485);
            this.groupBox_Input.TabIndex = 8;
            this.groupBox_Input.TabStop = false;
            this.groupBox_Input.Text = "Input";
            // 
            // label_IncomingData
            // 
            this.label_IncomingData.AutoSize = true;
            this.label_IncomingData.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_IncomingData.Location = new System.Drawing.Point(6, 23);
            this.label_IncomingData.Name = "label_IncomingData";
            this.label_IncomingData.Size = new System.Drawing.Size(123, 24);
            this.label_IncomingData.TabIndex = 9;
            this.label_IncomingData.Text = "Incoming data";
            // 
            // button_Sort
            // 
            this.button_Sort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Sort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_Sort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Sort.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Sort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_Sort.Location = new System.Drawing.Point(10, 451);
            this.button_Sort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Sort.Name = "button_Sort";
            this.button_Sort.Size = new System.Drawing.Size(394, 26);
            this.button_Sort.TabIndex = 5;
            this.button_Sort.Text = "Sort";
            this.button_Sort.UseMnemonic = false;
            this.button_Sort.UseVisualStyleBackColor = false;
            this.button_Sort.Click += new System.EventHandler(this.button_Sort_Click);
            // 
            // radioButton_CombSort
            // 
            this.radioButton_CombSort.AutoSize = true;
            this.radioButton_CombSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton_CombSort.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_CombSort.Location = new System.Drawing.Point(25, 105);
            this.radioButton_CombSort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton_CombSort.Name = "radioButton_CombSort";
            this.radioButton_CombSort.Size = new System.Drawing.Size(73, 28);
            this.radioButton_CombSort.TabIndex = 7;
            this.radioButton_CombSort.Text = "Comb";
            this.radioButton_CombSort.UseVisualStyleBackColor = true;
            // 
            // radioButton_ShakerSort
            // 
            this.radioButton_ShakerSort.AutoSize = true;
            this.radioButton_ShakerSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton_ShakerSort.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_ShakerSort.Location = new System.Drawing.Point(25, 74);
            this.radioButton_ShakerSort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton_ShakerSort.Name = "radioButton_ShakerSort";
            this.radioButton_ShakerSort.Size = new System.Drawing.Size(88, 28);
            this.radioButton_ShakerSort.TabIndex = 6;
            this.radioButton_ShakerSort.Text = "Shaker";
            this.radioButton_ShakerSort.UseVisualStyleBackColor = true;
            // 
            // Sortings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(856, 506);
            this.Controls.Add(this.groupBox_Input);
            this.Controls.Add(this.groupBox_Output);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Sortings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sortings";
            this.groupBox_Types.ResumeLayout(false);
            this.groupBox_Types.PerformLayout();
            this.groupBox_Output.ResumeLayout(false);
            this.groupBox_Output.PerformLayout();
            this.groupBox_Input.ResumeLayout(false);
            this.groupBox_Input.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Console;
        private System.Windows.Forms.Button button_Random;
        private System.Windows.Forms.TextBox textBox_IncomingData;
        private System.Windows.Forms.RadioButton radioButton_BubbleSort;
        private System.Windows.Forms.GroupBox groupBox_Types;
        private System.Windows.Forms.GroupBox groupBox_Output;
        private System.Windows.Forms.Label label_Console;
        private System.Windows.Forms.TextBox textBox_Answer;
        private System.Windows.Forms.Label label_Answer;
        private System.Windows.Forms.GroupBox groupBox_Input;
        private System.Windows.Forms.Button button_Sort;
        private System.Windows.Forms.Label label_IncomingData;
        private System.Windows.Forms.RadioButton radioButton_CombSort;
        private System.Windows.Forms.RadioButton radioButton_ShakerSort;
    }
}

