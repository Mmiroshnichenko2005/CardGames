namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlPlayer1 = new System.Windows.Forms.Panel();
            this.pnlPlayer2 = new System.Windows.Forms.Panel();
            this.pnlTable2 = new System.Windows.Forms.Panel();
            this.pnlDeck = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTable1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlPlayer1
            // 
            this.pnlPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.pnlPlayer1.Location = new System.Drawing.Point(12, 12);
            this.pnlPlayer1.Name = "pnlPlayer1";
            this.pnlPlayer1.Size = new System.Drawing.Size(1054, 99);
            this.pnlPlayer1.TabIndex = 0;
            // 
            // pnlPlayer2
            // 
            this.pnlPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.pnlPlayer2.Location = new System.Drawing.Point(12, 576);
            this.pnlPlayer2.Name = "pnlPlayer2";
            this.pnlPlayer2.Size = new System.Drawing.Size(1054, 119);
            this.pnlPlayer2.TabIndex = 1;
            // 
            // pnlTable2
            // 
            this.pnlTable2.BackColor = System.Drawing.Color.Transparent;
            this.pnlTable2.Location = new System.Drawing.Point(12, 127);
            this.pnlTable2.Name = "pnlTable2";
            this.pnlTable2.Size = new System.Drawing.Size(1019, 169);
            this.pnlTable2.TabIndex = 2;
            this.pnlTable2.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTable_Paint);
            // 
            // pnlDeck
            // 
            this.pnlDeck.BackColor = System.Drawing.Color.Transparent;
            this.pnlDeck.Location = new System.Drawing.Point(1049, 127);
            this.pnlDeck.Name = "pnlDeck";
            this.pnlDeck.Size = new System.Drawing.Size(17, 149);
            this.pnlDeck.TabIndex = 3;
            this.pnlDeck.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDeck_Paint);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Location = new System.Drawing.Point(1037, 283);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(35, 13);
            this.lblMessage.TabIndex = 4;
            this.lblMessage.Text = "label1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(87, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(520, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "P2Table";
            // 
            // pnlTable1
            // 
            this.pnlTable1.BackColor = System.Drawing.Color.Transparent;
            this.pnlTable1.Location = new System.Drawing.Point(27, 400);
            this.pnlTable1.Name = "pnlTable1";
            this.pnlTable1.Size = new System.Drawing.Size(1019, 160);
            this.pnlTable1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1090, 707);
            this.Controls.Add(this.pnlTable1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.pnlDeck);
            this.Controls.Add(this.pnlTable2);
            this.Controls.Add(this.pnlPlayer2);
            this.Controls.Add(this.pnlPlayer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlPlayer1;
        private System.Windows.Forms.Panel pnlPlayer2;
        private System.Windows.Forms.Panel pnlTable2;
        private System.Windows.Forms.Panel pnlDeck;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlTable1;
    }
}

