namespace Függőhidakwinform
{
    partial class Keresés
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
            this.orszagkeresocomboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.keresobutton = new System.Windows.Forms.Button();
            this.bezarobutton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // orszagkeresocomboBox
            // 
            this.orszagkeresocomboBox.FormattingEnabled = true;
            this.orszagkeresocomboBox.Location = new System.Drawing.Point(79, 42);
            this.orszagkeresocomboBox.Name = "orszagkeresocomboBox";
            this.orszagkeresocomboBox.Size = new System.Drawing.Size(121, 21);
            this.orszagkeresocomboBox.TabIndex = 0;
            this.orszagkeresocomboBox.SelectedIndexChanged += new System.EventHandler(this.orszagkeresocomboBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bezarobutton);
            this.groupBox1.Controls.Add(this.keresobutton);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.orszagkeresocomboBox);
            this.groupBox1.Location = new System.Drawing.Point(78, 237);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 201);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Keresés";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ország";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 80);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(114, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "1  km -nél hosszab";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // keresobutton
            // 
            this.keresobutton.Location = new System.Drawing.Point(45, 129);
            this.keresobutton.Name = "keresobutton";
            this.keresobutton.Size = new System.Drawing.Size(75, 23);
            this.keresobutton.TabIndex = 3;
            this.keresobutton.Text = "Keresés";
            this.keresobutton.UseVisualStyleBackColor = true;
            this.keresobutton.Click += new System.EventHandler(this.keresobutton_Click);
            // 
            // bezarobutton
            // 
            this.bezarobutton.Location = new System.Drawing.Point(236, 129);
            this.bezarobutton.Name = "bezarobutton";
            this.bezarobutton.Size = new System.Drawing.Size(75, 23);
            this.bezarobutton.TabIndex = 4;
            this.bezarobutton.Text = "Bezárás";
            this.bezarobutton.UseVisualStyleBackColor = true;
            this.bezarobutton.Click += new System.EventHandler(this.bezarobutton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(78, 22);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(407, 186);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Keresés
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Keresés";
            this.Text = "Keresés";
            this.Load += new System.EventHandler(this.Keresés_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox orszagkeresocomboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bezarobutton;
        private System.Windows.Forms.Button keresobutton;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ListBox listBox1;
    }
}