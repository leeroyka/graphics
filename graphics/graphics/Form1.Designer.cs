namespace graphics
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.plane = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.labelForm = new System.Windows.Forms.Label();
            this.hideButton = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Label();
            this.textGraph = new System.Windows.Forms.TextBox();
            this.precisionBar = new System.Windows.Forms.TrackBar();
            this.sizeBar = new System.Windows.Forms.TrackBar();
            this.buildButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.precisionLabel = new System.Windows.Forms.Label();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.Debug = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DebugTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.precisionBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeBar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox1.Location = new System.Drawing.Point(-14, -17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 631);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите функцию:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // plane
            // 
            this.plane.BackColor = System.Drawing.Color.Transparent;
            this.plane.Location = new System.Drawing.Point(225, 28);
            this.plane.Name = "plane";
            this.plane.Size = new System.Drawing.Size(534, 534);
            this.plane.TabIndex = 2;
            this.plane.TabStop = false;
            this.plane.Visible = false;
            this.plane.Paint += new System.Windows.Forms.PaintEventHandler(this.plane_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pictureBox3.Location = new System.Drawing.Point(-32, -6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(803, 34);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseDown);
            this.pictureBox3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseMove);
            this.pictureBox3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseUp);
            // 
            // labelForm
            // 
            this.labelForm.AutoSize = true;
            this.labelForm.Location = new System.Drawing.Point(318, 6);
            this.labelForm.Name = "labelForm";
            this.labelForm.Size = new System.Drawing.Size(113, 16);
            this.labelForm.TabIndex = 4;
            this.labelForm.Text = "Graphics Building";
            this.labelForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelForm_MouseDown);
            this.labelForm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelForm_MouseMove);
            this.labelForm.MouseUp += new System.Windows.Forms.MouseEventHandler(this.labelForm_MouseUp);
            // 
            // hideButton
            // 
            this.hideButton.AutoSize = true;
            this.hideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hideButton.Location = new System.Drawing.Point(726, 6);
            this.hideButton.Name = "hideButton";
            this.hideButton.Size = new System.Drawing.Size(16, 16);
            this.hideButton.TabIndex = 5;
            this.hideButton.Text = "_";
            this.hideButton.Click += new System.EventHandler(this.hideButton_Click);
            this.hideButton.MouseEnter += new System.EventHandler(this.hideButton_MouseEnter);
            this.hideButton.MouseLeave += new System.EventHandler(this.hideButton_MouseLeave);
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.Location = new System.Drawing.Point(743, 6);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(17, 16);
            this.closeButton.TabIndex = 6;
            this.closeButton.Text = "X";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            // 
            // textGraph
            // 
            this.textGraph.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textGraph.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textGraph.ForeColor = System.Drawing.Color.White;
            this.textGraph.Location = new System.Drawing.Point(40, 73);
            this.textGraph.Name = "textGraph";
            this.textGraph.Size = new System.Drawing.Size(165, 22);
            this.textGraph.TabIndex = 7;
            // 
            // precisionBar
            // 
            this.precisionBar.Location = new System.Drawing.Point(12, 129);
            this.precisionBar.Maximum = 100;
            this.precisionBar.Minimum = 1;
            this.precisionBar.Name = "precisionBar";
            this.precisionBar.Size = new System.Drawing.Size(193, 45);
            this.precisionBar.SmallChange = 10;
            this.precisionBar.TabIndex = 8;
            this.precisionBar.Value = 13;
            this.precisionBar.Scroll += new System.EventHandler(this.precisionBar_Scroll);
            // 
            // sizeBar
            // 
            this.sizeBar.Location = new System.Drawing.Point(12, 225);
            this.sizeBar.Name = "sizeBar";
            this.sizeBar.Size = new System.Drawing.Size(193, 45);
            this.sizeBar.TabIndex = 9;
            // 
            // buildButton
            // 
            this.buildButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buildButton.Location = new System.Drawing.Point(12, 288);
            this.buildButton.Name = "buildButton";
            this.buildButton.Size = new System.Drawing.Size(193, 35);
            this.buildButton.TabIndex = 10;
            this.buildButton.Text = "Построить";
            this.buildButton.UseVisualStyleBackColor = true;
            this.buildButton.Click += new System.EventHandler(this.buildButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Точность";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Размер сетки";
            // 
            // precisionLabel
            // 
            this.precisionLabel.AutoSize = true;
            this.precisionLabel.Location = new System.Drawing.Point(95, 158);
            this.precisionLabel.Name = "precisionLabel";
            this.precisionLabel.Size = new System.Drawing.Size(22, 16);
            this.precisionLabel.TabIndex = 13;
            this.precisionLabel.Text = "13";
            this.precisionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(95, 254);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(15, 16);
            this.sizeLabel.TabIndex = 14;
            this.sizeLabel.Text = "0";
            this.sizeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Debug
            // 
            this.Debug.AutoSize = true;
            this.Debug.Location = new System.Drawing.Point(31, 513);
            this.Debug.Name = "Debug";
            this.Debug.Size = new System.Drawing.Size(49, 16);
            this.Debug.TabIndex = 15;
            this.Debug.Text = "Debug";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(12, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "y=";
            // 
            // DebugTimer
            // 
            this.DebugTimer.Interval = 5;
            this.DebugTimer.Tick += new System.EventHandler(this.DebugTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(772, 574);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Debug);
            this.Controls.Add(this.sizeLabel);
            this.Controls.Add(this.precisionLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buildButton);
            this.Controls.Add(this.sizeBar);
            this.Controls.Add(this.precisionBar);
            this.Controls.Add(this.textGraph);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.hideButton);
            this.Controls.Add(this.labelForm);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.plane);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Graphics Building";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.precisionBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox plane;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label labelForm;
        private System.Windows.Forms.Label hideButton;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.TextBox textGraph;
        private System.Windows.Forms.TrackBar precisionBar;
        private System.Windows.Forms.TrackBar sizeBar;
        private System.Windows.Forms.Button buildButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label precisionLabel;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.Label Debug;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer DebugTimer;
    }
}

