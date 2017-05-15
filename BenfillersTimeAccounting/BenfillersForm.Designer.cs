namespace BenfillersTimeAccounting
{
    partial class BenfillersForm
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
            this.buttonAddBenfiller = new System.Windows.Forms.Button();
            this.buttonDelBenfiller = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridViewBenfillers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBenfillers)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddBenfiller
            // 
            this.buttonAddBenfiller.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAddBenfiller.Location = new System.Drawing.Point(0, 35);
            this.buttonAddBenfiller.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddBenfiller.Name = "buttonAddBenfiller";
            this.buttonAddBenfiller.Size = new System.Drawing.Size(364, 35);
            this.buttonAddBenfiller.TabIndex = 1;
            this.buttonAddBenfiller.Text = "Добавить официанта";
            this.buttonAddBenfiller.UseVisualStyleBackColor = true;
            this.buttonAddBenfiller.Click += new System.EventHandler(this.buttonAddBenfiller_Click);
            // 
            // buttonDelBenfiller
            // 
            this.buttonDelBenfiller.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDelBenfiller.Location = new System.Drawing.Point(0, 0);
            this.buttonDelBenfiller.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDelBenfiller.Name = "buttonDelBenfiller";
            this.buttonDelBenfiller.Size = new System.Drawing.Size(364, 35);
            this.buttonDelBenfiller.TabIndex = 2;
            this.buttonDelBenfiller.Text = "Удалить официанта";
            this.buttonDelBenfiller.UseVisualStyleBackColor = true;
            this.buttonDelBenfiller.Click += new System.EventHandler(this.buttonDelBenfiller_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridViewBenfillers);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.AutoScrollMinSize = new System.Drawing.Size(60, 0);
            this.splitContainer1.Panel2.Controls.Add(this.buttonAddBenfiller);
            this.splitContainer1.Panel2.Controls.Add(this.buttonDelBenfiller);
            this.splitContainer1.Size = new System.Drawing.Size(642, 523);
            this.splitContainer1.SplitterDistance = 276;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 3;
            // 
            // dataGridViewBenfillers
            // 
            this.dataGridViewBenfillers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBenfillers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewBenfillers.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewBenfillers.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewBenfillers.Name = "dataGridViewBenfillers";
            this.dataGridViewBenfillers.RowTemplate.Height = 33;
            this.dataGridViewBenfillers.Size = new System.Drawing.Size(276, 523);
            this.dataGridViewBenfillers.TabIndex = 1;
            this.dataGridViewBenfillers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBenfillers_CellContentClick_1);
            // 
            // BenfillersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 523);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BenfillersForm";
            this.ShowIcon = false;
            this.Text = "Официанты";
            this.Load += new System.EventHandler(this.BenfillersForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBenfillers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonAddBenfiller;
        private System.Windows.Forms.Button buttonDelBenfiller;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridViewBenfillers;
    }
}