using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaussInterpolation
{
    public partial class Form1 : Form
    {
        private struct DisplayInfo
        {
            public double top, right, bottom, left;
            public bool drawF, drawPoly, drawRemainder, drawDF, drawDPoly;
        };
        private DisplayInfo displayInfo = new DisplayInfo();

        public Form1()
        {
            InitializeComponent();
        }

        private int getRealNumberOfInterNodes(int n)
        {
            return 2 * n + 1;
        }

        private void interNumNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            int value = (int) interNumNumericUpDown.Value;
            if (value >= 0 && value <= 100)
            {
                interNumLabel.Text = getRealNumberOfInterNodes(value).ToString();
            }
        }

        private GaussInterpolation beginNewGaussianInterpolation()
        {
            double alpha = double.Parse(alphaTextBox.Text);
            double beta = double.Parse(betaTextBox.Text);
            double gamma = double.Parse(gammaTextBox.Text);
            double delta = double.Parse(deltaTextBox.Text);
            double epsilon = double.Parse(epsilonTextBox.Text);
            int n = (int)interNumNumericUpDown.Value;

            displayInfo.left = double.Parse(aScreenTextBox.Text);
            displayInfo.bottom = double.Parse(bScreenTextBox.Text);
            displayInfo.top = double.Parse(cScreenTextBox.Text);
            displayInfo.right = double.Parse(dScreenTextBox.Text);
            displayInfo.drawF = fDrawCheckBox.Checked;
            displayInfo.drawPoly = polyDrawCheckBox.Checked;
            displayInfo.drawRemainder = remainderDrawCheckBox.Checked;
            displayInfo.drawDF = dfDrawCheckBox.Checked;
            displayInfo.drawDPoly = dPolyDrawCheckBox.Checked;

            int realN = getRealNumberOfInterNodes(n);
            double h;
            if (realN > 1)
            {
                h = (displayInfo.right - displayInfo.left) / (getRealNumberOfInterNodes(n) - 1);
            }
            else
            {
                h = 1;
            }
            double x0 = displayInfo.left + (displayInfo.right - displayInfo.left) / 2;
            double stepX = (displayInfo.right - displayInfo.left) / plotView.Width;

            return new GaussInterpolation(alpha, beta, gamma, delta, epsilon, n, h, x0, stepX);
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            GaussInterpolation interpolation = beginNewGaussianInterpolation();
            double stepX = (displayInfo.right - displayInfo.left) / plotView.Width;

            var plotModel = new PlotModel();
            plotModel.Axes.Add(new LinearAxis { Position = AxisPosition.Bottom, Minimum = displayInfo.left, Maximum = displayInfo.right });
            plotModel.Axes.Add(new LinearAxis { Position = AxisPosition.Left, Minimum = displayInfo.bottom, Maximum = displayInfo.top });

            if (displayInfo.drawF)
            {
                plotModel.Series.Add(new FunctionSeries(interpolation.F, displayInfo.left, displayInfo.right, stepX, "f(x)"));
            }
            if (displayInfo.drawPoly)
            {
                plotModel.Series.Add(new FunctionSeries(interpolation.Pn, displayInfo.left, displayInfo.right, stepX, "Pₙ(x)"));
            }
            if (displayInfo.drawRemainder)
            {
                plotModel.Series.Add(new FunctionSeries(interpolation.Rn, displayInfo.left, displayInfo.right, stepX, "rₙ(x)"));
            }
            if (displayInfo.drawDF)
            {
                plotModel.Series.Add(new FunctionSeries(interpolation.dF, displayInfo.left, displayInfo.right, stepX, "∂f(x)"));
            }
            if (displayInfo.drawDPoly)
            {
                plotModel.Series.Add(new FunctionSeries(interpolation.dPn, displayInfo.left, displayInfo.right, stepX, "∂Pₙ(x)"));
            }

            plotView.Model = plotModel;
        }
    }
}
