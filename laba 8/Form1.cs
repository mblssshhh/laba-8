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
                operators.Add(new Operator(';'));
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
                
                Elips el = new Elips(Convert.ToInt32(textBoxX.Text), Convert.ToInt32(textBoxY.Text), Convert.ToInt32(textBoxW.Text), Convert.ToInt32(textBoxH.Text), "");
                ShapeContainer.AddFigure(el);
                el.Draw();
                comboBox1.Items.Add(el);
            }



            if (checkBoxCircle.Checked == true)
            {
                Circle ci = new Circle(Convert.ToInt32(textBoxX.Text), Convert.ToInt32(textBoxY.Text), Convert.ToInt32(textBoxW.Text));
                ShapeContainer.AddFigure(ci);
                ci.Draw();
                comboBox1.Items.Add(ci);
            }



            if (checkBox1.Checked == true)
            {
                fi = new MyFigure(Convert.ToInt32(textBoxX.Text), Convert.ToInt32(textBoxY.Text), Convert.ToInt32(textBoxW.Text), Convert.ToInt32(textBoxH.Text));
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
            Figure figu = (Figure)comboBox1.SelectedItem;
            figu.MoveTo(Convert.ToInt32(move1.Text), Convert.ToInt32(move2.Text), (Figure)comboBox1.SelectedItem);
            if (checkBoxPolygon.Checked == true)
            {
                Figure pol = (Figure)comboBox1.SelectedItem;
                pol.MoveTo(Convert.ToInt32(move1.Text), Convert.ToInt32(move2.Text), (Figure)comboBox1.SelectedItem);
            }
           
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
        Figure figure;
        private void SelectingPerformingOperation(Operator op)
        {
            if (op.symbolOperator == 'C')
            {
                string name = Convert.ToString(operands.Pop().value);
                string x = Convert.ToString(operands.Pop().value);
                string y = Convert.ToString(operands.Pop().value);
                string w = Convert.ToString(operands.Pop().value);
                string h = Convert.ToString(operands.Pop().value);
                Elips el = new Elips(Convert.ToInt32(x), Convert.ToInt32(y), Convert.ToInt32(w), Convert.ToInt32(h), name);
                ShapeContainer.AddFigure(el);
                comboBox1.Items.Add(el);
                this.figure = el;
                
                op = new Operator(this.figure.Draw, 'C');
                ShapeContainer.AddFigure(figure);
                comboBox1.Items.Add(figure.name);
                op.operatorMethod();
            }
        }
            bool flag = true;

            private void textBox1_KeyDown(object sender, KeyEventArgs e)
            {
            string textBoxInputString = textBox1.Text;
            if (e.KeyCode == Keys.Enter)
            {

                for (int i = 0; i < textBoxInputString.Length; i++)
                {
                    if (IsNotOperation(textBoxInputString[i]))
                    {
                        if (!(Char.IsDigit(textBoxInputString[i])))
                        {
                            this.operands.Push(new Operand(textBoxInputString[i]));
                            continue;
                        }
                        else if (Char.IsDigit(textBoxInputString[i]))
                        {
                            if (Char.IsDigit(textBoxInputString[i + 1]))
                            {
                                if (flag)
                                {
                                    this.operands.Push(new Operand(textBoxInputString[i]));
                                }
                                this.operands.Push(new Operand(Convert.ToInt32((this.operands.Pop().value).ToString()) * 10 + Convert.ToInt32(textBoxInputString[i + 1])));
                                flag = false;
                                continue;
                            }
                            else if ((textBoxInputString[i + 1] == ','
                            || textBoxInputString[i + 1] == ')')
                            && !(Char.IsDigit(textBoxInputString[i - 1])))
                            {
                                this.operands.Push(new Operand(Convert.ToInt32
                                (textBoxInputString[i])));
                                continue;
                            }
                        }
                        


                    }
                    else if (textBoxInputString[i] == 'C')
                    {
                        if (this.operators.Count == 0)
                        {
                            this.operators.Push(OperatorContainer.FindOperator
                            (textBoxInputString[i]));
                        }
                    }
                    else if (textBoxInputString[i] == '(')
                    {
                        this.operators.Push(OperatorContainer.FindOperator
                        (textBoxInputString[i]));
                    }
                    else if (textBoxInputString[i] == ')')
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



                if (operators.Peek() != null)
                {
                    this.SelectingPerformingOperation(operators.Peek());
                }
                else
                {
                    MessageBox.Show("Введенной операции не существует");
                }
            }
            }
    }


    }

                

