namespace Mandip.Karki_Assignment2
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.newForm = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.buttonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movieRatingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bestGenreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moreInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movieRatingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bestGenreToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.moreInfoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name : Mandip Karki\r\nClass : Web Services\r\nStudent Number : 991365874";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(16, 128);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(408, 124);
            this.listBox1.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(432, 128);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(512, 128);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(784, 96);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(144, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "Titles";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "Movie Rating";
            this.toolTip1.SetToolTip(this.button1, "Gives movie rating in Descending order.");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // newForm
            // 
            this.newForm.Location = new System.Drawing.Point(784, 264);
            this.newForm.Name = "newForm";
            this.newForm.Size = new System.Drawing.Size(115, 31);
            this.newForm.TabIndex = 5;
            this.newForm.Text = "More Info.";
            this.newForm.UseVisualStyleBackColor = true;
            this.newForm.Click += new System.EventHandler(this.newForm_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(208, 272);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 32);
            this.button2.TabIndex = 6;
            this.button2.Text = "Best Genre";
            this.toolTip1.SetToolTip(this.button2, "Best Pop genre avaiable");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(972, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.movieRatingToolStripMenuItem1,
            this.bestGenreToolStripMenuItem1,
            this.moreInfoToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(145, 70);
            // 
            // buttonsToolStripMenuItem
            // 
            this.buttonsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.movieRatingToolStripMenuItem,
            this.bestGenreToolStripMenuItem,
            this.moreInfoToolStripMenuItem});
            this.buttonsToolStripMenuItem.Name = "buttonsToolStripMenuItem";
            this.buttonsToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.buttonsToolStripMenuItem.Text = "Buttons";
            // 
            // movieRatingToolStripMenuItem
            // 
            this.movieRatingToolStripMenuItem.Name = "movieRatingToolStripMenuItem";
            this.movieRatingToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.movieRatingToolStripMenuItem.Text = "Movie Rating";
            this.movieRatingToolStripMenuItem.Click += new System.EventHandler(this.movieRatingToolStripMenuItem_Click);
            // 
            // bestGenreToolStripMenuItem
            // 
            this.bestGenreToolStripMenuItem.Name = "bestGenreToolStripMenuItem";
            this.bestGenreToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bestGenreToolStripMenuItem.Text = "Best Genre";
            this.bestGenreToolStripMenuItem.Click += new System.EventHandler(this.bestGenreToolStripMenuItem_Click);
            // 
            // moreInfoToolStripMenuItem
            // 
            this.moreInfoToolStripMenuItem.Name = "moreInfoToolStripMenuItem";
            this.moreInfoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.moreInfoToolStripMenuItem.Text = "More Info.";
            this.moreInfoToolStripMenuItem.Click += new System.EventHandler(this.moreInfoToolStripMenuItem_Click);
            // 
            // movieRatingToolStripMenuItem1
            // 
            this.movieRatingToolStripMenuItem1.Name = "movieRatingToolStripMenuItem1";
            this.movieRatingToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.movieRatingToolStripMenuItem1.Text = "Movie Rating";
            this.movieRatingToolStripMenuItem1.Click += new System.EventHandler(this.movieRatingToolStripMenuItem1_Click);
            // 
            // bestGenreToolStripMenuItem1
            // 
            this.bestGenreToolStripMenuItem1.Name = "bestGenreToolStripMenuItem1";
            this.bestGenreToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.bestGenreToolStripMenuItem1.Text = "Best Genre";
            this.bestGenreToolStripMenuItem1.Click += new System.EventHandler(this.bestGenreToolStripMenuItem1_Click);
            // 
            // moreInfoToolStripMenuItem1
            // 
            this.moreInfoToolStripMenuItem1.Name = "moreInfoToolStripMenuItem1";
            this.moreInfoToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.moreInfoToolStripMenuItem1.Text = "More Info.";
            this.moreInfoToolStripMenuItem1.Click += new System.EventHandler(this.moreInfoToolStripMenuItem1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(576, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Choose Movie For Info. :";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(16, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 80);
            this.label3.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 313);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.newForm);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label3);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Mandip.karki_991365874";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button newForm;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem buttonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movieRatingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bestGenreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moreInfoToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem movieRatingToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bestGenreToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem moreInfoToolStripMenuItem1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

