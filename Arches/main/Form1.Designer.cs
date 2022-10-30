
namespace main
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cevreRBT = new System.Windows.Forms.RadioButton();
            this.alanRBT = new System.Windows.Forms.RadioButton();
            this.hacimRBT = new System.Windows.Forms.RadioButton();
            this.ObjectsGroupBox = new System.Windows.Forms.GroupBox();
            this.dPrizmasiRBT = new System.Windows.Forms.RadioButton();
            this.silindirRBT = new System.Windows.Forms.RadioButton();
            this.kureRBT = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ikinciKenarLabel = new System.Windows.Forms.Label();
            this.yukseklikLabel = new System.Windows.Forms.Label();
            this.yariCapLabel = new System.Windows.Forms.Label();
            this.ikinciKenarTextBox = new System.Windows.Forms.TextBox();
            this.yukseklikTextBox = new System.Windows.Forms.TextBox();
            this.yaricapTextBox = new System.Windows.Forms.TextBox();
            this.onaylaBTN = new System.Windows.Forms.Button();
            this.yenidenSecBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.ObjectsGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cevreRBT);
            this.groupBox1.Controls.Add(this.alanRBT);
            this.groupBox1.Controls.Add(this.hacimRBT);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(166, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 115);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hesaplayacağınız birim";
            // 
            // cevreRBT
            // 
            this.cevreRBT.AutoSize = true;
            this.cevreRBT.Location = new System.Drawing.Point(7, 25);
            this.cevreRBT.Name = "cevreRBT";
            this.cevreRBT.Size = new System.Drawing.Size(68, 24);
            this.cevreRBT.TabIndex = 2;
            this.cevreRBT.TabStop = true;
            this.cevreRBT.Text = "Çevre";
            this.cevreRBT.UseVisualStyleBackColor = true;
            this.cevreRBT.CheckedChanged += new System.EventHandler(this.cevreRBT_CheckedChanged);
            // 
            // alanRBT
            // 
            this.alanRBT.AutoSize = true;
            this.alanRBT.Location = new System.Drawing.Point(7, 73);
            this.alanRBT.Name = "alanRBT";
            this.alanRBT.Size = new System.Drawing.Size(59, 24);
            this.alanRBT.TabIndex = 1;
            this.alanRBT.Text = "Alan";
            this.alanRBT.UseVisualStyleBackColor = true;
            this.alanRBT.CheckedChanged += new System.EventHandler(this.alanRBT_CheckedChanged);
            // 
            // hacimRBT
            // 
            this.hacimRBT.AutoSize = true;
            this.hacimRBT.Location = new System.Drawing.Point(7, 50);
            this.hacimRBT.Name = "hacimRBT";
            this.hacimRBT.Size = new System.Drawing.Size(72, 24);
            this.hacimRBT.TabIndex = 0;
            this.hacimRBT.Text = "Hacim";
            this.hacimRBT.UseVisualStyleBackColor = true;
            this.hacimRBT.CheckedChanged += new System.EventHandler(this.hacimRBT_CheckedChanged);
            // 
            // ObjectsGroupBox
            // 
            this.ObjectsGroupBox.Controls.Add(this.dPrizmasiRBT);
            this.ObjectsGroupBox.Controls.Add(this.silindirRBT);
            this.ObjectsGroupBox.Controls.Add(this.kureRBT);
            this.ObjectsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ObjectsGroupBox.Location = new System.Drawing.Point(381, 30);
            this.ObjectsGroupBox.Name = "ObjectsGroupBox";
            this.ObjectsGroupBox.Size = new System.Drawing.Size(251, 115);
            this.ObjectsGroupBox.TabIndex = 2;
            this.ObjectsGroupBox.TabStop = false;
            this.ObjectsGroupBox.Text = "Objeler";
            // 
            // dPrizmasiRBT
            // 
            this.dPrizmasiRBT.AutoSize = true;
            this.dPrizmasiRBT.Location = new System.Drawing.Point(7, 86);
            this.dPrizmasiRBT.Name = "dPrizmasiRBT";
            this.dPrizmasiRBT.Size = new System.Drawing.Size(185, 24);
            this.dPrizmasiRBT.TabIndex = 2;
            this.dPrizmasiRBT.TabStop = true;
            this.dPrizmasiRBT.Text = "Dikdörtgenler Prizması";
            this.dPrizmasiRBT.UseVisualStyleBackColor = true;
            this.dPrizmasiRBT.CheckedChanged += new System.EventHandler(this.dPrizmasiRBT_CheckedChanged);
            // 
            // silindirRBT
            // 
            this.silindirRBT.AutoSize = true;
            this.silindirRBT.Location = new System.Drawing.Point(7, 56);
            this.silindirRBT.Name = "silindirRBT";
            this.silindirRBT.Size = new System.Drawing.Size(73, 24);
            this.silindirRBT.TabIndex = 1;
            this.silindirRBT.TabStop = true;
            this.silindirRBT.Text = "Silindir";
            this.silindirRBT.UseVisualStyleBackColor = true;
            this.silindirRBT.CheckedChanged += new System.EventHandler(this.silindirRBT_CheckedChanged);
            // 
            // kureRBT
            // 
            this.kureRBT.AutoSize = true;
            this.kureRBT.Location = new System.Drawing.Point(7, 26);
            this.kureRBT.Name = "kureRBT";
            this.kureRBT.Size = new System.Drawing.Size(60, 24);
            this.kureRBT.TabIndex = 0;
            this.kureRBT.TabStop = true;
            this.kureRBT.Text = "Küre";
            this.kureRBT.UseVisualStyleBackColor = true;
            this.kureRBT.CheckedChanged += new System.EventHandler(this.kureRBT_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(170, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ikinciKenarLabel);
            this.groupBox2.Controls.Add(this.yukseklikLabel);
            this.groupBox2.Controls.Add(this.yariCapLabel);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.ikinciKenarTextBox);
            this.groupBox2.Controls.Add(this.yukseklikTextBox);
            this.groupBox2.Controls.Add(this.yaricapTextBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(173, 211);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(459, 180);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Değerler";
            // 
            // ikinciKenarLabel
            // 
            this.ikinciKenarLabel.AutoSize = true;
            this.ikinciKenarLabel.Location = new System.Drawing.Point(147, 80);
            this.ikinciKenarLabel.Name = "ikinciKenarLabel";
            this.ikinciKenarLabel.Size = new System.Drawing.Size(64, 20);
            this.ikinciKenarLabel.TabIndex = 5;
            this.ikinciKenarLabel.Text = "2.Kenar";
            this.ikinciKenarLabel.Visible = false;
            // 
            // yukseklikLabel
            // 
            this.yukseklikLabel.AutoSize = true;
            this.yukseklikLabel.Location = new System.Drawing.Point(132, 51);
            this.yukseklikLabel.Name = "yukseklikLabel";
            this.yukseklikLabel.Size = new System.Drawing.Size(95, 20);
            this.yukseklikLabel.TabIndex = 4;
            this.yukseklikLabel.Text = "yükseklik (h)";
            // 
            // yariCapLabel
            // 
            this.yariCapLabel.AutoSize = true;
            this.yariCapLabel.Location = new System.Drawing.Point(140, 22);
            this.yariCapLabel.Name = "yariCapLabel";
            this.yariCapLabel.Size = new System.Drawing.Size(78, 20);
            this.yariCapLabel.TabIndex = 3;
            this.yariCapLabel.Text = "yarıçap (r)";
            // 
            // ikinciKenarTextBox
            // 
            this.ikinciKenarTextBox.Location = new System.Drawing.Point(248, 80);
            this.ikinciKenarTextBox.Name = "ikinciKenarTextBox";
            this.ikinciKenarTextBox.Size = new System.Drawing.Size(45, 26);
            this.ikinciKenarTextBox.TabIndex = 2;
            this.ikinciKenarTextBox.Visible = false;
            // 
            // yukseklikTextBox
            // 
            this.yukseklikTextBox.Location = new System.Drawing.Point(248, 48);
            this.yukseklikTextBox.Name = "yukseklikTextBox";
            this.yukseklikTextBox.Size = new System.Drawing.Size(45, 26);
            this.yukseklikTextBox.TabIndex = 1;
            // 
            // yaricapTextBox
            // 
            this.yaricapTextBox.Location = new System.Drawing.Point(248, 16);
            this.yaricapTextBox.Name = "yaricapTextBox";
            this.yaricapTextBox.Size = new System.Drawing.Size(45, 26);
            this.yaricapTextBox.TabIndex = 0;
            // 
            // onaylaBTN
            // 
            this.onaylaBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.onaylaBTN.Location = new System.Drawing.Point(253, 151);
            this.onaylaBTN.Name = "onaylaBTN";
            this.onaylaBTN.Size = new System.Drawing.Size(105, 41);
            this.onaylaBTN.TabIndex = 7;
            this.onaylaBTN.Text = "Onayla";
            this.onaylaBTN.UseVisualStyleBackColor = true;
            this.onaylaBTN.Click += new System.EventHandler(this.onaylaBTN_Click);
            // 
            // yenidenSecBTN
            // 
            this.yenidenSecBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yenidenSecBTN.Location = new System.Drawing.Point(364, 151);
            this.yenidenSecBTN.Name = "yenidenSecBTN";
            this.yenidenSecBTN.Size = new System.Drawing.Size(131, 41);
            this.yenidenSecBTN.TabIndex = 8;
            this.yenidenSecBTN.Text = "Yeniden Seç";
            this.yenidenSecBTN.UseVisualStyleBackColor = true;
            this.yenidenSecBTN.Click += new System.EventHandler(this.yenidenSecBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(630, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Coded and Designed By Arches";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yenidenSecBTN);
            this.Controls.Add(this.onaylaBTN);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ObjectsGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Arches hacim-alan-cevre Hesap";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ObjectsGroupBox.ResumeLayout(false);
            this.ObjectsGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton cevreRBT;
        private System.Windows.Forms.RadioButton alanRBT;
        private System.Windows.Forms.RadioButton hacimRBT;
        private System.Windows.Forms.GroupBox ObjectsGroupBox;
        private System.Windows.Forms.RadioButton silindirRBT;
        private System.Windows.Forms.RadioButton kureRBT;
        private System.Windows.Forms.RadioButton dPrizmasiRBT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label yukseklikLabel;
        private System.Windows.Forms.Label yariCapLabel;
        private System.Windows.Forms.TextBox ikinciKenarTextBox;
        private System.Windows.Forms.TextBox yukseklikTextBox;
        private System.Windows.Forms.TextBox yaricapTextBox;
        private System.Windows.Forms.Label ikinciKenarLabel;
        private System.Windows.Forms.Button onaylaBTN;
        private System.Windows.Forms.Button yenidenSecBTN;
        private System.Windows.Forms.Label label1;
    }
}

