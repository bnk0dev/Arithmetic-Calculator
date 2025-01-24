using System.Linq;
using System.Runtime.InteropServices;

namespace base_transformations
{
    public partial class Arithmetic_Calc : Form
    {
        public Arithmetic_Calc()
        {
            InitializeComponent();
            output.Enabled = false;
        }

        private void binaryButton_Click(object sender, EventArgs e)
        {
            try
            {
                string userInput = input.Text;

                // Invalid input check (negative values and empty inputs)
                if (userInput.Contains("-"))
                {
                    MessageBox.Show("Negative numbers are not allowed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(userInput))
                {
                    MessageBox.Show("Please enter a value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Ensure only one checkbox is selected
                var checkBoxes = new List<CheckBox> { checkBox1, checkBox2, checkBox3, checkBox4, checkBox5, checkBox6 };
                int selectedCount = checkBoxes.Count(cb => cb.Checked);

                if (selectedCount > 1)
                {
                    MessageBox.Show("You can only select one operation at a time!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (selectedCount == 0)
                {
                    MessageBox.Show("Please select an operation!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Perform the selected operation
                if (checkBox1.Checked) // Binary conversion
                {
                    int inputValue = Convert.ToInt32(userInput);
                    List<int> binary = new List<int>();

                    while (inputValue > 0)
                    {
                        int rest = inputValue % 2;
                        binary.Add(rest);
                        inputValue /= 2;
                    }
                    binary.Reverse();
                    output.Text = string.Join(" ", binary);
                }

                if (checkBox2.Checked) // Convert to decimal (from binary)
                {
                    if (!double.TryParse(userInput, out double inputValue))
                    {
                        MessageBox.Show("Please enter a valid decimal number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    int sum = 0;
                    int power = 0;
                    int baseValue = 2;

                    // Convert binary number to decimal
                    while (inputValue >= 1)
                    {
                        int mod = (int)inputValue % 10;
                        int multiplier = (int)Math.Pow(baseValue, power);
                        int temp = mod * multiplier;
                        sum += temp;
                        inputValue /= 10;
                        power++;
                    }
                    output.Text = sum.ToString();
                }

                if (checkBox3.Checked) // Octal conversion
                {
                    int inputValue = Convert.ToInt32(userInput);
                    List<int> octal = new List<int>();

                    while (inputValue > 0)
                    {
                        int rest = inputValue % 8;
                        octal.Add(rest);
                        inputValue /= 8;
                    }
                    octal.Reverse();
                    output.Text = string.Join(" ", octal);
                }

                if (checkBox4.Checked) // Decimal to octal conversion
                {
                    int inputValue = Convert.ToInt32(userInput);
                    int sum = 0;
                    int power = 0;
                    int baseValue = 8;

                    while (inputValue != 0)
                    {
                        int mod = inputValue % 10;
                        int multiplier = (int)Math.Pow(baseValue, power);
                        int temp = mod * multiplier;
                        sum += temp;
                        inputValue /= 10;
                        power++;
                    }
                    output.Text = sum.ToString();
                }

                if (checkBox5.Checked) // Decimal to hexadecimal conversion
                {
                    int inputValue = Convert.ToInt32(userInput);
                    List<int> hex = new List<int>();

                    while (inputValue > 0)
                    {
                        int rest = inputValue % 16;
                        hex.Add(rest);
                        inputValue /= 16;
                    }
                    hex.Reverse();
                    output.Text = string.Join(" ", hex);
                }

                if (checkBox6.Checked) // Hexadecimal to decimal conversion
                {
                    string hexNumber = userInput;
                    int sum = 0;
                    int length = hexNumber.Length;

                    for (int i = 0; i < length; i++)
                    {
                        char digit = hexNumber[length - 1 - i];
                        int value;

                        // Calculate value for letters and numbers
                        if (digit >= '0' && digit <= '9')
                        {
                            value = digit - '0';
                        }
                        else if (digit >= 'A' && digit <= 'F')
                        {
                            value = digit - 'A' + 10;
                        }
                        else if (digit >= 'a' && digit <= 'f')
                        {
                            value = digit - 'a' + 10;
                        }
                        else
                        {
                            MessageBox.Show("Invalid input", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        sum += value * (int)Math.Pow(16, i);
                    }
                    output.Text = sum.ToString();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("The number you entered is too large!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
