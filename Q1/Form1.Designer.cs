
namespace Q1
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ShowlistBox = new System.Windows.Forms.ListBox();
            this.Addbutton = new System.Windows.Forms.Button();
            this.LNtextBox = new System.Windows.Forms.TextBox();
            this.FNtextBox = new System.Windows.Forms.TextBox();
            this.IDtextBox = new System.Windows.Forms.TextBox();
            this.LNlabel = new System.Windows.Forms.Label();
            this.FNlabel = new System.Windows.Forms.Label();
            this.IDlabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Searchbutton = new System.Windows.Forms.Button();
            this.ResulttextBox = new System.Windows.Forms.TextBox();
            this.Resultlabel = new System.Windows.Forms.Label();
            this.SKtextBox = new System.Windows.Forms.TextBox();
            this.SKlabel = new System.Windows.Forms.Label();
            this.StudentradioButton = new System.Windows.Forms.RadioButton();
            this.IntegerradioButton = new System.Windows.Forms.RadioButton();
            this.IAtextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(43, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Int Array";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ShowlistBox);
            this.groupBox1.Controls.Add(this.Addbutton);
            this.groupBox1.Controls.Add(this.LNtextBox);
            this.groupBox1.Controls.Add(this.FNtextBox);
            this.groupBox1.Controls.Add(this.IDtextBox);
            this.groupBox1.Controls.Add(this.LNlabel);
            this.groupBox1.Controls.Add(this.FNlabel);
            this.groupBox1.Controls.Add(this.IDlabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(43, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 287);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Student Info";
            // 
            // ShowlistBox
            // 
            this.ShowlistBox.ItemHeight = 20;
            this.ShowlistBox.Location = new System.Drawing.Point(6, 187);
            this.ShowlistBox.Name = "ShowlistBox";
            this.ShowlistBox.Size = new System.Drawing.Size(389, 84);
            this.ShowlistBox.TabIndex = 0;
            // 
            // Addbutton
            // 
            this.Addbutton.Location = new System.Drawing.Point(300, 83);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(95, 63);
            this.Addbutton.TabIndex = 9;
            this.Addbutton.Text = "add to";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // LNtextBox
            // 
            this.LNtextBox.Location = new System.Drawing.Point(130, 148);
            this.LNtextBox.Name = "LNtextBox";
            this.LNtextBox.Size = new System.Drawing.Size(136, 27);
            this.LNtextBox.TabIndex = 8;
            // 
            // FNtextBox
            // 
            this.FNtextBox.Location = new System.Drawing.Point(130, 92);
            this.FNtextBox.Name = "FNtextBox";
            this.FNtextBox.Size = new System.Drawing.Size(136, 27);
            this.FNtextBox.TabIndex = 7;
            // 
            // IDtextBox
            // 
            this.IDtextBox.Location = new System.Drawing.Point(130, 41);
            this.IDtextBox.Name = "IDtextBox";
            this.IDtextBox.Size = new System.Drawing.Size(136, 27);
            this.IDtextBox.TabIndex = 6;
            // 
            // LNlabel
            // 
            this.LNlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LNlabel.Location = new System.Drawing.Point(6, 151);
            this.LNlabel.Name = "LNlabel";
            this.LNlabel.Size = new System.Drawing.Size(102, 29);
            this.LNlabel.TabIndex = 5;
            this.LNlabel.Text = "Last Name";
            // 
            // FNlabel
            // 
            this.FNlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FNlabel.Location = new System.Drawing.Point(6, 92);
            this.FNlabel.Name = "FNlabel";
            this.FNlabel.Size = new System.Drawing.Size(102, 29);
            this.FNlabel.TabIndex = 4;
            this.FNlabel.Text = "First Name";
            // 
            // IDlabel
            // 
            this.IDlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IDlabel.Location = new System.Drawing.Point(6, 41);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(89, 29);
            this.IDlabel.TabIndex = 3;
            this.IDlabel.Text = "ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Searchbutton);
            this.groupBox2.Controls.Add(this.ResulttextBox);
            this.groupBox2.Controls.Add(this.Resultlabel);
            this.groupBox2.Controls.Add(this.SKtextBox);
            this.groupBox2.Controls.Add(this.SKlabel);
            this.groupBox2.Controls.Add(this.StudentradioButton);
            this.groupBox2.Controls.Add(this.IntegerradioButton);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(43, 385);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(416, 249);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // Searchbutton
            // 
            this.Searchbutton.Location = new System.Drawing.Point(300, 174);
            this.Searchbutton.Name = "Searchbutton";
            this.Searchbutton.Size = new System.Drawing.Size(95, 45);
            this.Searchbutton.TabIndex = 10;
            this.Searchbutton.Text = "Search";
            this.Searchbutton.UseVisualStyleBackColor = true;
            this.Searchbutton.Click += new System.EventHandler(this.Searchbutton_Click);
            // 
            // ResulttextBox
            // 
            this.ResulttextBox.Location = new System.Drawing.Point(130, 204);
            this.ResulttextBox.Name = "ResulttextBox";
            this.ResulttextBox.Size = new System.Drawing.Size(136, 27);
            this.ResulttextBox.TabIndex = 9;
            // 
            // Resultlabel
            // 
            this.Resultlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Resultlabel.Location = new System.Drawing.Point(19, 204);
            this.Resultlabel.Name = "Resultlabel";
            this.Resultlabel.Size = new System.Drawing.Size(89, 29);
            this.Resultlabel.TabIndex = 8;
            this.Resultlabel.Text = "Result";
            // 
            // SKtextBox
            // 
            this.SKtextBox.Location = new System.Drawing.Point(130, 160);
            this.SKtextBox.Name = "SKtextBox";
            this.SKtextBox.Size = new System.Drawing.Size(136, 27);
            this.SKtextBox.TabIndex = 7;
            // 
            // SKlabel
            // 
            this.SKlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SKlabel.Location = new System.Drawing.Point(19, 160);
            this.SKlabel.Name = "SKlabel";
            this.SKlabel.Size = new System.Drawing.Size(105, 29);
            this.SKlabel.TabIndex = 4;
            this.SKlabel.Text = "Search Key";
            // 
            // StudentradioButton
            // 
            this.StudentradioButton.AutoSize = true;
            this.StudentradioButton.Location = new System.Drawing.Point(21, 105);
            this.StudentradioButton.Name = "StudentradioButton";
            this.StudentradioButton.Size = new System.Drawing.Size(281, 26);
            this.StudentradioButton.TabIndex = 1;
            this.StudentradioButton.TabStop = true;
            this.StudentradioButton.Text = "Search Student in StudentArray";
            this.StudentradioButton.UseVisualStyleBackColor = true;
            // 
            // IntegerradioButton
            // 
            this.IntegerradioButton.AutoSize = true;
            this.IntegerradioButton.Location = new System.Drawing.Point(21, 49);
            this.IntegerradioButton.Name = "IntegerradioButton";
            this.IntegerradioButton.Size = new System.Drawing.Size(231, 26);
            this.IntegerradioButton.TabIndex = 0;
            this.IntegerradioButton.TabStop = true;
            this.IntegerradioButton.Text = "Search Integer in IntArray";
            this.IntegerradioButton.UseVisualStyleBackColor = true;
            // 
            // IAtextBox
            // 
            this.IAtextBox.Location = new System.Drawing.Point(148, 29);
            this.IAtextBox.Name = "IAtextBox";
            this.IAtextBox.Size = new System.Drawing.Size(311, 23);
            this.IAtextBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 681);
            this.Controls.Add(this.IAtextBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generic Method";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LNlabel;
        private System.Windows.Forms.Label FNlabel;
        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.TextBox LNtextBox;
        private System.Windows.Forms.TextBox FNtextBox;
        private System.Windows.Forms.TextBox IDtextBox;
        private System.Windows.Forms.TextBox IAtextBox;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.ListBox ShowlistBox;
        private System.Windows.Forms.Button Searchbutton;
        private System.Windows.Forms.TextBox ResulttextBox;
        private System.Windows.Forms.Label Resultlabel;
        private System.Windows.Forms.TextBox SKtextBox;
        private System.Windows.Forms.Label SKlabel;
        private System.Windows.Forms.RadioButton StudentradioButton;
        private System.Windows.Forms.RadioButton IntegerradioButton;
    }
}

