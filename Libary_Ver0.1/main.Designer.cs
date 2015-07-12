namespace Libary_Ver0._1
{
    partial class main
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Image = new System.Windows.Forms.PictureBox();
            this.BSearch = new System.Windows.Forms.Button();
            this.Binsert = new System.Windows.Forms.Button();
            this.Mbinformation = new System.Windows.Forms.Button();
            this.Mbmanager = new System.Windows.Forms.Button();
            this.loan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Image)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Image
            // 
            this.Image.Image = ((System.Drawing.Image)(resources.GetObject("Image.Image")));
            this.Image.Location = new System.Drawing.Point(12, 12);
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(932, 441);
            this.Image.TabIndex = 0;
            this.Image.TabStop = false;
            this.Image.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BSearch
            // 
            this.BSearch.Location = new System.Drawing.Point(12, 459);
            this.BSearch.Name = "BSearch";
            this.BSearch.Size = new System.Drawing.Size(100, 73);
            this.BSearch.TabIndex = 1;
            this.BSearch.Text = "BookSearch";
            this.BSearch.UseVisualStyleBackColor = true;
            this.BSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // Binsert
            // 
            this.Binsert.Location = new System.Drawing.Point(118, 459);
            this.Binsert.Name = "Binsert";
            this.Binsert.Size = new System.Drawing.Size(100, 73);
            this.Binsert.TabIndex = 2;
            this.Binsert.Text = "BookInsert";
            this.Binsert.UseVisualStyleBackColor = true;
            this.Binsert.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Mbinformation
            // 
            this.Mbinformation.Location = new System.Drawing.Point(224, 459);
            this.Mbinformation.Name = "Mbinformation";
            this.Mbinformation.Size = new System.Drawing.Size(100, 73);
            this.Mbinformation.TabIndex = 3;
            this.Mbinformation.Text = "Membership Information";
            this.Mbinformation.UseVisualStyleBackColor = true;
            this.Mbinformation.Click += new System.EventHandler(this.Mbinformation_Click);
            // 
            // Mbmanager
            // 
            this.Mbmanager.Location = new System.Drawing.Point(330, 459);
            this.Mbmanager.Name = "Mbmanager";
            this.Mbmanager.Size = new System.Drawing.Size(100, 73);
            this.Mbmanager.TabIndex = 4;
            this.Mbmanager.Text = "Member manager";
            this.Mbmanager.UseVisualStyleBackColor = true;
            this.Mbmanager.Click += new System.EventHandler(this.Mbmanager_Click);
            // 
            // loan
            // 
            this.loan.Location = new System.Drawing.Point(436, 459);
            this.loan.Name = "loan";
            this.loan.Size = new System.Drawing.Size(100, 73);
            this.loan.TabIndex = 5;
            this.loan.Text = "check out";
            this.loan.UseVisualStyleBackColor = true;
            this.loan.Click += new System.EventHandler(this.loan_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 544);
            this.Controls.Add(this.loan);
            this.Controls.Add(this.Mbmanager);
            this.Controls.Add(this.Mbinformation);
            this.Controls.Add(this.Binsert);
            this.Controls.Add(this.BSearch);
            this.Controls.Add(this.Image);
            this.Name = "main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "main";
            this.Load += new System.EventHandler(this.main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox Image;
        private System.Windows.Forms.Button BSearch;
        private System.Windows.Forms.Button Binsert;
        private System.Windows.Forms.Button Mbinformation;
        private System.Windows.Forms.Button Mbmanager;
        private System.Windows.Forms.Button loan;
    }
}