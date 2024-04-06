using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void Bai3_Load(object sender, EventArgs e)
        {

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.ShowDialog();
            FileStream fs = new FileStream(openFile.FileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fs);
            txtFileContent.Text = reader.ReadToEnd();
            reader.Close();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text file|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter writer = new StreamWriter(fs);
                string FileContent = txtFileContent.Text;
                string command = "";
                string Postfix;
                double result;
                for (int index = 0; index < FileContent.Length; index++)
                {
                    if (FileContent[index] == '\n' || index == FileContent.Length - 1)
                    {
                        if(index == FileContent.Length - 1)
                        {
                            command += FileContent[index];
                        } 
                        //Postfix = InfixToPostfix(command);
                        Postfix = command;
                        writer.Write(command);
                        writer.Write(" = ");
                        command = "";
                        result = Calculate(Postfix);
                        result = Math.Round(result, 2);
                        writer.Write(result+ "\n");

                    }
                    else
                    {
                        command += FileContent[index];
                    }
                }
                writer.Close();
            }
        }

        static double Calculate(string expression)
        {
            
            Queue<double> operands = new Queue<double>();
            Queue<char> operators = new Queue<char>();

            string currentOperand = ""; 

            
            foreach (char c in expression)
            {
                if (char.IsDigit(c))
                {
                    currentOperand += c;
                }
                else
                {
                    if (currentOperand != "")
                    {
                        operands.Enqueue(double.Parse(currentOperand));
                        currentOperand = "";
                    }

                    
                    if (IsOperator(c))
                    {
                        operators.Enqueue(c);
                    }
                    
                }
            }

            
            if (currentOperand != "")
            {
                operands.Enqueue(double.Parse(currentOperand));
            }

            while (operators.Count > 0)
            {
                double temp = 0;
                temp = Calculate(operators.Dequeue(), operands.Dequeue(), operands.Dequeue());
                ReverseQueue(operands);
                operands.Enqueue(temp);
                ReverseQueue(operands);
            }

            return operands.Dequeue();
        }

        static bool IsOperator(char c)
        {
            return c == '+' || c == '-' || c == '*' || c == '/' || c == '(' || c == ')';
        }

        static int Precedence(char c)
        {
            switch (c)
            {
                case '+':
                case '-':
                    return 1;
                case '*':
                case '/':
                    return 2;
                default:
                    return 0;
            }
        }

        static double Calculate(char op, double operand1, double operand2)
        {
            switch (op)
            {
                case '+':
                    return operand1 + operand2;
                case '-':
                    return operand1 - operand2;
                case '*':
                    return operand1 * operand2;
                case '/':
                    return operand1 / operand2;
                default:
                    return 0;
            }
        }

        public static void ReverseQueue(Queue<double> queue)
        {
            Stack<double> stack = new Stack<double>();

            // Enqueue all elements from queue to stack
            while (queue.Count > 0)
            {
                stack.Push(queue.Dequeue());
            }

            // Dequeue all elements from stack and enqueue them back to queue (reversed order)
            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }
        }


    }
}
