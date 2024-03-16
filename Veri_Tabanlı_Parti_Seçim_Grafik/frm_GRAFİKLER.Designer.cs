namespace Veri_Tabanlı_Parti_Seçim_Grafik
{
    partial class frm_GRAFİKLER
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_YRP = new System.Windows.Forms.Label();
            this.lbl_MHP = new System.Windows.Forms.Label();
            this.lbl_CHP = new System.Windows.Forms.Label();
            this.lbl_ZP = new System.Windows.Forms.Label();
            this.lbl_AKP = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.progressBar5 = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.cmb_İLCE_SECİMİ = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chart1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(955, 347);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GRAFİKLER";
//            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // chart1
            // 
            this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(3, 26);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Legend = "Legend1";
            series2.Name = "Partiler";
            series2.YValuesPerPoint = 4;
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(949, 318);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_YRP);
            this.groupBox2.Controls.Add(this.lbl_MHP);
            this.groupBox2.Controls.Add(this.lbl_CHP);
            this.groupBox2.Controls.Add(this.lbl_ZP);
            this.groupBox2.Controls.Add(this.lbl_AKP);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.progressBar5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.progressBar3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.progressBar4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.progressBar2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.cmb_İLCE_SECİMİ);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(15, 374);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(952, 353);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İLÇE DEĞERLERİ";
            // 
            // lbl_YRP
            // 
            this.lbl_YRP.AutoSize = true;
            this.lbl_YRP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_YRP.Location = new System.Drawing.Point(828, 290);
            this.lbl_YRP.Name = "lbl_YRP";
            this.lbl_YRP.Size = new System.Drawing.Size(31, 32);
            this.lbl_YRP.TabIndex = 16;
            this.lbl_YRP.Text = "0";
            // 
            // lbl_MHP
            // 
            this.lbl_MHP.AutoSize = true;
            this.lbl_MHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_MHP.Location = new System.Drawing.Point(828, 242);
            this.lbl_MHP.Name = "lbl_MHP";
            this.lbl_MHP.Size = new System.Drawing.Size(31, 32);
            this.lbl_MHP.TabIndex = 15;
            this.lbl_MHP.Text = "0";
            // 
            // lbl_CHP
            // 
            this.lbl_CHP.AutoSize = true;
            this.lbl_CHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_CHP.Location = new System.Drawing.Point(828, 194);
            this.lbl_CHP.Name = "lbl_CHP";
            this.lbl_CHP.Size = new System.Drawing.Size(31, 32);
            this.lbl_CHP.TabIndex = 14;
            this.lbl_CHP.Text = "0";
            // 
            // lbl_ZP
            // 
            this.lbl_ZP.AutoSize = true;
            this.lbl_ZP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ZP.Location = new System.Drawing.Point(828, 146);
            this.lbl_ZP.Name = "lbl_ZP";
            this.lbl_ZP.Size = new System.Drawing.Size(31, 32);
            this.lbl_ZP.TabIndex = 13;
            this.lbl_ZP.Text = "0";
            // 
            // lbl_AKP
            // 
            this.lbl_AKP.AutoSize = true;
            this.lbl_AKP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_AKP.Location = new System.Drawing.Point(828, 98);
            this.lbl_AKP.Name = "lbl_AKP";
            this.lbl_AKP.Size = new System.Drawing.Size(31, 32);
            this.lbl_AKP.TabIndex = 12;
            this.lbl_AKP.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "YRP:";
            // 
            // progressBar5
            // 
            this.progressBar5.Location = new System.Drawing.Point(150, 232);
            this.progressBar5.Maximum = 250;
            this.progressBar5.Name = "progressBar5";
            this.progressBar5.Size = new System.Drawing.Size(673, 42);
            this.progressBar5.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "MHP:";
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(149, 184);
            this.progressBar3.Maximum = 250;
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(673, 42);
            this.progressBar3.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "CHP:";
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(150, 280);
            this.progressBar4.Maximum = 250;
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(673, 42);
            this.progressBar4.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "ZP:";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(149, 136);
            this.progressBar2.Maximum = 250;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(673, 42);
            this.progressBar2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "AKP:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(149, 88);
            this.progressBar1.Maximum = 250;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(673, 42);
            this.progressBar1.TabIndex = 2;
            // 
            // cmb_İLCE_SECİMİ
            // 
            this.cmb_İLCE_SECİMİ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_İLCE_SECİMİ.FormattingEnabled = true;
            this.cmb_İLCE_SECİMİ.Location = new System.Drawing.Point(149, 45);
            this.cmb_İLCE_SECİMİ.Name = "cmb_İLCE_SECİMİ";
            this.cmb_İLCE_SECİMİ.Size = new System.Drawing.Size(297, 33);
            this.cmb_İLCE_SECİMİ.TabIndex = 1;
            this.cmb_İLCE_SECİMİ.SelectedIndexChanged += new System.EventHandler(this.cmb_İLCE_SECİMİ_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "İlçe Seçimi:";
            // 
            // frm_GRAFİKLER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(971, 734);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_GRAFİKLER";
            this.Text = "frm_GRAFİKLER";
            this.Load += new System.EventHandler(this.frm_GRAFİKLER_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_YRP;
        private System.Windows.Forms.Label lbl_MHP;
        private System.Windows.Forms.Label lbl_CHP;
        private System.Windows.Forms.Label lbl_ZP;
        private System.Windows.Forms.Label lbl_AKP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar progressBar5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ComboBox cmb_İLCE_SECİMİ;
        private System.Windows.Forms.Label label1;
    }
}