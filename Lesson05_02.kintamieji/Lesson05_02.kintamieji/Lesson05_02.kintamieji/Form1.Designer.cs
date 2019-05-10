namespace Lesson05_02.kintamieji
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
            this.tbSvoris = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbUgis = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPadetiIMasyva = new System.Windows.Forms.Button();
            this.btnParodytiMasyva = new System.Windows.Forms.Button();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbSvoris
            // 
            this.tbSvoris.Location = new System.Drawing.Point(150, 96);
            this.tbSvoris.Name = "tbSvoris";
            this.tbSvoris.Size = new System.Drawing.Size(100, 20);
            this.tbSvoris.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Svoris";
            // 
            // tbUgis
            // 
            this.tbUgis.Location = new System.Drawing.Point(150, 57);
            this.tbUgis.Name = "tbUgis";
            this.tbUgis.Size = new System.Drawing.Size(100, 20);
            this.tbUgis.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ugis";
            // 
            // btnPadetiIMasyva
            // 
            this.btnPadetiIMasyva.Location = new System.Drawing.Point(84, 138);
            this.btnPadetiIMasyva.Name = "btnPadetiIMasyva";
            this.btnPadetiIMasyva.Size = new System.Drawing.Size(166, 23);
            this.btnPadetiIMasyva.TabIndex = 6;
            this.btnPadetiIMasyva.Text = "Padeti i masyva";
            this.btnPadetiIMasyva.UseVisualStyleBackColor = true;
            this.btnPadetiIMasyva.Click += new System.EventHandler(this.BtnPadetiIMasyva_Click);
            // 
            // btnParodytiMasyva
            // 
            this.btnParodytiMasyva.Location = new System.Drawing.Point(300, 138);
            this.btnParodytiMasyva.Name = "btnParodytiMasyva";
            this.btnParodytiMasyva.Size = new System.Drawing.Size(183, 23);
            this.btnParodytiMasyva.TabIndex = 8;
            this.btnParodytiMasyva.Text = "Parodyti masyva";
            this.btnParodytiMasyva.UseVisualStyleBackColor = true;
            this.btnParodytiMasyva.Click += new System.EventHandler(this.BtnParodytiMasyva_Click);
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(300, 57);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(183, 59);
            this.tbOutput.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 213);
            this.Controls.Add(this.btnParodytiMasyva);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.btnPadetiIMasyva);
            this.Controls.Add(this.tbUgis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSvoris);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSvoris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUgis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPadetiIMasyva;
        private System.Windows.Forms.Button btnParodytiMasyva;
        private System.Windows.Forms.TextBox tbOutput;
    }
}

