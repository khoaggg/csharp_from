namespace csharp_from
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
            this.lblso = new System.Windows.Forms.Label();
            this.btnketqua = new System.Windows.Forms.Button();
            this.txtso = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblso
            // 
            this.lblso.AutoSize = true;
            this.lblso.Location = new System.Drawing.Point(401, 91);
            this.lblso.Name = "lblso";
            this.lblso.Size = new System.Drawing.Size(45, 13);
            this.lblso.TabIndex = 1;
            this.lblso.Text = "nhập số";
            // 
            // btnketqua
            // 
            this.btnketqua.Location = new System.Drawing.Point(527, 151);
            this.btnketqua.Name = "btnketqua";
            this.btnketqua.Size = new System.Drawing.Size(75, 23);
            this.btnketqua.TabIndex = 2;
            this.btnketqua.Text = "tính";
            this.btnketqua.UseVisualStyleBackColor = true;
            this.btnketqua.Click += new System.EventHandler(this.btnketqua_Click);
            // 
            // txtso
            // 
            this.txtso.Location = new System.Drawing.Point(527, 91);
            this.txtso.Name = "txtso";
            this.txtso.Size = new System.Drawing.Size(100, 20);
            this.txtso.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(401, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "ước số";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(139, 328);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(331, 212);
            this.listBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(787, 595);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtso);
            this.Controls.Add(this.btnketqua);
            this.Controls.Add(this.lblso);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnhapso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lsb;
        private System.Windows.Forms.Label lblso;
        private System.Windows.Forms.Button btnketqua;
        private System.Windows.Forms.TextBox txtso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox1;
    }
}