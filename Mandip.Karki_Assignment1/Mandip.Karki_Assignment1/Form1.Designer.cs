namespace Mandip.Karki_Assignment1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.IngList = new System.Windows.Forms.ListBox();
            this.NumServed = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ChangeServeButton = new System.Windows.Forms.Button();
            this.SaveServeButton = new System.Windows.Forms.Button();
            this.RecipeInstr = new System.Windows.Forms.Label();
            this.OvenButton = new System.Windows.Forms.Button();
            this.MicroButton = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ovenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.microwaveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mandipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ovenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.microwaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MintCream;
            this.label1.Location = new System.Drawing.Point(56, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mandip Karki\r\n991365874";
            // 
            // IngList
            // 
            this.IngList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngList.FormattingEnabled = true;
            this.IngList.ItemHeight = 24;
            this.IngList.Location = new System.Drawing.Point(16, 152);
            this.IngList.Name = "IngList";
            this.IngList.Size = new System.Drawing.Size(280, 148);
            this.IngList.TabIndex = 4;
            // 
            // NumServed
            // 
            this.NumServed.Enabled = false;
            this.NumServed.Location = new System.Drawing.Point(320, 192);
            this.NumServed.Multiline = true;
            this.NumServed.Name = "NumServed";
            this.NumServed.Size = new System.Drawing.Size(144, 24);
            this.NumServed.TabIndex = 5;
            this.NumServed.Text = "4";
            this.NumServed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(328, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "People To Serve :";
            // 
            // ChangeServeButton
            // 
            this.ChangeServeButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.ChangeServeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeServeButton.ForeColor = System.Drawing.Color.Yellow;
            this.ChangeServeButton.Location = new System.Drawing.Point(320, 224);
            this.ChangeServeButton.Name = "ChangeServeButton";
            this.ChangeServeButton.Size = new System.Drawing.Size(136, 32);
            this.ChangeServeButton.TabIndex = 7;
            this.ChangeServeButton.Text = "Change Servings";
            this.toolTip1.SetToolTip(this.ChangeServeButton, "Change The number of people needed to serve.");
            this.ChangeServeButton.UseVisualStyleBackColor = false;
            this.ChangeServeButton.Click += new System.EventHandler(this.ChangeServeButton_Click);
            // 
            // SaveServeButton
            // 
            this.SaveServeButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.SaveServeButton.Enabled = false;
            this.SaveServeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveServeButton.ForeColor = System.Drawing.Color.Chartreuse;
            this.SaveServeButton.Location = new System.Drawing.Point(344, 272);
            this.SaveServeButton.Name = "SaveServeButton";
            this.SaveServeButton.Size = new System.Drawing.Size(88, 32);
            this.SaveServeButton.TabIndex = 8;
            this.SaveServeButton.Text = "Save Serve";
            this.toolTip1.SetToolTip(this.SaveServeButton, "Save number of people needed to Serve.");
            this.SaveServeButton.UseVisualStyleBackColor = false;
            this.SaveServeButton.Click += new System.EventHandler(this.SaveServeButton_Click);
            // 
            // RecipeInstr
            // 
            this.RecipeInstr.BackColor = System.Drawing.Color.Crimson;
            this.RecipeInstr.Font = new System.Drawing.Font("Felix Titling", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecipeInstr.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RecipeInstr.Location = new System.Drawing.Point(496, 32);
            this.RecipeInstr.Name = "RecipeInstr";
            this.RecipeInstr.Size = new System.Drawing.Size(296, 280);
            this.RecipeInstr.TabIndex = 9;
            // 
            // OvenButton
            // 
            this.OvenButton.Location = new System.Drawing.Point(504, 272);
            this.OvenButton.Name = "OvenButton";
            this.OvenButton.Size = new System.Drawing.Size(112, 23);
            this.OvenButton.TabIndex = 10;
            this.OvenButton.Text = "Oven Cooking";
            this.toolTip1.SetToolTip(this.OvenButton, "Instruction to Cook in Oven.");
            this.OvenButton.UseVisualStyleBackColor = true;
            this.OvenButton.Click += new System.EventHandler(this.OvenButton_Click);
            // 
            // MicroButton
            // 
            this.MicroButton.Location = new System.Drawing.Point(664, 272);
            this.MicroButton.Name = "MicroButton";
            this.MicroButton.Size = new System.Drawing.Size(120, 23);
            this.MicroButton.TabIndex = 11;
            this.MicroButton.Text = "Microwave Cooking";
            this.toolTip1.SetToolTip(this.MicroButton, "Instruction to Microwave into Tasty Food.\r\n");
            this.MicroButton.UseVisualStyleBackColor = true;
            this.MicroButton.Click += new System.EventHandler(this.MicroButton_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Mandip.Karki_Assignment1.Properties.Resources.bakeIt;
            this.pictureBox2.Location = new System.Drawing.Point(312, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(152, 152);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(480, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(424, 312);
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ovenToolStripMenuItem1,
            this.microwaveToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(133, 48);
            // 
            // ovenToolStripMenuItem1
            // 
            this.ovenToolStripMenuItem1.Name = "ovenToolStripMenuItem1";
            this.ovenToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            this.ovenToolStripMenuItem1.Text = "Oven";
            this.ovenToolStripMenuItem1.Click += new System.EventHandler(this.ovenToolStripMenuItem1_Click);
            // 
            // microwaveToolStripMenuItem1
            // 
            this.microwaveToolStripMenuItem1.Name = "microwaveToolStripMenuItem1";
            this.microwaveToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            this.microwaveToolStripMenuItem1.Text = "Microwave";
            this.microwaveToolStripMenuItem1.Click += new System.EventHandler(this.microwaveToolStripMenuItem1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBox4.Image = global::Mandip.Karki_Assignment1.Properties.Resources.spaceLines;
            this.pictureBox4.Location = new System.Drawing.Point(-16, -40);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(960, 384);
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InfoText;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mandipToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(815, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mandipToolStripMenuItem
            // 
            this.mandipToolStripMenuItem.BackColor = System.Drawing.Color.GreenYellow;
            this.mandipToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ovenToolStripMenuItem,
            this.microwaveToolStripMenuItem});
            this.mandipToolStripMenuItem.ForeColor = System.Drawing.Color.Chocolate;
            this.mandipToolStripMenuItem.Name = "mandipToolStripMenuItem";
            this.mandipToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.mandipToolStripMenuItem.Text = "Mandip";
            // 
            // ovenToolStripMenuItem
            // 
            this.ovenToolStripMenuItem.Name = "ovenToolStripMenuItem";
            this.ovenToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.ovenToolStripMenuItem.Text = "Oven";
            this.ovenToolStripMenuItem.Click += new System.EventHandler(this.ovenToolStripMenuItem_Click);
            // 
            // microwaveToolStripMenuItem
            // 
            this.microwaveToolStripMenuItem.Name = "microwaveToolStripMenuItem";
            this.microwaveToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.microwaveToolStripMenuItem.Text = "Microwave";
            this.microwaveToolStripMenuItem.Click += new System.EventHandler(this.microwaveToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.BackColor = System.Drawing.Color.Indigo;
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.Cornsilk;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.ClientSize = new System.Drawing.Size(815, 326);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.MicroButton);
            this.Controls.Add(this.OvenButton);
            this.Controls.Add(this.RecipeInstr);
            this.Controls.Add(this.SaveServeButton);
            this.Controls.Add(this.ChangeServeButton);
            this.Controls.Add(this.NumServed);
            this.Controls.Add(this.IngList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mandip.karki_991365874";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox IngList;
        private System.Windows.Forms.TextBox NumServed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ChangeServeButton;
        private System.Windows.Forms.Button SaveServeButton;
        private System.Windows.Forms.Label RecipeInstr;
        private System.Windows.Forms.Button OvenButton;
        private System.Windows.Forms.Button MicroButton;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mandipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ovenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem microwaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ovenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem microwaveToolStripMenuItem1;
    }
}

