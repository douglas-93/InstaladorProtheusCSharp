namespace InstaladorProtheus
{
    partial class MainForm
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
            label1 = new Label();
            txtOrigem = new TextBox();
            btnSelecionaOrigem = new Button();
            btnSelecionaDestino = new Button();
            txtDestino = new TextBox();
            label2 = new Label();
            progressBar = new ProgressBar();
            btnInstalar = new Button();
            lblStatus = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 0;
            label1.Text = "Origem";
            // 
            // txtOrigem
            // 
            txtOrigem.Location = new Point(78, 12);
            txtOrigem.Name = "txtOrigem";
            txtOrigem.ReadOnly = true;
            txtOrigem.Size = new Size(482, 27);
            txtOrigem.TabIndex = 1;
            txtOrigem.Text = "\\\\192.168.100.30\\Instalaveis\\smartclient 03.06\\smartclient.zip";
            // 
            // btnSelecionaOrigem
            // 
            btnSelecionaOrigem.Location = new Point(566, 11);
            btnSelecionaOrigem.Name = "btnSelecionaOrigem";
            btnSelecionaOrigem.Size = new Size(94, 29);
            btnSelecionaOrigem.TabIndex = 2;
            btnSelecionaOrigem.Text = "Selecionar";
            btnSelecionaOrigem.UseVisualStyleBackColor = true;
            btnSelecionaOrigem.Click += btnSelecionaOrigem_Click;
            // 
            // btnSelecionaDestino
            // 
            btnSelecionaDestino.Location = new Point(566, 44);
            btnSelecionaDestino.Name = "btnSelecionaDestino";
            btnSelecionaDestino.Size = new Size(94, 29);
            btnSelecionaDestino.TabIndex = 5;
            btnSelecionaDestino.Text = "Selecionar";
            btnSelecionaDestino.UseVisualStyleBackColor = true;
            btnSelecionaDestino.Click += btnSelecionaDestino_Click;
            // 
            // txtDestino
            // 
            txtDestino.Location = new Point(78, 45);
            txtDestino.Name = "txtDestino";
            txtDestino.ReadOnly = true;
            txtDestino.Size = new Size(482, 27);
            txtDestino.TabIndex = 4;
            txtDestino.Text = "C:\\";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 48);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 3;
            label2.Text = "Destino";
            // 
            // progressBar
            // 
            progressBar.Location = new Point(12, 78);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(648, 29);
            progressBar.TabIndex = 6;
            // 
            // btnInstalar
            // 
            btnInstalar.Location = new Point(566, 113);
            btnInstalar.Name = "btnInstalar";
            btnInstalar.Size = new Size(94, 29);
            btnInstalar.TabIndex = 7;
            btnInstalar.Text = "Instalar";
            btnInstalar.UseVisualStyleBackColor = true;
            btnInstalar.Click += btnInstalar_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(12, 117);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 20);
            lblStatus.TabIndex = 8;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(672, 154);
            Controls.Add(lblStatus);
            Controls.Add(btnInstalar);
            Controls.Add(progressBar);
            Controls.Add(btnSelecionaDestino);
            Controls.Add(txtDestino);
            Controls.Add(label2);
            Controls.Add(btnSelecionaOrigem);
            Controls.Add(txtOrigem);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "Instalador Protheus";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtOrigem;
        private Button btnSelecionaOrigem;
        private Button btnSelecionaDestino;
        private TextBox txtDestino;
        private Label label2;
        private ProgressBar progressBar;
        private Button btnInstalar;
        private Label lblStatus;
    }
}
