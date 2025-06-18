namespace WinFormsWebApi
{
    partial class Main
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
            label2 = new Label();
            label3 = new Label();
            txtNome = new TextBox();
            txtPreco = new TextBox();
            txtEstoque = new TextBox();
            btnCarregar = new Button();
            btnAdicionar = new Button();
            btnAtualizar = new Button();
            btnRemover = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 21);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 52);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Preço:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 81);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 2;
            label3.Text = "Estoque:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(75, 18);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(170, 23);
            txtNome.TabIndex = 3;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(75, 49);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(119, 23);
            txtPreco.TabIndex = 3;
            // 
            // txtEstoque
            // 
            txtEstoque.Location = new Point(75, 78);
            txtEstoque.Name = "txtEstoque";
            txtEstoque.Size = new Size(88, 23);
            txtEstoque.TabIndex = 3;
            // 
            // btnCarregar
            // 
            btnCarregar.Location = new Point(75, 127);
            btnCarregar.Name = "btnCarregar";
            btnCarregar.Size = new Size(75, 23);
            btnCarregar.TabIndex = 4;
            btnCarregar.Text = "Carregar";
            btnCarregar.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(174, 127);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 4;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(269, 127);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(75, 23);
            btnAtualizar.TabIndex = 4;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(364, 127);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(75, 23);
            btnRemover.TabIndex = 4;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(50, 166);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(414, 150);
            dataGridView1.TabIndex = 5;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 336);
            Controls.Add(dataGridView1);
            Controls.Add(btnRemover);
            Controls.Add(btnAtualizar);
            Controls.Add(btnAdicionar);
            Controls.Add(btnCarregar);
            Controls.Add(txtEstoque);
            Controls.Add(txtPreco);
            Controls.Add(txtNome);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Main";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNome;
        private TextBox txtPreco;
        private TextBox txtEstoque;
        private Button btnCarregar;
        private Button btnAdicionar;
        private Button btnAtualizar;
        private Button btnRemover;
        private DataGridView dataGridView1;
    }
}
