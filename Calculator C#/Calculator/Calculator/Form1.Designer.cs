namespace Calculator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            input = new TextBox();
            num7 = new Button();
            num8 = new Button();
            num9 = new Button();
            num4 = new Button();
            num5 = new Button();
            num6 = new Button();
            num1 = new Button();
            num2 = new Button();
            num3 = new Button();
            num0 = new Button();
            decimalbutton = new Button();
            dividebutton = new Button();
            subtractbutton = new Button();
            addbutton = new Button();
            equalsbutton = new Button();
            multiplybutton = new Button();
            backspace = new Button();
            ACbutton = new Button();
            SuspendLayout();
            // 
            // input
            // 
            input.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            input.Location = new Point(30, 20);
            input.Margin = new Padding(4, 5, 4, 5);
            input.Multiline = true;
            input.Name = "input";
            input.Size = new Size(528, 212);
            input.TabIndex = 0;
            input.Text = "0";
            input.TextAlign = HorizontalAlignment.Right;
            input.TextChanged += input_TextChanged;
            // 
            // num7
            // 
            num7.FlatStyle = FlatStyle.Popup;
            num7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            num7.Location = new Point(30, 342);
            num7.Margin = new Padding(4, 5, 4, 5);
            num7.Name = "num7";
            num7.Size = new Size(111, 110);
            num7.TabIndex = 2;
            num7.Text = "7";
            num7.UseVisualStyleBackColor = true;
            num7.Click += num7_Click;
            // 
            // num8
            // 
            num8.BackColor = SystemColors.Control;
            num8.FlatStyle = FlatStyle.Popup;
            num8.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            num8.Location = new Point(150, 342);
            num8.Margin = new Padding(4, 5, 4, 5);
            num8.Name = "num8";
            num8.Size = new Size(111, 110);
            num8.TabIndex = 3;
            num8.Text = "8";
            num8.UseVisualStyleBackColor = false;
            num8.Click += num8_Click;
            // 
            // num9
            // 
            num9.FlatStyle = FlatStyle.Popup;
            num9.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            num9.Location = new Point(270, 342);
            num9.Margin = new Padding(4, 5, 4, 5);
            num9.Name = "num9";
            num9.Size = new Size(111, 110);
            num9.TabIndex = 4;
            num9.Text = "9";
            num9.UseVisualStyleBackColor = true;
            num9.Click += num9_Click;
            // 
            // num4
            // 
            num4.FlatStyle = FlatStyle.Popup;
            num4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            num4.Location = new Point(30, 462);
            num4.Margin = new Padding(4, 5, 4, 5);
            num4.Name = "num4";
            num4.Size = new Size(111, 110);
            num4.TabIndex = 5;
            num4.Text = "4";
            num4.UseVisualStyleBackColor = true;
            num4.Click += num4_Click;
            // 
            // num5
            // 
            num5.FlatStyle = FlatStyle.Popup;
            num5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            num5.Location = new Point(150, 462);
            num5.Margin = new Padding(4, 5, 4, 5);
            num5.Name = "num5";
            num5.Size = new Size(111, 110);
            num5.TabIndex = 6;
            num5.Text = "5";
            num5.UseVisualStyleBackColor = true;
            num5.Click += num5_Click;
            // 
            // num6
            // 
            num6.FlatStyle = FlatStyle.Popup;
            num6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            num6.Location = new Point(270, 462);
            num6.Margin = new Padding(4, 5, 4, 5);
            num6.Name = "num6";
            num6.Size = new Size(111, 110);
            num6.TabIndex = 7;
            num6.Text = "6";
            num6.UseVisualStyleBackColor = true;
            num6.Click += num6_Click;
            // 
            // num1
            // 
            num1.FlatStyle = FlatStyle.Popup;
            num1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            num1.Location = new Point(30, 582);
            num1.Margin = new Padding(4, 5, 4, 5);
            num1.Name = "num1";
            num1.Size = new Size(111, 110);
            num1.TabIndex = 8;
            num1.Text = "1";
            num1.UseVisualStyleBackColor = true;
            num1.Click += num1_Click;
            // 
            // num2
            // 
            num2.FlatStyle = FlatStyle.Popup;
            num2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            num2.Location = new Point(150, 582);
            num2.Margin = new Padding(4, 5, 4, 5);
            num2.Name = "num2";
            num2.Size = new Size(111, 110);
            num2.TabIndex = 9;
            num2.Text = "2";
            num2.UseVisualStyleBackColor = true;
            num2.Click += num2_Click;
            // 
            // num3
            // 
            num3.FlatStyle = FlatStyle.Popup;
            num3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            num3.Location = new Point(270, 582);
            num3.Margin = new Padding(4, 5, 4, 5);
            num3.Name = "num3";
            num3.Size = new Size(111, 110);
            num3.TabIndex = 10;
            num3.Text = "3";
            num3.UseVisualStyleBackColor = true;
            num3.Click += num3_Click;
            // 
            // num0
            // 
            num0.FlatStyle = FlatStyle.Popup;
            num0.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            num0.Location = new Point(30, 702);
            num0.Margin = new Padding(4, 5, 4, 5);
            num0.Name = "num0";
            num0.Size = new Size(231, 110);
            num0.TabIndex = 11;
            num0.Text = "0";
            num0.UseVisualStyleBackColor = true;
            num0.Click += num0_Click;
            // 
            // decimalbutton
            // 
            decimalbutton.FlatStyle = FlatStyle.Popup;
            decimalbutton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            decimalbutton.Location = new Point(270, 702);
            decimalbutton.Margin = new Padding(4, 5, 4, 5);
            decimalbutton.Name = "decimalbutton";
            decimalbutton.Size = new Size(111, 110);
            decimalbutton.TabIndex = 12;
            decimalbutton.Text = ".";
            decimalbutton.UseVisualStyleBackColor = true;
            decimalbutton.Click += decimalbutton_Click;
            // 
            // dividebutton
            // 
            dividebutton.FlatStyle = FlatStyle.Popup;
            dividebutton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            dividebutton.Location = new Point(447, 462);
            dividebutton.Margin = new Padding(4, 5, 4, 5);
            dividebutton.Name = "dividebutton";
            dividebutton.Size = new Size(111, 110);
            dividebutton.TabIndex = 13;
            dividebutton.Text = "\\";
            dividebutton.UseVisualStyleBackColor = true;
            dividebutton.Click += dividebutton_Click;
            // 
            // subtractbutton
            // 
            subtractbutton.FlatStyle = FlatStyle.Popup;
            subtractbutton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            subtractbutton.Location = new Point(447, 582);
            subtractbutton.Margin = new Padding(4, 5, 4, 5);
            subtractbutton.Name = "subtractbutton";
            subtractbutton.Size = new Size(111, 110);
            subtractbutton.TabIndex = 14;
            subtractbutton.Text = "-";
            subtractbutton.UseVisualStyleBackColor = true;
            subtractbutton.Click += subtractbutton_Click;
            // 
            // addbutton
            // 
            addbutton.FlatStyle = FlatStyle.Popup;
            addbutton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            addbutton.Location = new Point(447, 702);
            addbutton.Margin = new Padding(4, 5, 4, 5);
            addbutton.Name = "addbutton";
            addbutton.Size = new Size(111, 110);
            addbutton.TabIndex = 15;
            addbutton.Text = "+";
            addbutton.UseVisualStyleBackColor = true;
            addbutton.Click += addbutton_Click;
            // 
            // equalsbutton
            // 
            equalsbutton.FlatStyle = FlatStyle.Popup;
            equalsbutton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            equalsbutton.Location = new Point(30, 832);
            equalsbutton.Margin = new Padding(4, 5, 4, 5);
            equalsbutton.Name = "equalsbutton";
            equalsbutton.Size = new Size(529, 77);
            equalsbutton.TabIndex = 16;
            equalsbutton.Text = "=";
            equalsbutton.UseVisualStyleBackColor = true;
            equalsbutton.Click += equalsbutton_Click;
            // 
            // multiplybutton
            // 
            multiplybutton.FlatStyle = FlatStyle.Popup;
            multiplybutton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            multiplybutton.Location = new Point(447, 342);
            multiplybutton.Margin = new Padding(4, 5, 4, 5);
            multiplybutton.Name = "multiplybutton";
            multiplybutton.Size = new Size(111, 110);
            multiplybutton.TabIndex = 17;
            multiplybutton.Text = "*";
            multiplybutton.UseVisualStyleBackColor = true;
            multiplybutton.Click += multiplybutton_Click;
            // 
            // backspace
            // 
            backspace.FlatStyle = FlatStyle.Popup;
            backspace.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            backspace.Location = new Point(270, 255);
            backspace.Margin = new Padding(4, 5, 4, 5);
            backspace.Name = "backspace";
            backspace.Size = new Size(289, 77);
            backspace.TabIndex = 18;
            backspace.Text = "←";
            backspace.UseVisualStyleBackColor = true;
            backspace.Click += backspace_Click;
            // 
            // ACbutton
            // 
            ACbutton.FlatStyle = FlatStyle.Popup;
            ACbutton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            ACbutton.Location = new Point(30, 255);
            ACbutton.Margin = new Padding(4, 5, 4, 5);
            ACbutton.Name = "ACbutton";
            ACbutton.Size = new Size(231, 77);
            ACbutton.TabIndex = 19;
            ACbutton.Text = "AC";
            ACbutton.UseVisualStyleBackColor = true;
            ACbutton.Click += ACbutton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(596, 943);
            Controls.Add(ACbutton);
            Controls.Add(backspace);
            Controls.Add(multiplybutton);
            Controls.Add(equalsbutton);
            Controls.Add(addbutton);
            Controls.Add(subtractbutton);
            Controls.Add(dividebutton);
            Controls.Add(decimalbutton);
            Controls.Add(num0);
            Controls.Add(num3);
            Controls.Add(num2);
            Controls.Add(num1);
            Controls.Add(num6);
            Controls.Add(num5);
            Controls.Add(num4);
            Controls.Add(num9);
            Controls.Add(num8);
            Controls.Add(num7);
            Controls.Add(input);
            ForeColor = SystemColors.Desktop;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox input;
        private Button num7;
        private Button num8;
        private Button num9;
        private Button num4;
        private Button num5;
        private Button num6;
        private Button num1;
        private Button num2;
        private Button num3;
        private Button num0;
        private Button decimalbutton;
        private Button dividebutton;
        private Button subtractbutton;
        private Button addbutton;
        private Button equalsbutton;
        private Button multiplybutton;
        private Button backspace;
        private Button ACbutton;
    }
}