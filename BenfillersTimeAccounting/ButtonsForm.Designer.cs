namespace BenfillersTimeAccounting
{
    partial class ButtonsForm
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
            this.buttonAddBtn = new System.Windows.Forms.Button();
            this.dataGridViewButtons = new System.Windows.Forms.DataGridView();
            this.buttonDelBtn = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewButtons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAddBtn
            // 
            this.buttonAddBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAddBtn.Location = new System.Drawing.Point(0, 0);
            this.buttonAddBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAddBtn.Name = "buttonAddBtn";
            this.buttonAddBtn.Size = new System.Drawing.Size(255, 24);
            this.buttonAddBtn.TabIndex = 0;
            this.buttonAddBtn.Text = "Добавить кнопку";
            this.buttonAddBtn.UseVisualStyleBackColor = true;
            this.buttonAddBtn.Click += new System.EventHandler(this.buttonAddBtn_Click);
            // 
            // dataGridViewButtons
            // 
            this.dataGridViewButtons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewButtons.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewButtons.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewButtons.Name = "dataGridViewButtons";
            this.dataGridViewButtons.Size = new System.Drawing.Size(457, 450);
            this.dataGridViewButtons.TabIndex = 1;
            this.dataGridViewButtons.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewButtons_CellContentClick);
            // 
            // buttonDelBtn
            // 
            this.buttonDelBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDelBtn.Location = new System.Drawing.Point(0, 24);
            this.buttonDelBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDelBtn.Name = "buttonDelBtn";
            this.buttonDelBtn.Size = new System.Drawing.Size(255, 24);
            this.buttonDelBtn.TabIndex = 2;
            this.buttonDelBtn.Text = "Удалить кнопку";
            this.buttonDelBtn.UseVisualStyleBackColor = true;
            this.buttonDelBtn.Click += new System.EventHandler(this.buttonDelBtn_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridViewButtons);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.AutoScrollMinSize = new System.Drawing.Size(60, 0);
            this.splitContainer1.Panel2.Controls.Add(this.buttonDelBtn);
            this.splitContainer1.Panel2.Controls.Add(this.buttonAddBtn);
            this.splitContainer1.Size = new System.Drawing.Size(714, 450);
            this.splitContainer1.SplitterDistance = 457;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 3;
            // 
            // ButtonsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 450);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ButtonsForm";
            this.ShowIcon = false;
            this.Text = "Кнопки";
            this.Load += new System.EventHandler(this.ButtonsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewButtons)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddBtn;
        private System.Windows.Forms.DataGridView dataGridViewButtons;
        private System.Windows.Forms.Button buttonDelBtn;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}