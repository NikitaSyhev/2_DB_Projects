namespace _2_DB_Projects
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cb_BD = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openBTN = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cb_BD
            // 
            this.cb_BD.FormattingEnabled = true;
            this.cb_BD.Items.AddRange(new object[] {
            "SQLite",
            "MSSql"});
            this.cb_BD.Location = new System.Drawing.Point(91, 111);
            this.cb_BD.Name = "cb_BD";
            this.cb_BD.Size = new System.Drawing.Size(121, 21);
            this.cb_BD.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Выбать тип БД";
            // 
            // openBTN
            // 
            this.openBTN.Location = new System.Drawing.Point(419, 111);
            this.openBTN.Name = "openBTN";
            this.openBTN.Size = new System.Drawing.Size(75, 23);
            this.openBTN.TabIndex = 5;
            this.openBTN.Text = "Открыть";
            this.openBTN.UseVisualStyleBackColor = true;
            this.openBTN.Click += new System.EventHandler(this.openBTN_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 239);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 124);
            this.textBox1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Выбать тип БД";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.openBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_BD);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ComboBox cb_BD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button openBTN;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}

