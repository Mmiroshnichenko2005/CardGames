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
            this.pnlPlayer2 = new System.Windows.Forms.Panel();
            this.pnlPlayer1 = new System.Windows.Forms.Panel();
            this.Card1P2 = new System.Windows.Forms.Panel();
            this.pnlDeck = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Card2P2 = new System.Windows.Forms.Panel();
            this.Card3P2 = new System.Windows.Forms.Panel();
            this.Card4P2 = new System.Windows.Forms.Panel();
            this.Card1P1 = new System.Windows.Forms.Panel();
            this.Card2P1 = new System.Windows.Forms.Panel();
            this.Card3P1 = new System.Windows.Forms.Panel();
            this.Card4P1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlPlayer2
            // 
            this.pnlPlayer2.BackColor = System.Drawing.Color.LightCyan;
            this.pnlPlayer2.Location = new System.Drawing.Point(1, 1);
            this.pnlPlayer2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlPlayer2.Name = "pnlPlayer2";
            this.pnlPlayer2.Size = new System.Drawing.Size(1329, 149);
            this.pnlPlayer2.TabIndex = 0;
            // 
            // pnlPlayer1
            // 
            this.pnlPlayer1.BackColor = System.Drawing.Color.LightCyan;
            this.pnlPlayer1.Location = new System.Drawing.Point(1, 622);
            this.pnlPlayer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlPlayer1.Name = "pnlPlayer1";
            this.pnlPlayer1.Size = new System.Drawing.Size(1329, 117);
            this.pnlPlayer1.TabIndex = 1;
            // 
            // Card1P2
            // 
            this.Card1P2.BackColor = System.Drawing.Color.LightCyan;
            this.Card1P2.Location = new System.Drawing.Point(297, 175);
            this.Card1P2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Card1P2.Name = "Card1P2";
            this.Card1P2.Size = new System.Drawing.Size(144, 208);
            this.Card1P2.TabIndex = 2;
            this.Card1P2.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTable_Paint);
            // 
            // pnlDeck
            // 
            this.pnlDeck.BackColor = System.Drawing.Color.Transparent;
            this.pnlDeck.Location = new System.Drawing.Point(1399, 156);
            this.pnlDeck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlDeck.Name = "pnlDeck";
            this.pnlDeck.Size = new System.Drawing.Size(23, 183);
            this.pnlDeck.TabIndex = 3;
            this.pnlDeck.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDeck_Paint);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Location = new System.Drawing.Point(1383, 348);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(46, 17);
            this.lblMessage.TabIndex = 4;
            this.lblMessage.Text = "label1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(116, 420);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(612, 154);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "P2Table";
            // 
            // Card2P2
            // 
            this.Card2P2.BackColor = System.Drawing.Color.LightCyan;
            this.Card2P2.Location = new System.Drawing.Point(479, 175);
            this.Card2P2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Card2P2.Name = "Card2P2";
            this.Card2P2.Size = new System.Drawing.Size(144, 208);
            this.Card2P2.TabIndex = 7;
            // 
            // Card3P2
            // 
            this.Card3P2.BackColor = System.Drawing.Color.LightCyan;
            this.Card3P2.Location = new System.Drawing.Point(671, 175);
            this.Card3P2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Card3P2.Name = "Card3P2";
            this.Card3P2.Size = new System.Drawing.Size(144, 208);
            this.Card3P2.TabIndex = 3;
            this.Card3P2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Card4P2
            // 
            this.Card4P2.BackColor = System.Drawing.Color.LightCyan;
            this.Card4P2.Location = new System.Drawing.Point(843, 175);
            this.Card4P2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Card4P2.Name = "Card4P2";
            this.Card4P2.Size = new System.Drawing.Size(144, 208);
            this.Card4P2.TabIndex = 4;
            // 
            // Card1P1
            // 
            this.Card1P1.BackColor = System.Drawing.Color.LightCyan;
            this.Card1P1.Location = new System.Drawing.Point(297, 390);
            this.Card1P1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Card1P1.Name = "Card1P1";
            this.Card1P1.Size = new System.Drawing.Size(144, 208);
            this.Card1P1.TabIndex = 3;
            // 
            // Card2P1
            // 
            this.Card2P1.BackColor = System.Drawing.Color.LightCyan;
            this.Card2P1.Location = new System.Drawing.Point(479, 390);
            this.Card2P1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Card2P1.Name = "Card2P1";
            this.Card2P1.Size = new System.Drawing.Size(144, 208);
            this.Card2P1.TabIndex = 4;
            // 
            // Card3P1
            // 
            this.Card3P1.BackColor = System.Drawing.Color.LightCyan;
            this.Card3P1.Location = new System.Drawing.Point(671, 390);
            this.Card3P1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Card3P1.Name = "Card3P1";
            this.Card3P1.Size = new System.Drawing.Size(144, 208);
            this.Card3P1.TabIndex = 5;
            // 
            // Card4P1
            // 
            this.Card4P1.BackColor = System.Drawing.Color.LightCyan;
            this.Card4P1.Location = new System.Drawing.Point(843, 390);
            this.Card4P1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Card4P1.Name = "Card4P1";
            this.Card4P1.Size = new System.Drawing.Size(144, 208);
            this.Card4P1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(611, 602);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "P1Table";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1363, 741);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Card4P1);
            this.Controls.Add(this.Card3P1);
            this.Controls.Add(this.Card2P1);
            this.Controls.Add(this.Card1P1);
            this.Controls.Add(this.Card4P2);
            this.Controls.Add(this.Card3P2);
            this.Controls.Add(this.Card2P2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.pnlDeck);
            this.Controls.Add(this.Card1P2);
            this.Controls.Add(this.pnlPlayer1);
            this.Controls.Add(this.pnlPlayer2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlPlayer2;
        private System.Windows.Forms.Panel pnlPlayer1;
        private System.Windows.Forms.Panel Card1P2;
        private System.Windows.Forms.Panel pnlDeck;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Card2P2;
        private System.Windows.Forms.Panel Card3P2;
        private System.Windows.Forms.Panel Card4P2;
        private System.Windows.Forms.Panel Card1P1;
        private System.Windows.Forms.Panel Card2P1;
        private System.Windows.Forms.Panel Card3P1;
        private System.Windows.Forms.Panel Card4P1;
        private System.Windows.Forms.Label label2;
    }
}

