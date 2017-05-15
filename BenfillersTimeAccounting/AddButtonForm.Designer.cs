namespace BenfillersTimeAccounting
{
    partial class AddButtonForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxMacAddress = new System.Windows.Forms.TextBox();
            this.textBoxButtonNumber = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.comboBoxBenfiller = new System.Windows.Forms.ComboBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBoxButtonTypes = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(46, 45);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 35);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "1) Нажмите кнопку";
            // 
            // textBoxMacAddress
            // 
            this.textBoxMacAddress.Location = new System.Drawing.Point(240, 45);
            this.textBoxMacAddress.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMacAddress.Name = "textBoxMacAddress";
            this.textBoxMacAddress.ReadOnly = true;
            this.textBoxMacAddress.Size = new System.Drawing.Size(114, 20);
            this.textBoxMacAddress.TabIndex = 1;
            this.textBoxMacAddress.TextChanged += new System.EventHandler(this.textBoxMacAddress_TextChanged);
            // 
            // textBoxButtonNumber
            // 
            this.textBoxButtonNumber.Location = new System.Drawing.Point(240, 83);
            this.textBoxButtonNumber.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxButtonNumber.Name = "textBoxButtonNumber";
            this.textBoxButtonNumber.Size = new System.Drawing.Size(114, 20);
            this.textBoxButtonNumber.TabIndex = 3;
            this.textBoxButtonNumber.TextChanged += new System.EventHandler(this.textBoxButtonNumber_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(46, 83);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(181, 49);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "2) Введите номер, изображенный на кнопке";
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(210, 331);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(65, 33);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(286, 331);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(65, 33);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // comboBoxBenfiller
            // 
            this.comboBoxBenfiller.FormattingEnabled = true;
            this.comboBoxBenfiller.Location = new System.Drawing.Point(240, 204);
            this.comboBoxBenfiller.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxBenfiller.Name = "comboBoxBenfiller";
            this.comboBoxBenfiller.Size = new System.Drawing.Size(114, 21);
            this.comboBoxBenfiller.TabIndex = 15;
            this.comboBoxBenfiller.SelectedIndexChanged += new System.EventHandler(this.comboBoxBenfiller_SelectedIndexChanged);
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.Control;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox7.Location = new System.Drawing.Point(46, 204);
            this.textBox7.Margin = new System.Windows.Forms.Padding(2);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(181, 25);
            this.textBox7.TabIndex = 14;
            this.textBox7.Text = "4) Выберите официанта";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Control;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox5.Location = new System.Drawing.Point(46, 243);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(181, 25);
            this.textBox5.TabIndex = 17;
            this.textBox5.Text = "5) Выберите кухню";
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(240, 243);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(114, 21);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(46, 148);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(181, 25);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = "3) Выберите тип кнопки";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // comboBoxButtonTypes
            // 
            this.comboBoxButtonTypes.FormattingEnabled = true;
            this.comboBoxButtonTypes.Location = new System.Drawing.Point(240, 148);
            this.comboBoxButtonTypes.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxButtonTypes.Name = "comboBoxButtonTypes";
            this.comboBoxButtonTypes.Size = new System.Drawing.Size(114, 21);
            this.comboBoxButtonTypes.TabIndex = 11;
            this.comboBoxButtonTypes.SelectedIndexChanged += new System.EventHandler(this.comboBoxButtonTypes_SelectedIndexChanged);
            // 
            // AddButtonForm
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(394, 397);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.comboBoxBenfiller);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.comboBoxButtonTypes);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxButtonNumber);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBoxMacAddress);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddButtonForm";
            this.Text = "Добавить новую кнопку";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddButtonForm_FormClosed);
            this.Load += new System.EventHandler(this.AddButtonForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxMacAddress;
        private System.Windows.Forms.TextBox textBoxButtonNumber;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ComboBox comboBoxBenfiller;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBoxButtonTypes;
    }
}