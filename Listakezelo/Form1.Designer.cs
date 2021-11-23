namespace Listakezelo
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
            this.labelNewItem = new System.Windows.Forms.Label();
            this.textBoxNewItem = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonRemoveAll = new System.Windows.Forms.Button();
            this.buttonBgColor = new System.Windows.Forms.Button();
            this.buttonTxtColor = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.buttonSort = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelItemsCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNewItem
            // 
            this.labelNewItem.Location = new System.Drawing.Point(42, 35);
            this.labelNewItem.Name = "labelNewItem";
            this.labelNewItem.Size = new System.Drawing.Size(100, 23);
            this.labelNewItem.TabIndex = 0;
            this.labelNewItem.Text = "Uj elem";
            // 
            // textBoxNewItem
            // 
            this.textBoxNewItem.Location = new System.Drawing.Point(42, 61);
            this.textBoxNewItem.Name = "textBoxNewItem";
            this.textBoxNewItem.Size = new System.Drawing.Size(100, 20);
            this.textBoxNewItem.TabIndex = 1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(302, 64);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Hozzaad";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(302, 93);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 3;
            this.buttonRemove.Text = "Torol";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonRemoveAll
            // 
            this.buttonRemoveAll.Location = new System.Drawing.Point(302, 122);
            this.buttonRemoveAll.Name = "buttonRemoveAll";
            this.buttonRemoveAll.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveAll.TabIndex = 4;
            this.buttonRemoveAll.Text = "Mindent torol";
            this.buttonRemoveAll.UseVisualStyleBackColor = true;
            this.buttonRemoveAll.Click += new System.EventHandler(this.buttonRemoveAll_Click);
            // 
            // buttonBgColor
            // 
            this.buttonBgColor.Location = new System.Drawing.Point(302, 151);
            this.buttonBgColor.Name = "buttonBgColor";
            this.buttonBgColor.Size = new System.Drawing.Size(75, 23);
            this.buttonBgColor.TabIndex = 5;
            this.buttonBgColor.Text = "Hatterszin";
            this.buttonBgColor.UseVisualStyleBackColor = true;
            // 
            // buttonTxtColor
            // 
            this.buttonTxtColor.Location = new System.Drawing.Point(302, 180);
            this.buttonTxtColor.Name = "buttonTxtColor";
            this.buttonTxtColor.Size = new System.Drawing.Size(75, 23);
            this.buttonTxtColor.TabIndex = 6;
            this.buttonTxtColor.Text = "Betuszin";
            this.buttonTxtColor.UseVisualStyleBackColor = true;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(494, 61);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(247, 160);
            this.listBox.TabIndex = 7;
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(42, 415);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(75, 23);
            this.buttonSort.TabIndex = 8;
            this.buttonSort.Text = "Sorbarendez";
            this.buttonSort.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(708, 419);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.Text = "Kilepes";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(494, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Elemek szama";
            // 
            // labelItemsCount
            // 
            this.labelItemsCount.Location = new System.Drawing.Point(580, 254);
            this.labelItemsCount.Name = "labelItemsCount";
            this.labelItemsCount.Size = new System.Drawing.Size(100, 23);
            this.labelItemsCount.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelItemsCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.buttonTxtColor);
            this.Controls.Add(this.buttonBgColor);
            this.Controls.Add(this.buttonRemoveAll);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxNewItem);
            this.Controls.Add(this.labelNewItem);
            this.Name = "Form1";
            this.Text = "Listakezelo";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button buttonAdd;

        private System.Windows.Forms.Label labelItemsCount;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button buttonExit;

        private System.Windows.Forms.Button buttonSort;

        private System.Windows.Forms.ListBox listBox;

        private System.Windows.Forms.ListBox listBox1;

        private System.Windows.Forms.Button buttonTxtColor;

        private System.Windows.Forms.Button buttonBgColor;
        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Button buttonRemoveAll;

        private System.Windows.Forms.Button buttonRemove;

        private System.Windows.Forms.Button Torol;

        private System.Windows.Forms.TextBox textBoxNewItem;

        private System.Windows.Forms.Label labelNewItem;

        #endregion
    }
}