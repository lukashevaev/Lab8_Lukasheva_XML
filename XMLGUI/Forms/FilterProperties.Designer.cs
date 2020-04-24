namespace XMLGUI.Forms
{
    partial class FilterProperties
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
            this.paramTxtBox = new System.Windows.Forms.TextBox();
            this.btn_surname = new System.Windows.Forms.Button();
            this.btn_gr_code = new System.Windows.Forms.Button();
            this.btn_coursework = new System.Windows.Forms.Button();
            this.btn_cu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // paramTxtBox
            // 
            this.paramTxtBox.Location = new System.Drawing.Point(48, 40);
            this.paramTxtBox.Name = "paramTxtBox";
            this.paramTxtBox.Size = new System.Drawing.Size(318, 22);
            this.paramTxtBox.TabIndex = 0;
            // 
            // btn_surname
            // 
            this.btn_surname.Location = new System.Drawing.Point(10, 79);
            this.btn_surname.Name = "btn_surname";
            this.btn_surname.Size = new System.Drawing.Size(88, 43);
            this.btn_surname.TabIndex = 6;
            this.btn_surname.Text = "surname";
            this.btn_surname.UseVisualStyleBackColor = true;
            this.btn_surname.Click += new System.EventHandler(this.btn_surname_Click);
            // 
            // btn_gr_code
            // 
            this.btn_gr_code.Location = new System.Drawing.Point(104, 79);
            this.btn_gr_code.Name = "btn_gr_code";
            this.btn_gr_code.Size = new System.Drawing.Size(92, 43);
            this.btn_gr_code.TabIndex = 5;
            this.btn_gr_code.Text = "gr_code";
            this.btn_gr_code.UseVisualStyleBackColor = true;
            this.btn_gr_code.Click += new System.EventHandler(this.Btn_gr_code_Click_1);
            // 
            // btn_coursework
            // 
            this.btn_coursework.Location = new System.Drawing.Point(202, 78);
            this.btn_coursework.Name = "btn_coursework";
            this.btn_coursework.Size = new System.Drawing.Size(92, 44);
            this.btn_coursework.TabIndex = 4;
            this.btn_coursework.Text = "coursework";
            this.btn_coursework.UseVisualStyleBackColor = true;
            this.btn_coursework.Click += new System.EventHandler(this.btn_coursework_Click);
            // 
            // btn_cu
            // 
            this.btn_cu.Location = new System.Drawing.Point(300, 78);
            this.btn_cu.Name = "btn_cu";
            this.btn_cu.Size = new System.Drawing.Size(103, 44);
            this.btn_cu.TabIndex = 7;
            this.btn_cu.Text = "cu";
            this.btn_cu.UseVisualStyleBackColor = true;
            this.btn_cu.Click += new System.EventHandler(this.btn_cu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Поиск по :";
            // 
            // FilterProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 148);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cu);
            this.Controls.Add(this.btn_surname);
            this.Controls.Add(this.btn_gr_code);
            this.Controls.Add(this.btn_coursework);
            this.Controls.Add(this.paramTxtBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FilterProperties";
            this.Text = "Filter properties";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox paramTxtBox;
        private System.Windows.Forms.Button btn_surname;
        private System.Windows.Forms.Button btn_gr_code;
        private System.Windows.Forms.Button btn_coursework;
        private System.Windows.Forms.Button btn_cu;
        private System.Windows.Forms.Label label1;
    }
}