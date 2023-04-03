using laba_8;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static laba_8.Form1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace laba_8
{

    public partial class Form1 : Form
    {
        Bitmap bitmap; 
        Pen pen = new Pen(Color.Black, 5);
        Rectangle re = new Rectangle();
        List<Figure> ListOfF = new List<Figure>();
        private Polygon polygon;
        ShapeContainer shapeContainer;
        MyFigure fi = new MyFigure();
        bool flag = true;
        string name;
        private Stack<Operator> operators = new Stack<Operator>();
        private Stack<Operand> operands = new Stack<Operand>();


        public Form1()
        {
            InitializeComponent();
            this.bitmap = new Bitmap(pictureBox.ClientSize.Width, pictureBox.ClientSize.Height);
            this.pen = new Pen(Color.Black, 5);
            Init.bitmap = this.bitmap;
            Init.pictureBox = pictureBox;
            Init.pen = this.pen;
            shapeContainer = new ShapeContainer();
        }


        public class Operand
        {
            public object value;
            public Operand(object NewValue)
            {
                this.value = NewValue;
            }
        }

        public class OperatorMethod
        {
            public delegate void EmptyOperatorMethod();
            public delegate void UnaryOperatorMethod(object operand);
            public delegate void BinaryOperatorMethod(object operand1, object operand2);
            public delegate void TrinaryOperatorMethod(object operand1, object operand2, object operand3);
        }

        public class Operator : OperatorMethod
        {
            public char symbolOperator;
            public EmptyOperatorMethod operatorMethod = null;
            public BinaryOperatorMethod binaryOperator = null;
            public TrinaryOperatorMethod trinaryOperator = null;
            public readonly char symboloperands;

            public Operator(EmptyOperatorMethod operatorMethod, char symbolOperator)
            {
                this.operatorMethod = operatorMethod;
                this.symbolOperator = symbolOperator;
            }
            public Operator(BinaryOperatorMethod binaryOperator, char symbolOperator)
            {
                this.binaryOperator = binaryOperator;
                this.symbolOperator = symbolOperator;
            }
            public Operator(TrinaryOperatorMethod trinaryOperator, char symbolOperator)
            {
                this.trinaryOperator = trinaryOperator;
                this.symbolOperator = symbolOperator;
            }
            public Operator(char symbolOperator)
            {
                this.symbolOperator = symbolOperator;
            }

        }

        public static class OperatorContainer
        { 
            public static List<Operator> operators = new List<Operator>();
            static OperatorContainer()
            {
                operators.Add(new Operator('C'));
                operators.Add(new Operator('M'));
                operators.Add(new Operator('D'));
                operators.Add(new Operator(','));
                operators.Add(new Operator('('));
                operators.Add(new Operator(')'));
            }
            public static Operator FindOperator(char s)
            {
                foreach (Operator op in operators)
                {
                    if (op.symbolOperator == s)
                    {
                        return op;
                    }
                }
                return null;
            }
        }
        


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
        private void button1_Click(object sender, EventArgs e)
        {

                if (RectagleCheck.Checked == true)
                {
                    re = new Rectangle(Convert.ToInt32(textBoxX.Text), Convert.ToInt32(textBoxY.Text), Convert.ToInt32(textBoxW.Text), Convert.ToInt32(textBoxH.Text), "");
                    re.Draw();
                    ShapeContainer.AddFigure(re);
                    comboBox1.Items.Add(re);
                    //ListOfF.Add(re);
                    //comboBox1.DataSource = ListOfF;
                    //comboBox1.DisplayMember = "Rectangle";
            }
            




            if (checkBoxSquare.Checked == true)
            { 
                
                Square sq = new Square(Convert.ToInt32(textBoxX.Text), Convert.ToInt32(textBoxY.Text), Convert.ToInt32(textBoxW.Text));
                sq.Draw();
                ShapeContainer.AddFigure(sq);
                comboBox1.Items.Add(sq);
                //ListOfF.Add(sq);
                //comboBox1.DataSource = ListOfF;
                //comboBox1.DisplayMember = "Square";
                
            }



            if (checkBoxElips.Checked == true)
            {
                
                Elips el = new Elips("", Convert.ToInt32(textBoxX.Text), Convert.ToInt32(textBoxY.Text), Convert.ToInt32(textBoxW.Text), Convert.ToInt32(textBoxH.Text));
                ShapeContainer.AddFigure(el);
                el.Draw();
                comboBox1.Items.Add(el);
            }



            if (checkBoxCircle.Checked == true)
            {
                Circle ci = new Circle("",Convert.ToInt32(textBoxX.Text), Convert.ToInt32(textBoxY.Text), Convert.ToInt32(textBoxW.Text));
                ShapeContainer.AddFigure(ci);
                ci.Draw();
                comboBox1.Items.Add(ci);
            }



            if (checkBox1.Checked == true)
            {
                fi = new MyFigure(Convert.ToInt32(textBoxX.Text), Convert.ToInt32(textBoxY.Text), Convert.ToInt32(textBoxW.Text), Convert.ToInt32(textBoxH.Text), "");
                fi.Draw();
                ShapeContainer.AddFigure(fi);
                comboBox1.Items.Add(fi);
                
            }


        }


        private void textBoxX_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxY_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void RectagleCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBoxW_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxH_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click( object sender, EventArgs e)
        {
            Figure figu = (Figure)comboBox1.SelectedItem;
            figu.DeleteF(figu);

            comboBox1.Items.Remove(comboBox1.SelectedItem);
        }

        private void checkBoxSquare_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxElips_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxCircle_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxPolygon_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPolygon.Checked == true)
            {
                
                Form ifrm = new Form2(ref Form2.pointFs, ref polygon);
                

                ifrm.ShowDialog();
                if (Form2.pointFs.Length != 0)
                {
                    ShapeContainer.AddFigure(polygon);
                    comboBox1.Items.Add(Form2.polygon);
                }
                


            }
            
        }




        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonMy_Click(object sender, EventArgs e)
        {



        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void move1_TextChanged(object sender, EventArgs e)
        {

        }

        private void move2_TextChanged(object sender, EventArgs e)
        {

        }

        private void moveBut_Click(object sender, EventArgs e)
        {
            //Figure figu = (Figure)comboBox1.SelectedItem;
            //figu.MoveTo("", Convert.ToInt32(move1.Text), Convert.ToInt32(move2.Text), (Figure)comboBox1.SelectedItem);
            //if (checkBoxPolygon.Checked == true)
            //{
            //    Figure pol = (Figure)comboBox1.SelectedItem;
            //    pol.MoveTo("", Convert.ToInt32(move1.Text), Convert.ToInt32(move2.Text), (Figure)comboBox1.SelectedItem);
            //}
           
        }

        void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private bool IsNotOperation(char item)
        {
            if (!(item == 'C' || item == 'M' || item == 'D' || item == ',' || item == '(' || item == ')'))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void SelectingPerformingOperation(Operator op)
        {
            if (textBox1.Text[0] == 'C')
            {
                int w = Convert.ToInt32(Convert.ToString(operands.Pop().value));

                int y = Convert.ToInt32(Convert.ToString(operands.Pop().value));
                int x = Convert.ToInt32(Convert.ToString(operands.Pop().value));
                if (this.operands.Count == 1)
                {
                    string name = Convert.ToString(operands.Pop().value);


                        Circle C = new Circle(name, x, y, w);
                        op = new Operator(C.Draw, 'C');
                        ShapeContainer.AddFigure(C);
                        richTextBox1.Text += "Circle: " + name + " spawn\n";
                        op.operatorMethod();


                }
                else
                {
                    MessageBox.Show("params > 4\n");
                }
            }
            if (textBox1.Text[0] == 'M')
            {
                    int y = Convert.ToInt32(Convert.ToString(operands.Pop().value));
                    int x = Convert.ToInt32(Convert.ToString(operands.Pop().value));
                    name = Convert.ToString(operands.Pop().value);
                    string movename = name + ":" + " replace\n";
                    if (ShapeContainer.FindFigure(name) == null)
                    {
                        MessageBox.Show("Error!\n");
                        richTextBox1.Text += "Repite command\n";
                    }
                    else
                    {
                        ShapeContainer.FindFigure(name).MoveTo(x, y);
                        richTextBox1.Text += movename;
                    }
            }
            if (textBox1.Text[0] == 'D')
            {
                    name = Convert.ToString(operands.Pop().value);
                    string deletename = name + ":" + " delete\n ";
                    if (ShapeContainer.FindFigure(name) == null)
                    {
                        MessageBox.Show("Error!");
                        richTextBox1.Text += "Repite command\n";
                    }
                    else
                    {
                        ShapeContainer.FindFigure(name).DeleteF(ShapeContainer.FindFigure(name), true);
                        richTextBox1.Text += ShapeContainer.FindFigure(name) + deletename;
                    }
            }

        }

        public int ConvertCharToInt(object item)
        {
            return Convert.ToInt32(Convert.ToString(item));
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
            {
            if (e.KeyCode == Keys.Enter)
            {
                operators = new Stack<Operator>();
                operands = new Stack<Operand>();
                for (int i = 0; i < textBox1.Text.Length; i++)
                {
                    if (IsNotOperation(textBox1.Text[i]))
                    {
                        if (!(Char.IsDigit(textBox1.Text[i])))
                        {
                            this.operands.Push(new Operand(textBox1.Text[i]));
                            continue;
                        }
                        else if (Char.IsDigit(textBox1.Text[i]))
                        {
                            if (flag)
                            {
                                this.operands.Push(new Operand(textBox1.Text[i]));
                            }
                            else
                            {
                                if (!(Char.IsDigit(textBox1.Text[i - 1])))
                                {
                                    this.operands.Push(new Operand(ConvertCharToInt(textBox1.Text[i])));
                                    continue;
                                }
                                this.operands.Push(new Operand(ConvertCharToInt(this.operands.Pop().value) * 10 + ConvertCharToInt(textBox1.Text[i])));
                            }
                            flag = false;
                            continue;
                        }
                    }
                    else if (textBox1.Text[i] == ',')
                    {
                        flag = true;
                        continue;
                    }

                    else if (textBox1.Text[i] == 'C')
                    {
                        this.operators.Push(OperatorContainer.FindOperator(textBox1.Text[i]));
                        continue;
                    }
                    else if (textBox1.Text[i] == 'M')
                    {
                        this.operators.Push(OperatorContainer.FindOperator(textBox1.Text[i]));
                        continue;
                    }
                    else if (textBox1.Text[i] == 'D')
                    {
                        this.operators.Push(OperatorContainer.FindOperator(textBox1.Text[i]));
                        continue;
                    }
                    else if (textBox1.Text[i] == '(')
                    {
                        this.operators.Push(OperatorContainer.FindOperator(textBox1.Text[i]));
                    }
                    else if (textBox1.Text[i] == ')')
                    {
                        do
                        {
                            if (operators.Peek().symbolOperator == '(')
                            {
                                operators.Pop();
                                break;
                            }
                            if (operators.Count == 0)
                            {
                                break;
                            }
                        }
                        while (operators.Peek().symbolOperator != '(');
                    }
                }
                try
                {
                    this.SelectingPerformingOperation(operators.Peek());
                } catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }


    }

                

