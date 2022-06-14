namespace MarianHasyak_AgencjaPracy
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
            this.btnPracodawca = new System.Windows.Forms.Button();
            this.btnPracownik = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnCompare = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPracodawca
            // 
            this.btnPracodawca.Location = new System.Drawing.Point(77, 97);
            this.btnPracodawca.Name = "btnPracodawca";
            this.btnPracodawca.Size = new System.Drawing.Size(320, 119);
            this.btnPracodawca.TabIndex = 0;
            this.btnPracodawca.Text = "Pracodawca";
            this.btnPracodawca.UseVisualStyleBackColor = true;
            this.btnPracodawca.Click += new System.EventHandler(this.btnPracodawca_Click);
            // 
            // btnPracownik
            // 
            this.btnPracownik.Location = new System.Drawing.Point(403, 97);
            this.btnPracownik.Name = "btnPracownik";
            this.btnPracownik.Size = new System.Drawing.Size(320, 119);
            this.btnPracownik.TabIndex = 1;
            this.btnPracownik.Text = "Pracownik";
            this.btnPracownik.UseVisualStyleBackColor = true;
            this.btnPracownik.Click += new System.EventHandler(this.btnPracownik_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(77, 222);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(646, 95);
            this.btnDisplay.TabIndex = 2;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(77, 323);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(210, 48);
            this.btnCompare.TabIndex = 3;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(509, 323);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(214, 48);
            this.btnSort.TabIndex = 4;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(293, 323);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(210, 48);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnPracownik);
            this.Controls.Add(this.btnPracodawca);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPracodawca;
        private System.Windows.Forms.Button btnPracownik;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnSearch;
    }
}

