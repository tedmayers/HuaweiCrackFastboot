namespace HuaweiCrackFastboot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.crack = new System.Windows.Forms.Button();
            this.status_box = new System.Windows.Forms.RichTextBox();
            this.start_num = new System.Windows.Forms.NumericUpDown();
            this.end_num = new System.Windows.Forms.NumericUpDown();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.adb_bootloader = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kill = new System.Windows.Forms.Button();
            this.currentCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.start_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.end_num)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // crack
            // 
            this.crack.AutoSize = true;
            this.crack.Location = new System.Drawing.Point(617, 338);
            this.crack.Name = "crack";
            this.crack.Size = new System.Drawing.Size(264, 73);
            this.crack.TabIndex = 0;
            this.crack.Text = "Crack";
            this.crack.UseVisualStyleBackColor = true;
            this.crack.Click += new System.EventHandler(this.button1_Click);
            // 
            // status_box
            // 
            this.status_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.status_box.Location = new System.Drawing.Point(12, 111);
            this.status_box.Name = "status_box";
            this.status_box.Size = new System.Drawing.Size(871, 221);
            this.status_box.TabIndex = 1;
            this.status_box.Text = "";
            // 
            // start_num
            // 
            this.start_num.Location = new System.Drawing.Point(53, 85);
            this.start_num.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.start_num.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.start_num.Name = "start_num";
            this.start_num.Size = new System.Drawing.Size(40, 20);
            this.start_num.TabIndex = 3;
            this.start_num.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.start_num.ValueChanged += new System.EventHandler(this.start_num_ValueChanged);
            // 
            // end_num
            // 
            this.end_num.Location = new System.Drawing.Point(140, 85);
            this.end_num.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.end_num.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.end_num.Name = "end_num";
            this.end_num.Size = new System.Drawing.Size(33, 20);
            this.end_num.TabIndex = 4;
            this.end_num.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.end_num.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(12, 338);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(599, 73);
            this.progress.TabIndex = 5;
            this.progress.Click += new System.EventHandler(this.progress_Click);
            // 
            // adb_bootloader
            // 
            this.adb_bootloader.Location = new System.Drawing.Point(12, 29);
            this.adb_bootloader.Name = "adb_bootloader";
            this.adb_bootloader.Size = new System.Drawing.Size(173, 50);
            this.adb_bootloader.TabIndex = 6;
            this.adb_bootloader.Text = "Reboot ADB Bootloader";
            this.adb_bootloader.UseVisualStyleBackColor = true;
            this.adb_bootloader.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(895, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Min:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(101, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Max:";
            // 
            // kill
            // 
            this.kill.Location = new System.Drawing.Point(191, 30);
            this.kill.Name = "kill";
            this.kill.Size = new System.Drawing.Size(167, 49);
            this.kill.TabIndex = 10;
            this.kill.Text = "Kill";
            this.kill.UseVisualStyleBackColor = true;
            this.kill.Click += new System.EventHandler(this.kill_Click);
            // 
            // currentCount
            // 
            this.currentCount.Location = new System.Drawing.Point(746, 84);
            this.currentCount.Name = "currentCount";
            this.currentCount.Size = new System.Drawing.Size(137, 20);
            this.currentCount.TabIndex = 11;
            this.currentCount.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(683, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Current:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 424);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.currentCount);
            this.Controls.Add(this.kill);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adb_bootloader);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.end_num);
            this.Controls.Add(this.start_num);
            this.Controls.Add(this.status_box);
            this.Controls.Add(this.crack);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Huawei OEM Brute Force Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.start_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.end_num)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button crack;
        private System.Windows.Forms.RichTextBox status_box;
        private System.Windows.Forms.NumericUpDown start_num;
        private System.Windows.Forms.NumericUpDown end_num;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Button adb_bootloader;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button kill;
        private System.Windows.Forms.TextBox currentCount;
        private System.Windows.Forms.Label label3;
    }
}

