namespace Lista_tarefas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tb_tarefas = new TextBox();
            lb_tarefas = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(356, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(446, 280);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(100, 32);
            label1.Name = "label1";
            label1.Size = new Size(163, 37);
            label1.TabIndex = 1;
            label1.Text = "Suas tarefas";
            // 
            // tb_tarefas
            // 
            tb_tarefas.Location = new Point(9, 135);
            tb_tarefas.Name = "tb_tarefas";
            tb_tarefas.Size = new Size(161, 23);
            tb_tarefas.TabIndex = 9;
            tb_tarefas.Text = "Tarefa_tb";
            tb_tarefas.TextChanged += textBox8_TextChanged;
            // 
            // lb_tarefas
            // 
            lb_tarefas.FormattingEnabled = true;
            lb_tarefas.ItemHeight = 15;
            lb_tarefas.Location = new Point(12, 194);
            lb_tarefas.Name = "lb_tarefas";
            lb_tarefas.Size = new Size(251, 169);
            lb_tarefas.TabIndex = 10;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.Location = new Point(200, 135);
            button1.Name = "button1";
            button1.Size = new Size(109, 34);
            button1.TabIndex = 11;
            button1.Text = "Confirmar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Location = new Point(12, 388);
            button2.Name = "button2";
            button2.Size = new Size(109, 34);
            button2.TabIndex = 12;
            button2.Text = "Excluir";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ScrollBar;
            button3.Location = new Point(170, 388);
            button3.Name = "button3";
            button3.Size = new Size(109, 34);
            button3.TabIndex = 13;
            button3.Text = "Alterar";
            button3.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lb_tarefas);
            Controls.Add(tb_tarefas);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox tb_tarefas;
        private ListBox lb_tarefas;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}