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
            this.radius = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.shape = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(52, 438);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(116, 38);
            this.refresh.TabIndex = 0;
            this.refresh.Text = "Оновити";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 383);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Зміщення Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Зміщення X";
            // 
            // offsetX
            // 
            this.offsetX.Location = new System.Drawing.Point(52, 354);
            this.offsetX.Name = "offsetX";
            this.offsetX.Size = new System.Drawing.Size(116, 26);
            this.offsetX.TabIndex = 3;
            this.offsetX.Text = "40";
            // 
            // offsetY
            // 
            this.offsetY.Location = new System.Drawing.Point(52, 406);
            this.offsetY.Name = "offsetY";
            this.offsetY.Size = new System.Drawing.Size(116, 26);
            this.offsetY.TabIndex = 4;
            this.offsetY.Text = "40";
            // 
            // radius
            // 
            this.radius.Location = new System.Drawing.Point(52, 295);
            this.radius.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radius.Name = "radius";
            this.radius.Size = new System.Drawing.Size(116, 26);
            this.radius.TabIndex = 5;
            this.radius.Text = "40";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 271);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Радіус";
            // 
            // shape
            // 
            this.shape.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.shape.FormattingEnabled = true;
            this.shape.Items.AddRange(new object[] {
            "Круг",
            "Трикутник",
            "Квадрат",
            "Ромб"});
            this.shape.Location = new System.Drawing.Point(54, 234);
            this.shape.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.shape.Name = "shape";
            this.shape.Size = new System.Drawing.Size(115, 28);
            this.shape.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 209);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Вибір фігури";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 702);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.shape);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radius);
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
        private System.Windows.Forms.TextBox radius;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox shape;
        private System.Windows.Forms.Label label4;
    }
}

