namespace Distraction_Tracker
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.distractionCount = new System.Windows.Forms.Label();
            this.AverageAttention = new System.Windows.Forms.Label();
            this.longestAttention = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.resetAverage = new System.Windows.Forms.Button();
            this.resetAll = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.distractionButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.totalElapsedTime = new System.Windows.Forms.Label();
            this.sinceLastElapsedTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.71535F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.28465F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel4, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.48553F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.51447F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(534, 311);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.distractionCount);
            this.flowLayoutPanel1.Controls.Add(this.AverageAttention);
            this.flowLayoutPanel1.Controls.Add(this.longestAttention);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(150, 188);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(381, 120);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // distractionCount
            // 
            this.distractionCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distractionCount.ForeColor = System.Drawing.Color.OrangeRed;
            this.distractionCount.Location = new System.Drawing.Point(3, 0);
            this.distractionCount.Name = "distractionCount";
            this.distractionCount.Size = new System.Drawing.Size(131, 114);
            this.distractionCount.TabIndex = 2;
            this.distractionCount.Text = "0";
            this.distractionCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.distractionCount.Click += new System.EventHandler(this.distractionCount_Click);
            // 
            // AverageAttention
            // 
            this.AverageAttention.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AverageAttention.Location = new System.Drawing.Point(140, 0);
            this.AverageAttention.Name = "AverageAttention";
            this.AverageAttention.Size = new System.Drawing.Size(111, 114);
            this.AverageAttention.TabIndex = 0;
            this.AverageAttention.Text = "00:00:00";
            this.AverageAttention.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AverageAttention.Click += new System.EventHandler(this.AverageAttention_Click);
            // 
            // longestAttention
            // 
            this.longestAttention.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.longestAttention.Location = new System.Drawing.Point(257, 0);
            this.longestAttention.Name = "longestAttention";
            this.longestAttention.Size = new System.Drawing.Size(115, 114);
            this.longestAttention.TabIndex = 1;
            this.longestAttention.Text = "00:00:00";
            this.longestAttention.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.longestAttention.Click += new System.EventHandler(this.longestAttention_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.Controls.Add(this.resetAverage);
            this.flowLayoutPanel2.Controls.Add(this.resetAll);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 188);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(141, 120);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // resetAverage
            // 
            this.resetAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetAverage.Location = new System.Drawing.Point(3, 3);
            this.resetAverage.Name = "resetAverage";
            this.resetAverage.Size = new System.Drawing.Size(138, 54);
            this.resetAverage.TabIndex = 0;
            this.resetAverage.Text = "Reset Average";
            this.resetAverage.UseVisualStyleBackColor = true;
            this.resetAverage.Click += new System.EventHandler(this.resetAverage_Click);
            // 
            // resetAll
            // 
            this.resetAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetAll.Location = new System.Drawing.Point(3, 63);
            this.resetAll.Name = "resetAll";
            this.resetAll.Size = new System.Drawing.Size(138, 54);
            this.resetAll.TabIndex = 1;
            this.resetAll.Text = "Reset All";
            this.resetAll.UseVisualStyleBackColor = true;
            this.resetAll.Click += new System.EventHandler(this.resetAll_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.startButton);
            this.flowLayoutPanel3.Controls.Add(this.stopButton);
            this.flowLayoutPanel3.Controls.Add(this.distractionButton);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(141, 179);
            this.flowLayoutPanel3.TabIndex = 2;
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(3, 3);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(138, 54);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.Location = new System.Drawing.Point(3, 63);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(138, 54);
            this.stopButton.TabIndex = 1;
            this.stopButton.Text = "Pause";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // distractionButton
            // 
            this.distractionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distractionButton.ForeColor = System.Drawing.Color.Red;
            this.distractionButton.Location = new System.Drawing.Point(3, 123);
            this.distractionButton.Name = "distractionButton";
            this.distractionButton.Size = new System.Drawing.Size(138, 54);
            this.distractionButton.TabIndex = 2;
            this.distractionButton.Text = "DIstraction";
            this.distractionButton.UseVisualStyleBackColor = true;
            this.distractionButton.Click += new System.EventHandler(this.distractionButton_Click);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.totalElapsedTime);
            this.flowLayoutPanel4.Controls.Add(this.sinceLastElapsedTime);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(150, 3);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(381, 179);
            this.flowLayoutPanel4.TabIndex = 3;
            // 
            // totalElapsedTime
            // 
            this.totalElapsedTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalElapsedTime.Location = new System.Drawing.Point(3, 0);
            this.totalElapsedTime.Name = "totalElapsedTime";
            this.totalElapsedTime.Size = new System.Drawing.Size(378, 89);
            this.totalElapsedTime.TabIndex = 0;
            this.totalElapsedTime.Text = "N/A";
            this.totalElapsedTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sinceLastElapsedTime
            // 
            this.sinceLastElapsedTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sinceLastElapsedTime.Location = new System.Drawing.Point(3, 89);
            this.sinceLastElapsedTime.Name = "sinceLastElapsedTime";
            this.sinceLastElapsedTime.Size = new System.Drawing.Size(378, 89);
            this.sinceLastElapsedTime.TabIndex = 1;
            this.sinceLastElapsedTime.Text = "N/A";
            this.sinceLastElapsedTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 311);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "DistractionTracker";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label distractionCount;
        private System.Windows.Forms.Label AverageAttention;
        private System.Windows.Forms.Label longestAttention;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button resetAverage;
        private System.Windows.Forms.Button resetAll;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button distractionButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label totalElapsedTime;
        private System.Windows.Forms.Label sinceLastElapsedTime;
    }
}

