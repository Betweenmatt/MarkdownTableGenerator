namespace MarkdownTableGenerator.Forms
{
    partial class TableGenerator
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.insertButton = new System.Windows.Forms.Button();
            this.addColumnButton = new System.Windows.Forms.Button();
            this.deleteColumnButton = new System.Windows.Forms.Button();
            this.clearTableButton = new System.Windows.Forms.Button();
            this.fillButton = new System.Windows.Forms.Button();
            this.lalignbutton = new System.Windows.Forms.Button();
            this.ralignbutton = new System.Windows.Forms.Button();
            this.centerbutton = new System.Windows.Forms.Button();
            this.tableGeneratorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableGeneratorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(2, 71);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.Size = new System.Drawing.Size(374, 187);
            this.dataGridView.TabIndex = 0;
            // 
            // insertButton
            // 
            this.insertButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.insertButton.Location = new System.Drawing.Point(6, 264);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(169, 23);
            this.insertButton.TabIndex = 1;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // addColumnButton
            // 
            this.addColumnButton.Location = new System.Drawing.Point(2, 42);
            this.addColumnButton.Name = "addColumnButton";
            this.addColumnButton.Size = new System.Drawing.Size(75, 23);
            this.addColumnButton.TabIndex = 2;
            this.addColumnButton.Text = "Add Column";
            this.addColumnButton.UseVisualStyleBackColor = true;
            this.addColumnButton.Click += new System.EventHandler(this.addColumnButton_Click);
            // 
            // deleteColumnButton
            // 
            this.deleteColumnButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteColumnButton.Location = new System.Drawing.Point(282, 42);
            this.deleteColumnButton.Name = "deleteColumnButton";
            this.deleteColumnButton.Size = new System.Drawing.Size(92, 23);
            this.deleteColumnButton.TabIndex = 3;
            this.deleteColumnButton.Text = "Delete Column";
            this.deleteColumnButton.UseVisualStyleBackColor = true;
            this.deleteColumnButton.Click += new System.EventHandler(this.deleteColumnButton_Click);
            // 
            // clearTableButton
            // 
            this.clearTableButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearTableButton.Location = new System.Drawing.Point(282, 3);
            this.clearTableButton.Name = "clearTableButton";
            this.clearTableButton.Size = new System.Drawing.Size(92, 23);
            this.clearTableButton.TabIndex = 4;
            this.clearTableButton.Text = "Clear Table";
            this.clearTableButton.UseVisualStyleBackColor = true;
            this.clearTableButton.Click += new System.EventHandler(this.clearTableButton_Click);
            // 
            // fillButton
            // 
            this.fillButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fillButton.Location = new System.Drawing.Point(197, 264);
            this.fillButton.Name = "fillButton";
            this.fillButton.Size = new System.Drawing.Size(169, 23);
            this.fillButton.TabIndex = 5;
            this.fillButton.Text = "Fill";
            this.fillButton.UseVisualStyleBackColor = true;
            this.fillButton.Click += new System.EventHandler(this.fillButton_Click);
            // 
            // lalignbutton
            // 
            this.lalignbutton.Location = new System.Drawing.Point(124, 42);
            this.lalignbutton.Name = "lalignbutton";
            this.lalignbutton.Size = new System.Drawing.Size(32, 23);
            this.lalignbutton.TabIndex = 7;
            this.lalignbutton.Text = ":---";
            this.lalignbutton.UseVisualStyleBackColor = true;
            this.lalignbutton.Click += new System.EventHandler(this.lalignbutton_Click);
            // 
            // ralignbutton
            // 
            this.ralignbutton.Location = new System.Drawing.Point(162, 42);
            this.ralignbutton.Name = "ralignbutton";
            this.ralignbutton.Size = new System.Drawing.Size(32, 23);
            this.ralignbutton.TabIndex = 8;
            this.ralignbutton.Text = "--:";
            this.ralignbutton.UseVisualStyleBackColor = true;
            this.ralignbutton.Click += new System.EventHandler(this.ralignbutton_Click);
            // 
            // centerbutton
            // 
            this.centerbutton.Location = new System.Drawing.Point(200, 42);
            this.centerbutton.Name = "centerbutton";
            this.centerbutton.Size = new System.Drawing.Size(32, 23);
            this.centerbutton.TabIndex = 9;
            this.centerbutton.Text = ":--:";
            this.centerbutton.UseVisualStyleBackColor = true;
            this.centerbutton.Click += new System.EventHandler(this.centerbutton_Click);
            // 
            // tableGeneratorBindingSource
            // 
            this.tableGeneratorBindingSource.DataSource = typeof(MarkdownTableGenerator.Forms.TableGenerator);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Markdown Table Generator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "github.com/TastyGod";
            // 
            // TableGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 299);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.centerbutton);
            this.Controls.Add(this.ralignbutton);
            this.Controls.Add(this.lalignbutton);
            this.Controls.Add(this.fillButton);
            this.Controls.Add(this.clearTableButton);
            this.Controls.Add(this.deleteColumnButton);
            this.Controls.Add(this.addColumnButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.dataGridView);
            this.Name = "TableGenerator";
            this.Text = "Markdown Table Generator";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableGeneratorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.BindingSource tableGeneratorBindingSource;
        private System.Windows.Forms.Button addColumnButton;
        private System.Windows.Forms.Button deleteColumnButton;
        private System.Windows.Forms.Button clearTableButton;
        private System.Windows.Forms.Button fillButton;
        private System.Windows.Forms.Button lalignbutton;
        private System.Windows.Forms.Button ralignbutton;
        private System.Windows.Forms.Button centerbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}