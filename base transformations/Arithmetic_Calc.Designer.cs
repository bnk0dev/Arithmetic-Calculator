namespace base_transformations
{
    partial class Arithmetic_Calc
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            input = new TextBox();
            binaryButton = new Button();
            output = new TextBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // input
            // 
            input.BorderStyle = BorderStyle.FixedSingle;
            input.Font = new Font("Microsoft Sans Serif", 14F);
            input.Location = new Point(67, 215);
            input.Name = "input";
            input.Size = new Size(214, 29);
            input.TabIndex = 1;
            input.TextAlign = HorizontalAlignment.Center;
            // 
            // binaryButton
            // 
            binaryButton.FlatStyle = FlatStyle.System;
            binaryButton.Font = new Font("Microsoft Sans Serif", 10F);
            binaryButton.Location = new Point(102, 259);
            binaryButton.Name = "binaryButton";
            binaryButton.Size = new Size(116, 30);
            binaryButton.TabIndex = 2;
            binaryButton.Text = "Sent";
            binaryButton.UseVisualStyleBackColor = true;
            binaryButton.Click += binaryButton_Click;
            // 
            // output
            // 
            output.Font = new Font("Microsoft Sans Serif", 14F);
            output.Location = new Point(67, 330);
            output.Name = "output";
            output.Size = new Size(214, 29);
            output.TabIndex = 3;
            output.TextAlign = HorizontalAlignment.Center;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Microsoft Sans Serif", 10F);
            checkBox1.Location = new Point(25, 37);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(72, 21);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "10 -> 2";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Microsoft Sans Serif", 10F);
            checkBox2.Location = new Point(25, 91);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(72, 21);
            checkBox2.TabIndex = 6;
            checkBox2.Text = "2 -> 10";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Microsoft Sans Serif", 10F);
            checkBox3.Location = new Point(134, 37);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(72, 21);
            checkBox3.TabIndex = 7;
            checkBox3.Text = "10 -> 8";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Font = new Font("Microsoft Sans Serif", 10F);
            checkBox4.Location = new Point(134, 91);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(72, 21);
            checkBox4.TabIndex = 8;
            checkBox4.Text = "8 -> 10";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Font = new Font("Microsoft Sans Serif", 10F);
            checkBox5.Location = new Point(236, 37);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(80, 21);
            checkBox5.TabIndex = 9;
            checkBox5.Text = "10 -> 16";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Font = new Font("Microsoft Sans Serif", 10F);
            checkBox6.Location = new Point(236, 91);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(80, 21);
            checkBox6.TabIndex = 10;
            checkBox6.Text = "16 -> 10";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(67, 194);
            label1.Name = "label1";
            label1.Size = new Size(119, 18);
            label1.TabIndex = 11;
            label1.Text = "Enter Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(67, 307);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 12;
            label2.Text = "Result";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox6);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(checkBox5);
            groupBox1.Controls.Add(checkBox4);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Arial Rounded MT Bold", 12F);
            groupBox1.Location = new Point(12, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(336, 149);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Select Action";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // Arithmetic_Calc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(366, 405);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(output);
            Controls.Add(binaryButton);
            Controls.Add(input);
            Name = "Arithmetic_Calc";
            Text = "Arithmetic calculator";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox input;
        private Button binaryButton;
        private TextBox output;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
    }
}
