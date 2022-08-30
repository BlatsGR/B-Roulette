using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B_Roulette
{
    public partial class Main : MaterialForm
    {
        int i = 0, low = 0, high = 0, red = 0, black = 0, odd = 0, even = 0, trigger = 0, trigger1 = 0;
        List<string> rouletteResults = new List<string>();
        public Main()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightBlue800, Primary.LightBlue900, Primary.LightBlue500, Accent.LightBlue200, TextShade.WHITE);
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        #region GUI Settings
        MaterialSkinManager ThemeManager = MaterialSkinManager.Instance; //constructor for theme dark and light
        private void materialSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (themeSwitcher.Checked)
            {
                ThemeManager.Theme = MaterialSkinManager.Themes.DARK;
            }
            else
            {
                ThemeManager.Theme = MaterialSkinManager.Themes.LIGHT;
            }
        }

        private void txtResult_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtResults();
                txtResult.Text = string.Empty;     
            }
        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtResult.Text, "[^0-9]"))
            {
               txtResult.Text = string.Empty;
            } 
        }
        #endregion

        #region Arrays
        string[,] roulette = new string[37 , 4] { {"0", "ZERO", "GREEN", "ZERO"},
                                                  {"1", "LOW", "RED", "ODD"},
                                                  {"2", "LOW", "BLACK", "EVEN"},
                                                  {"3", "LOW", "RED", "ODD"},
                                                  {"4", "LOW", "BLACK", "EVEN"},
                                                  {"5", "LOW", "RED", "ODD"},
                                                  {"6", "LOW", "BLACK", "EVEN"},
                                                  {"7", "LOW", "RED", "ODD"},
                                                  {"8", "LOW", "BLACK", "EVEN"},
                                                  {"9", "LOW", "RED", "ODD"},
                                                  {"10", "LOW", "BLACK", "EVEN"},
                                                  {"11", "LOW", "BLACK", "ODD"},
                                                  {"12", "LOW", "RED", "EVEN"},
                                                  {"13", "LOW", "BLACK", "ODD"},
                                                  {"14", "LOW", "RED", "EVEN"},
                                                  {"15", "LOW", "BLACK", "ODD"},
                                                  {"16", "LOW", "RED", "EVEN"},
                                                  {"17", "LOW", "BLACK", "ODD"},
                                                  {"18", "LOW", "RED", "EVEN"},
                                                  {"19", "HIGH", "RED", "ODD"},
                                                  {"20", "HIGH", "BLACK", "EVEN"},
                                                  {"21", "HIGH", "RED", "ODD"},
                                                  {"22", "HIGH", "BLACK", "EVEN"},
                                                  {"23", "HIGH", "RED", "ODD"},
                                                  {"24", "HIGH", "BLACK", "EVEN"},
                                                  {"25", "HIGH", "RED", "ODD"},
                                                  {"26", "HIGH", "BLACK", "EVEN"},
                                                  {"27", "HIGH", "RED", "ODD"},
                                                  {"28", "HIGH", "BLACK", "EVEN"},
                                                  {"29", "HIGH", "BLACK", "ODD"},
                                                  {"30", "HIGH", "RED", "EVEN"},
                                                  {"31", "HIGH", "BLACK", "ODD"},
                                                  {"32", "HIGH", "RED", "EVEN"},
                                                  {"33", "HIGH", "BLACK", "ODD"},
                                                  {"34", "HIGH", "RED", "EVEN"},
                                                  {"35", "HIGH", "BLACK", "ODD"},
                                                  {"36", "HIGH", "RED", "EVEN"}};
        #endregion

        #region Text Results
        private void txtResults()
        {
            int result;
            if (txtResult.Text == "0")
            {
                txtResult.Text = string.Empty;
                lblResult.Text = roulette[0, 0].ToString() + " =  " + roulette[0, 1].ToString() + "  " + roulette[0, 2].ToString() + "  " + roulette[0, 3].ToString();
            }
            else if (txtResult.Text == "1")
            {
                lblResult.Text = roulette[1, 0].ToString() + " =  " + roulette[1, 1].ToString() + "  " + roulette[1, 2].ToString() + "  " + roulette[1, 3].ToString();
                high++;
                black++;
                even++;
            }
            else if (txtResult.Text == "2")
            {
                lblResult.Text = roulette[2, 0].ToString() + " =  " + roulette[2, 1].ToString() + "  " + roulette[2, 2].ToString() + "  " + roulette[2, 3].ToString();
                high++;
                red++;
                odd++;
            }
            else if (txtResult.Text == "3")
            {
                lblResult.Text = roulette[3, 0].ToString() + " =  " + roulette[3, 1].ToString() + "  " + roulette[3, 2].ToString() + "  " + roulette[3, 3].ToString();
                high++;
                black++;
                even++;
            }
            else if (txtResult.Text == "4")
            {
                lblResult.Text = roulette[4, 0].ToString() + " =  " + roulette[4, 1].ToString() + "  " + roulette[4, 2].ToString() + "  " + roulette[4, 3].ToString();
                high++;
                red++;
                odd++;
            }
            else if (txtResult.Text == "5")
            {
                lblResult.Text = roulette[5, 0].ToString() + " =  " + roulette[5, 1].ToString() + "  " + roulette[5, 2].ToString() + "  " + roulette[5, 3].ToString();
                high++;
                black++;
                even++;
            }
            else if (txtResult.Text == "6")
            {
                lblResult.Text = roulette[6, 0].ToString() + " =  " + roulette[6, 1].ToString() + "  " + roulette[6, 2].ToString() + "  " + roulette[6, 3].ToString();
                high++;
                red++;
                odd++;
            }
            else if (txtResult.Text == "7")
            {
                lblResult.Text = roulette[7, 0].ToString() + " =  " + roulette[7, 1].ToString() + "  " + roulette[7, 2].ToString() + "  " + roulette[7, 3].ToString();
                high++;
                black++;
                even++;
            }
            else if (txtResult.Text == "8")
            {
                lblResult.Text = roulette[8, 0].ToString() + " =  " + roulette[8, 1].ToString() + "  " + roulette[8, 2].ToString() + "  " + roulette[8, 3].ToString();
                high++;
                red++;
                odd++;
            }
            else if (txtResult.Text == "9")
            {
                lblResult.Text = roulette[9, 0].ToString() + " =  " + roulette[9, 1].ToString() + "  " + roulette[9, 2].ToString() + "  " + roulette[9, 3].ToString();
                high++;
                black++;
                even++;
            }
            else if (txtResult.Text == "10")
            {
                lblResult.Text = roulette[10, 0].ToString() + " =  " + roulette[10, 1].ToString() + "  " + roulette[10, 2].ToString() + "  " + roulette[10, 3].ToString();
                high++;
                red++;
                odd++;
            }
            else if (txtResult.Text == "11")
            {
                lblResult.Text = roulette[11, 0].ToString() + " =  " + roulette[11, 1].ToString() + "  " + roulette[11, 2].ToString() + "  " + roulette[11, 3].ToString();
                high++;
                red++;
                even++;
            }
            else if (txtResult.Text == "12")
            {
                lblResult.Text = roulette[12, 0].ToString() + " =  " + roulette[12, 1].ToString() + "  " + roulette[12, 2].ToString() + "  " + roulette[12, 3].ToString();
                high++;
                black++;
                odd++;
            }
            else if (txtResult.Text == "13")
            {
                lblResult.Text = roulette[13, 0].ToString() + " =  " + roulette[13, 1].ToString() + "  " + roulette[13, 2].ToString() + "  " + roulette[13, 3].ToString();
                high++;
                red++;
                even++;
            }
            else if (txtResult.Text == "14")
            {
                lblResult.Text = roulette[14, 0].ToString() + " =  " + roulette[14, 1].ToString() + "  " + roulette[14, 2].ToString() + "  " + roulette[14, 3].ToString();
                high++;
                black++;
                odd++;
            }
            else if (txtResult.Text == "15")
            {
                lblResult.Text = roulette[15, 0].ToString() + " =  " + roulette[15, 1].ToString() + "  " + roulette[15, 2].ToString() + "  " + roulette[15, 3].ToString();
                high++;
                red++;
                even++;
            }
            else if (txtResult.Text == "16")
            {
                lblResult.Text = roulette[16, 0].ToString() + " =  " + roulette[16, 1].ToString() + "  " + roulette[16, 2].ToString() + "  " + roulette[16, 3].ToString();
                high++;
                black++;
                odd++;
            }
            else if (txtResult.Text == "17")
            {
                lblResult.Text = roulette[17, 0].ToString() + " =  " + roulette[17, 1].ToString() + "  " + roulette[17, 2].ToString() + "  " + roulette[17, 3].ToString();
                high++;
                red++;
                even++;
            }
            else if (txtResult.Text == "18")
            {
                lblResult.Text = roulette[18, 0].ToString() + " =  " + roulette[18, 1].ToString() + "  " + roulette[18, 2].ToString() + "  " + roulette[18, 3].ToString();
                high++;
                black++;
                odd++;
            }
            else if (txtResult.Text == "19")
            {
                lblResult.Text = roulette[19, 0].ToString() + " =  " + roulette[19, 1].ToString() + "  " + roulette[19, 2].ToString() + "  " + roulette[19, 3].ToString();
                low++;
                black++;
                even++;
            }
            else if (txtResult.Text == "20")
            {
                lblResult.Text = roulette[20, 0].ToString() + " =  " + roulette[20, 1].ToString() + "  " + roulette[20, 2].ToString() + "  " + roulette[20, 3].ToString();
                low++;
                red++;
                odd++;
            }
            else if (txtResult.Text == "21")
            {
                lblResult.Text = roulette[21, 0].ToString() + " =  " + roulette[21, 1].ToString() + "  " + roulette[21, 2].ToString() + "  " + roulette[21, 3].ToString();
                low++;
                black++;
                even++;
            }
            else if (txtResult.Text == "22")
            {
                lblResult.Text = roulette[22, 0].ToString() + " =  " + roulette[22, 1].ToString() + "  " + roulette[22, 2].ToString() + "  " + roulette[22, 3].ToString();
                low++;
                red++;
                odd++;
            }
            else if (txtResult.Text == "23")
            {
                lblResult.Text = roulette[23, 0].ToString() + " =  " + roulette[23, 1].ToString() + "  " + roulette[23, 2].ToString() + "  " + roulette[23, 3].ToString();
                low++;
                black++;
                even++;
            }
            else if (txtResult.Text == "24")
            {
                lblResult.Text = roulette[24, 0].ToString() + " =  " + roulette[24, 1].ToString() + "  " + roulette[24, 2].ToString() + "  " + roulette[24, 3].ToString();
                low++;
                red++;
                odd++;
            }
            else if (txtResult.Text == "25")
            {
                lblResult.Text = roulette[25, 0].ToString() + " =  " + roulette[25, 1].ToString() + "  " + roulette[25, 2].ToString() + "  " + roulette[25, 3].ToString();
                low++;
                black++;
                even++;
            }
            else if (txtResult.Text == "26")
            {
                lblResult.Text = roulette[26, 0].ToString() + " =  " + roulette[26, 1].ToString() + "  " + roulette[26, 2].ToString() + "  " + roulette[26, 3].ToString();
                low++;
                red++;
                odd++;
            }
            else if (txtResult.Text == "27")
            {
                lblResult.Text = roulette[27, 0].ToString() + " =  " + roulette[27, 1].ToString() + "  " + roulette[27, 2].ToString() + "  " + roulette[27, 3].ToString();
                low++;
                black++;
                even++;
            }
            else if (txtResult.Text == "28")
            {
                lblResult.Text = roulette[28, 0].ToString() + " =  " + roulette[28, 1].ToString() + "  " + roulette[28, 2].ToString() + "  " + roulette[28, 3].ToString();
                low++;
                red++;
                odd++;
            }
            else if (txtResult.Text == "29")
            {
                lblResult.Text = roulette[29, 0].ToString() + " =  " + roulette[29, 1].ToString() + "  " + roulette[29, 2].ToString() + "  " + roulette[29, 3].ToString();
                low++;
                red++;
                even++;
            }
            else if (txtResult.Text == "30")
            {
                lblResult.Text = roulette[30, 0].ToString() + " =  " + roulette[30, 1].ToString() + "  " + roulette[30, 2].ToString() + "  " + roulette[30, 3].ToString();
                low++;
                black++;
                odd++;
            }
            else if (txtResult.Text == "31")
            {
                lblResult.Text = roulette[31, 0].ToString() + " =  " + roulette[31, 1].ToString() + "  " + roulette[31, 2].ToString() + "  " + roulette[31, 3].ToString();
                low++;
                red++;
                even++;
            }
            else if (txtResult.Text == "32")
            {
                lblResult.Text = roulette[32, 0].ToString() + " =  " + roulette[32, 1].ToString() + "  " + roulette[32, 2].ToString() + "  " + roulette[32, 3].ToString();
                low++;
                black++;
                odd++;
            }
            else if (txtResult.Text == "33")
            {
                lblResult.Text = roulette[33, 0].ToString() + " =  " + roulette[33, 1].ToString() + "  " + roulette[33, 2].ToString() + "  " + roulette[33, 3].ToString();
                low++;
                red++;
                even++;
            }
            else if (txtResult.Text == "34")
            {
                lblResult.Text = roulette[34, 0].ToString() + " =  " + roulette[34, 1].ToString() + "  " + roulette[34, 2].ToString() + "  " + roulette[34, 3].ToString();
                low++;
                black++;
                odd++;
            }
            else if (txtResult.Text == "35")
            {
                lblResult.Text = roulette[35, 0].ToString() + " =  " + roulette[35, 1].ToString() + "  " + roulette[35, 2].ToString() + "  " + roulette[35, 3].ToString();
                low++;
                red++;
                even++;
            }
            else if (txtResult.Text == "36")
            {
                lblResult.Text = roulette[36, 0].ToString() + " =  " + roulette[36, 1].ToString() + "  " + roulette[36, 2].ToString() + "  " + roulette[36, 3].ToString();
                low++;
                black++;
                odd++;
            }
            else if (Int32.TryParse(txtResult.Text, out result))
            {
                lblResult.Text = "Error. Roulette numbers are between 0 - 36.";
                txtResult.Text = string.Empty;
            }
        }
        #endregion

        #region Button Results
        private void btn0_Click(object sender, EventArgs e)
        {
            lblResult.Text = roulette[0, 0].ToString() + " =  " + roulette[0, 1].ToString() + "  " + roulette[0, 2].ToString() + "  " + roulette[0, 3].ToString();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lblResult.Text = roulette[1, 0].ToString() + " =  " + roulette[1, 1].ToString() + "  " + roulette[1, 2].ToString() + "  " + roulette[1, 3].ToString();
            high++;
            black++;
            even++;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            lblResult.Text = roulette[2, 0].ToString() + " =  " + roulette[2, 1].ToString() + "  " + roulette[2, 2].ToString() + "  " + roulette[2, 3].ToString();
            high++;
            red++;
            odd++;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            lblResult.Text = roulette[3, 0].ToString() + " =  " + roulette[3, 1].ToString() + "  " + roulette[3, 2].ToString() + "  " + roulette[3, 3].ToString();
            high++;
            black++;
            even++;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            lblResult.Text = roulette[4, 0].ToString() + " =  " + roulette[4, 1].ToString() + "  " + roulette[4, 2].ToString() + "  " + roulette[4, 3].ToString();
            high++;
            red++;
            odd++;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            lblResult.Text = roulette[5, 0].ToString() + " =  " + roulette[5, 1].ToString() + "  " + roulette[5, 2].ToString() + "  " + roulette[5, 3].ToString();
            high++;
            black++;
            even++;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            lblResult.Text = roulette[6, 0].ToString() + " =  " + roulette[6, 1].ToString() + "  " + roulette[6, 2].ToString() + "  " + roulette[6, 3].ToString();
            high++;
            red++;
            odd++;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            lblResult.Text = roulette[7, 0].ToString() + " =  " + roulette[7, 1].ToString() + "  " + roulette[7, 2].ToString() + "  " + roulette[7, 3].ToString();
            high++;
            black++;
            even++;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            lblResult.Text = roulette[8, 0].ToString() + " =  " + roulette[8, 1].ToString() + "  " + roulette[8, 2].ToString() + "  " + roulette[8, 3].ToString();
            high++;
            red++;
            odd++;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            lblResult.Text = roulette[9, 0].ToString() + " =  " + roulette[9, 1].ToString() + "  " + roulette[9, 2].ToString() + "  " + roulette[9, 3].ToString();
            high++;
            black++;
            even++;
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            lblResult.Text = roulette[10, 0].ToString() + " =  " + roulette[10, 1].ToString() + "  " + roulette[10, 2].ToString() + "  " + roulette[10, 3].ToString();
            high++;
            red++;
            odd++;
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            lblResult.Text = roulette[11, 0].ToString() + " =  " + roulette[11, 1].ToString() + "  " + roulette[11, 2].ToString() + "  " + roulette[11, 3].ToString();
            high++;
            red++;
            even++;
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            lblResult.Text = roulette[12, 0].ToString() + " =  " + roulette[12, 1].ToString() + "  " + roulette[12, 2].ToString() + "  " + roulette[12, 3].ToString();
            high++;
            black++;
            odd++;
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            lblResult.Text = roulette[13, 0].ToString() + " =  " + roulette[13, 1].ToString() + "  " + roulette[13, 2].ToString() + "  " + roulette[13, 3].ToString();
            high++;
            red++;
            even++;
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            lblResult.Text = roulette[14, 0].ToString() + " =  " + roulette[14, 1].ToString() + "  " + roulette[14, 2].ToString() + "  " + roulette[14, 3].ToString();
            high++;
            black++;
            odd++;
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            lblResult.Text = roulette[15, 0].ToString() + " =  " + roulette[15, 1].ToString() + "  " + roulette[15, 2].ToString() + "  " + roulette[15, 3].ToString();
            high++;
            red++;
            even++;
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            lblResult.Text = roulette[16, 0].ToString() + " =  " + roulette[16, 1].ToString() + "  " + roulette[16, 2].ToString() + "  " + roulette[16, 3].ToString();
            high++;
            black++;
            odd++;
        }

        private void btn17_Click(object sender, EventArgs e)
        {
            lblResult.Text = roulette[17, 0].ToString() + " =  " + roulette[17, 1].ToString() + "  " + roulette[17, 2].ToString() + "  " + roulette[17, 3].ToString();
            high++;
            red++;
            even++;
        }

        private void btn18_Click(object sender, EventArgs e)
        {
            lblResult.Text = roulette[18, 0].ToString() + " =  " + roulette[18, 1].ToString() + "  " + roulette[18, 2].ToString() + "  " + roulette[18, 3].ToString();
            high++;
            black++;
            odd++;
        }

        private void btn19_Click(object sender, EventArgs e)
        {
            lblResult.Text = roulette[19, 0].ToString() + " =  " + roulette[19, 1].ToString() + "  " + roulette[19, 2].ToString() + "  " + roulette[19, 3].ToString();
            low++;
            black++;
            even++;
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            lblResult.Text = roulette[20, 0].ToString() + " =  " + roulette[20, 1].ToString() + "  " + roulette[20, 2].ToString() + "  " + roulette[20, 3].ToString();
            low++;
            red++;
            odd++;
        }

        private void btn21_Click(object sender, EventArgs e)
        {
            lblResult.Text = roulette[21, 0].ToString() + " =  " + roulette[21, 1].ToString() + "  " + roulette[21, 2].ToString() + "  " + roulette[21, 3].ToString();
            low++;
            black++;
            even++;
        }

        private void btn22_Click(object sender, EventArgs e)
        {
            lblResult.Text = roulette[22, 0].ToString() + " =  " + roulette[22, 1].ToString() + "  " + roulette[22, 2].ToString() + "  " + roulette[22, 3].ToString();
            low++;
            red++;
            odd++;
        }

        private void btn23_Click(object sender, EventArgs e)
        {
            lblResult.Text = roulette[23, 0].ToString() + " =  " + roulette[23, 1].ToString() + "  " + roulette[23, 2].ToString() + "  " + roulette[23, 3].ToString();
            low++;
            black++;
            even++;
        }

        private void btn24_Click(object sender, EventArgs e)
        {
            lblResult.Text = roulette[24, 0].ToString() + " =  " + roulette[24, 1].ToString() + "  " + roulette[24, 2].ToString() + "  " + roulette[24, 3].ToString();
            low++;
            red++;
            odd++;
        }

        private void btn25_Click(object sender, EventArgs e)
        {
            lblResult.Text = roulette[25, 0].ToString() + " =  " + roulette[25, 1].ToString() + "  " + roulette[25, 2].ToString() + "  " + roulette[25, 3].ToString();
            low++;
            black++;
            even++;
        }

        private void btn26_Click(object sender, EventArgs e)
        {
            lblResult.Text = roulette[26, 0].ToString() + " =  " + roulette[26, 1].ToString() + "  " + roulette[26, 2].ToString() + "  " + roulette[26, 3].ToString();
            low++;
            red++;
            odd++;
        }

        private void btn27_Click(object sender, EventArgs e)
        {
            lblResult.Text = roulette[27, 0].ToString() + " =  " + roulette[27, 1].ToString() + "  " + roulette[27, 2].ToString() + "  " + roulette[27, 3].ToString();
            low++;
            black++;
            even++;
        }

        private void btn28_Click(object sender, EventArgs e)
        {
            lblResult.Text = roulette[28, 0].ToString() + " =  " + roulette[28, 1].ToString() + "  " + roulette[28, 2].ToString() + "  " + roulette[28, 3].ToString();
            low++;
            red++;
            odd++;
        }

        private void btn29_Click(object sender, EventArgs e)
        {
            lblResult.Text = roulette[29, 0].ToString() + " =  " + roulette[29, 1].ToString() + "  " + roulette[29, 2].ToString() + "  " + roulette[29, 3].ToString();
            low++;
            red++;
            even++;
        }

        private void btn30_Click(object sender, EventArgs e)
        {
            lblResult.Text = roulette[30, 0].ToString() + " =  " + roulette[30, 1].ToString() + "  " + roulette[30, 2].ToString() + "  " + roulette[30, 3].ToString();
            low++;
            black++;
            odd++;
        }

        private void btn31_Click(object sender, EventArgs e)
        {
            lblResult.Text = roulette[31, 0].ToString() + " =  " + roulette[31, 1].ToString() + "  " + roulette[31, 2].ToString() + "  " + roulette[31, 3].ToString();
            low++;
            red++;
            even++;
        }

        private void btn32_Click(object sender, EventArgs e)
        {
            lblResult.Text = roulette[32, 0].ToString() + " =  " + roulette[32, 1].ToString() + "  " + roulette[32, 2].ToString() + "  " + roulette[32, 3].ToString();
            low++;
            black++;
            odd++;
        }

        private void btn33_Click(object sender, EventArgs e)
        {
            lblResult.Text = roulette[33, 0].ToString() + " =  " + roulette[33, 1].ToString() + "  " + roulette[33, 2].ToString() + "  " + roulette[33, 3].ToString();
            low++;
            red++;
            even++;
        }

        private void btn34_Click(object sender, EventArgs e)
        {
            lblResult.Text = roulette[34, 0].ToString() + " =  " + roulette[34, 1].ToString() + "  " + roulette[34, 2].ToString() + "  " + roulette[34, 3].ToString();
            low++;
            black++;
            odd++;
        }

        private void btn35_Click(object sender, EventArgs e)
        {
            lblResult.Text = roulette[35, 0].ToString() + " =  " + roulette[35, 1].ToString() + "  " + roulette[35, 2].ToString() + "  " + roulette[35, 3].ToString();
            low++;
            red++;
            even++;
        }

        private void btn36_Click(object sender, EventArgs e)
        {
            lblResult.Text = roulette[36, 0].ToString() + " =  " + roulette[36, 1].ToString() + "  " + roulette[36, 2].ToString() + "  " + roulette[36, 3].ToString();
            low++;
            black++;
            odd++;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblTrigger.Text = trigger.ToString();
            trigger1++;
            if(trigger1 == 3)
            {
                trigger = 2;
                trigger1 = 0;
            }
            lblResult.Text = "";
            trigger--;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            rouletteResults.Clear();
            lblSessionResults.Text = "";
            lblResult.Text = "";
            low = 0;
            high = 0;
            red = 0;
            black = 0;
            odd = 0;
            even = 0;
            trigger = 0;
            lblTrigger.Text = "";
            lblInfo.Text = "";
            lblInfo2.Text = "";
            lblInfo3.Text = "";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            lblResult.Text = roulette[0, 0].ToString() + " =  " + roulette[0, 1].ToString() + "  " + roulette[0, 2].ToString() + "  " + roulette[0, 3].ToString();
            btn0.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
            btn10.Enabled = true;
            btn11.Enabled = true;
            btn12.Enabled = true;
            btn13.Enabled = true;
            btn14.Enabled = true;
            btn15.Enabled = true;
            btn16.Enabled = true;
            btn17.Enabled = true;
            btn18.Enabled = true;
            btn19.Enabled = true;
            btn20.Enabled = true;
            btn21.Enabled = true;
            btn22.Enabled = true;
            btn23.Enabled = true;
            btn24.Enabled = true;
            btn25.Enabled = true;
            btn26.Enabled = true;
            btn27.Enabled = true;
            btn28.Enabled = true;
            btn29.Enabled = true;
            btn30.Enabled = true;
            btn31.Enabled = true;
            btn32.Enabled = true;
            btn33.Enabled = true;
            btn34.Enabled = true;
            btn35.Enabled = true;
            btn36.Enabled = true;
            btnClear.Enabled = false;
            btnReset.Enabled = true;
            lblClickOK.Visible = false;
            btnOK.Visible = false;
            txtResult.Enabled = true;
            trigger = 0;
        }
        #endregion

        #region Session Results
        private void lblResult_TextChanged(object sender, EventArgs e)
        {
            trigger++;
            if(trigger == 4)
            {   btn0.Enabled = false;
                btn1.Enabled = false;
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                btn5.Enabled = false;
                btn6.Enabled = false;
                btn7.Enabled = false;
                btn8.Enabled = false;
                btn9.Enabled = false;
                btn10.Enabled = false;
                btn11.Enabled = false;
                btn12.Enabled = false;
                btn13.Enabled = false;
                btn14.Enabled = false;
                btn15.Enabled = false;
                btn16.Enabled = false;
                btn17.Enabled = false;
                btn18.Enabled = false;
                btn19.Enabled = false;
                btn20.Enabled = false;
                btn21.Enabled = false;
                btn22.Enabled = false;
                btn23.Enabled = false;
                btn24.Enabled = false;
                btn25.Enabled = false;
                btn26.Enabled = false;
                btn27.Enabled = false;
                btn28.Enabled = false;
                btn29.Enabled = false;
                btn30.Enabled = false;
                btn31.Enabled = false;
                btn32.Enabled = false;
                btn33.Enabled = false;
                btn34.Enabled = false;
                btn35.Enabled = false;
                btn36.Enabled = false;
                btnClear.Enabled = false;
                btnReset.Enabled = false;
                lblClickOK.Visible = true;
                btnOK.Visible = true;
                txtResult.Enabled = false;
                trigger = 0;
            }
            counter();
            sessionResults();
            foreach (object item in rouletteResults)
            {
                lblSessionResults.Text += item.ToString();
            }
        }

        private void sessionResults()
        {
            int rouletteSize = rouletteResults.Count;
            if(rouletteSize == 25)
            {
                rouletteResults.Clear();
            }
            lblSessionResults.Text = "";
            if(lblResult.Text != "" && lblResult.Text != "Error. Roulette numbers are between 0 - 36.")
            {
                rouletteResults.Add(lblResult.Text + "\n");
            }
        }
        #endregion

        #region Counter & Trigger
        private void counter()
        {
            if (low == 4)
            {
                lblInfo.Text = "LOW";
                low = 0;
                lblTrigger.Text = "Trigger is active: LOW";
            }
            if (high == 4)
            {
                lblInfo.Text = "HIGH";
                high = 0;
                lblTrigger.Text = "Trigger is active: HIGH";
            }
            if (red == 4)
            {
                lblInfo2.Text = "RED";
                red = 0;
                lblTrigger.Text = "Trigger is active: RED";
            }
            if (black == 4)
            {
                lblInfo2.Text = "BLACK";
                black = 0;
                lblTrigger.Text = "Trigger is active: BLACK";
            }
            if (odd == 4)
            {
                lblInfo3.Text = "ODD";
                odd = 0;
                lblTrigger.Text = "Trigger is active: ODD";
            }
            if (even == 4)
            {
                lblInfo3.Text = "EVEN";
                even = 0;
                lblTrigger.Text = "Trigger is active: EVEN";
            }
        }
        #endregion
    }
}
