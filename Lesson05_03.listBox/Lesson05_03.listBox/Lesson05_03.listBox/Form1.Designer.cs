namespace Lesson05_03.listBox
{
    partial class frmPazymiai
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbPazymis = new System.Windows.Forms.TextBox();
            this.btnPrideti = new System.Windows.Forms.Button();
            this.lbxPazymiai = new System.Windows.Forms.ListBox();
            this.btnIštrinti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pažymis";
            // 
            // tbPazymis
            // 
            this.tbPazymis.Location = new System.Drawing.Point(106, 59);
            this.tbPazymis.Name = "tbPazymis";
            this.tbPazymis.Size = new System.Drawing.Size(100, 20);
            this.tbPazymis.TabIndex = 1;
            // 
            // btnPrideti
            // 
            this.btnPrideti.Location = new System.Drawing.Point(55, 85);
            this.btnPrideti.Name = "btnPrideti";
            this.btnPrideti.Size = new System.Drawing.Size(151, 23);
            this.btnPrideti.TabIndex = 2;
            this.btnPrideti.Text = "Pridėti pažymį";
            this.btnPrideti.UseVisualStyleBackColor = true;
            this.btnPrideti.Click += new System.EventHandler(this.BtnPrideti_Click);
            // 
            // lbxPazymiai
            // 
            this.lbxPazymiai.FormattingEnabled = true;
            this.lbxPazymiai.Location = new System.Drawing.Point(241, 59);
            this.lbxPazymiai.Name = "lbxPazymiai";
            this.lbxPazymiai.Size = new System.Drawing.Size(140, 199);
            this.lbxPazymiai.TabIndex = 3;
            // 
            // btnIštrinti
            // 
            this.btnIštrinti.Location = new System.Drawing.Point(55, 114);
            this.btnIštrinti.Name = "btnIštrinti";
            this.btnIštrinti.Size = new System.Drawing.Size(151, 23);
            this.btnIštrinti.TabIndex = 4;
            this.btnIštrinti.Text = "Ištrinti pažymėtą";
            this.btnIštrinti.UseVisualStyleBackColor = true;
            this.btnIštrinti.Click += new System.EventHandler(this.BtnIštrinti_Click);
            // 
            // frmPazymiai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 270);
            this.Controls.Add(this.btnIštrinti);
            this.Controls.Add(this.lbxPazymiai);
            this.Controls.Add(this.btnPrideti);
            this.Controls.Add(this.tbPazymis);
            this.Controls.Add(this.label1);
            this.Name = "frmPazymiai";
            this.Text = "Pažymiai";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPazymis;
        private System.Windows.Forms.Button btnPrideti;
        private System.Windows.Forms.ListBox lbxPazymiai;
        private System.Windows.Forms.Button btnIštrinti;
    }
}

