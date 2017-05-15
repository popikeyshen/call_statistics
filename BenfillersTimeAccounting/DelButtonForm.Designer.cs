namespace BenfillersTimeAccounting
{
    partial class DelButtonForm
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
            this.comboBoxButtonID = new System.Windows.Forms.ComboBox();
            this.labelBtnID = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxButtonID
            // 
            this.comboBoxButtonID.FormattingEnabled = true;
            this.comboBoxButtonID.Location = new System.Drawing.Point(122, 39);
            this.comboBoxButtonID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxButtonID.Name = "comboBoxButtonID";
            this.comboBoxButtonID.Size = new System.Drawing.Size(109, 21);
            this.comboBoxButtonID.TabIndex = 0;
            this.comboBoxButtonID.SelectedIndexChanged += new System.EventHandler(this.comboBoxButtonID_SelectedIndexChanged);
            // 
            // labelBtnID
            // 
            this.labelBtnID.AutoSize = true;
            this.labelBtnID.Location = new System.Drawing.Point(32, 41);
            this.labelBtnID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBtnID.Name = "labelBtnID";
            this.labelBtnID.Size = new System.Drawing.Size(83, 13);
            this.labelBtnID.TabIndex = 1;
            this.labelBtnID.Text = "Номер кнопки:";
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(35, 85);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(81, 27);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(148, 85);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(81, 27);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // DelButtonForm
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(260, 147);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelBtnID);
            this.Controls.Add(this.comboBoxButtonID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DelButtonForm";
            this.Text = "Удалить кнопку";
            this.Load += new System.EventHandler(this.DelButtonForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxButtonID;
        private System.Windows.Forms.Label labelBtnID;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
    }
}