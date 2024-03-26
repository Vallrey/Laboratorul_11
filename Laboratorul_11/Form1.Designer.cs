namespace Laboratorul_11
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
            vara = new Button();
            toamna = new Button();
            iarna = new Button();
            primavara = new Button();
            SuspendLayout();
            // 
            // vara
            // 
            vara.Location = new Point(722, 60);
            vara.Margin = new Padding(4);
            vara.Name = "vara";
            vara.Size = new Size(118, 30);
            vara.TabIndex = 0;
            vara.Text = "Vara";
            vara.UseVisualStyleBackColor = true;
            vara.Click += vara_Click;
            // 
            // toamna
            // 
            toamna.Location = new Point(722, 358);
            toamna.Margin = new Padding(4);
            toamna.Name = "toamna";
            toamna.Size = new Size(118, 30);
            toamna.TabIndex = 0;
            toamna.Text = "Toamana";
            toamna.UseVisualStyleBackColor = true;
            toamna.Click += toamna_Click;
            // 
            // iarna
            // 
            iarna.Location = new Point(149, 358);
            iarna.Margin = new Padding(4);
            iarna.Name = "iarna";
            iarna.Size = new Size(118, 30);
            iarna.TabIndex = 0;
            iarna.Text = "Iarna";
            iarna.UseVisualStyleBackColor = true;
            iarna.Click += iarna_Click;
            // 
            // primavara
            // 
            primavara.Location = new Point(149, 60);
            primavara.Margin = new Padding(4);
            primavara.Name = "primavara";
            primavara.Size = new Size(118, 30);
            primavara.TabIndex = 0;
            primavara.Text = "Primavara";
            primavara.UseVisualStyleBackColor = true;
            primavara.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(primavara);
            Controls.Add(iarna);
            Controls.Add(toamna);
            Controls.Add(vara);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button vara;
        private Button toamna;
        private Button iarna;
        private Button primavara;
    }
}
