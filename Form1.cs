using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Osu_mania_Dan_Accuracy_Calculator
{
    public partial class dan_Calculator : Form
    {

        public dan_Calculator()
        {
               
            InitializeComponent();

            #region form colors
            menuStripMain.BackColor = Color.FromArgb(36, 27, 47);
            this.BackColor = Color.FromArgb(38, 35, 53);

            numericUpDown_MapCount.Font = new Font("Verdana", 11, FontStyle.Bold);
            numericUpDown_MapCount.BackColor = Color.FromArgb(36, 27, 47);
            numericUpDown_MapCount.ForeColor = Color.FromArgb(224, 224, 224);

            labelMapCount.BackColor = Color.FromArgb(36, 27, 47);
            #endregion

            numericUpDown_MapCount.MouseWheel += anyNumericUpDown_MouseWheel;

            Label panelTitle = createPanelTitle(startX, startY, height, panel_Maps.Width);
            panel_Maps.Controls.Add(panelTitle);


            AdjustControlCount(null, EventArgs.Empty);

            panel_Maps.AutoScroll = false;
            panel_Maps.HorizontalScroll.Maximum = 0;
            panel_Maps.VerticalScroll.Visible = false;
            panel_Maps.AutoScroll = true;

        }
        int currentMapCount;
        List<Label> labels = new List<Label>();
        List<NumericUpDown> numAcc = new List<NumericUpDown>();
        List<NumericUpDown> numNotecount = new List<NumericUpDown>();
        List<TextBox> textBoxes = new List<TextBox>();
        int[] notecountValues = new int[4];
        float[] accValues = new float[4];
        bool modeSeparating = true;
        

        #region controls
        const int startX = 0;
        const int startY = 5;
        const int height = 24;
        const int labelWidth = 35;
        const int textBoxAccWidth = 75;
        const int textBoxNoteWidth = 90;

        private Label createPanelTitle(int startX, int startY, int height, int panelWidth)
        {
            return new Label
            {
                Name = "label_panelTitle",
                Size = new Size(panelWidth, height),
                Text = "    Total Acc:  Objects:    Individual Acc:",
                TextAlign = ContentAlignment.TopLeft,
                Location = new Point(startX, startY - 1),
                ForeColor = Color.White,
                Font = new Font("Verdana", 12, FontStyle.Bold)
            };
        }
        private Label createMapLabel(int i, int startX, int startY, int height, int labelWidth)
        {
            return new Label
            {
                Location = new Point(startX, startY + ((i + 1) * (height - 1))),
                Size = new Size(labelWidth, height),
                Name = $"labelMap{i}",
                Text = $"{i + 1}:",
                TextAlign = ContentAlignment.MiddleRight,
                ForeColor = Color.FromArgb(167, 154, 233)
            };
        }
        private NumericUpDown createAccuracyNumericUpDown(int i, int startX, int startY, int height, int labelWidth, int textBoxAccWidth)
        {
            var numericUpDownAcc = new NumericUpDown
            {
                Name = $"acc{i}",
                Text = null,
                Location = new Point(startX + labelWidth, startY + ((i + 1) * (height - 1))),
                Size = new Size(textBoxAccWidth, height),
                TextAlign = HorizontalAlignment.Right,
                Maximum = 100,
                Minimum = 0,
                DecimalPlaces = 2,
                Increment = 1,
                Font = new Font("Verdana", 11, FontStyle.Bold),
                BackColor = Color.FromArgb(36, 24, 38),
                ForeColor = Color.FromArgb(224, 224, 224),
            };
            numericUpDownAcc.ResetText();
            ReplaceNumericArrowsWithPercent(numericUpDownAcc);
            numericUpDownAcc.ValueChanged += anyNumericUpDown_ValueChanged;
            numericUpDownAcc.MouseWheel += anyNumericUpDown_MouseWheel;
            return numericUpDownAcc;
        }
        private NumericUpDown createNoteCountNumericUpDown(int i, int startX, int startY, int height, int labelWidth, int textBoxAccWidth, int textBoxNoteWidth)
        {
            var numericUpDownMap = new NumericUpDown
            {
                Name = $"notecount{i}",
                Location = new Point(startX + labelWidth + textBoxAccWidth, startY + ((i + 1) * (height - 1))),
                Size = new Size(textBoxNoteWidth, height),
                TextAlign = HorizontalAlignment.Right,
                Font = new Font("Verdana", 11, FontStyle.Bold),
                DecimalPlaces = 0,
                Minimum = 1,
                Maximum = 999999,
                Increment = 1,
                BackColor = Color.FromArgb(36, 24, 38),
                ForeColor = Color.FromArgb(224, 224, 224),
            };
            numericUpDownMap.ResetText();
            numericUpDownMap.ValueChanged += anyNumericUpDown_ValueChanged;
            numericUpDownMap.MouseWheel += anyNumericUpDown_MouseWheel;
            return numericUpDownMap;
        }
        private TextBox createIndividualAccuracyTextBox(int i, int startX, int startY, int height, int labelWidth, int textBoxAccWidth, int textBoxNoteWidth)
        {
            return new TextBox
            {
                Name = $"textBoxIndividualAcc{i}",
                TextAlign = HorizontalAlignment.Right,
                Location = new Point(startX + labelWidth + textBoxAccWidth + textBoxNoteWidth + 40, startY + ((i + 1) * (height - 1))),
                Size = new Size(textBoxAccWidth, height),
                Text = null,
                ReadOnly = true,
                Font = new Font("Verdana", 11, FontStyle.Bold),
                BackColor = Color.FromArgb(38, 35, 53),
                ForeColor = Color.FromArgb(224, 224, 224),
            };
        }
        #endregion

        private void AdjustControlCount(object sender, EventArgs e) 
        {
            int mapsTemp = (int)numericUpDown_MapCount.Value;
            Array.Resize(ref notecountValues, mapsTemp);
            Array.Resize(ref accValues, mapsTemp);

            //remove controls
            while (labels.Count > mapsTemp)
            {
                panel_Maps.Controls.Remove(labels[labels.Count - 1]);
                labels.RemoveAt(labels.Count - 1);
            }
            while (numAcc.Count > mapsTemp)
            {
                panel_Maps.Controls.Remove(numAcc[numAcc.Count - 1]);
                numAcc.RemoveAt(numAcc.Count - 1);
            }
            while (numNotecount.Count > mapsTemp)
            {
                panel_Maps.Controls.Remove(numNotecount[numNotecount.Count - 1]);
                numNotecount.RemoveAt(numNotecount.Count - 1);
            }
            while (textBoxes.Count > mapsTemp)
            {
                panel_Maps.Controls.Remove(textBoxes[textBoxes.Count - 1]);
                textBoxes.RemoveAt(textBoxes.Count - 1);
            }

            //add controls
            for (int i = currentMapCount; i < mapsTemp; i++)
            {
                Label label = createMapLabel(i,startX, startY, height, labelWidth);
                panel_Maps.Controls.Add(label); labels.Add(label);

                NumericUpDown numericAcc = createAccuracyNumericUpDown(i, startX, startY, height, labelWidth, textBoxAccWidth);
                panel_Maps.Controls.Add(numericAcc); numAcc.Add(numericAcc);

                NumericUpDown numericNotecount = createNoteCountNumericUpDown(i, startX, startY, height, labelWidth, textBoxAccWidth, textBoxNoteWidth);
                panel_Maps.Controls.Add(numericNotecount); numNotecount.Add(numericNotecount);

                TextBox textBox = createIndividualAccuracyTextBox(i, startX, startY, height, labelWidth, textBoxAccWidth, textBoxNoteWidth);
                panel_Maps.Controls.Add(textBox); textBoxes.Add(textBox);
            }

            currentMapCount = mapsTemp;

            storeValuesAndCalculate();
        }

        private void anyNumericUpDown_ValueChanged(object sender, EventArgs e) { storeValuesAndCalculate(); }
        private void anyNumericUpDown_MouseWheel(object sender, MouseEventArgs e)
        {
            NumericUpDown numericUpDown = sender as NumericUpDown;
            if (numericUpDown == null) { return; }

            decimal defaultIncrement; decimal shiftedIncrement; int ctrledIncrement;
            if (numericUpDown.Name.StartsWith("acc")) { defaultIncrement = 0.5m; shiftedIncrement = 0.01m; ctrledIncrement = 5; }
            else if (numericUpDown.Name.StartsWith("notecount")) { defaultIncrement = 100; shiftedIncrement = 1; ctrledIncrement = 1000; }
            else { defaultIncrement = 0; shiftedIncrement = 1; ctrledIncrement = 2; }

            decimal numericUpDownIncrement = Control.ModifierKeys == Keys.Shift ? shiftedIncrement : defaultIncrement;
            numericUpDownIncrement = Control.ModifierKeys == Keys.Control ? ctrledIncrement : numericUpDownIncrement;

            
            if (e.Delta > 0) // mouse wheel up
            {
                if (numericUpDown.Value + numericUpDownIncrement < numericUpDown.Maximum) { numericUpDown.Value += numericUpDownIncrement; }
                else if (numericUpDown.Value == numericUpDown.Maximum && numericUpDown != numericUpDown_MapCount) { numericUpDown.Value = numericUpDown.Minimum; }
                
                else { numericUpDown.Value = numericUpDown.Maximum; } 
            }
            else if (e.Delta < 0) // mouse wheel down
            {
                if (numericUpDown.Value - numericUpDownIncrement > numericUpDown.Minimum) { numericUpDown.Value -= numericUpDownIncrement; }
                else if (numericUpDown.Value == numericUpDown.Minimum && numericUpDown != numericUpDown_MapCount) { numericUpDown.Value = numericUpDown.Maximum; }

                else { numericUpDown.Value = numericUpDown.Minimum; }
            } 

            ((HandledMouseEventArgs)e).Handled = true;

            storeValuesAndCalculate();
        }

        //calculation
        private void storeValuesAndCalculate()
        {
            bool cancelCalculation = false;

            // stores acc and notecount values
            foreach (Control control in panel_Maps.Controls) 
            {
                if (!(control is NumericUpDown)) { continue; }
                if (control.Text == string.Empty)
                {
                    clearTextBoxes();
                    cancelCalculation = true;
                } // cancels calculation

                if (control.Name.StartsWith("acc") && control is NumericUpDown accVals)
                {
                    int i = int.Parse(control.Name.Substring(3));
                    if (control.Text == string.Empty) { accValues[i] = 0; continue; } //handles empty
                    accValues[i] = float.Parse(control.Text);
                    if (accValues[i] == 100) { accVals.DecimalPlaces = 0; } else { accVals.DecimalPlaces = 2; }
                }
                else if (control.Name.StartsWith("notecount"))
                {
                    int i = int.Parse(control.Name.Substring(9));
                    if (control.Text == string.Empty) { notecountValues[i] = 0; continue; } //handles empty
                    notecountValues[i] = int.Parse(control.Text);
                }

            }
            setPreset(null, Dans.checkDanMatch(notecountValues));
            if (cancelCalculation) { return; }

            //writes down the calculation results into textBoxes
            int noteCountSoFar = 0;
            double previousAccuracy = 0;
            for(int i = 0; i < currentMapCount; i++)
            {
                textBoxes[i].ForeColor = Color.FromArgb(224, 224, 224);
                double latterMapAcc = map2IndividualAcc(previousAccuracy, noteCountSoFar, accValues[i], notecountValues[i]);

                if (latterMapAcc < 0 || latterMapAcc > 100) { textBoxes[i].ForeColor = Color.FromArgb(254, 68, 80); }
                textBoxes[i].Text =  latterMapAcc + "%";

                previousAccuracy = accValues[i];
                noteCountSoFar += notecountValues[i];
            }
        }
        private double map2IndividualAcc(double firstAcc, int firstNoteCount, double totalAcc, int latterNoteCount)
        {
            int totalNoteCount = firstNoteCount + latterNoteCount;
            double latterAcc = ((totalNoteCount * totalAcc) - (firstNoteCount * firstAcc)) / latterNoteCount;
            return Math.Round(latterAcc*100)/100;
        }



        private void clearTextBoxes()
        {
            foreach(Control control in panel_Maps.Controls)
            {
                if(control is TextBox textBox)
                {
                    textBox.BackColor = Color.FromArgb(36, 24, 38);
                    textBox.Text = string.Empty;
                }
            }
        }
        private void ReplaceNumericArrowsWithPercent(NumericUpDown numericUpDown)
        {
            // Remove the arrow buttons
            numericUpDown.Controls[0].Visible = false;
            numericUpDown.Controls[0].BackColor = Color.FromArgb(36, 24, 38);

            
            // Add the "%" label
            Label labelPercent = new Label();
            labelPercent.Text = "%";
            labelPercent.Location = new Point(numericUpDown.Width - 19, 1);
            labelPercent.Size = new Size(20, numericUpDown.Height-2);
            labelPercent.Font = new Font("Verdana", 9, FontStyle.Bold);
            labelPercent.TextAlign = ContentAlignment.MiddleLeft;
            labelPercent.ForeColor = Color.White;
            labelPercent.BackColor = Color.FromArgb(36, 24, 38);
            numericUpDown.Controls.Add(labelPercent);
        }

        private void setPreset(int[] mapNoteCounts, string danName)
        {
            if (danName == "custom") { danPresetToolStripMenuItem.Text = $"No Preset"; danPresetToolStripMenuItem.ForeColor = Color.Red; }
            else { danPresetToolStripMenuItem.Text = danName; danPresetToolStripMenuItem.ForeColor = Color.Lime; }
            
            if (mapNoteCounts == null) { return; }

            numericUpDown_MapCount.Value = mapNoteCounts.Length;
            if (danName == "custom") { danPresetToolStripMenuItem.Text = $"No Preset"; danPresetToolStripMenuItem.ForeColor = Color.Red; }
            else { danPresetToolStripMenuItem.Text = danName; danPresetToolStripMenuItem.ForeColor = Color.Lime; }

            NumericUpDown[] notecountNumericUpDowns = new NumericUpDown[mapNoteCounts.Length];
            foreach (Control control in panel_Maps.Controls)
            {
                if (control is NumericUpDown notecountNumericUpDown)
                {
                    if(!(control.Name.StartsWith("notecount"))) { continue; }

                    if (int.TryParse(control.Name.Substring(9), out int index))
                    {
                        notecountNumericUpDowns[index] = notecountNumericUpDown;
                        continue;
                    }
                    else { MessageBox.Show("calculation textBox index preset error"); }
                }
            }

            for (int i = 0; i < mapNoteCounts.Length; i++)
            {
                try { notecountNumericUpDowns[i].Value = mapNoteCounts[i]; }
                catch
                {
                    MessageBox.Show("Dan notecounts missing data \r\n I'm a lazy man, You'll have to find them yourself. \r\n\r\n (if you do so, please tell me the object counts on discord (kfcadmin) so I can add them)"); 
                    foreach (NumericUpDown notecounts in notecountNumericUpDowns) { notecounts.ResetText(); }
                    storeValuesAndCalculate();
                    return;
                }
            }
            storeValuesAndCalculate();
        }
        private void danPreset_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem selectedDan = (ToolStripMenuItem)sender;
            string clickedDanSystemName = selectedDan.OwnerItem.Text;
            string clickedDanName = selectedDan.Text;

            string fullDanName = clickedDanSystemName + ": " + clickedDanName;

            Dans dansInstance = new Dans();

            int[] data = dansInstance.GetIntArray(fullDanName);

            setPreset(data, fullDanName);
        }
    }

    public class DoubleBufferedPanel : Panel
    {
        public DoubleBufferedPanel()
        {
            this.DoubleBuffered = true;
            this.ResizeRedraw = true;
        }
    }

    public class Dans
    {
        #region dan objects
        // Reform DDMythical
        public static readonly int[] Epsilon = { 2128, 2542, 2194, 2829 };
        public static readonly int[] Delta = { 2018, 2711, 3268, 2629 };
        public static readonly int[] Gamma = { 1973, 1980, 1429, 3979 };
        public static readonly int[] Beta = { 2277, 2308, 1740, 2302 };
        public static readonly int[] Alpha = { 2265, 1528, 2300, 3334 };
        public static readonly int[] rf10th = { 1906, 1460, 1723, 2392};
        public static readonly int[] rf9th = { 2114, 2070, 1674, 2271};
        public static readonly int[] rf8th = { 2177, 1309, 1608, 1859 };
        public static readonly int[] rf7th = { 2114, 1777, 1081, 2734 };
        public static readonly int[] rf6th = { 1487, 1266, 1378, 2186 };
        public static readonly int[] rf5th = { 1293, 1722, 1126, 1903 };
        public static readonly int[] rf4th = { 980, 1499, 1283, 2071 };
        public static readonly int[] rf3rd = { 905, 797, 1047, 1259 };
        public static readonly int[] rf2nd = { 1107, 905, 955, 1487 };
        public static readonly int[] rf1st = { 878, 696, 954, 1167 };
        // Shoegazer
        public static readonly int[] Tachyon_v3 = { 3037, 2859, 2412, 2708 };
        public static readonly int[] Luminal_v2 = { 1761, 2308, 2925, 3453 };
        public static readonly int[] sg10th_v2 = { 1906, 3194, 2549, 2438 };
        public static readonly int[] sg9th_v2 = { 2114, 1777, 2367, 2987 };
        public static readonly int[] sg8th_v2 = { 2288, 0, 0, 2214 }; // to fill
        public static readonly int[] sg7th_v2 = { 2110, 1779, 2024, 1777 };
        public static readonly int[] sg6th = { 1875, 1494, 1674, 2186 };
        public static readonly int[] sg5th = { 1671, 2323, 2189, 0 }; // to fill
        public static readonly int[] sg4th_v2 = { -1, 0, 0, 0}; // to fill
        public static readonly int[] sg3rd_v2 = { -1, 0, 0, 0}; // to fill
        public static readonly int[] sg2nd_v2 = { -1, 0, 0, 0}; // to fill
        public static readonly int[] sg1st_v2 = { -1, 0, 0, 0}; // to fill

        public static Dictionary<string, int[]> danArrayNameMap = new Dictionary<string, int[]>()
        {
                { "Reform: Epsilon", Epsilon },
                { "Reform: Delta", Delta },
                { "Reform: Gamma", Gamma },
                { "Reform: Beta", Beta },
                { "Reform: Alpha", Alpha },
                { "Reform: 10th", rf10th },
                { "Reform: 9th", rf9th },
                { "Reform: 8th", rf8th },
                { "Reform: 7th", rf7th },
                { "Reform: 6th", rf6th },
                { "Reform: 5th", rf5th },
                { "Reform: 4th", rf4th },
                { "Reform: 3rd", rf3rd },
                { "Reform: 2nd", rf2nd },
                { "Reform: 1st", rf1st },

                { "Shoegazer: Tachyon v3", Tachyon_v3 },
                { "Shoegazer: Luminal v2", Luminal_v2 },
                { "Shoegazer: 10th v2", sg10th_v2 },
                { "Shoegazer: 9th v2", sg9th_v2 },
                { "Shoegazer: 8th v2", sg8th_v2 },
                { "Shoegazer: 7th v2", sg7th_v2 },
                { "Shoegazer: 6th", sg6th},
                { "Shoegazer: 5th", sg5th},
                { "Shoegazer: 4th v2", sg4th_v2 },
                { "Shoegazer: 3rd v2", sg3rd_v2 },
                { "Shoegazer: 2nd v2", sg2nd_v2 },
                { "Shoegazer: 1st v2", sg1st_v2 },
        };
        #endregion

        public int[] GetIntArray(string menuItemName)
        {
            if (danArrayNameMap.TryGetValue(menuItemName, out int[] data))
            {
                return data;
            }
            else
            {
                return null; // No matching array found
            }
        }

        public static string checkDanMatch(int[] noteCounts)
        {
            foreach (var kvp in Dans.danArrayNameMap)
            {
                if (kvp.Value.SequenceEqual(noteCounts))
                {
                    return kvp.Key;
                }
            }
            return "custom";
        }
    }
}