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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageState = new System.Windows.Forms.TabPage();
            this.labelWorkTimeToday = new System.Windows.Forms.Label();
            this.labelWorkTimeMonth = new System.Windows.Forms.Label();
            this.labelWorkTimeWeek = new System.Windows.Forms.Label();
            this.tableLayoutButtonsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxPausing = new System.Windows.Forms.CheckBox();
            this.checkBoxWorking = new System.Windows.Forms.CheckBox();
            this.tabPageData = new System.Windows.Forms.TabPage();
            this.textBoxWorkTimeToday = new System.Windows.Forms.TextBox();
            this.textBoxWorkTimeWeek = new System.Windows.Forms.TextBox();
            this.textBoxWorkTimeMonth = new System.Windows.Forms.TextBox();
            this.labelPauseTimeToday = new System.Windows.Forms.Label();
            this.textBoxPausingTimeToday = new System.Windows.Forms.TextBox();
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
            this.tabControl1.Size = new System.Drawing.Size(615, 312);
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
            this.tabPageState.Size = new System.Drawing.Size(607, 286);
            this.tabPageState.TabIndex = 0;
            this.tabPageState.Text = "Status";
            this.tabPageState.UseVisualStyleBackColor = true;
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
            this.tableLayoutButtonsPanel.Controls.Add(this.checkBoxPausing, 0, 1);
            this.tableLayoutButtonsPanel.Controls.Add(this.checkBoxWorking, 0, 0);
            this.tableLayoutButtonsPanel.Location = new System.Drawing.Point(13, 29);
            this.tableLayoutButtonsPanel.Name = "tableLayoutButtonsPanel";
            this.tableLayoutButtonsPanel.RowCount = 2;
            this.tableLayoutButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutButtonsPanel.Size = new System.Drawing.Size(234, 219);
            this.tableLayoutButtonsPanel.TabIndex = 4;
            // 
            // checkBoxPausing
            // 
            this.checkBoxPausing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxPausing.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxPausing.Location = new System.Drawing.Point(3, 112);
            this.checkBoxPausing.Name = "checkBoxPausing";
            this.checkBoxPausing.Size = new System.Drawing.Size(228, 104);
            this.checkBoxPausing.TabIndex = 3;
            this.checkBoxPausing.Text = "Ich mache Pause";
            this.checkBoxPausing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxPausing.UseVisualStyleBackColor = true;
            this.checkBoxPausing.CheckedChanged += new System.EventHandler(this.CheckBoxPausingCheckedChanged);
            // 
            // checkBoxWorking
            // 
            this.checkBoxWorking.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxWorking.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxWorking.Location = new System.Drawing.Point(3, 3);
            this.checkBoxWorking.Name = "checkBoxWorking";
            this.checkBoxWorking.Size = new System.Drawing.Size(228, 103);
            this.checkBoxWorking.TabIndex = 2;
            this.checkBoxWorking.Text = "Ich arbeite";
            this.checkBoxWorking.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxWorking.UseVisualStyleBackColor = true;
            this.checkBoxWorking.CheckedChanged += new System.EventHandler(this.CheckBoxWorkingCheckedChanged);
            // 
            // tabPageData
            // 
            this.tabPageData.Location = new System.Drawing.Point(4, 22);
            this.tabPageData.Name = "tabPageData";
            this.tabPageData.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageData.Size = new System.Drawing.Size(907, 410);
            this.tabPageData.TabIndex = 1;
            this.tabPageData.Text = "Daten";
            this.tabPageData.UseVisualStyleBackColor = true;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 312);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Worky";
            this.tabControl1.ResumeLayout(false);
            this.tabPageState.ResumeLayout(false);
            this.tabPageState.PerformLayout();
            this.tableLayoutButtonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageState;
        private System.Windows.Forms.TabPage tabPageData;
        private System.Windows.Forms.CheckBox checkBoxPausing;
        private System.Windows.Forms.CheckBox checkBoxWorking;
        private System.Windows.Forms.TableLayoutPanel tableLayoutButtonsPanel;
        private System.Windows.Forms.Label labelWorkTimeToday;
        private System.Windows.Forms.Label labelWorkTimeMonth;
        private System.Windows.Forms.Label labelWorkTimeWeek;
        private System.Windows.Forms.TextBox textBoxPausingTimeToday;
        private System.Windows.Forms.Label labelPauseTimeToday;
        private System.Windows.Forms.TextBox textBoxWorkTimeMonth;
        private System.Windows.Forms.TextBox textBoxWorkTimeWeek;
        private System.Windows.Forms.TextBox textBoxWorkTimeToday;
    }
}

