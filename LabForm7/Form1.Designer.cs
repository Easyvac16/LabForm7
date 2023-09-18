namespace LabForm7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox_X = new PictureBox();
            pictureBox_O = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            comboBox1 = new ComboBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox_X).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_O).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox_X
            // 
            pictureBox_X.Image = (Image)resources.GetObject("pictureBox_X.Image");
            pictureBox_X.Location = new Point(12, 238);
            pictureBox_X.Name = "pictureBox_X";
            pictureBox_X.Size = new Size(25, 113);
            pictureBox_X.TabIndex = 0;
            pictureBox_X.TabStop = false;
            // 
            // pictureBox_O
            // 
            pictureBox_O.Image = (Image)resources.GetObject("pictureBox_O.Image");
            pictureBox_O.Location = new Point(1028, 238);
            pictureBox_O.Name = "pictureBox_O";
            pictureBox_O.Size = new Size(25, 113);
            pictureBox_O.TabIndex = 1;
            pictureBox_O.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(503, 290);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(27, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(187, 29);
            label1.Name = "label1";
            label1.Size = new Size(13, 15);
            label1.TabIndex = 3;
            label1.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(766, 29);
            label2.Name = "label2";
            label2.Size = new Size(13, 15);
            label2.TabIndex = 4;
            label2.Text = "0";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1", "2", "3" });
            comboBox1.Location = new Point(442, 515);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(469, 555);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1065, 604);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox_O);
            Controls.Add(pictureBox_X);
            Name = "Form1";
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox_X).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_O).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox_X;
        private PictureBox pictureBox_O;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
        private ComboBox comboBox1;
        private Button button1;
    }
}