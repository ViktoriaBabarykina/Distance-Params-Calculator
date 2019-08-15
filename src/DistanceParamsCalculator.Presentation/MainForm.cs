using DistanceParamsCalculator.Exceptions;
using DistanceParamsCalculator.Math;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DistanceParamsCalculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                ResetColors();
                TrimTextBoxes();
                CorrectDecimalSeparator();
                Solve();
            }
            catch (NoEmptyTextBoxException exception)
            {
                lblErrorText.Visible = true;
                lblErrorText.Text = exception.Message;
            }
            catch (MultyEmptyTextBoxException exception)
            {
                foreach (Label label in exception.EmptyTextBoxLabels)
                {
                    label.ForeColor = Color.Red;
                }
                lblErrorText.Visible = true;
                lblErrorText.Text = exception.Message;
            }
            catch (IncorrectInputException exception)
            {
                lblErrorText.Visible = true;
                lblErrorText.Text = exception.Message;
                foreach (Label label in exception.IncorrectInputLabels)
                {
                    label.ForeColor = Color.Red;
                }
            }
            catch (Exception exception)
            {
                lblErrorText.Visible = true;
                lblErrorText.Text = exception.Message;
            }
        }

        private void ResetColors()
        {
            lblErrorText.Visible = false;
            lblDistance.ForeColor = Color.Black;
            lblHorisontalFieldOfView.ForeColor = Color.Black;
            lblHorisontalSizeInPixels.ForeColor = Color.Black;
            lblLinearSize.ForeColor = Color.Black;
            lblPixelSize.ForeColor = Color.Black;
        }

        private void ClearTextBoxes()
        {
            tbxPixelSize.Text = "";
            tbxLinearSize.Text = "";
            tbxHorisontalSizeInPixels.Text = "";
            tbxDistance.Text = "";
            tbxHorisontalFieldOfView.Text = "";
        }

        private void Solve()
        {
            DistanceParamsSolver solver = new DistanceParamsSolver();
            TextBox emptyTextBox = FindEmptyTextBox();
            List<Label> incorrectInputLabels = new List<Label>();
            double pixelSize = 0, linearSize = 0, horisontalSizeInPixels = 0, distance = 0, horisontalFieldOfView = 0;
            if (emptyTextBox != tbxPixelSize)
            {
                if (!double.TryParse(tbxPixelSize.Text, out pixelSize))
                    incorrectInputLabels.Add(lblPixelSize);
            }
            if (emptyTextBox != tbxLinearSize)
            {
                if (!double.TryParse(tbxLinearSize.Text, out linearSize))
                    incorrectInputLabels.Add(lblLinearSize);
            }
            if (emptyTextBox != tbxHorisontalSizeInPixels)
            {
                if (!double.TryParse(tbxHorisontalSizeInPixels.Text, out horisontalSizeInPixels))
                    incorrectInputLabels.Add(lblHorisontalSizeInPixels);
            }
            if (emptyTextBox != tbxDistance)
            {
                if (!double.TryParse(tbxDistance.Text, out distance))
                    incorrectInputLabels.Add(lblDistance);
            }
            if (emptyTextBox != tbxHorisontalFieldOfView)
            {
                if (!double.TryParse(tbxHorisontalFieldOfView.Text, out horisontalFieldOfView))
                    incorrectInputLabels.Add(lblHorisontalFieldOfView);
            }

            if (incorrectInputLabels.Count > 0)
            {
                throw new IncorrectInputException(incorrectInputLabels, "Введено некорректное число!");
            }

            if (emptyTextBox == tbxPixelSize)
            {
                pixelSize = solver.FindPixelSize(linearSize,
                    horisontalSizeInPixels, distance, horisontalFieldOfView);
                tbxPixelSize.Text = pixelSize.ToString();
                lblPixelSize.ForeColor = Color.Green;
            }
            if (emptyTextBox == tbxLinearSize)
            {
                linearSize = solver.FindLinearSize(pixelSize,
                    horisontalSizeInPixels, distance, horisontalFieldOfView);
                tbxLinearSize.Text = linearSize.ToString();
                lblLinearSize.ForeColor = Color.Green;
            }
            if (emptyTextBox == tbxHorisontalSizeInPixels)
            {
                horisontalSizeInPixels = solver.FindHorisontalSizeInPixels(pixelSize,
                    linearSize, distance, horisontalFieldOfView);
                tbxHorisontalSizeInPixels.Text = horisontalSizeInPixels.ToString();
                lblHorisontalSizeInPixels.ForeColor = Color.Green;
            }
            if (emptyTextBox == tbxDistance)
            {
                distance = solver.FindDistance(pixelSize,
                    linearSize, horisontalSizeInPixels, horisontalFieldOfView);
                tbxDistance.Text = distance.ToString();
                lblDistance.ForeColor = Color.Green;
            }
            if (emptyTextBox == tbxHorisontalFieldOfView)
            {
                horisontalFieldOfView = solver.FindHorisontalFieldOfView(pixelSize,
                    linearSize, horisontalSizeInPixels, distance);
                tbxHorisontalFieldOfView.Text = horisontalFieldOfView.ToString();
                lblHorisontalFieldOfView.ForeColor = Color.Green;
            }
        }

        private TextBox FindEmptyTextBox()
        {
            TextBox emptyTextBox = null;
            List<Label> emptyTextBoxLabels = new List<Label>();
            if (tbxPixelSize.Text == "")
            {
                emptyTextBox = tbxPixelSize;
                emptyTextBoxLabels.Add(lblPixelSize);
            }
            if (tbxLinearSize.Text == "")
            {
                emptyTextBox = tbxLinearSize;
                emptyTextBoxLabels.Add(lblLinearSize);
            }
            if (tbxHorisontalSizeInPixels.Text == "")
            {
                emptyTextBox = tbxHorisontalSizeInPixels;
                emptyTextBoxLabels.Add(lblHorisontalSizeInPixels);
            }
            if (tbxDistance.Text == "")
            {
                emptyTextBox = tbxDistance;
                emptyTextBoxLabels.Add(lblDistance);
            }
            if (tbxHorisontalFieldOfView.Text == "")
            {
                emptyTextBox = tbxHorisontalFieldOfView;
                emptyTextBoxLabels.Add(lblHorisontalFieldOfView);
            }

            if (emptyTextBoxLabels.Count == 0)
                throw new NoEmptyTextBoxException("Рассчитываемый элемент должен быть пустым!");
            else if (emptyTextBoxLabels.Count > 1)
                throw new MultyEmptyTextBoxException(emptyTextBoxLabels, "Только одно поле должно быть пустым!");

            return emptyTextBox;
        }

        private void TrimTextBoxes()
        {
            tbxPixelSize.Text = tbxPixelSize.Text.Trim();
            tbxLinearSize.Text = tbxLinearSize.Text.Trim();
            tbxHorisontalSizeInPixels.Text = tbxHorisontalSizeInPixels.Text.Trim();
            tbxDistance.Text = tbxDistance.Text.Trim();
            tbxHorisontalFieldOfView.Text = tbxHorisontalFieldOfView.Text.Trim();
        }

        private void CorrectDecimalSeparator()
        {
            string decimalSeparator = Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            tbxPixelSize.Text = tbxPixelSize.Text.Replace(",", decimalSeparator);
            tbxLinearSize.Text = tbxLinearSize.Text.Replace(",", decimalSeparator); 
            tbxHorisontalSizeInPixels.Text = tbxHorisontalSizeInPixels.Text.Replace(",", decimalSeparator);
            tbxDistance.Text = tbxDistance.Text.Replace(",", decimalSeparator);
            tbxHorisontalFieldOfView.Text = tbxHorisontalFieldOfView.Text.Replace(",", decimalSeparator);

            tbxPixelSize.Text = tbxPixelSize.Text.Replace(".", decimalSeparator);
            tbxLinearSize.Text = tbxLinearSize.Text.Replace(".", decimalSeparator);
            tbxHorisontalSizeInPixels.Text = tbxHorisontalSizeInPixels.Text.Replace(".", decimalSeparator);
            tbxDistance.Text = tbxDistance.Text.Replace(".", decimalSeparator);
            tbxHorisontalFieldOfView.Text = tbxHorisontalFieldOfView.Text.Replace(".", decimalSeparator);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ResetColors();
            ClearTextBoxes();
        }
    }
}
