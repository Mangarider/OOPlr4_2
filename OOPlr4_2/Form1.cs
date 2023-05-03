using OOPlr4_2.Properties;
using System;
using System.Reflection;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OOPlr4_2
{
    public partial class Form1 : Form
    {
        Model model;
        EventHandler handler;

        public Form1()
        {
            model = new Model();
            InitializeComponent();
            model.obs += new EventHandler(this.UpdateFromModel);
            model.obs.Invoke(this, EventArgs.Empty);
            handler += textA_LostFocus;
            handler += textB_LostFocus;
            handler += textC_LostFocus;
            Application.ApplicationExit += Application_ApplicationExit;
        }
        private void Application_ApplicationExit(object sender, EventArgs e)
        {
            model.save();
        }
        private void textA_LostFocus(object sender, EventArgs e)
        {
            try
            {
                model.SetA(Int32.Parse(textA.Text));
            }
            catch(Exception ex) { };
        }
        private void textB_LostFocus(object sender, EventArgs e)
        {
            try
            {
                model.SetB(Int32.Parse(textB.Text));
            }
            catch (Exception ex) { };
        }
        private void textC_LostFocus(object sender, EventArgs e)
        {
            try
            {
                model.SetC(Int32.Parse(textC.Text));
            }
            catch (Exception ex) { };
        }
        private void track3_Scroll(object sender, EventArgs e)
        {
            model.SetC(trackC.Value);
        }

        private void track2_Scroll(object sender, EventArgs e)
        {
            model.SetB(trackB.Value);
        }

        private void track1_Scroll(object sender, EventArgs e)
        {
            model.SetA(trackA.Value);   
        }

        private void num2_ValueChanged(object sender, EventArgs e)
        {
            model.SetB(Decimal.ToInt32(numB.Value));
        }

        private void numA_ValueChanged(object sender, EventArgs e)
        {
            model.SetA(Decimal.ToInt32(numA.Value));
        }

        private void numC_ValueChanged(object sender, EventArgs e)
        {
            model.SetC(Decimal.ToInt32(numC.Value));
        }
        private void UpdateFromModel(object sender, EventArgs e)
        {
            int a = model.getA();
            int b = model.getB();
            int c = model.getC();
            textA.Text = a.ToString();
            textB.Text = b.ToString();
            textC.Text = c.ToString();
            trackA.Value = a;
            trackB.Value = b;
            trackC.Value = c;
            numA.Value = Convert.ToInt32(a);
            numB.Value = Convert.ToInt32(b);
            numC.Value = Convert.ToInt32(c);
        }
        private void textA_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                model.SetA(Int32.Parse(textA.Text));
        }
        private void textB_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                model.SetB(Int32.Parse(textB.Text));
        }
        private void textC_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                model.SetC(Int32.Parse(textC.Text));
        }
    }
    class Model
    {
        private int A, B, C;
        public EventHandler obs;
        public Model()
        {
            A = Settings.Default.A;
            B = Settings.Default.B;
            C = Settings.Default.C;
        }
        public void SetA(int value)
        {
            if (value < 0 || value > 100)
            {
                obs.Invoke(this, EventArgs.Empty);
                return;
            }
            if (value > B)
                SetB(value);
            if (value > C)
                SetC(value);
            A = value;
            obs.Invoke(this, EventArgs.Empty);

        }
        public void SetB(int value)
        {
            if (value < A || value > C)
            {
                obs.Invoke(this, EventArgs.Empty);
                return;
            }
            B = value;
            obs.Invoke(this, EventArgs.Empty);
        }
        public void SetC(int value)
        {

            if (value < 0 || value > 100) {
                obs.Invoke(this, EventArgs.Empty);
                return;
        }
            if (value < B)
                SetB(value);
            if (value < A)
                SetA(value);
            C = value;
            obs.Invoke(this, EventArgs.Empty);
        }
        public int getA()
        {
            return A;
        }
        public int getB() { 
            return B; 
        }
        public int getC()
        {
            return C;
        }
        public void save()
        {
            Settings.Default.A = A;
            Settings.Default.B = B;
            Settings.Default.C = C;
            Settings.Default.Save();
        }
    }
}
