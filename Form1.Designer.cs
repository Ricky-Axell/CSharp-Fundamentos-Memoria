namespace ParametrosValorRef
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
            lblVarA = new Label();
            lblVarB = new Label();
            txtVarA = new TextBox();
            txtVarB = new TextBox();
            btnValor = new Button();
            btnRef = new Button();
            lblResA = new Label();
            lblResB = new Label();
            txtResA = new TextBox();
            txtResB = new TextBox();
            SuspendLayout();
            // 
            // lblVarA
            // 
            lblVarA.AutoSize = true;
            lblVarA.Location = new Point(32, 52);
            lblVarA.Name = "lblVarA";
            lblVarA.Size = new Size(75, 20);
            lblVarA.TabIndex = 0;
            lblVarA.Text = "Variavel A";
            // 
            // lblVarB
            // 
            lblVarB.AutoSize = true;
            lblVarB.Location = new Point(32, 115);
            lblVarB.Name = "lblVarB";
            lblVarB.Size = new Size(74, 20);
            lblVarB.TabIndex = 1;
            lblVarB.Text = "Variavel B";
            // 
            // txtVarA
            // 
            txtVarA.Location = new Point(157, 45);
            txtVarA.Name = "txtVarA";
            txtVarA.Size = new Size(125, 27);
            txtVarA.TabIndex = 2;
            // 
            // txtVarB
            // 
            txtVarB.Location = new Point(157, 112);
            txtVarB.Name = "txtVarB";
            txtVarB.Size = new Size(125, 27);
            txtVarB.TabIndex = 3;
            // 
            // btnValor
            // 
            btnValor.Location = new Point(32, 201);
            btnValor.Name = "btnValor";
            btnValor.Size = new Size(106, 29);
            btnValor.TabIndex = 4;
            btnValor.Text = "Por Valor";
            btnValor.UseVisualStyleBackColor = true;
            btnValor.Click += btnValor_Click;
            // 
            // btnRef
            // 
            btnRef.Location = new Point(158, 201);
            btnRef.Name = "btnRef";
            btnRef.Size = new Size(124, 29);
            btnRef.TabIndex = 5;
            btnRef.Text = "Por Referencia";
            btnRef.UseVisualStyleBackColor = true;
            btnRef.Click += btnRef_Click;
            // 
            // lblResA
            // 
            lblResA.AutoSize = true;
            lblResA.Location = new Point(32, 276);
            lblResA.Name = "lblResA";
            lblResA.Size = new Size(75, 20);
            lblResA.TabIndex = 6;
            lblResA.Text = "Variavel A";
            // 
            // lblResB
            // 
            lblResB.AutoSize = true;
            lblResB.Location = new Point(32, 345);
            lblResB.Name = "lblResB";
            lblResB.Size = new Size(74, 20);
            lblResB.TabIndex = 7;
            lblResB.Text = "Variavel B";
            // 
            // txtResA
            // 
            txtResA.Location = new Point(157, 276);
            txtResA.Name = "txtResA";
            txtResA.Size = new Size(125, 27);
            txtResA.TabIndex = 8;
            // 
            // txtResB
            // 
            txtResB.Location = new Point(157, 345);
            txtResB.Name = "txtResB";
            txtResB.Size = new Size(125, 27);
            txtResB.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 450);
            Controls.Add(txtResB);
            Controls.Add(txtResA);
            Controls.Add(lblResB);
            Controls.Add(lblResA);
            Controls.Add(btnRef);
            Controls.Add(btnValor);
            Controls.Add(txtVarB);
            Controls.Add(txtVarA);
            Controls.Add(lblVarB);
            Controls.Add(lblVarA);
            Name = "Form1";
            Text = "Valor / Referencia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblVarA;
        private Label lblVarB;
        private TextBox txtVarA;
        private TextBox txtVarB;
        private Button btnValor;
        private Button btnRef;
        private Label lblResA;
        private Label lblResB;
        private TextBox txtResA;
        private TextBox txtResB;
    }
}
