namespace My_ToDo
{
    partial class main_form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Calendar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.today_lab = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.calendarpanel = new System.Windows.Forms.Panel();
            this.calendar_month = new System.Windows.Forms.Label();
            this.calendargrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.calendarpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calendargrid)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.Location = new System.Drawing.Point(-5, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 596);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "DON\'T Do";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flowLayoutPanel1.Controls.Add(this.Calendar);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 93);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(257, 473);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // Calendar
            // 
            this.Calendar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Calendar.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.Calendar.Location = new System.Drawing.Point(7, 7);
            this.Calendar.Margin = new System.Windows.Forms.Padding(2);
            this.Calendar.Name = "Calendar";
            this.Calendar.Padding = new System.Windows.Forms.Padding(4);
            this.Calendar.Size = new System.Drawing.Size(241, 53);
            this.Calendar.TabIndex = 0;
            this.Calendar.Text = "Month Calendar";
            this.Calendar.UseVisualStyleBackColor = true;
            this.Calendar.Click += new System.EventHandler(this.Calendar_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.button2.Location = new System.Drawing.Point(7, 64);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(4);
            this.button2.Size = new System.Drawing.Size(241, 53);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.button3.Location = new System.Drawing.Point(7, 121);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(4);
            this.button3.Size = new System.Drawing.Size(241, 53);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.button4.Location = new System.Drawing.Point(7, 178);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(4);
            this.button4.Size = new System.Drawing.Size(241, 53);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "anything";
            // 
            // today_lab
            // 
            this.today_lab.AutoSize = true;
            this.today_lab.BackColor = System.Drawing.SystemColors.Control;
            this.today_lab.Font = new System.Drawing.Font("OCR A Extended", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.today_lab.Location = new System.Drawing.Point(282, 30);
            this.today_lab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.today_lab.Name = "today_lab";
            this.today_lab.Size = new System.Drawing.Size(164, 37);
            this.today_lab.TabIndex = 4;
            this.today_lab.Text = "Today: ";
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // calendarpanel
            // 
            this.calendarpanel.Controls.Add(this.calendar_month);
            this.calendarpanel.Controls.Add(this.calendargrid);
            this.calendarpanel.Location = new System.Drawing.Point(289, 93);
            this.calendarpanel.Name = "calendarpanel";
            this.calendarpanel.Size = new System.Drawing.Size(745, 473);
            this.calendarpanel.TabIndex = 5;
            this.calendarpanel.Visible = false;
            // 
            // calendar_month
            // 
            this.calendar_month.AutoSize = true;
            this.calendar_month.BackColor = System.Drawing.SystemColors.Control;
            this.calendar_month.Font = new System.Drawing.Font("OCR A Extended", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendar_month.Location = new System.Drawing.Point(2, 8);
            this.calendar_month.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.calendar_month.Name = "calendar_month";
            this.calendar_month.Size = new System.Drawing.Size(38, 37);
            this.calendar_month.TabIndex = 5;
            this.calendar_month.Text = "_";
            // 
            // calendargrid
            // 
            this.calendargrid.AllowUserToAddRows = false;
            this.calendargrid.AllowUserToDeleteRows = false;
            this.calendargrid.AllowUserToResizeColumns = false;
            this.calendargrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("OCR A Extended", 15.75F);
            this.calendargrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.calendargrid.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("OCR A Extended", 15.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.calendargrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.calendargrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.calendargrid.ColumnHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("OCR A Extended", 15.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.calendargrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.calendargrid.GridColor = System.Drawing.SystemColors.Control;
            this.calendargrid.Location = new System.Drawing.Point(3, 47);
            this.calendargrid.Name = "calendargrid";
            this.calendargrid.ReadOnly = true;
            this.calendargrid.RowHeadersVisible = false;
            this.calendargrid.Size = new System.Drawing.Size(739, 423);
            this.calendargrid.TabIndex = 0;
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 590);
            this.Controls.Add(this.calendarpanel);
            this.Controls.Add(this.today_lab);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "main_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Don\'t Do";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.calendarpanel.ResumeLayout(false);
            this.calendarpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calendargrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button Calendar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label today_lab;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Panel calendarpanel;
        private System.Windows.Forms.DataGridView calendargrid;
        private System.Windows.Forms.Label calendar_month;
    }
}

