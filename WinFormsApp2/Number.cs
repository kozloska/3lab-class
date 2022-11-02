using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    public enum MeasureType { двоичная, восьмеричная, десятичная, шестнадцатеричная };
    public class Number
    {
        private string value;
        private MeasureType type;
        public Number(string value, MeasureType type)
        {
            this.value = value;
            this.type = type;
        }

        public string Verbose()
        {
            string typeVerbose = "";
            switch (this.type)
            {
                case MeasureType.двоичная:
                    typeVerbose = "двоичная";
                    break;
                case MeasureType.восьмеричная:
                    typeVerbose = "восьмеричная";
                    break;
                case MeasureType.десятичная:
                    typeVerbose = "десятичная";
                    break;
                case MeasureType.шестнадцатеричная:
                    typeVerbose = "шестнадцатеричная";
                    break;
            }
            return String.Format("{0} {1}", this.value, typeVerbose);
        }

        public string Verbose2()
        {
            return this.value;
        }

        public Number To(MeasureType newType)
        {
            int a = 0;
            var newValue = this.value;
            if (this.type == MeasureType.десятичная)
            {
                switch (newType)
                {

                    case MeasureType.десятичная:
                        newValue = this.value;
                        break;

                    case MeasureType.двоичная:
                        a = Convert.ToInt32(this.value);
                        if (a < 0)
                        {
                            a = a * (-1);
                            newValue = Convert.ToString(a, 2);
                            newValue = "-" + newValue;
                        }
                        else
                        {
                            newValue = Convert.ToString(a, 2);
                        }
                        break;

                    case MeasureType.восьмеричная:
                        a = Convert.ToInt32(this.value);
                        if (a < 0)
                        {
                            a = a * (-1);
                            newValue = Convert.ToString(a, 8);
                            newValue = "-" + newValue;
                        }
                        else
                        {
                            newValue = Convert.ToString(a, 8);
                        }
                        break;

                    case MeasureType.шестнадцатеричная:
                        a = Convert.ToInt32(this.value);
                        if (a < 0)
                        {
                            a = a * (-1);
                            newValue = Convert.ToString(a, 16);
                            newValue = "-" + newValue;
                        }
                        else
                        {
                            newValue = Convert.ToString(a, 16);
                        }
                        break;
                }
            }
            else if (newType == MeasureType.десятичная)
            {
                switch (this.type)
                {
                    case MeasureType.десятичная:
                        newValue = this.value;
                        break;
                    case MeasureType.двоичная:
                        try
                        {
                            if (this.value[0] == '-' && this.value.Length > 1)
                            {
                                this.value = this.value.Remove(0, 1);
                                a = Convert.ToInt32(this.value, 2);
                                newValue = Convert.ToString(a);
                                newValue = "-" + newValue;
                            }
                            else
                            {
                                a = Convert.ToInt32(this.value, 2);
                                newValue = Convert.ToString(a);
                            }
                        }
                        catch
                        {
                            newValue = "";
                        }
                        break;
                    case MeasureType.восьмеричная:
                        try
                        {
                            if (this.value[0] == '-' && this.value.Length > 1)
                            {
                                this.value = this.value.Remove(0, 1);
                                a = Convert.ToInt32(this.value, 8);
                                newValue = Convert.ToString(a);
                                newValue = "-" + newValue;
                            }
                            else
                            {
                                a = Convert.ToInt32(this.value, 8);
                                newValue = Convert.ToString(a);
                            }
                        }
                        catch
                        {
                            newValue = "";
                        }
                        break;
                    case MeasureType.шестнадцатеричная:
                        try
                        {
                            if (this.value[0] == '-' && this.value.Length > 1)
                            {
                                this.value = this.value.Remove(0, 1);
                                a = Convert.ToInt32(this.value, 16);
                                newValue = Convert.ToString(a);
                                newValue = "-" + newValue;
                            }
                            else
                            {
                                a = Convert.ToInt32(this.value, 16);
                                newValue = Convert.ToString(a);
                            }
                        }
                        catch {
                            newValue = "";
                        }
                        break;
                }
            }
            else
            {
                newValue = this.To(MeasureType.десятичная).To(newType).value;
            }
            return new Number(newValue, newType);
        }
        public static Number operator +(Number instance1, Number instance2)
        {
            int number1, number2, result;
            string newValue;
            MeasureType a = instance1.type;
            instance1 = instance1.To(MeasureType.десятичная);
            instance2 = instance2.To(MeasureType.десятичная);
           // number2 = Convert.ToInt32(instance2.value);
            number1 = Convert.ToInt32(instance1.value);
            number2 = Convert.ToInt32(instance2.value);
            result = number1 + number2;
            newValue = Convert.ToString(result);
            Number inresult = new(newValue, MeasureType.десятичная);
            return inresult.To(a);
        }
        public static Number operator -(Number instance1, Number instance2)
        {
            int number1, number2, result;
            string newValue;
            MeasureType a = instance1.type;
            instance1 = instance1.To(MeasureType.десятичная);
            instance2 = instance2.To(MeasureType.десятичная);
            number1 = Convert.ToInt32(instance1.value);
            number2 = Convert.ToInt32(instance2.value);
            result = number1 - number2;
            newValue = Convert.ToString(result);
            Number inresult = new(newValue, MeasureType.десятичная);
            return inresult.To(a);
        }
        public static Number operator *(Number instance1, Number instance2)
        {
            int number1, number2, result;
            string newValue;
            MeasureType a = instance1.type;
            instance1 = instance1.To(MeasureType.десятичная);
            instance2 = instance2.To(MeasureType.десятичная);
            number1 = Convert.ToInt32(instance1.value);
            number2 = Convert.ToInt32(instance2.value);
            result = number1 * number2;
            newValue = Convert.ToString(result);
            Number inresult = new(newValue, MeasureType.десятичная);
            return inresult.To(a);
        }
    }
}
