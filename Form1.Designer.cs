using System.ComponentModel;
using System.Windows.Forms;

namespace Osu_mania_Dan_Accuracy_Calculator
{
    partial class dan_Calculator
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
            this.numericUpDown_MapCount = new System.Windows.Forms.NumericUpDown();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.danPresetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dDMythicalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.epsilonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deltaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gammaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.betaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alphaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shoegazerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tachyonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.luminalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thV2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thV2ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.thV2ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.thV2ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.thToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.thV2ToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.rdV2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ndV2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stV2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelMapCount = new System.Windows.Forms.Label();
            this.modeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_Maps = new Osu_mania_Dan_Accuracy_Calculator.DoubleBufferedPanel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MapCount)).BeginInit();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericUpDown_MapCount
            // 
            this.numericUpDown_MapCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown_MapCount.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_MapCount.Location = new System.Drawing.Point(435, 27);
            this.numericUpDown_MapCount.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDown_MapCount.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown_MapCount.Name = "numericUpDown_MapCount";
            this.numericUpDown_MapCount.Size = new System.Drawing.Size(52, 23);
            this.numericUpDown_MapCount.TabIndex = 1;
            this.numericUpDown_MapCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_MapCount.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown_MapCount.ValueChanged += new System.EventHandler(this.AdjustControlCount);
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danPresetToolStripMenuItem,
            this.modeToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(487, 25);
            this.menuStripMain.TabIndex = 3;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // danPresetToolStripMenuItem
            // 
            this.danPresetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dDMythicalToolStripMenuItem,
            this.shoegazerToolStripMenuItem});
            this.danPresetToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.danPresetToolStripMenuItem.Name = "danPresetToolStripMenuItem";
            this.danPresetToolStripMenuItem.Size = new System.Drawing.Size(174, 21);
            this.danPresetToolStripMenuItem.Text = "Dan preset: Custom";
            // 
            // dDMythicalToolStripMenuItem
            // 
            this.dDMythicalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.epsilonToolStripMenuItem,
            this.deltaToolStripMenuItem,
            this.gammaToolStripMenuItem,
            this.betaToolStripMenuItem,
            this.alphaToolStripMenuItem});
            this.dDMythicalToolStripMenuItem.Name = "dDMythicalToolStripMenuItem";
            this.dDMythicalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dDMythicalToolStripMenuItem.Text = "Reform";
            // 
            // epsilonToolStripMenuItem
            // 
            this.epsilonToolStripMenuItem.Name = "epsilonToolStripMenuItem";
            this.epsilonToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.epsilonToolStripMenuItem.Text = "Epsilon";
            this.epsilonToolStripMenuItem.Click += new System.EventHandler(this.danPreset_Click);
            // 
            // deltaToolStripMenuItem
            // 
            this.deltaToolStripMenuItem.Name = "deltaToolStripMenuItem";
            this.deltaToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.deltaToolStripMenuItem.Text = "Delta";
            this.deltaToolStripMenuItem.Click += new System.EventHandler(this.danPreset_Click);
            // 
            // gammaToolStripMenuItem
            // 
            this.gammaToolStripMenuItem.Name = "gammaToolStripMenuItem";
            this.gammaToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.gammaToolStripMenuItem.Text = "Gamma";
            this.gammaToolStripMenuItem.Click += new System.EventHandler(this.danPreset_Click);
            // 
            // betaToolStripMenuItem
            // 
            this.betaToolStripMenuItem.Name = "betaToolStripMenuItem";
            this.betaToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.betaToolStripMenuItem.Text = "Beta";
            this.betaToolStripMenuItem.Click += new System.EventHandler(this.danPreset_Click);
            // 
            // alphaToolStripMenuItem
            // 
            this.alphaToolStripMenuItem.Name = "alphaToolStripMenuItem";
            this.alphaToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.alphaToolStripMenuItem.Text = "Alpha";
            this.alphaToolStripMenuItem.Click += new System.EventHandler(this.danPreset_Click);
            // 
            // shoegazerToolStripMenuItem
            // 
            this.shoegazerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tachyonToolStripMenuItem,
            this.luminalToolStripMenuItem,
            this.thV2ToolStripMenuItem,
            this.thV2ToolStripMenuItem1,
            this.thV2ToolStripMenuItem2,
            this.thV2ToolStripMenuItem3,
            this.thToolStripMenuItem,
            this.thToolStripMenuItem1,
            this.thV2ToolStripMenuItem4,
            this.rdV2ToolStripMenuItem,
            this.ndV2ToolStripMenuItem,
            this.stV2ToolStripMenuItem});
            this.shoegazerToolStripMenuItem.Name = "shoegazerToolStripMenuItem";
            this.shoegazerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.shoegazerToolStripMenuItem.Text = "Shoegazer";
            // 
            // tachyonToolStripMenuItem
            // 
            this.tachyonToolStripMenuItem.Name = "tachyonToolStripMenuItem";
            this.tachyonToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.tachyonToolStripMenuItem.Text = "Tachyon v3";
            this.tachyonToolStripMenuItem.Click += new System.EventHandler(this.danPreset_Click);
            // 
            // luminalToolStripMenuItem
            // 
            this.luminalToolStripMenuItem.Name = "luminalToolStripMenuItem";
            this.luminalToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.luminalToolStripMenuItem.Text = "Luminal v2";
            this.luminalToolStripMenuItem.Click += new System.EventHandler(this.danPreset_Click);
            // 
            // thV2ToolStripMenuItem
            // 
            this.thV2ToolStripMenuItem.Name = "thV2ToolStripMenuItem";
            this.thV2ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.thV2ToolStripMenuItem.Text = "10th v2";
            this.thV2ToolStripMenuItem.Click += new System.EventHandler(this.danPreset_Click);
            // 
            // thV2ToolStripMenuItem1
            // 
            this.thV2ToolStripMenuItem1.Name = "thV2ToolStripMenuItem1";
            this.thV2ToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.thV2ToolStripMenuItem1.Text = "9th v2";
            this.thV2ToolStripMenuItem1.Click += new System.EventHandler(this.danPreset_Click);
            // 
            // thV2ToolStripMenuItem2
            // 
            this.thV2ToolStripMenuItem2.Name = "thV2ToolStripMenuItem2";
            this.thV2ToolStripMenuItem2.Size = new System.Drawing.Size(166, 22);
            this.thV2ToolStripMenuItem2.Text = "8th v2";
            this.thV2ToolStripMenuItem2.Click += new System.EventHandler(this.danPreset_Click);
            // 
            // thV2ToolStripMenuItem3
            // 
            this.thV2ToolStripMenuItem3.Name = "thV2ToolStripMenuItem3";
            this.thV2ToolStripMenuItem3.Size = new System.Drawing.Size(166, 22);
            this.thV2ToolStripMenuItem3.Text = "7th v2";
            this.thV2ToolStripMenuItem3.Click += new System.EventHandler(this.danPreset_Click);
            // 
            // thToolStripMenuItem
            // 
            this.thToolStripMenuItem.Name = "thToolStripMenuItem";
            this.thToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.thToolStripMenuItem.Text = "6th";
            this.thToolStripMenuItem.Click += new System.EventHandler(this.danPreset_Click);
            // 
            // thToolStripMenuItem1
            // 
            this.thToolStripMenuItem1.Name = "thToolStripMenuItem1";
            this.thToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.thToolStripMenuItem1.Text = "5th";
            this.thToolStripMenuItem1.Click += new System.EventHandler(this.danPreset_Click);
            // 
            // thV2ToolStripMenuItem4
            // 
            this.thV2ToolStripMenuItem4.Name = "thV2ToolStripMenuItem4";
            this.thV2ToolStripMenuItem4.Size = new System.Drawing.Size(166, 22);
            this.thV2ToolStripMenuItem4.Text = "4th v2";
            this.thV2ToolStripMenuItem4.Click += new System.EventHandler(this.danPreset_Click);
            // 
            // rdV2ToolStripMenuItem
            // 
            this.rdV2ToolStripMenuItem.Name = "rdV2ToolStripMenuItem";
            this.rdV2ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.rdV2ToolStripMenuItem.Text = "3rd v2";
            this.rdV2ToolStripMenuItem.Click += new System.EventHandler(this.danPreset_Click);
            // 
            // ndV2ToolStripMenuItem
            // 
            this.ndV2ToolStripMenuItem.Name = "ndV2ToolStripMenuItem";
            this.ndV2ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.ndV2ToolStripMenuItem.Text = "2nd v2";
            this.ndV2ToolStripMenuItem.Click += new System.EventHandler(this.danPreset_Click);
            // 
            // stV2ToolStripMenuItem
            // 
            this.stV2ToolStripMenuItem.Name = "stV2ToolStripMenuItem";
            this.stV2ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.stV2ToolStripMenuItem.Text = "1st v2";
            this.stV2ToolStripMenuItem.Click += new System.EventHandler(this.danPreset_Click);
            // 
            // labelMapCount
            // 
            this.labelMapCount.AutoSize = true;
            this.labelMapCount.BackColor = System.Drawing.Color.Transparent;
            this.labelMapCount.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMapCount.ForeColor = System.Drawing.Color.White;
            this.labelMapCount.Location = new System.Drawing.Point(377, 27);
            this.labelMapCount.Name = "labelMapCount";
            this.labelMapCount.Size = new System.Drawing.Size(60, 18);
            this.labelMapCount.TabIndex = 4;
            this.labelMapCount.Text = "Maps:";
            // 
            // panel_Maps
            // 
            this.panel_Maps.AutoScroll = true;
            this.panel_Maps.Font = new System.Drawing.Font("Verdana", 11F);
            this.panel_Maps.Location = new System.Drawing.Point(0, 27);
            this.panel_Maps.Name = "panel_Maps";
            this.panel_Maps.Size = new System.Drawing.Size(371, 215);
            this.panel_Maps.TabIndex = 2;
            // 
            // dan_Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(487, 242);
            this.Controls.Add(this.labelMapCount);
            this.Controls.Add(this.panel_Maps);
            this.Controls.Add(this.numericUpDown_MapCount);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "dan_Calculator";
            this.Text = "osu!mania Dan Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MapCount)).EndInit();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numericUpDown_MapCount;
        private MenuStrip menuStripMain;
        private ToolStripMenuItem danPresetToolStripMenuItem;
        private ToolStripMenuItem dDMythicalToolStripMenuItem;
        private ToolStripMenuItem epsilonToolStripMenuItem;
        private ToolStripMenuItem deltaToolStripMenuItem;
        private ToolStripMenuItem gammaToolStripMenuItem;
        private ToolStripMenuItem betaToolStripMenuItem;
        private ToolStripMenuItem alphaToolStripMenuItem;
        private ToolStripMenuItem shoegazerToolStripMenuItem;
        private ToolStripMenuItem tachyonToolStripMenuItem;
        private ToolStripMenuItem luminalToolStripMenuItem;
        private DoubleBufferedPanel panel_Maps;
        private ToolStripMenuItem thV2ToolStripMenuItem;
        private ToolStripMenuItem thV2ToolStripMenuItem1;
        private ToolStripMenuItem thV2ToolStripMenuItem2;
        private ToolStripMenuItem thV2ToolStripMenuItem3;
        private ToolStripMenuItem thToolStripMenuItem;
        private ToolStripMenuItem thToolStripMenuItem1;
        private ToolStripMenuItem thV2ToolStripMenuItem4;
        private ToolStripMenuItem rdV2ToolStripMenuItem;
        private ToolStripMenuItem ndV2ToolStripMenuItem;
        private ToolStripMenuItem stV2ToolStripMenuItem;
        private Label labelMapCount;
        private ToolStripMenuItem modeToolStripMenuItem;
    }
}

