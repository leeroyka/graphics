using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graphics
{
    //Good luck
    public partial class Form1 : Form
    {

        Polka plk = new Polka();
        Color cBackGR = Color.FromArgb(255, 36, 36, 36);
        Color cBack = Color.FromArgb(255, 26, 26, 26);
        Color cBlue = Color.FromArgb(255, 0, 122, 204);
        Color cBlueA = Color.FromArgb(255, 0, 153, 255);
        public Form1()
        {
            InitializeComponent();
            //COLOR START
            label1.BackColor = cBackGR;
            pictureBox1.BackColor = cBackGR;
            pictureBox3.BackColor = cBlue;
            labelForm.BackColor = cBlue;
            hideButton.BackColor = cBlue;
            closeButton.BackColor = cBlue;
            textGraph.BackColor = cBack;
            precisionBar.BackColor = cBackGR;
            buildButton.BackColor = cBackGR;
            button1.BackColor = cBackGR;
            BuildSec.BackColor = cBackGR;
            label2.BackColor = cBackGR;
            label4.BackColor = cBackGR;
            label5.BackColor = cBackGR;
            label6.BackColor = cBackGR;
            labelBuild.BackColor = cBackGR;
            textBox1.BackColor = cBack;

            precisionLabel.BackColor = cBackGR;
            //COLOR END
        
                        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public bool checkString(string txt)
        {
            int cBrackets = 0;
            
           
            foreach (char i in txt)
            {
                
                
                if (("y=';<>@#&$".IndexOf(i) != -1))
                {
                    MessageBox.Show("Введите функцию f(x) без сторонних символов");
                    return false;
                }
                if (i == '(')
                    cBrackets++;
                if (i == ')')
                {
                    cBrackets--;
                    if (cBrackets < 0)
                    {
                        MessageBox.Show("Неправильная постановка скобочек");
                        return false;
                    }
                }

            }
            if(cBrackets!=0)
            {
                MessageBox.Show("Неправильная постановка скобочек");
                return false;
            }
            return true;
        }

        //in Develop. Not working
        int sMap = 100;
        int prsn = 100;
        public void BuildGraph()
        {
            prsn /= 100;
            for(int i=-sMap;i<=sMap;i=i+prsn )
            {
                
            }
        }


        //form movement
        private bool isDragging = false;
        private Point lastCursor;
        private Point lastForm;
        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            lastCursor = Cursor.Position;
            lastForm = this.Location;
        }
        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.Location =
                    Point.Add(lastForm, new Size(Point.Subtract(Cursor.Position, new Size(lastCursor))));
            }
        }
        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void hideButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hideButton_MouseEnter(object sender, EventArgs e)
        {
            hideButton.BackColor = cBlueA;   
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void hideButton_MouseLeave(object sender, EventArgs e)
        {
            hideButton.BackColor = cBlue;
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.BackColor = cBlueA;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.BackColor = cBlue;
        }

        private void labelForm_MouseDown(object sender, MouseEventArgs e)
        {

            isDragging = true;
            lastCursor = Cursor.Position;
            lastForm = this.Location;
        }

        private void labelForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.Location =
                    Point.Add(lastForm, new Size(Point.Subtract(Cursor.Position, new Size(lastCursor))));
            }
        }

        private void labelForm_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }
        string expression;
        private void buildButton_Click(object sender, EventArgs e)
        {
            expression = textGraph.Text;
            if (checkString(expression))
            {
                
               Debug.Text = "Debug " +plk.Calculate(textGraph.Text); // Debug
                //BuildGraph(); // In develop
                DrawPlane(); // Draw background

                dt =  - (int) 2600/precisionBar.Value;
                isFirstDraw = true;
                DebugTimer.Enabled = true; //Draw Graph
                textGraph.Enabled = false;
                labelBuild.Visible = true;
               
                buildButton.Enabled = false;
                precisionBar.Enabled = false;
                
            }
        }

        private void precisionBar_Scroll(object sender, EventArgs e)
        {
            precisionLabel.Text = precisionBar.Value.ToString();
        }
        bool isFirstDraw = true;
        int last_x, last_y;
        Pen pen = new Pen(Color.FromArgb(255, 0, 122, 204),3);        
        Pen wPen = new Pen(Color.FromArgb(255, 255, 255, 255));
        Pen bPen = new Pen(Color.FromArgb(30, 255, 255, 255));
        int center = 267;
        private void DrawPlane()
        {

            Graphics fG;
            fG = this.CreateGraphics();
            
            fG.DrawLine(wPen,center + plane.Location.X, plane.Location.Y, center + plane.Location.X, center*2+ plane.Location.Y);
            fG.DrawLine(wPen, 0 + plane.Location.X, center+ plane.Location.Y, center * 2 + plane.Location.X, center+ plane.Location.Y);
            for(int i= plane.Location.X+center;i< plane.Location.X+center*2;i+= precisionBar.Value)
            {
                fG.DrawLine(bPen, i, 0+plane.Location.Y, i, center * 2 + plane.Location.Y);
            }
            for (int i = plane.Location.X + center; i > plane.Location.X - center * 2; i -= precisionBar.Value)
            {
                fG.DrawLine(bPen, i, 0 + plane.Location.Y, i, center * 2 + plane.Location.Y);
            }
            for(int i = plane.Location.Y+center;i<plane.Location.Y+center*2;i+=precisionBar.Value)
            {
                fG.DrawLine(bPen, 0 + plane.Location.X, i, center * 2 + plane.Location.X, i);
            }
            for (int i = plane.Location.Y + center; i > plane.Location.Y - center * 2; i -= precisionBar.Value)
            {
                fG.DrawLine(bPen, 0 + plane.Location.X, i, center * 2 + plane.Location.X, i);
            }

        }
        private void DrawLine(int x,int y)
        {
            Graphics fG;
            fG = this.CreateGraphics();
            pen.Alignment = PenAlignment.Center;
            x += plane.Location.X +center;
            y += plane.Location.Y + center;
            if(isFirstDraw)
            {
                last_x = x;
                last_y = y;
                isFirstDraw = false;
            }
            if(y<10000 && y>-10000)
            fG.DrawLine(pen, last_x, last_y, x, y);
            last_x = x;
            last_y = y;
        }
        int dt; // -x

        private void plane_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BuildSec_Click(object sender, EventArgs e)
        {
            //   MessageBox.Show("Nope");
            BuildSec.Visible = false;
            label5.Visible = true;
            label6.Visible = true;
            textBox1.Visible = true;
            button1.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            expression = textBox1.Text;
            if (checkString(expression))
            {
                button1.Enabled = false;
                Debug.Text = "Debug " + plk.Calculate(textGraph.Text); // Debug
                                                                       //BuildGraph(); // In develop
                pen = new Pen(Color.FromArgb(255, 255, 76, 59), 3);
                
                dt = -(int)2600 / precisionBar.Value;
                isFirstDraw = true;
                DebugTimer.Enabled = true; //Draw Graph
                textBox1.Enabled = false;
            }
        }

        private void DebugTimer_Tick(object sender, EventArgs e)
        {
            double d =(double) dt / 10;
            plk.x = d.ToString();
            
            
            double y = Convert.ToDouble(plk.Calculate(expression));
            if (!plk.isAsymptote)
            {
                Debug.Text = "Debug " + d.ToString()+ " + " + ((int)y * 10).ToString();

                DrawLine((int)(d * (double)precisionBar.Value), -(int)(y * precisionBar.Value));
            }
            else
            {
                isFirstDraw = true;
            }
            dt+=1;
            if (dt >= (int)2600 / precisionBar.Value)
            {
                BuildSec.Enabled = true;
                labelBuild.Visible = false;
                DebugTimer.Enabled = false;
            }
        }
    }
}
