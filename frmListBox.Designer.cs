namespace BAITAPTHUCHANH05C
{
    partial class frmListBox
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
            this.lst_Trai = new System.Windows.Forms.ListBox();
            this.lst_Phai = new System.Windows.Forms.ListBox();
            this.btnQuaPhai = new System.Windows.Forms.Button();
            this.btnQuaPhaiAll = new System.Windows.Forms.Button();
            this.btnQuaTrai = new System.Windows.Forms.Button();
            this.btnQuaTraiAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lst_Trai
            // 
            this.lst_Trai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_Trai.FormattingEnabled = true;
            this.lst_Trai.ItemHeight = 20;
            this.lst_Trai.Items.AddRange(new object[] {
            "Cốc",
            "Ổi",
            "Xoài",
            "Me",
            "Bưởi",
            "Cam"});
            this.lst_Trai.Location = new System.Drawing.Point(62, 33);
            this.lst_Trai.Name = "lst_Trai";
            this.lst_Trai.Size = new System.Drawing.Size(288, 664);
            this.lst_Trai.TabIndex = 0;
            // 
            // lst_Phai
            // 
            this.lst_Phai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_Phai.FormattingEnabled = true;
            this.lst_Phai.ItemHeight = 20;
            this.lst_Phai.Location = new System.Drawing.Point(720, 52);
            this.lst_Phai.Name = "lst_Phai";
            this.lst_Phai.Size = new System.Drawing.Size(222, 664);
            this.lst_Phai.TabIndex = 1;
            // 
            // btnQuaPhai
            // 
            this.btnQuaPhai.Location = new System.Drawing.Point(468, 52);
            this.btnQuaPhai.Name = "btnQuaPhai";
            this.btnQuaPhai.Size = new System.Drawing.Size(163, 112);
            this.btnQuaPhai.TabIndex = 2;
            this.btnQuaPhai.Text = ">";
            this.btnQuaPhai.UseVisualStyleBackColor = true;
            this.btnQuaPhai.Click += new System.EventHandler(this.btnQuaPhai_Click);
            // 
            // btnQuaPhaiAll
            // 
            this.btnQuaPhaiAll.Location = new System.Drawing.Point(468, 202);
            this.btnQuaPhaiAll.Name = "btnQuaPhaiAll";
            this.btnQuaPhaiAll.Size = new System.Drawing.Size(163, 112);
            this.btnQuaPhaiAll.TabIndex = 3;
            this.btnQuaPhaiAll.Text = ">>";
            this.btnQuaPhaiAll.UseVisualStyleBackColor = true;
            this.btnQuaPhaiAll.Click += new System.EventHandler(this.btnQuaPhaiAll_Click);
            // 
            // btnQuaTrai
            // 
            this.btnQuaTrai.Location = new System.Drawing.Point(468, 371);
            this.btnQuaTrai.Name = "btnQuaTrai";
            this.btnQuaTrai.Size = new System.Drawing.Size(163, 112);
            this.btnQuaTrai.TabIndex = 4;
            this.btnQuaTrai.Text = "<";
            this.btnQuaTrai.UseVisualStyleBackColor = true;
            this.btnQuaTrai.Click += new System.EventHandler(this.btnQuaTrai_Click);
            // 
            // btnQuaTraiAll
            // 
            this.btnQuaTraiAll.Location = new System.Drawing.Point(468, 549);
            this.btnQuaTraiAll.Name = "btnQuaTraiAll";
            this.btnQuaTraiAll.Size = new System.Drawing.Size(163, 112);
            this.btnQuaTraiAll.TabIndex = 5;
            this.btnQuaTraiAll.Text = "<<";
            this.btnQuaTraiAll.UseVisualStyleBackColor = true;
            this.btnQuaTraiAll.Click += new System.EventHandler(this.btnQuaTraiAll_Click);
            // 
            // frmListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1537, 792);
            this.Controls.Add(this.btnQuaTraiAll);
            this.Controls.Add(this.btnQuaTrai);
            this.Controls.Add(this.btnQuaPhaiAll);
            this.Controls.Add(this.btnQuaPhai);
            this.Controls.Add(this.lst_Phai);
            this.Controls.Add(this.lst_Trai);
            this.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lst_Trai;
        private System.Windows.Forms.ListBox lst_Phai;
        private System.Windows.Forms.Button btnQuaPhai;
        private System.Windows.Forms.Button btnQuaPhaiAll;
        private System.Windows.Forms.Button btnQuaTrai;
        private System.Windows.Forms.Button btnQuaTraiAll;
    }
}

