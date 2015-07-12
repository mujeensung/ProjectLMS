namespace Libary_Ver0._1
{
    partial class Member
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
            this.id = new System.Windows.Forms.Label();
            this.insert = new System.Windows.Forms.Button();
            this.tbid = new System.Windows.Forms.TextBox();
            this.worid = new System.Windows.Forms.Label();
            this.tbname = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(117, 62);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(15, 12);
            this.id.TabIndex = 0;
            this.id.Text = "id";
            this.id.Click += new System.EventHandler(this.label1_Click);
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(214, 234);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(75, 23);
            this.insert.TabIndex = 1;
            this.insert.Text = "inset";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // tbid
            // 
            this.tbid.Location = new System.Drawing.Point(214, 59);
            this.tbid.Name = "tbid";
            this.tbid.Size = new System.Drawing.Size(100, 21);
            this.tbid.TabIndex = 2;
            // 
            // worid
            // 
            this.worid.AutoSize = true;
            this.worid.Location = new System.Drawing.Point(117, 118);
            this.worid.Name = "worid";
            this.worid.Size = new System.Drawing.Size(0, 12);
            this.worid.TabIndex = 3;
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(214, 174);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(100, 21);
            this.tbname.TabIndex = 6;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(117, 174);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(37, 12);
            this.name.TabIndex = 5;
            this.name.Text = "name";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(692, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(82, 20);
            this.toolStripMenuItem1.Text = "BookSearch";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuItem2.Text = "Insert";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(53, 20);
            this.toolStripMenuItem3.Text = "Delete";
            // 
            // Member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 349);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.name);
            this.Controls.Add(this.worid);
            this.Controls.Add(this.tbid);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.id);
            this.Name = "Member";
            this.Text = "Member";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.TextBox tbid;
        private System.Windows.Forms.Label worid;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
    }
}