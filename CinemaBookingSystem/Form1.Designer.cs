namespace bioprogram
{
    partial class Mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.resv = new System.Windows.Forms.RadioButton();
            this.canc = new System.Windows.Forms.RadioButton();
            this.Reservations = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lstReservation = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.TextBox();
            this.uName = new System.Windows.Forms.TextBox();
            this.userButton = new System.Windows.Forms.Button();
            this.noSeat = new System.Windows.Forms.Label();
            this.noResv = new System.Windows.Forms.Label();
            this.vacSeat = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // resv
            // 
            resources.ApplyResources(this.resv, "resv");
            this.resv.Name = "resv";
            this.resv.TabStop = true;
            this.resv.UseVisualStyleBackColor = true;
            this.resv.CheckedChanged += new System.EventHandler(this.Resv_CheckedChanged);
            // 
            // canc
            // 
            resources.ApplyResources(this.canc, "canc");
            this.canc.Name = "canc";
            this.canc.TabStop = true;
            this.canc.UseVisualStyleBackColor = true;
            this.canc.CheckedChanged += new System.EventHandler(this.CResv_CheckedChanged);
            // 
            // Reservations
            // 
            resources.ApplyResources(this.Reservations, "Reservations");
            this.Reservations.ForeColor = System.Drawing.Color.Black;
            this.Reservations.Name = "Reservations";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Name = "label9";
            // 
            // lstReservation
            // 
            resources.ApplyResources(this.lstReservation, "lstReservation");
            this.lstReservation.FormattingEnabled = true;
            this.lstReservation.Name = "lstReservation";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // Price
            // 
            resources.ApplyResources(this.Price, "Price");
            this.Price.Name = "Price";
            // 
            // uName
            // 
            resources.ApplyResources(this.uName, "uName");
            this.uName.Name = "uName";
            // 
            // userButton
            // 
            resources.ApplyResources(this.userButton, "userButton");
            this.userButton.Name = "userButton";
            this.userButton.UseVisualStyleBackColor = true;
            this.userButton.Click += new System.EventHandler(this.userButton_Click);
            // 
            // noSeat
            // 
            this.noSeat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.noSeat, "noSeat");
            this.noSeat.Name = "noSeat";
            // 
            // noResv
            // 
            resources.ApplyResources(this.noResv, "noResv");
            this.noResv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.noResv.Name = "noResv";
            // 
            // vacSeat
            // 
            resources.ApplyResources(this.vacSeat, "vacSeat");
            this.vacSeat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.vacSeat.Name = "vacSeat";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.noSeat);
            this.groupBox2.Controls.Add(this.vacSeat);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.Price);
            this.groupBox3.Controls.Add(this.userButton);
            this.groupBox3.Controls.Add(this.canc);
            this.groupBox3.Controls.Add(this.uName);
            this.groupBox3.Controls.Add(this.resv);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // Mainform
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.noResv);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lstReservation);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Reservations);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "Mainform";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton resv;
        private System.Windows.Forms.RadioButton canc;
        private System.Windows.Forms.Label Reservations;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lstReservation;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox uName;
        private System.Windows.Forms.Button userButton;
        private System.Windows.Forms.Label noSeat;
        private System.Windows.Forms.Label noResv;
        private System.Windows.Forms.Label vacSeat;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

