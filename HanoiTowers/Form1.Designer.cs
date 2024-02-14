namespace HanoiTowers
{
    partial class tableLayoutPanel1
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
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.DragPanel = new System.Windows.Forms.Panel();
            this.Third = new System.Windows.Forms.Panel();
            this.Second = new System.Windows.Forms.Panel();
            this.First = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.sign1 = new System.Windows.Forms.PictureBox();
            this.sign = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.time = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel3.SuspendLayout();
            this.DragPanel.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sign1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sign)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.DragPanel, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel7, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel6, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(884, 542);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // DragPanel
            // 
            this.DragPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.DragPanel.Controls.Add(this.Third);
            this.DragPanel.Controls.Add(this.Second);
            this.DragPanel.Controls.Add(this.First);
            this.DragPanel.Controls.Add(this.panel3);
            this.DragPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DragPanel.Location = new System.Drawing.Point(0, 81);
            this.DragPanel.Margin = new System.Windows.Forms.Padding(0);
            this.DragPanel.Name = "DragPanel";
            this.DragPanel.Size = new System.Drawing.Size(884, 406);
            this.DragPanel.TabIndex = 0;
            this.DragPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MouseClickDrag);
            this.DragPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove);
            // 
            // Third
            // 
            this.Third.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Third.BackColor = System.Drawing.Color.White;
            this.Third.Location = new System.Drawing.Point(726, 133);
            this.Third.Margin = new System.Windows.Forms.Padding(0);
            this.Third.Name = "Third";
            this.Third.Size = new System.Drawing.Size(20, 244);
            this.Third.TabIndex = 3;
            // 
            // Second
            // 
            this.Second.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Second.BackColor = System.Drawing.Color.White;
            this.Second.Location = new System.Drawing.Point(432, 133);
            this.Second.Margin = new System.Windows.Forms.Padding(0);
            this.Second.Name = "Second";
            this.Second.Size = new System.Drawing.Size(20, 244);
            this.Second.TabIndex = 2;
            // 
            // First
            // 
            this.First.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.First.BackColor = System.Drawing.Color.White;
            this.First.Location = new System.Drawing.Point(153, 133);
            this.First.Margin = new System.Windows.Forms.Padding(0);
            this.First.Name = "First";
            this.First.Size = new System.Drawing.Size(20, 244);
            this.First.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(12, 370);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(860, 20);
            this.panel3.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel7.Controls.Add(this.sign1);
            this.panel7.Controls.Add(this.sign);
            this.panel7.Controls.Add(this.tableLayoutPanel4);
            this.panel7.Controls.Add(this.button1);
            this.panel7.Controls.Add(this.Stop);
            this.panel7.Controls.Add(this.textBox1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(884, 81);
            this.panel7.TabIndex = 1;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // sign1
            // 
            this.sign1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sign1.Image = global::HanoiTowers.Properties.Resources.Безымянный1;
            this.sign1.Location = new System.Drawing.Point(772, 13);
            this.sign1.Name = "sign1";
            this.sign1.Size = new System.Drawing.Size(73, 58);
            this.sign1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sign1.TabIndex = 4;
            this.sign1.TabStop = false;
            this.sign1.Visible = false;
            // 
            // sign
            // 
            this.sign.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sign.Image = global::HanoiTowers.Properties.Resources.Безымянный;
            this.sign.Location = new System.Drawing.Point(772, 13);
            this.sign.Name = "sign";
            this.sign.Size = new System.Drawing.Size(75, 59);
            this.sign.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sign.TabIndex = 4;
            this.sign.TabStop = false;
            this.sign.Visible = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.button3, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.button2, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(628, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(118, 81);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gold;
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Enabled = false;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(0, 40);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 41);
            this.button3.TabIndex = 4;
            this.button3.Text = "Solve";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gold;
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Enabled = false;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 40);
            this.button2.TabIndex = 3;
            this.button2.Text = "Hint";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Kristen ITC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(278, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(350, 81);
            this.button1.TabIndex = 2;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Stop
            // 
            this.Stop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Stop.BackColor = System.Drawing.Color.Gold;
            this.Stop.Enabled = false;
            this.Stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Stop.Font = new System.Drawing.Font("Kristen ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stop.Location = new System.Drawing.Point(153, 0);
            this.Stop.Margin = new System.Windows.Forms.Padding(0);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(125, 81);
            this.Stop.TabIndex = 1;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = false;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(12, 9);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(74, 33);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 487);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(884, 55);
            this.panel6.TabIndex = 2;
            // 
            // time
            // 
            this.time.Tick += new System.EventHandler(this.time_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.ClientSize = new System.Drawing.Size(884, 542);
            this.Controls.Add(this.tableLayoutPanel3);
            this.MinimumSize = new System.Drawing.Size(900, 581);
            this.Name = "tableLayoutPanel1";
            this.tableLayoutPanel3.ResumeLayout(false);
            this.DragPanel.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sign1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sign)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        
        private System.Windows.Forms.Panel panel1;
 
        private System.Windows.Forms.Panel panel2;

  
    
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
      
     
    
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    
   
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel DragPanel;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox sign1;
        private System.Windows.Forms.Panel Third;
        private System.Windows.Forms.Panel Second;
        private System.Windows.Forms.Panel First;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox sign;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer time;
    }
}

