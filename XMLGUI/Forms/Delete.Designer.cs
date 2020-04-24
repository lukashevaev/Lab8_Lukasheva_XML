namespace XMLGUI.Forms
{
    partial class Delete
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
            this.label2 = new System.Windows.Forms.Label();
            this.paramTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_disc_name = new System.Windows.Forms.Button();
            this.btn_disc_id = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.label2.Location = new System.Drawing.Point(21, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Удаление записей :";
            // 
            // paramTxtBox
            // 
            this.paramTxtBox.Location = new System.Drawing.Point(25, 49);
            this.paramTxtBox.Name = "paramTxtBox";
            this.paramTxtBox.Size = new System.Drawing.Size(291, 22);
            this.paramTxtBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 15;
            // 
            // btn_disc_name
            // 
            this.btn_disc_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.btn_disc_name.Location = new System.Drawing.Point(201, 92);
            this.btn_disc_name.Name = "btn_disc_name";
            this.btn_disc_name.Size = new System.Drawing.Size(115, 75);
            this.btn_disc_name.TabIndex = 14;
            this.btn_disc_name.Text = "disc_name";
            this.btn_disc_name.UseVisualStyleBackColor = true;
            this.btn_disc_name.Click += new System.EventHandler(this.Btn_disc_name_Click);
            // 
            // btn_disc_id
            // 
            this.btn_disc_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.btn_disc_id.Location = new System.Drawing.Point(25, 93);
            this.btn_disc_id.Name = "btn_disc_id";
            this.btn_disc_id.Size = new System.Drawing.Size(113, 74);
            this.btn_disc_id.TabIndex = 13;
            this.btn_disc_id.Text = "disc_id";
            this.btn_disc_id.UseVisualStyleBackColor = true;
            this.btn_disc_id.Click += new System.EventHandler(this.Btn_disc_id_Click);
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 188);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.paramTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_disc_name);
            this.Controls.Add(this.btn_disc_id);
            this.Name = "Delete";
            this.Text = "Delete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox paramTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_disc_name;
        private System.Windows.Forms.Button btn_disc_id;
    }
}