namespace Worky
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageState = new System.Windows.Forms.TabPage();
            this.textBoxPausingTimeToday = new System.Windows.Forms.TextBox();
            this.labelPauseTimeToday = new System.Windows.Forms.Label();
            this.textBoxWorkTimeMonth = new System.Windows.Forms.TextBox();
            this.textBoxWorkTimeWeek = new System.Windows.Forms.TextBox();
            this.textBoxWorkTimeToday = new System.Windows.Forms.TextBox();
            this.labelWorkTimeToday = new System.Windows.Forms.Label();
            this.labelWorkTimeMonth = new System.Windows.Forms.Label();
            this.labelWorkTimeWeek = new System.Windows.Forms.Label();
            this.tableLayoutButtonsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.radioButtonPausing = new System.Windows.Forms.RadioButton();
            this.radioButtonWorking = new System.Windows.Forms.RadioButton();
            this.tabPageData = new System.Windows.Forms.TabPage();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPageState.SuspendLayout();
            this.tableLayoutButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageState);
            this.tabControl1.Controls.Add(this.tabPageData);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(615, 558);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageState
            // 
            this.tabPageState.Controls.Add(this.textBoxPausingTimeToday);
            this.tabPageState.Controls.Add(this.labelPauseTimeToday);
            this.tabPageState.Controls.Add(this.textBoxWorkTimeMonth);
            this.tabPageState.Controls.Add(this.textBoxWorkTimeWeek);
            this.tabPageState.Controls.Add(this.textBoxWorkTimeToday);
            this.tabPageState.Controls.Add(this.labelWorkTimeToday);
            this.tabPageState.Controls.Add(this.labelWorkTimeMonth);
            this.tabPageState.Controls.Add(this.labelWorkTimeWeek);
            this.tabPageState.Controls.Add(this.tableLayoutButtonsPanel);
            this.tabPageState.Location = new System.Drawing.Point(4, 22);
            this.tabPageState.Name = "tabPageState";
            this.tabPageState.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageState.Size = new System.Drawing.Size(607, 532);
            this.tabPageState.TabIndex = 0;
            this.tabPageState.Text = "Status";
            this.tabPageState.UseVisualStyleBackColor = true;
            // 
            // textBoxPausingTimeToday
            // 
            this.textBoxPausingTimeToday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPausingTimeToday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPausingTimeToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPausingTimeToday.Location = new System.Drawing.Point(469, 64);
            this.textBoxPausingTimeToday.Name = "textBoxPausingTimeToday";
            this.textBoxPausingTimeToday.ReadOnly = true;
            this.textBoxPausingTimeToday.Size = new System.Drawing.Size(130, 26);
            this.textBoxPausingTimeToday.TabIndex = 12;
            // 
            // labelPauseTimeToday
            // 
            this.labelPauseTimeToday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPauseTimeToday.AutoSize = true;
            this.labelPauseTimeToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPauseTimeToday.Location = new System.Drawing.Point(257, 66);
            this.labelPauseTimeToday.Name = "labelPauseTimeToday";
            this.labelPauseTimeToday.Size = new System.Drawing.Size(137, 20);
            this.labelPauseTimeToday.TabIndex = 11;
            this.labelPauseTimeToday.Text = "Pausenzeit heute:";
            // 
            // textBoxWorkTimeMonth
            // 
            this.textBoxWorkTimeMonth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxWorkTimeMonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxWorkTimeMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWorkTimeMonth.Location = new System.Drawing.Point(469, 227);
            this.textBoxWorkTimeMonth.Name = "textBoxWorkTimeMonth";
            this.textBoxWorkTimeMonth.ReadOnly = true;
            this.textBoxWorkTimeMonth.Size = new System.Drawing.Size(130, 26);
            this.textBoxWorkTimeMonth.TabIndex = 10;
            // 
            // textBoxWorkTimeWeek
            // 
            this.textBoxWorkTimeWeek.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxWorkTimeWeek.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxWorkTimeWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWorkTimeWeek.Location = new System.Drawing.Point(469, 192);
            this.textBoxWorkTimeWeek.Name = "textBoxWorkTimeWeek";
            this.textBoxWorkTimeWeek.ReadOnly = true;
            this.textBoxWorkTimeWeek.Size = new System.Drawing.Size(130, 26);
            this.textBoxWorkTimeWeek.TabIndex = 9;
            // 
            // textBoxWorkTimeToday
            // 
            this.textBoxWorkTimeToday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxWorkTimeToday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxWorkTimeToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWorkTimeToday.Location = new System.Drawing.Point(469, 32);
            this.textBoxWorkTimeToday.Name = "textBoxWorkTimeToday";
            this.textBoxWorkTimeToday.ReadOnly = true;
            this.textBoxWorkTimeToday.Size = new System.Drawing.Size(130, 26);
            this.textBoxWorkTimeToday.TabIndex = 8;
            // 
            // labelWorkTimeToday
            // 
            this.labelWorkTimeToday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWorkTimeToday.AutoSize = true;
            this.labelWorkTimeToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWorkTimeToday.Location = new System.Drawing.Point(257, 32);
            this.labelWorkTimeToday.Name = "labelWorkTimeToday";
            this.labelWorkTimeToday.Size = new System.Drawing.Size(133, 20);
            this.labelWorkTimeToday.TabIndex = 7;
            this.labelWorkTimeToday.Text = "Arbeitszeit heute:";
            // 
            // labelWorkTimeMonth
            // 
            this.labelWorkTimeMonth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWorkTimeMonth.AutoSize = true;
            this.labelWorkTimeMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWorkTimeMonth.Location = new System.Drawing.Point(257, 227);
            this.labelWorkTimeMonth.Name = "labelWorkTimeMonth";
            this.labelWorkTimeMonth.Size = new System.Drawing.Size(188, 20);
            this.labelWorkTimeMonth.TabIndex = 6;
            this.labelWorkTimeMonth.Text = "Arbeitszeit diesen Monat:";
            // 
            // labelWorkTimeWeek
            // 
            this.labelWorkTimeWeek.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWorkTimeWeek.AutoSize = true;
            this.labelWorkTimeWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWorkTimeWeek.Location = new System.Drawing.Point(257, 192);
            this.labelWorkTimeWeek.Name = "labelWorkTimeWeek";
            this.labelWorkTimeWeek.Size = new System.Drawing.Size(184, 20);
            this.labelWorkTimeWeek.TabIndex = 5;
            this.labelWorkTimeWeek.Text = "Arbeitszeit diese Woche:";
            // 
            // tableLayoutButtonsPanel
            // 
            this.tableLayoutButtonsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutButtonsPanel.ColumnCount = 1;
            this.tableLayoutButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutButtonsPanel.Controls.Add(this.radioButtonPausing, 0, 1);
            this.tableLayoutButtonsPanel.Controls.Add(this.radioButtonWorking, 0, 0);
            this.tableLayoutButtonsPanel.Location = new System.Drawing.Point(13, 29);
            this.tableLayoutButtonsPanel.Name = "tableLayoutButtonsPanel";
            this.tableLayoutButtonsPanel.RowCount = 2;
            this.tableLayoutButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutButtonsPanel.Size = new System.Drawing.Size(234, 465);
            this.tableLayoutButtonsPanel.TabIndex = 4;
            // 
            // radioButtonPausing
            // 
            this.radioButtonPausing.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonPausing.AutoSize = true;
            this.radioButtonPausing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonPausing.Location = new System.Drawing.Point(3, 235);
            this.radioButtonPausing.Name = "radioButtonPausing";
            this.radioButtonPausing.Size = new System.Drawing.Size(228, 227);
            this.radioButtonPausing.TabIndex = 14;
            this.radioButtonPausing.TabStop = true;
            this.radioButtonPausing.Text = "Ich mache Pause";
            this.radioButtonPausing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonPausing.UseVisualStyleBackColor = true;
            // 
            // radioButtonWorking
            // 
            this.radioButtonWorking.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonWorking.AutoSize = true;
            this.radioButtonWorking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonWorking.Location = new System.Drawing.Point(3, 3);
            this.radioButtonWorking.Name = "radioButtonWorking";
            this.radioButtonWorking.Size = new System.Drawing.Size(228, 226);
            this.radioButtonWorking.TabIndex = 13;
            this.radioButtonWorking.TabStop = true;
            this.radioButtonWorking.Text = "Ich arbeite";
            this.radioButtonWorking.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonWorking.UseVisualStyleBackColor = true;
            // 
            // tabPageData
            // 
            this.tabPageData.Location = new System.Drawing.Point(4, 22);
            this.tabPageData.Name = "tabPageData";
            this.tabPageData.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageData.Size = new System.Drawing.Size(607, 532);
            this.tabPageData.TabIndex = 1;
            this.tabPageData.Text = "Daten";
            this.tabPageData.UseVisualStyleBackColor = true;
            // 
            // timer
            // 
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.Timer_Ticked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 558);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Worky";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageState.ResumeLayout(false);
            this.tabPageState.PerformLayout();
            this.tableLayoutButtonsPanel.ResumeLayout(false);
            this.tableLayoutButtonsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageState;
        private System.Windows.Forms.TabPage tabPageData;
        private System.Windows.Forms.TableLayoutPanel tableLayoutButtonsPanel;
        private System.Windows.Forms.Label labelWorkTimeToday;
        private System.Windows.Forms.Label labelWorkTimeMonth;
        private System.Windows.Forms.Label labelWorkTimeWeek;
        private System.Windows.Forms.TextBox textBoxPausingTimeToday;
        private System.Windows.Forms.Label labelPauseTimeToday;
        private System.Windows.Forms.TextBox textBoxWorkTimeMonth;
        private System.Windows.Forms.TextBox textBoxWorkTimeWeek;
        private System.Windows.Forms.TextBox textBoxWorkTimeToday;
        private System.Windows.Forms.RadioButton radioButtonPausing;
        private System.Windows.Forms.RadioButton radioButtonWorking;
        private System.Windows.Forms.Timer timer;
    }
}

