
namespace TestAddin
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allow_deletion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allow_editing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count_CC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type_CC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.title,
            this.tag,
            this.allow_deletion,
            this.allow_editing,
            this.count_CC,
            this.type_CC});
            this.dataGridView1.Location = new System.Drawing.Point(12, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(717, 286);
            this.dataGridView1.TabIndex = 0;
            // 
            // title
            // 
            this.title.DataPropertyName = "title";
            this.title.HeaderText = "Content Control Title";
            this.title.Name = "title";
            this.title.ReadOnly = true;
            // 
            // tag
            // 
            this.tag.DataPropertyName = "tag";
            this.tag.HeaderText = "Content Control Tag";
            this.tag.Name = "tag";
            this.tag.ReadOnly = true;
            // 
            // allow_deletion
            // 
            this.allow_deletion.DataPropertyName = "allow_deletion";
            this.allow_deletion.HeaderText = "Allow Deletion";
            this.allow_deletion.Name = "allow_deletion";
            this.allow_deletion.ReadOnly = true;
            // 
            // allow_editing
            // 
            this.allow_editing.DataPropertyName = "allow_editing";
            this.allow_editing.HeaderText = "Allow Editing";
            this.allow_editing.Name = "allow_editing";
            this.allow_editing.ReadOnly = true;
            // 
            // count_CC
            // 
            this.count_CC.DataPropertyName = "count_CC";
            this.count_CC.HeaderText = "Count of CC in Document";
            this.count_CC.Name = "count_CC";
            this.count_CC.ReadOnly = true;
            // 
            // type_CC
            // 
            this.type_CC.DataPropertyName = "type_CC";
            this.type_CC.HeaderText = "Type of Content Control";
            this.type_CC.Name = "type_CC";
            this.type_CC.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn tag;
        private System.Windows.Forms.DataGridViewTextBoxColumn allow_deletion;
        private System.Windows.Forms.DataGridViewTextBoxColumn allow_editing;
        private System.Windows.Forms.DataGridViewTextBoxColumn count_CC;
        private System.Windows.Forms.DataGridViewTextBoxColumn type_CC;
    }
}