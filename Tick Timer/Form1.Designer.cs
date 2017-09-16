namespace Tick_Timer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerBox2 = new System.Windows.Forms.TextBox();
            this.restartButton = new System.Windows.Forms.Button();
            this.adjustTimerButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.timerBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerBox2
            // 
            this.timerBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.timerBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.timerBox2.Font = new System.Drawing.Font("Candara", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerBox2.Location = new System.Drawing.Point(46, 85);
            this.timerBox2.MinimumSize = new System.Drawing.Size(325, 125);
            this.timerBox2.Name = "timerBox2";
            this.timerBox2.Size = new System.Drawing.Size(325, 125);
            this.timerBox2.TabIndex = 7;
            this.timerBox2.Text = "00:00";
            this.timerBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.timerBox2.Visible = false;
            // 
            // restartButton
            // 
            this.restartButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.restartButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.restartButton.BackColor = System.Drawing.Color.Silver;
            this.restartButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.restartButton.FlatAppearance.BorderSize = 3;
            this.restartButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.restartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restartButton.Font = new System.Drawing.Font("Candara", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.restartButton.Location = new System.Drawing.Point(238, 223);
            this.restartButton.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(133, 54);
            this.restartButton.TabIndex = 7;
            this.restartButton.Text = "Restart";
            this.restartButton.UseVisualStyleBackColor = false;
            this.restartButton.Visible = false;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // adjustTimerButton
            // 
            this.adjustTimerButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.adjustTimerButton.BackColor = System.Drawing.Color.Silver;
            this.adjustTimerButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.adjustTimerButton.FlatAppearance.BorderSize = 3;
            this.adjustTimerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.adjustTimerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adjustTimerButton.Font = new System.Drawing.Font("Candara", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adjustTimerButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.adjustTimerButton.Location = new System.Drawing.Point(46, 223);
            this.adjustTimerButton.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.adjustTimerButton.Name = "adjustTimerButton";
            this.adjustTimerButton.Size = new System.Drawing.Size(136, 54);
            this.adjustTimerButton.TabIndex = 8;
            this.adjustTimerButton.Text = "Adjust";
            this.adjustTimerButton.UseVisualStyleBackColor = false;
            this.adjustTimerButton.Visible = false;
            this.adjustTimerButton.Click += new System.EventHandler(this.adjustTimer_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.startButton, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.timerBox, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(46, 11);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(325, 131);
            this.tableLayoutPanel3.TabIndex = 3;
            this.tableLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);
            // 
            // timerBox
            // 
            this.timerBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timerBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.timerBox.Font = new System.Drawing.Font("Candara", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerBox.Location = new System.Drawing.Point(94, 7);
            this.timerBox.Name = "timerBox";
            this.timerBox.ReadOnly = true;
            this.timerBox.Size = new System.Drawing.Size(136, 50);
            this.timerBox.TabIndex = 6;
            this.timerBox.Text = "00:00";
            this.timerBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // startButton
            // 
            this.startButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.startButton.BackColor = System.Drawing.Color.Silver;
            this.startButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.startButton.FlatAppearance.BorderSize = 3;
            this.startButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Candara", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.startButton.Location = new System.Drawing.Point(89, 68);
            this.startButton.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(149, 49);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.start_Event);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.31507F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.68493F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(418, 295);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.Controls.Add(this.button19, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.button18, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.button17, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.button16, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.button15, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.button10, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.button11, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.button12, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.button13, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.button14, 4, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(46, 148);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(325, 144);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // button10
            // 
            this.button10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button10.BackColor = System.Drawing.Color.Silver;
            this.button10.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.button10.FlatAppearance.BorderSize = 3;
            this.button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Candara", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button10.Location = new System.Drawing.Point(9, 11);
            this.button10.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(50, 50);
            this.button10.TabIndex = 3;
            this.button10.Text = "0";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.click_Event);
            // 
            // button11
            // 
            this.button11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button11.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button11.BackColor = System.Drawing.Color.Silver;
            this.button11.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.button11.FlatAppearance.BorderSize = 3;
            this.button11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Candara", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button11.Location = new System.Drawing.Point(74, 11);
            this.button11.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(50, 50);
            this.button11.TabIndex = 4;
            this.button11.Text = "1";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.click_Event);
            // 
            // button12
            // 
            this.button12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button12.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button12.BackColor = System.Drawing.Color.Silver;
            this.button12.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.button12.FlatAppearance.BorderSize = 3;
            this.button12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Candara", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button12.Location = new System.Drawing.Point(139, 11);
            this.button12.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(50, 50);
            this.button12.TabIndex = 5;
            this.button12.Text = "2";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.click_Event);
            // 
            // button13
            // 
            this.button13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button13.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button13.BackColor = System.Drawing.Color.Silver;
            this.button13.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.button13.FlatAppearance.BorderSize = 3;
            this.button13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Candara", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button13.Location = new System.Drawing.Point(204, 11);
            this.button13.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(50, 50);
            this.button13.TabIndex = 6;
            this.button13.Text = "3";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.click_Event);
            // 
            // button14
            // 
            this.button14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button14.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button14.BackColor = System.Drawing.Color.Silver;
            this.button14.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.button14.FlatAppearance.BorderSize = 3;
            this.button14.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Candara", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button14.Location = new System.Drawing.Point(269, 11);
            this.button14.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(50, 50);
            this.button14.TabIndex = 7;
            this.button14.Text = "4";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.click_Event);
            // 
            // button15
            // 
            this.button15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button15.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button15.BackColor = System.Drawing.Color.Silver;
            this.button15.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.button15.FlatAppearance.BorderSize = 3;
            this.button15.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Font = new System.Drawing.Font("Candara", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button15.Location = new System.Drawing.Point(204, 83);
            this.button15.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(50, 50);
            this.button15.TabIndex = 8;
            this.button15.Text = "8";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.click_Event);
            // 
            // button16
            // 
            this.button16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button16.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button16.BackColor = System.Drawing.Color.Silver;
            this.button16.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.button16.FlatAppearance.BorderSize = 3;
            this.button16.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Font = new System.Drawing.Font("Candara", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button16.Location = new System.Drawing.Point(269, 83);
            this.button16.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(50, 50);
            this.button16.TabIndex = 9;
            this.button16.Text = "9";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.click_Event);
            // 
            // button17
            // 
            this.button17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button17.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button17.BackColor = System.Drawing.Color.Silver;
            this.button17.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.button17.FlatAppearance.BorderSize = 3;
            this.button17.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Font = new System.Drawing.Font("Candara", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button17.Location = new System.Drawing.Point(74, 83);
            this.button17.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(50, 50);
            this.button17.TabIndex = 10;
            this.button17.Text = "6";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.click_Event);
            // 
            // button18
            // 
            this.button18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button18.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button18.BackColor = System.Drawing.Color.Silver;
            this.button18.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.button18.FlatAppearance.BorderSize = 3;
            this.button18.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Font = new System.Drawing.Font("Candara", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button18.Location = new System.Drawing.Point(139, 83);
            this.button18.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(50, 50);
            this.button18.TabIndex = 11;
            this.button18.Text = "7";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.click_Event);
            // 
            // button19
            // 
            this.button19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button19.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button19.BackColor = System.Drawing.Color.Silver;
            this.button19.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.button19.FlatAppearance.BorderSize = 3;
            this.button19.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Font = new System.Drawing.Font("Candara", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button19.Location = new System.Drawing.Point(9, 83);
            this.button19.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(50, 50);
            this.button19.TabIndex = 12;
            this.button19.Text = "5";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.click_Event);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(418, 295);
            this.Controls.Add(this.adjustTimerButton);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.timerBox2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(600, 415);
            this.Name = "Form1";
            this.Text = "Tick Tick Timer";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox timerBox2;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Button adjustTimerButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox timerBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
    }
}

