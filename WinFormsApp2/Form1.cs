namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var measureItems = new string[]
            {
            "десятичная",
            "двоичная",
            "восьмеричная",
            "шестнадцатеричная",
            };

            cmbFirstType.DataSource = new List<string>(measureItems);
            cmbSecondType.DataSource = new List<string>(measureItems);
            cmbResultType.DataSource = new List<string>(measureItems);
            cmbBox1.DataSource = new List<string>(measureItems);
            cmbBox2.DataSource = new List<string>(measureItems);
        }

        private MeasureType GetMeasureType(ComboBox comboBox)
        {
            MeasureType measureType;
            switch (comboBox.Text)
            {
                case "десятичная":
                    measureType = MeasureType.десятичная;
                    break;
                case "двоичная":
                    measureType = MeasureType.двоичная;
                    break;
                case "восьмеричная":
                    measureType = MeasureType.восьмеричная;
                    break;
                case "шестнадцатеричная":
                    measureType = MeasureType.шестнадцатеричная;
                    break;
                default:
                    measureType = MeasureType.десятичная;
                    break;
            }
            return measureType;
        }
        private void Calculate()
        {
            try
            {
                var firstValue = Convert.ToString(txtFirst.Text);
                var secondValue = Convert.ToString(txtSecond.Text);

                MeasureType firstType = GetMeasureType(cmbFirstType);
                MeasureType secondType = GetMeasureType(cmbSecondType);
                MeasureType resultType = GetMeasureType(cmbResultType);

                var first = new Number(firstValue, firstType);
                var second = new Number(secondValue, secondType);

                Number sumLength;

                switch (cmbOperation.Text)
                {
                    case "+":
                        sumLength = first + second;
                        break;
                    case "-":
                        sumLength = first - second;
                        break;
                    case "*":
                        sumLength = first * second;
                        break;
                    default:
                        sumLength = new Number("0", MeasureType.десятичная);
                        break;
                }

                txtResult.Text = sumLength.To(resultType).Verbose2();
            }
            catch (FormatException)
            {
                //eror
            }
        }
        private void Translate()
        {
            try
            {
                var firstValue = Convert.ToString(number1.Text);
              

                MeasureType firstType = GetMeasureType(cmbBox1);
                MeasureType secondType = GetMeasureType(cmbBox2);
              

                var firstLength = new Number(firstValue, firstType);

                var number = firstLength.To(secondType);

                number2.Text = number.Verbose2();
            }
            catch (FormatException)
            {
                //eror
            }
        }

        private void txtFirst_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void txtSecond_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {
            ;
        }

        private void cmbOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void cmbFirstType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void cmbSecondType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void cmbResultType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Translate();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}