namespace 영상처리_공부자료
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.열기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.저장ToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.닫기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.닫기ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.닫기ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.영상처리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.이진화ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maxminBinaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roiareaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brightupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blockmaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reverseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.histogramViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.brightLUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basicStretchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equalizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.영상처리ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1078, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.열기ToolStripMenuItem,
            this.저장ToolStripMenuItem,
            this.닫기ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.닫기ToolStripMenuItem1,
            this.toolStripMenuItem3,
            this.닫기ToolStripMenuItem2});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.openToolStripMenuItem.Text = "파일";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // 열기ToolStripMenuItem
            // 
            this.열기ToolStripMenuItem.Name = "열기ToolStripMenuItem";
            this.열기ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.열기ToolStripMenuItem.Text = "열기";
            this.열기ToolStripMenuItem.Click += new System.EventHandler(this.열기ToolStripMenuItem_Click);
            // 
            // 저장ToolStripMenuItem
            // 
            this.저장ToolStripMenuItem.Name = "저장ToolStripMenuItem";
            this.저장ToolStripMenuItem.Size = new System.Drawing.Size(149, 6);
            // 
            // 닫기ToolStripMenuItem
            // 
            this.닫기ToolStripMenuItem.Name = "닫기ToolStripMenuItem";
            this.닫기ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.닫기ToolStripMenuItem.Text = "원본";
            this.닫기ToolStripMenuItem.Click += new System.EventHandler(this.닫기ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // 닫기ToolStripMenuItem1
            // 
            this.닫기ToolStripMenuItem1.Name = "닫기ToolStripMenuItem1";
            this.닫기ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.닫기ToolStripMenuItem1.Text = "저장";
            this.닫기ToolStripMenuItem1.Click += new System.EventHandler(this.닫기ToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(149, 6);
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // 닫기ToolStripMenuItem2
            // 
            this.닫기ToolStripMenuItem2.Name = "닫기ToolStripMenuItem2";
            this.닫기ToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.닫기ToolStripMenuItem2.Text = "닫기";
            this.닫기ToolStripMenuItem2.Click += new System.EventHandler(this.닫기ToolStripMenuItem2_Click);
            // 
            // 영상처리ToolStripMenuItem
            // 
            this.영상처리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.이진화ToolStripMenuItem,
            this.binaryToolStripMenuItem,
            this.maxminBinaryToolStripMenuItem,
            this.roiareaToolStripMenuItem,
            this.brightupToolStripMenuItem,
            this.flowToolStripMenuItem,
            this.blockmaskToolStripMenuItem,
            this.borderToolStripMenuItem,
            this.reverseToolStripMenuItem,
            this.toolStripSeparator1,
            this.histogramViewToolStripMenuItem,
            this.brightLUTToolStripMenuItem,
            this.basicStretchToolStripMenuItem,
            this.equalizationToolStripMenuItem});
            this.영상처리ToolStripMenuItem.Name = "영상처리ToolStripMenuItem";
            this.영상처리ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.영상처리ToolStripMenuItem.Text = "영상처리";
            // 
            // 이진화ToolStripMenuItem
            // 
            this.이진화ToolStripMenuItem.Name = "이진화ToolStripMenuItem";
            this.이진화ToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.이진화ToolStripMenuItem.Text = "Gray";
            this.이진화ToolStripMenuItem.Click += new System.EventHandler(this.이진화ToolStripMenuItem_Click);
            // 
            // binaryToolStripMenuItem
            // 
            this.binaryToolStripMenuItem.Name = "binaryToolStripMenuItem";
            this.binaryToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.binaryToolStripMenuItem.Text = "Binary";
            this.binaryToolStripMenuItem.Click += new System.EventHandler(this.binaryToolStripMenuItem_Click);
            // 
            // maxminBinaryToolStripMenuItem
            // 
            this.maxminBinaryToolStripMenuItem.Name = "maxminBinaryToolStripMenuItem";
            this.maxminBinaryToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.maxminBinaryToolStripMenuItem.Text = "maxminBinary";
            this.maxminBinaryToolStripMenuItem.Click += new System.EventHandler(this.maxminBinaryToolStripMenuItem_Click);
            // 
            // roiareaToolStripMenuItem
            // 
            this.roiareaToolStripMenuItem.Name = "roiareaToolStripMenuItem";
            this.roiareaToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.roiareaToolStripMenuItem.Text = "roiarea";
            this.roiareaToolStripMenuItem.Click += new System.EventHandler(this.roiareaToolStripMenuItem_Click);
            // 
            // brightupToolStripMenuItem
            // 
            this.brightupToolStripMenuItem.Name = "brightupToolStripMenuItem";
            this.brightupToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.brightupToolStripMenuItem.Text = "brightup";
            this.brightupToolStripMenuItem.Click += new System.EventHandler(this.brightupToolStripMenuItem_Click);
            // 
            // flowToolStripMenuItem
            // 
            this.flowToolStripMenuItem.Name = "flowToolStripMenuItem";
            this.flowToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.flowToolStripMenuItem.Text = "flow";
            this.flowToolStripMenuItem.Click += new System.EventHandler(this.flowToolStripMenuItem_Click);
            // 
            // blockmaskToolStripMenuItem
            // 
            this.blockmaskToolStripMenuItem.Name = "blockmaskToolStripMenuItem";
            this.blockmaskToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.blockmaskToolStripMenuItem.Text = "block_mask";
            this.blockmaskToolStripMenuItem.Click += new System.EventHandler(this.blockmaskToolStripMenuItem_Click);
            // 
            // borderToolStripMenuItem
            // 
            this.borderToolStripMenuItem.Name = "borderToolStripMenuItem";
            this.borderToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.borderToolStripMenuItem.Text = "border";
            this.borderToolStripMenuItem.Click += new System.EventHandler(this.borderToolStripMenuItem_Click);
            // 
            // reverseToolStripMenuItem
            // 
            this.reverseToolStripMenuItem.Name = "reverseToolStripMenuItem";
            this.reverseToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.reverseToolStripMenuItem.Text = "reverse";
            this.reverseToolStripMenuItem.Click += new System.EventHandler(this.reverseToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(153, 6);
            // 
            // histogramViewToolStripMenuItem
            // 
            this.histogramViewToolStripMenuItem.Name = "histogramViewToolStripMenuItem";
            this.histogramViewToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.histogramViewToolStripMenuItem.Text = "histogram view";
            this.histogramViewToolStripMenuItem.Click += new System.EventHandler(this.histogramViewToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(315, 327);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(388, 27);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(308, 327);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(753, 27);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(308, 327);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // brightLUTToolStripMenuItem
            // 
            this.brightLUTToolStripMenuItem.Name = "brightLUTToolStripMenuItem";
            this.brightLUTToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.brightLUTToolStripMenuItem.Text = "bright_LUT";
            this.brightLUTToolStripMenuItem.Click += new System.EventHandler(this.brightLUTToolStripMenuItem_Click);
            // 
            // basicStretchToolStripMenuItem
            // 
            this.basicStretchToolStripMenuItem.Name = "basicStretchToolStripMenuItem";
            this.basicStretchToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.basicStretchToolStripMenuItem.Text = "basicStretch";
            this.basicStretchToolStripMenuItem.Click += new System.EventHandler(this.basicStretchToolStripMenuItem_Click);
            // 
            // equalizationToolStripMenuItem
            // 
            this.equalizationToolStripMenuItem.Name = "equalizationToolStripMenuItem";
            this.equalizationToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.equalizationToolStripMenuItem.Text = "equalization";
            this.equalizationToolStripMenuItem.Click += new System.EventHandler(this.equalizationToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 366);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 열기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator 저장ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 닫기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 닫기ToolStripMenuItem1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem 영상처리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 이진화ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem 닫기ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem maxminBinaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roiareaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem brightupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blockmaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borderToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem histogramViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reverseToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ToolStripMenuItem brightLUTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem basicStretchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equalizationToolStripMenuItem;
    }
}

