namespace CSharp_bangcuuchuong
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
            this.lbsKetqua = new System.Windows.Forms.ListBox();
            this.txtSo = new System.Windows.Forms.TextBox();
            this.btnXem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbsKetqua
            // 
            this.lbsKetqua.FormattingEnabled = true;
            this.lbsKetqua.ItemHeight = 18;
            this.lbsKetqua.Location = new System.Drawing.Point(67, 259);
            this.lbsKetqua.Name = "lbsKetqua";
            this.lbsKetqua.Size = new System.Drawing.Size(940, 310);
            this.lbsKetqua.TabIndex = 0;
            this.lbsKetqua.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txtSo
            // 
            this.txtSo.Location = new System.Drawing.Point(67, 201);
            this.txtSo.Name = "txtSo";
            this.txtSo.Size = new System.Drawing.Size(552, 26);
            this.txtSo.TabIndex = 1;
            this.txtSo.TextChanged += new System.EventHandler(this.txtSo_TextChanged);
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(676, 201);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(263, 40);
            this.btnXem.TabIndex = 2;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(642, 77);
            this.label1.TabIndex = 3;
            this.label1.Text = "BẢNG CỬU CHƯƠNG ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(944, 58);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bạn muốn hiển thị bảng cửu chương mấy ?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 623);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.txtSo);
            this.Controls.Add(this.lbsKetqua);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbsKetqua;
        private System.Windows.Forms.TextBox txtSo;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

