namespace BackgroundWorkerSample
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Label();
            this.labelDo = new System.Windows.Forms.Label();
            this.labelOd = new System.Windows.Forms.Label();
            this.labelPodzielne = new System.Windows.Forms.Label();
            this.labelIle = new System.Windows.Forms.Label();
            this.textBoxDo = new System.Windows.Forms.TextBox();
            this.textBoxOd = new System.Windows.Forms.TextBox();
            this.textBoxPodzielne = new System.Windows.Forms.TextBox();
            this.textBoxIle = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnStartAsyncOperation = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.labelDo);
            this.panel1.Controls.Add(this.labelOd);
            this.panel1.Controls.Add(this.labelPodzielne);
            this.panel1.Controls.Add(this.labelIle);
            this.panel1.Controls.Add(this.textBoxDo);
            this.panel1.Controls.Add(this.textBoxOd);
            this.panel1.Controls.Add(this.textBoxPodzielne);
            this.panel1.Controls.Add(this.textBoxIle);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.btnStartAsyncOperation);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 312);
            this.panel1.TabIndex = 0;
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exit.ForeColor = System.Drawing.Color.Black;
            this.exit.Location = new System.Drawing.Point(606, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(23, 22);
            this.exit.TabIndex = 24;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            this.exit.MouseEnter += new System.EventHandler(this.exit_MouseEnter);
            this.exit.MouseLeave += new System.EventHandler(this.exit_MouseLeave);
            // 
            // labelDo
            // 
            this.labelDo.AutoSize = true;
            this.labelDo.ForeColor = System.Drawing.Color.Black;
            this.labelDo.Location = new System.Drawing.Point(359, 264);
            this.labelDo.Name = "labelDo";
            this.labelDo.Size = new System.Drawing.Size(21, 13);
            this.labelDo.TabIndex = 23;
            this.labelDo.Text = "Do";
            // 
            // labelOd
            // 
            this.labelOd.AutoSize = true;
            this.labelOd.ForeColor = System.Drawing.Color.Black;
            this.labelOd.Location = new System.Drawing.Point(359, 206);
            this.labelOd.Name = "labelOd";
            this.labelOd.Size = new System.Drawing.Size(21, 13);
            this.labelOd.TabIndex = 22;
            this.labelOd.Text = "Od";
            // 
            // labelPodzielne
            // 
            this.labelPodzielne.AutoSize = true;
            this.labelPodzielne.BackColor = System.Drawing.Color.Transparent;
            this.labelPodzielne.ForeColor = System.Drawing.Color.Black;
            this.labelPodzielne.Location = new System.Drawing.Point(81, 265);
            this.labelPodzielne.Name = "labelPodzielne";
            this.labelPodzielne.Size = new System.Drawing.Size(81, 13);
            this.labelPodzielne.TabIndex = 21;
            this.labelPodzielne.Text = "Podzielne przez";
            // 
            // labelIle
            // 
            this.labelIle.AutoSize = true;
            this.labelIle.ForeColor = System.Drawing.Color.Black;
            this.labelIle.Location = new System.Drawing.Point(106, 207);
            this.labelIle.Name = "labelIle";
            this.labelIle.Size = new System.Drawing.Size(42, 13);
            this.labelIle.TabIndex = 20;
            this.labelIle.Text = "Ile liczb";
            // 
            // textBoxDo
            // 
            this.textBoxDo.Location = new System.Drawing.Point(431, 257);
            this.textBoxDo.Name = "textBoxDo";
            this.textBoxDo.Size = new System.Drawing.Size(100, 20);
            this.textBoxDo.TabIndex = 19;
            // 
            // textBoxOd
            // 
            this.textBoxOd.Location = new System.Drawing.Point(432, 199);
            this.textBoxOd.Name = "textBoxOd";
            this.textBoxOd.Size = new System.Drawing.Size(100, 20);
            this.textBoxOd.TabIndex = 18;
            // 
            // textBoxPodzielne
            // 
            this.textBoxPodzielne.Location = new System.Drawing.Point(185, 258);
            this.textBoxPodzielne.Name = "textBoxPodzielne";
            this.textBoxPodzielne.Size = new System.Drawing.Size(100, 20);
            this.textBoxPodzielne.TabIndex = 17;
            // 
            // textBoxIle
            // 
            this.textBoxIle.Location = new System.Drawing.Point(185, 200);
            this.textBoxIle.Name = "textBoxIle";
            this.textBoxIle.Size = new System.Drawing.Size(100, 20);
            this.textBoxIle.TabIndex = 16;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Location = new System.Drawing.Point(270, 44);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(69, 23);
            this.lblStatus.TabIndex = 15;
            this.lblStatus.Text = "Start....";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Enabled = false;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(333, 136);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(200, 22);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(47, 70);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(538, 23);
            this.progressBar1.TabIndex = 13;
            // 
            // btnStartAsyncOperation
            // 
            this.btnStartAsyncOperation.BackColor = System.Drawing.Color.Cyan;
            this.btnStartAsyncOperation.FlatAppearance.BorderColor = System.Drawing.Color.MediumSpringGreen;
            this.btnStartAsyncOperation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnStartAsyncOperation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnStartAsyncOperation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartAsyncOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartAsyncOperation.ForeColor = System.Drawing.Color.Black;
            this.btnStartAsyncOperation.Location = new System.Drawing.Point(84, 136);
            this.btnStartAsyncOperation.Name = "btnStartAsyncOperation";
            this.btnStartAsyncOperation.Size = new System.Drawing.Size(201, 23);
            this.btnStartAsyncOperation.TabIndex = 12;
            this.btnStartAsyncOperation.Text = "Start Asynchronous Operation";
            this.btnStartAsyncOperation.UseVisualStyleBackColor = false;
            this.btnStartAsyncOperation.Click += new System.EventHandler(this.btnStartAsyncOperation_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 312);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BackgroundWorker Sample";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelDo;
        private System.Windows.Forms.Label labelOd;
        private System.Windows.Forms.Label labelPodzielne;
        private System.Windows.Forms.Label labelIle;
        private System.Windows.Forms.TextBox textBoxDo;
        private System.Windows.Forms.TextBox textBoxOd;
        private System.Windows.Forms.TextBox textBoxPodzielne;
        private System.Windows.Forms.TextBox textBoxIle;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnStartAsyncOperation;
        private System.Windows.Forms.Label exit;
    }
}

