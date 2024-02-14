using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace HanoiTowers
{
    public partial class tableLayoutPanel1 : Form
    {
        Stack<Panel> s1;
        Stack<Panel> s2;
        Stack<Panel> s3;
        Panel movePan;
        Panel solvePan;
        Stack<Panel> r;
        Panel[] pan;
        bool isMove = false;
        public event Action<int> NumberInThird;
        Thread recur;

        int height1;

        private void Mover(object obj)
        {
            Panel anotherPanel = movePan;
            Point point = (Point)obj;
            int d1 = 0;
            int d2=0;
            int x1 = point.X - anotherPanel.Location.X;
            int y1 = First.Location.Y-120- anotherPanel.Location.Y;
            int i = 1;
            int dx = (x1)/(x1==0 ? 1 : Math.Abs(x1));
            int dy = (y1) / (y1 == 0 ? 1 : Math.Abs(y1));
            Action act=()=> { anotherPanel.Left += dx; anotherPanel.Top += dy; };
            while (true)
            {

                if (InvokeRequired)
                {
                    Invoke(act);
                }
                else
                {

                    act();
                }

                d1 = d1 + dx;
                d2 = d2 + dy;

                
                if (((Math.Abs(y1)>=Math.Abs(x1)) ? d2 : d1)==i*5*((Math.Abs(y1) >= Math.Abs(x1)) ? dy : dx))
                {
                    Thread.Sleep(1);

                    i = i + 1;

                }
                if ((d1 - x1) == 0)
                {

                    dx=0;
                }
                if ((d2 - y1) == 0)
                {

                    dy = 0;
                }

                if(dx==0 && dy == 0)
                {

                    break;
                }
            }
            d1 = 0;
            y1 = point.Y  - anotherPanel.Location.Y;
            dy = (y1) / (y1 == 0 ? 1 : Math.Abs(y1));
            act = () => { anotherPanel.Top += dy; };
            i = 1;
            Thread.Sleep(2);
            while (true)
            {
                if (InvokeRequired)
                {
                    Invoke(act);
                }
                else
                {

                    act();
                }


                d1 = d1 + dy;
                if (d1 == i*5 * dy)
                {
                    Thread.Sleep(1);

                    i=i + 1;

                }
                if ((d1 - y1) == 0)
                {

                    break;
                }

            }



            act = () => { NumberInThird(s3.Count);  anotherPanel.Enabled = true;
            };

            if (InvokeRequired)
            {
                Invoke(act);
            }
            else
            {

                act();
            }
           
        }


        private void Mover1(object obj)
        {
            Panel anotherPanel = solvePan;
            Point point = (Point)obj;
            int d1 = 0;
            
            int x1 = point.X - anotherPanel.Location.X;
            int y1 = First.Location.Y - 120 - anotherPanel.Location.Y;
          
            int dx = (x1) / (x1 == 0 ? 1 : Math.Abs(x1));
            int dy = (y1) / (y1 == 0 ? 1 : Math.Abs(y1));
            Action act = () => { anotherPanel.Top += dy; };
           
            while (true)
            {
                if (InvokeRequired)
                {
                    Invoke(act);
                }
                else
                {

                    act();
                }


                d1 = d1 + dy;

                if ((d1 - y1) == 0)
                {

                    break;
                }

            }
            d1 = 0;
            Thread.Sleep(1);
            act = () => { anotherPanel.Left += dx; };
            while (true)
            {
                if (InvokeRequired)
                {
                    Invoke(act);
                }
                else
                {

                    act();
                }


                d1 = d1 + dx;

                if ((d1 - x1) == 0)
                {

                    break;
                }

            }
            y1 = point.Y - anotherPanel.Location.Y;
            dy = (y1) / (y1 == 0 ? 1 : Math.Abs(y1));
            act = () => { anotherPanel.Top += dy; };
            d1 = 0;
            Thread.Sleep(1);
            while (true)
            {
                if (InvokeRequired)
                {
                    Invoke(act);
                }
                else
                {

                    act();
                }


                d1 = d1 + dy;
                
                if ((d1 - y1) == 0)
                {

                    break;
                }

            }



            act = () => {
                NumberInThird(s3.Count); anotherPanel.Enabled = true;
            };

            if (InvokeRequired)
            {
                Invoke(act);
            }
            else
            {

                act();
            }

        }
        private void _NumberInThird(int a)
        {
            if (alloved)
            {
                if (a == int.Parse(textBox1.Text))
                {


                    button1.Enabled = true;
                    textBox1.Enabled = true;
                    textBox1.Text = "0";
                    Stop.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    for (int i = 0; i < pan.Length; i++)
                    {
                        pan[i].MouseClick -= new MouseEventHandler(MouseClickEvent);
                        DragPanel.Controls.Remove(pan[i]);
                        pan[i].Dispose();
                        time.Enabled = false;
                    }

                    alloved = false;



                }

            }
             
        }
        
        public tableLayoutPanel1()
        {
            InitializeComponent();
            First.Enabled = false;
            Second.Enabled = false;
            Third.Enabled = false;
            panel3.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            NumberInThird += _NumberInThird;
            int n;
            try{
                 n = int.Parse(textBox1.Text);

                if (n <= 1)
                {

                    throw new Exception();
                }
            }
            catch (Exception)
            {
                sign1.Visible = true;
                return;
                 
            }
            sign1.Visible = false;
            s1 = new Stack<Panel>();
            s3 = new Stack<Panel>();
            s2 = new Stack<Panel>();
            pan = new Panel[n];
            Random rand = new Random();
            Color randomColor;

            for (int i = 0; i < n; i++)
            {

                while (true)
                {
                    try
                    {
                        randomColor = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
                        if (randomColor == Color.FromArgb(44, 53, 64) || randomColor == Color.Black || randomColor == Color.White)
                        {

                            throw new Exception();

                        }
                        break;
                    }
                    catch (Exception)
                    {


                    }


                }
                int w = (35 - 200) / (n - 1) * i + 200;
                
                int h = First.Height / n;
                pan[i] = CreatePanel(1, w, h, randomColor, (i + 1) * h);

                s1.Push(pan[i]);
            }

            for(int i=0; i<n; i++)
            {

                DragPanel.Controls.Add(pan[i]);
                pan[i].BringToFront();
                pan[i].MouseClick +=new MouseEventHandler( MouseClickEvent);


            }

            button1.Enabled = false;
            textBox1.Enabled = false;
            height1 = First.Height;
            Stop.Enabled = true;
            time.Enabled = true;
            button3.Enabled = true;
            button2.Enabled = true;
            recur = new Thread(RecursionAdapter);
            alloved = true;
        }

        int dx;
        int dy;

        private void MouseClickEvent(object sender, MouseEventArgs e)
        {

            Panel p = (Panel)sender;
            dx = e.X;
            dy = e.Y;
            if(StackCheck(s1, p) || StackCheck(s2, p) || StackCheck(s3, p))
            {
                
                movePan = p;
                isMove = true;

                if(StackCheck(s1, p))
                {
                    
                    r = s1;

                }else if (StackCheck(s2, p))
                {

                    r = s2;

                }
                else
                {

                    r = s3;
                     
                }
            }
            else
            {

                return;
            }

            movePan.BringToFront();
            for (int i = 0; i < pan.Length; i++)
            {

                pan[i].Enabled = false;
            }

            
        }
         private bool StackCheck(Stack<Panel> s, Panel p)
        {

            if (s.Count == 0)
            {

                return false;
            }

            if (s.Peek() == p)
            {

                return true;
            }

            return false;
             
        }
       


        private void MouseMove(object sender, MouseEventArgs e)
        {

            
            if (isMove)
            {


                if (First.Bounds.IntersectsWith(movePan.Bounds))
                {

                    if (s1.Count == 0)
                    {

                        sign.Visible = true;
                        sign1.Visible = false;
                         
                    }else if (s1.Peek().Width<movePan.Width)
                    {

                        sign.Visible = false;
                        sign1.Visible = true;
                    }
                    else 
                    {
                        sign.Visible = true;
                        sign1.Visible = false;

                    }
                }else if (Second.Bounds.IntersectsWith(movePan.Bounds))
                {

                    if (s2.Count == 0)
                    {

                        sign.Visible = true;
                        sign1.Visible = false;

                    }
                    else if (s2.Peek().Width < movePan.Width)
                    {

                        sign.Visible = false;
                        sign1.Visible = true;
                    }
                    else
                    {
                        sign.Visible = true;
                        sign1.Visible = false;

                    }


                }else if (Third.Bounds.IntersectsWith(movePan.Bounds))
                {

                    if (s3.Count == 0)
                    {

                        sign.Visible = true;
                        sign1.Visible = false;

                    }
                    else if (s3.Peek().Width < movePan.Width)
                    {

                        sign.Visible = false;
                        sign1.Visible = true;
                    }
                    else
                    {
                        sign.Visible = true;
                        sign1.Visible = false;

                    }

                }
                else
                {


                    sign.Visible = false;
                    sign1.Visible = false;
                }
               


             
                movePan.Left+=movePan.PointToClient(Cursor.Position).X-dx;
                movePan.Top+=movePan.PointToClient(Cursor.Position).Y-dy;

            }
        }

        private void MouseClickDrag(object sender, MouseEventArgs e)
        {


            if (isMove)
            {
                Thread mover = new Thread(Mover);
               
                for (int i = 0; i < pan.Length; i++)
                {
                    if (pan[i] != movePan)
                    {
                        pan[i].Enabled = true;
                    }
                }

                
                int count;
                Panel an;
                isMove = false;
                if (r==s1)
                {

                    an = First;
                    count = s1.Count;
                     
                }else if (r == s2)
                {

                    an = Second;
                    count = s2.Count;

                }
                else
                {

                    an = Third;
                    count = s3.Count;
                }
                if (First.Bounds.IntersectsWith(movePan.Bounds))
                {

                    if (s1.Count == 0)
                    {
                        mover.Start(new Point((First.Left - movePan.Width / 2 + First.Width / 2), panel3.Location.Y - (r == s1 ? count : s1.Count + 1) * movePan.Height));
                        r.Pop();
                        s1.Push(movePan);

                    }
                    else if (s1.Peek().Width < movePan.Width)
                    {

                        mover.Start(new Point((an.Left - movePan.Width / 2 + an.Width / 2), panel3.Location.Y - (count) * movePan.Height));
                    }
                    else
                    {
                        mover.Start(new Point((First.Left - movePan.Width / 2 + First.Width / 2), panel3.Location.Y - (r == s1 ? count  : s1.Count+1) * movePan.Height));
                        r.Pop();
                        s1.Push(movePan);
                    }
                }
                else if (Second.Bounds.IntersectsWith(movePan.Bounds))
                {

                    if (s2.Count == 0)
                    {

                        mover.Start(new Point((Second.Left - movePan.Width / 2 + Second.Width / 2), panel3.Location.Y - (r == s2 ? count  : s2.Count+1) * movePan.Height));
                        r.Pop();
                        s2.Push(movePan);
                    }
                    else if (s2.Peek().Width < movePan.Width)
                    {

                        mover.Start(new Point((an.Left - movePan.Width / 2 + an.Width / 2), panel3.Location.Y - (count ) * movePan.Height));
                    }
                    else
                    {
                        mover.Start(new Point((Second.Left - movePan.Width / 2 + Second.Width / 2), panel3.Location.Y - (r == s2 ? count  : s2.Count+1) * movePan.Height));
                        r.Pop();
                        s2.Push(movePan);

                    }


                }
                else if (Third.Bounds.IntersectsWith(movePan.Bounds))
                {

                    if (s3.Count == 0)
                    {

                        mover.Start(new Point((Third.Left - movePan.Width / 2 + Third.Width / 2), panel3.Location.Y - (r == s3 ? count : s3.Count+1) * movePan.Height));
                        r.Pop();
                        s3.Push(movePan);
                        
                    }
                    else if (s3.Peek().Width < movePan.Width)
                    {

                        mover.Start(new Point((an.Left - movePan.Width / 2 + an.Width / 2), panel3.Location.Y - (count ) * movePan.Height));
                    
                    }
                    else
                    {
                        mover.Start(new Point((Third.Left - movePan.Width / 2 + Third.Width / 2), panel3.Location.Y - (r == s3 ? count : s3.Count+1) * movePan.Height));
                        r.Pop();
                        s3.Push(movePan);

                    }

                }
                else
                {


                    mover.Start(new Point((an.Left - movePan.Width / 2 + an.Width / 2), panel3.Location.Y - (count) * movePan.Height));
                }

                sign.Visible = false;
                sign1.Visible = false;
                
            }


         

             
        }
         
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        private Panel CreatePanel(int i, int width, int height, Color col, int h)
        {
            

            if (i == 1)
            {
                Panel pan1 = new Panel();
                pan1.BackColor = col;
                pan1.Height =height;
                pan1.Width = width;
                pan1.Location = new Point((First.Left - pan1.Width / 2 + First.Width / 2), panel3.Location.Y - h);
                pan1.Anchor = AnchorStyles.None;
                pan1.Anchor = AnchorStyles.Bottom;

                return pan1;




            }
            else if (i == 2)
            {
                Panel pan = new Panel();
                pan.BackColor = col;
                pan.Height = height;
                pan.Width = width;
                pan.Location = new Point((Second.Left - pan.Width / 2 + Second.Width / 2), panel3.Location.Y - h);
                pan.Anchor = AnchorStyles.None;
                pan.Anchor = AnchorStyles.Bottom;

                return pan;

            }
            else
            {
                Panel pan2 = new Panel();
                pan2.BackColor = col;
                pan2.Height = height;
                pan2.Width = width;
                pan2.Location = new Point((Third.Left - pan2.Width / 2 + Third.Width / 2), panel3.Location.Y - h);
                pan2.Anchor = AnchorStyles.None;
                pan2.Anchor = AnchorStyles.Bottom;
                return pan2;
            }


        }

        private void sign1_Click(object sender, EventArgs e)
        {

        }
      
        
        int indexOf(Stack<Panel> st1, Panel pan1)
        {
            if (st1.Contains(pan1))
            {

                for(int i=0; i<st1.Count; i++)
                {


                    if (pan1 == st1.ElementAt(i))
                    {

                        return st1.Count-(i);
                    }
                }

            }

            return 0;

        }
        
        private void Adapter(Panel ap, Stack<Panel> st)
        {

            Action act = () => { ap.Enabled = false; };

              Invoke(act);
           solvePan = ap;
            Panel pap;
            if (st == s1)
            {

                pap = First;
            }else if(st == s2)
            {

                pap = Second;
            }
            else
            {
                pap = Third;

            }
            Mover1(new Point((pap.Left - solvePan.Width / 2 + pap.Width / 2), panel3.Location.Y - (st.Count+1) * solvePan.Height));

            

        }


        private Stack<Panel> Widest(int Width)
        {

            Stack<Panel> stack=s1;



             for(int i=0; i<s1.Count; i++)
            {

                if (s1.ElementAt(i).Width == Width)
                {

                    return s1;
                }
            }
            for (int i = 0; i < s2.Count; i++)
            {

                if (s2.ElementAt(i).Width == Width)
                {

                    return s2;
                }
            }


            for (int i = 0; i < s3.Count; i++)
            {

                if (s3.ElementAt(i).Width == Width)
                {

                    return s3;
                }
            }
            return stack;
             
        }

        private int WidthLessThan(int Width)
        {

            int m=0;
            for(int i=0; i<pan.Length; i++)
            {
                if(m<pan[i].Width && pan[i].Width<Width)
                {
                    m = pan[i].Width;


                }

                 
            }
            return m;
        }
        private void Recursive(int i,  Stack<Panel> st2, int Width)
        {
            
                Stack<Panel> st1 = Widest(Width);
          
                if (i == 0)
                {


                    return;
                }
                if (st1 == st2)
                {

                    Recursive(i - 1, st2, WidthLessThan(Width));

                }
                else if ((st1 == s1 && st2 == s3) || (st1 == s3 && st2 == s1))
                {

                    Recursive(i - 1, s2, WidthLessThan(Width));



                    Adapter(st1.Peek(), st2);
                    st2.Push(st1.Pop());

                    Recursive(i - 1, st2, WidthLessThan(Width));
                }
                else if ((st1 == s1 && st2 == s2) || (st1 == s2 && st2 == s1))
                {


                    Recursive(i - 1, s3, WidthLessThan(Width));

                    Adapter(st1.Peek(), st2);
                    st2.Push(st1.Pop());

                    Recursive(i - 1, st2, WidthLessThan(Width));


                }
                else if ((st1 == s2 && st2 == s3) || (st1 == s3 && st2 == s2))
                {

                    Recursive(i - 1, s1, WidthLessThan(Width));

                    Adapter(st1.Peek(), st2);
                    st2.Push(st1.Pop());

                    Recursive(i - 1, st2, WidthLessThan(Width));



                }
            


        }
        private void time_Tick(object sender, EventArgs e)
        {
            if (First.Height != height1)
            {

                int h;
                for (int i = 0; i < pan.Length; i++)
                {

                    
                    h = indexOf(s1, pan[i]) + indexOf(s2, pan[i]) + indexOf(s3, pan[i]);

                    pan[i].Height = First.Height / int.Parse(textBox1.Text);
                    pan[i].Location = new Point(pan[i].Left, panel3.Location.Y - h*pan[i].Height);


                }

                height1 = First.Height;
            }
        }
            

        private void RecursionAdapter()
        {
            
                Action act;
                Recursive(pan.Length, s3, 200);
                act = () => { NumberInThird(s3.Count); };
                Invoke(act);
           

        } 
        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            button2.Enabled = false;
            Thread recur = new Thread(RecursionAdapter);
            
            recur.Start();

            
        }

        bool alloved = false;
        private void Stop_Click(object sender, EventArgs e)
        {


            recur.Abort();
            NumberInThird(int.Parse(textBox1.Text));

        }
        private void Recursive1(int i, Stack<Panel> st2, int Width, ref bool bo)
        {
            Stack<Panel> st1 = Widest(Width);
            if (i == 0)
            {


                return;
            }
            if (st1 == st2)
            {

                Recursive1(i - 1, st2, WidthLessThan(Width), ref bo);

            }
            else if ((st1 == s1 && st2 == s3) || (st1 == s3 && st2 == s1))
            {

                Recursive1(i - 1, s2, WidthLessThan(Width), ref bo);


                if (!bo)
                {
                    Adapter(st1.Peek(), st2);
                    st2.Push(st1.Pop());
                    bo = true;
                    Adapter(st2.Peek(), st1);
                    st1.Push(st2.Pop());

                    
                }
                else
                {
                    return;
                }
                Recursive1(i - 1, st2, WidthLessThan(Width), ref bo);
            }
            else if ((st1 == s1 && st2 == s2) || (st1 == s2 && st2 == s1))
            {

             
                    Recursive1(i - 1, s3, WidthLessThan(Width), ref bo);
                if (!bo)
                {
                    Adapter(st1.Peek(), st2);
                st2.Push(st1.Pop());
                    bo = true;
                    Adapter(st2.Peek(), st1);
                    st1.Push(st2.Pop());


                }
                else
                {
                    return;
                }
                Recursive1(i - 1, st2, WidthLessThan(Width), ref bo);


            }
            else if ((st1 == s2 && st2 == s3) || (st1 == s3 && st2 == s2))
            {

                Recursive1(i - 1, s1, WidthLessThan(Width), ref bo);
                if (!bo)
                {
                    Adapter(st1.Peek(), st2);
                st2.Push(st1.Pop());
                    bo = true;
                    Adapter(st2.Peek(), st1);
                    st1.Push(st2.Pop());


                }
                else
                {
                    return;
                }
                Recursive1(i - 1, st2, WidthLessThan(Width), ref bo);



            }


        }

        void RecursionAdapter1()
        {
            bool bo = false;
            Action act;
            Recursive1(pan.Length, s3, 200, ref bo);
         
           

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Thread nextthread = new Thread(RecursionAdapter1);

            nextthread.Start();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
