namespace Fractals
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows
        private void InitializeComponent()
        {
            this.refresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.offsetX = new System.Windows.Forms.TextBox();
            this.offsetY = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(53, 438);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(116, 38);
            this.refresh.TabIndex = 0;
            this.refresh.Text = "Обновить";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 383);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Смещение Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Смещение X";
            // 
            // offsetX
            // 
            this.offsetX.Location = new System.Drawing.Point(53, 354);
            this.offsetX.Name = "offsetX";
            this.offsetX.Size = new System.Drawing.Size(116, 26);
            this.offsetX.TabIndex = 3;
            this.offsetX.Text = "40";
            // 
            // offsetY
            // 
            this.offsetY.Location = new System.Drawing.Point(53, 406);
            this.offsetY.Name = "offsetY";
            this.offsetY.Size = new System.Drawing.Size(116, 26);
            this.offsetY.TabIndex = 4;
            this.offsetY.Text = "40";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 709);
            this.Controls.Add(this.offsetY);
            this.Controls.Add(this.offsetX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.refresh);
            this.Name = "Form1";
            this.Text = "Fractals";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox offsetX;
        private System.Windows.Forms.TextBox offsetY;
    }
}

