namespace laba_8
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.RectagleCheck = new System.Windows.Forms.CheckBox();
            this.textBoxW = new System.Windows.Forms.TextBox();
            this.textBoxH = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBoxSquare = new System.Windows.Forms.CheckBox();
            this.checkBoxElips = new System.Windows.Forms.CheckBox();
            this.checkBoxCircle = new System.Windows.Forms.CheckBox();
            this.checkBoxPolygon = new System.Windows.Forms.CheckBox();
            this.checkBoxTriangle = new System.Windows.Forms.CheckBox();
            this.buttonMy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(599, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "x:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(599, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "y:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(599, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "w: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(599, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "h:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(631, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Draw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(620, 149);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(100, 22);
            this.textBoxX.TabIndex = 6;
            this.textBoxX.TextChanged += new System.EventHandler(this.textBoxX_TextChanged);
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(620, 177);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(100, 22);
            this.textBoxY.TabIndex = 7;
            this.textBoxY.TextChanged += new System.EventHandler(this.textBoxY_TextChanged);
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(522, 310);
            this.pictureBox.TabIndex = 8;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // RectagleCheck
            // 
            this.RectagleCheck.AutoSize = true;
            this.RectagleCheck.Location = new System.Drawing.Point(12, 342);
            this.RectagleCheck.Name = "RectagleCheck";
            this.RectagleCheck.Size = new System.Drawing.Size(84, 20);
            this.RectagleCheck.TabIndex = 9;
            this.RectagleCheck.Text = "Rectagle";
            this.RectagleCheck.UseVisualStyleBackColor = true;
            this.RectagleCheck.CheckedChanged += new System.EventHandler(this.RectagleCheck_CheckedChanged);
            // 
            // textBoxW
            // 
            this.textBoxW.Location = new System.Drawing.Point(620, 211);
            this.textBoxW.Name = "textBoxW";
            this.textBoxW.Size = new System.Drawing.Size(100, 22);
            this.textBoxW.TabIndex = 10;
            this.textBoxW.TextChanged += new System.EventHandler(this.textBoxW_TextChanged);
            // 
            // textBoxH
            // 
            this.textBoxH.Location = new System.Drawing.Point(620, 239);
            this.textBoxH.Name = "textBoxH";
            this.textBoxH.Size = new System.Drawing.Size(100, 22);
            this.textBoxH.TabIndex = 11;
            this.textBoxH.TextChanged += new System.EventHandler(this.textBoxH_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(631, 296);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBoxSquare
            // 
            this.checkBoxSquare.AutoSize = true;
            this.checkBoxSquare.Location = new System.Drawing.Point(12, 368);
            this.checkBoxSquare.Name = "checkBoxSquare";
            this.checkBoxSquare.Size = new System.Drawing.Size(73, 20);
            this.checkBoxSquare.TabIndex = 13;
            this.checkBoxSquare.Text = "Square";
            this.checkBoxSquare.UseVisualStyleBackColor = true;
            this.checkBoxSquare.CheckedChanged += new System.EventHandler(this.checkBoxSquare_CheckedChanged);
            // 
            // checkBoxElips
            // 
            this.checkBoxElips.AutoSize = true;
            this.checkBoxElips.Location = new System.Drawing.Point(137, 342);
            this.checkBoxElips.Name = "checkBoxElips";
            this.checkBoxElips.Size = new System.Drawing.Size(59, 20);
            this.checkBoxElips.TabIndex = 14;
            this.checkBoxElips.Text = "Elips";
            this.checkBoxElips.UseVisualStyleBackColor = true;
            this.checkBoxElips.CheckedChanged += new System.EventHandler(this.checkBoxElips_CheckedChanged);
            // 
            // checkBoxCircle
            // 
            this.checkBoxCircle.AutoSize = true;
            this.checkBoxCircle.Location = new System.Drawing.Point(137, 368);
            this.checkBoxCircle.Name = "checkBoxCircle";
            this.checkBoxCircle.Size = new System.Drawing.Size(63, 20);
            this.checkBoxCircle.TabIndex = 15;
            this.checkBoxCircle.Text = "Circle";
            this.checkBoxCircle.UseVisualStyleBackColor = true;
            this.checkBoxCircle.CheckedChanged += new System.EventHandler(this.checkBoxCircle_CheckedChanged);
            // 
            // checkBoxPolygon
            // 
            this.checkBoxPolygon.AutoSize = true;
            this.checkBoxPolygon.Location = new System.Drawing.Point(259, 342);
            this.checkBoxPolygon.Name = "checkBoxPolygon";
            this.checkBoxPolygon.Size = new System.Drawing.Size(79, 20);
            this.checkBoxPolygon.TabIndex = 16;
            this.checkBoxPolygon.Text = "Polygon";
            this.checkBoxPolygon.UseVisualStyleBackColor = true;
            this.checkBoxPolygon.CheckedChanged += new System.EventHandler(this.checkBoxPolygon_CheckedChanged);
            // 
            // checkBoxTriangle
            // 
            this.checkBoxTriangle.AutoSize = true;
            this.checkBoxTriangle.Location = new System.Drawing.Point(259, 368);
            this.checkBoxTriangle.Name = "checkBoxTriangle";
            this.checkBoxTriangle.Size = new System.Drawing.Size(79, 20);
            this.checkBoxTriangle.TabIndex = 17;
            this.checkBoxTriangle.Text = "Triangle";
            this.checkBoxTriangle.UseVisualStyleBackColor = true;
            this.checkBoxTriangle.CheckedChanged += new System.EventHandler(this.checkBoxTriangle_CheckedChanged);
            // 
            // buttonMy
            // 
            this.buttonMy.Location = new System.Drawing.Point(631, 325);
            this.buttonMy.Name = "buttonMy";
            this.buttonMy.Size = new System.Drawing.Size(75, 23);
            this.buttonMy.TabIndex = 18;
            this.buttonMy.Text = "MyPicture";
            this.buttonMy.UseVisualStyleBackColor = true;
            this.buttonMy.Click += new System.EventHandler(this.buttonMy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonMy);
            this.Controls.Add(this.checkBoxTriangle);
            this.Controls.Add(this.checkBoxPolygon);
            this.Controls.Add(this.checkBoxCircle);
            this.Controls.Add(this.checkBoxElips);
            this.Controls.Add(this.checkBoxSquare);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxH);
            this.Controls.Add(this.textBoxW);
            this.Controls.Add(this.RectagleCheck);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
        public System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.CheckBox RectagleCheck;
        private System.Windows.Forms.TextBox textBoxW;
        private System.Windows.Forms.TextBox textBoxH;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBoxSquare;
        private System.Windows.Forms.CheckBox checkBoxElips;
        private System.Windows.Forms.CheckBox checkBoxCircle;
        private System.Windows.Forms.CheckBox checkBoxPolygon;
        private System.Windows.Forms.CheckBox checkBoxTriangle;
        private System.Windows.Forms.Button buttonMy;
    }
}

