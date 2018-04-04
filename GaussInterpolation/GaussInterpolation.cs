using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaussInterpolation
{
    class GaussInterpolation
    {
        private double alpha, beta, gamma, delta, epsilon, h, x0, dx;
        private int n;
        private double[,] diffs;

        public GaussInterpolation(double alpha, double beta, double gamma, double delta, double epsilon, int n, double h, double x0, double dx)
        {
            this.alpha = alpha;
            this.beta = beta;
            this.gamma = gamma;
            this.delta = delta;
            this.epsilon = epsilon;
            this.n = n;
            this.h = h;
            this.x0 = x0;
            this.dx = dx;

            buildDiffsTable();
        }

        private void buildDiffsTable()
        {
            int size = 2 * n + 1;
            diffs = new double[size, size];

            for (int i = 0, t = -n; i < size; i++, t++)
            {
                diffs[i, 0] = F(x0 + t * h);
            }
            for (int i = 1; i < size; i++)
            {
                for (int j = 0; j < size - i; j++)
                {
                    diffs[j, i] = diffs[j + 1, i - 1] - diffs[j, i - 1];
                }
            }
        }

        public double F(double x)
        {
            return epsilon * Math.Sin(alpha / (beta * x * x + gamma * x + delta));
        }

        private double _Pn(double t)
        {
            int currentDiffRow = n;
            int size = 2 * n + 1;

            double result = diffs[currentDiffRow, 0] + t*diffs[currentDiffRow, 1];
            currentDiffRow--;

            double currentMultiplier = t;
            double currentNominatorIncrease = 0;
            double currentDenominator = 1;

            for (int i = 2; i < size; i++)
            {
                currentDenominator++;
                if (currentNominatorIncrease >= 0)
                {
                    currentNominatorIncrease = -currentNominatorIncrease - 1;
                }
                else
                {
                    currentNominatorIncrease = -currentNominatorIncrease;
                }
                currentMultiplier *= (t + currentNominatorIncrease) / currentDenominator;
                result += currentMultiplier * diffs[currentDiffRow, i];
                currentDiffRow -= i % 2;
            }

            return result;
        }

        public double Pn(double x)
        {
            double t = (x - x0) / h;
            return _Pn(t);
        }

        public double VisualPn(double x)
        {
            double result = Pn(x);
            if (result > 1000)
            {
                return 1000;
            }
            else if (result < -1000)
            {
                return -1000;
            }
            else
            {
                return result;
            }
        }

        public double Rn(double x)
        {
            return F(x) - Pn(x);
        }

        public double VisualRn(double x)
        {
            double result = Rn(x);
            if (result > 1000)
            {
                return 1000;
            }
            else if (result < -1000)
            {
                return -1000;
            }
            else
            {
                return result;
            }
        }

        public double dF(double x)
        {
            return (F(x + dx) - F(x)) / dx;
        }

        public double VisualDF(double x)
        {
            double result = dF(x);
            if (result > 1000)
            {
                return 1000;
            }
            else if (result < -1000)
            {
                return -1000;
            }
            else
            {
                return result;
            }
        }

        public double dPn(double x)
        {
            return (Pn(x + dx) - Pn(x)) / dx;
        }

        public double VisualDPn(double x)
        {
            double result = dPn(x);
            if (result > 1000)
            {
                return 1000;
            }
            else if (result < -1000)
            {
                return -1000;
            }
            else
            {
                return result;
            }
        }
    }
}
