namespace WindowsFormsApp5
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.carbstextbox = new System.Windows.Forms.TextBox();
            this.fattextbox = new System.Windows.Forms.TextBox();
            this.fatbutton = new System.Windows.Forms.Button();
            this.carbsbutton = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calories";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "No.of fat grams";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "No.of carb grams";
            // 
            // carbstextbox
            // 
            this.carbstextbox.Location = new System.Drawing.Point(188, 170);
            this.carbstextbox.Name = "carbstextbox";
            this.carbstextbox.Size = new System.Drawing.Size(100, 20);
            this.carbstextbox.TabIndex = 3;
            this.carbstextbox.TextChanged += new System.EventHandler(this.carbstextbox_TextChanged);
            // 
            // fattextbox
            // 
            this.fattextbox.Location = new System.Drawing.Point(188, 120);
            this.fattextbox.Name = "fattextbox";
            this.fattextbox.Size = new System.Drawing.Size(100, 20);
            this.fattextbox.TabIndex = 4;
            this.fattextbox.TextChanged += new System.EventHandler(this.fattextbox_TextChanged);
            // 
            // fatbutton
            // 
            this.fatbutton.Location = new System.Drawing.Point(35, 278);
            this.fatbutton.Name = "fatbutton";
            this.fatbutton.Size = new System.Drawing.Size(75, 23);
            this.fatbutton.TabIndex = 5;
            this.fatbutton.Text = "fat calories";
            this.fatbutton.UseVisualStyleBackColor = true;
            this.fatbutton.Click += new System.EventHandler(this.fatbutton_Click);
            // 
            // carbsbutton
            // 
            this.carbsbutton.Location = new System.Drawing.Point(151, 278);
            this.carbsbutton.Name = "carbsbutton";
            this.carbsbutton.Size = new System.Drawing.Size(75, 23);
            this.carbsbutton.TabIndex = 6;
            this.carbsbutton.Text = "carb calories";
            this.carbsbutton.UseVisualStyleBackColor = true;
            this.carbsbutton.Click += new System.EventHandler(this.carbsbutton_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.Location = new System.Drawing.Point(259, 278);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(75, 23);
            this.exitbutton.TabIndex = 7;
            this.exitbutton.Text = "exit";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 444);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.carbsbutton);
            this.Controls.Add(this.fatbutton);
            this.Controls.Add(this.fattextbox);
            this.Controls.Add(this.carbstextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox carbstextbox;
        private System.Windows.Forms.TextBox fattextbox;
        private System.Windows.Forms.Button fatbutton;
        private System.Windows.Forms.Button carbsbutton;
        private System.Windows.Forms.Button exitbutton;
    }
}

