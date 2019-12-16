namespace forLoopsGUI
{
    partial class Fpizza
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pizza = new System.Windows.Forms.Label();
            this.txtNumPizza = new System.Windows.Forms.TextBox();
            this.btnPizza = new System.Windows.Forms.Button();
            this.amountOfPizza = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pizza
            // 
            this.pizza.AutoSize = true;
            this.pizza.Location = new System.Drawing.Point(98, 57);
            this.pizza.Name = "pizza";
            this.pizza.Size = new System.Drawing.Size(135, 13);
            this.pizza.TabIndex = 0;
            this.pizza.Text = "How many pizzas you want";
            // 
            // txtNumPizza
            // 
            this.txtNumPizza.Location = new System.Drawing.Point(446, 44);
            this.txtNumPizza.Name = "txtNumPizza";
            this.txtNumPizza.Size = new System.Drawing.Size(100, 20);
            this.txtNumPizza.TabIndex = 1;
            // 
            // btnPizza
            // 
            this.btnPizza.Location = new System.Drawing.Point(250, 113);
            this.btnPizza.Name = "btnPizza";
            this.btnPizza.Size = new System.Drawing.Size(121, 41);
            this.btnPizza.TabIndex = 2;
            this.btnPizza.Text = "Click for pizza";
            this.btnPizza.UseVisualStyleBackColor = true;
            this.btnPizza.Click += new System.EventHandler(this.button1_Click);
            // 
            // amountOfPizza
            // 
            this.amountOfPizza.Location = new System.Drawing.Point(167, 157);
            this.amountOfPizza.Name = "amountOfPizza";
            this.amountOfPizza.Size = new System.Drawing.Size(286, 177);
            this.amountOfPizza.TabIndex = 3;
            this.amountOfPizza.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Fpizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.amountOfPizza);
            this.Controls.Add(this.btnPizza);
            this.Controls.Add(this.txtNumPizza);
            this.Controls.Add(this.pizza);
            this.Name = "Fpizza";
            this.Text = "Pizza machin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pizza;
        private System.Windows.Forms.TextBox txtNumPizza;
        private System.Windows.Forms.Button btnPizza;
        private System.Windows.Forms.Label amountOfPizza;
    }
}

