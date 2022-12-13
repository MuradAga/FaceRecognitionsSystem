namespace KSLR_R_FaceRecognitionsSystem
{
    partial class FaceRecognitionSystem
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FaceRecognitionSystem));
            this.cameraBox = new Emgu.CV.UI.ImageBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txName = new System.Windows.Forms.TextBox();
            this.IBOutput = new Emgu.CV.UI.ImageBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCountAllFaces = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mic1 = new System.Windows.Forms.PictureBox();
            this.mic2 = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDatabase = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cameraBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IBOutput)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mic2)).BeginInit();
            this.SuspendLayout();
            // 
            // cameraBox
            // 
            this.cameraBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cameraBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cameraBox.Location = new System.Drawing.Point(15, 12);
            this.cameraBox.Margin = new System.Windows.Forms.Padding(4);
            this.cameraBox.Name = "cameraBox";
            this.cameraBox.Size = new System.Drawing.Size(431, 304);
            this.cameraBox.TabIndex = 2;
            this.cameraBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 334);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Şəxsin Adı";
            // 
            // txName
            // 
            this.txName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txName.Location = new System.Drawing.Point(19, 368);
            this.txName.Margin = new System.Windows.Forms.Padding(4);
            this.txName.Name = "txName";
            this.txName.Size = new System.Drawing.Size(289, 45);
            this.txName.TabIndex = 6;
            // 
            // IBOutput
            // 
            this.IBOutput.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.IBOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IBOutput.Location = new System.Drawing.Point(8, 174);
            this.IBOutput.Margin = new System.Windows.Forms.Padding(4);
            this.IBOutput.Name = "IBOutput";
            this.IBOutput.Size = new System.Drawing.Size(137, 128);
            this.IBOutput.TabIndex = 11;
            this.IBOutput.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.IBOutput);
            this.groupBox2.Controls.Add(this.lblName);
            this.groupBox2.Controls.Add(this.lblCountAllFaces);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(476, 14);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(236, 310);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nəticə:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 21);
            this.label3.TabIndex = 18;
            this.label3.Text = "Üzün şəkli";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(5, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 22);
            this.label5.TabIndex = 17;
            this.label5.Text = "Kamerada olan şəxslər:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Blue;
            this.lblName.Location = new System.Drawing.Point(5, 39);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(82, 24);
            this.lblName.TabIndex = 16;
            this.lblName.Text = "Heç kim";
            // 
            // lblCountAllFaces
            // 
            this.lblCountAllFaces.AutoSize = true;
            this.lblCountAllFaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountAllFaces.ForeColor = System.Drawing.Color.Red;
            this.lblCountAllFaces.Location = new System.Drawing.Point(212, 116);
            this.lblCountAllFaces.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCountAllFaces.Name = "lblCountAllFaces";
            this.lblCountAllFaces.Size = new System.Drawing.Size(24, 25);
            this.lblCountAllFaces.TabIndex = 15;
            this.lblCountAllFaces.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "Aşkarlanan şəxslərin sayı: :";
            // 
            // mic1
            // 
            this.mic1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mic1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mic1.Image = ((System.Drawing.Image)(resources.GetObject("mic1.Image")));
            this.mic1.Location = new System.Drawing.Point(855, 14);
            this.mic1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mic1.Name = "mic1";
            this.mic1.Size = new System.Drawing.Size(89, 89);
            this.mic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mic1.TabIndex = 13;
            this.mic1.TabStop = false;
            this.mic1.Click += new System.EventHandler(this.mic1_Click);
            // 
            // mic2
            // 
            this.mic2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mic2.Image = ((System.Drawing.Image)(resources.GetObject("mic2.Image")));
            this.mic2.Location = new System.Drawing.Point(855, 14);
            this.mic2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mic2.Name = "mic2";
            this.mic2.Size = new System.Drawing.Size(89, 89);
            this.mic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mic2.TabIndex = 14;
            this.mic2.TabStop = false;
            this.mic2.Click += new System.EventHandler(this.mic2_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(337, 368);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(109, 45);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Yadda saxla";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDatabase
            // 
            this.btnDatabase.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnDatabase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatabase.Location = new System.Drawing.Point(877, 368);
            this.btnDatabase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDatabase.Name = "btnDatabase";
            this.btnDatabase.Size = new System.Drawing.Size(67, 45);
            this.btnDatabase.TabIndex = 20;
            this.btnDatabase.Text = "BAZA";
            this.btnDatabase.UseVisualStyleBackColor = false;
            this.btnDatabase.Click += new System.EventHandler(this.btnDatabase_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(826, 14);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 21);
            this.button1.TabIndex = 21;
            this.button1.Text = "K";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FaceRecognitionSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(956, 420);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDatabase);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.mic1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cameraBox);
            this.Controls.Add(this.mic2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FaceRecognitionSystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Üz tanıma sistemi";
            this.Load += new System.EventHandler(this.FaceRecognitionSystem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cameraBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IBOutput)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mic2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txName;
        public Emgu.CV.UI.ImageBox cameraBox;
        public Emgu.CV.UI.ImageBox IBOutput;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCountAllFaces;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox mic1;
        private System.Windows.Forms.PictureBox mic2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDatabase;
        private System.Windows.Forms.Button button1;
    }
}

