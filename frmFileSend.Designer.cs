namespace IUH_Messenger
{
    partial class frmFileSend
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
            this.lstAddedFile = new System.Windows.Forms.ListView();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSearchPC = new System.Windows.Forms.Button();
            this.txtPCName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // lstAddedFile
            // 
            this.lstAddedFile.HideSelection = false;
            this.lstAddedFile.LargeImageList = this.imageList;
            this.lstAddedFile.Location = new System.Drawing.Point(12, 58);
            this.lstAddedFile.Name = "lstAddedFile";
            this.lstAddedFile.Size = new System.Drawing.Size(581, 103);
            this.lstAddedFile.SmallImageList = this.imageList;
            this.lstAddedFile.TabIndex = 0;
            this.lstAddedFile.UseCompatibleStateImageBehavior = false;
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(12, 167);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMsg.Size = new System.Drawing.Size(581, 207);
            this.txtMsg.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(507, 13);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 27);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "종료";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(293, 13);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(86, 27);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.Text = "파일추가";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSearchPC
            // 
            this.btnSearchPC.Location = new System.Drawing.Point(124, 13);
            this.btnSearchPC.Name = "btnSearchPC";
            this.btnSearchPC.Size = new System.Drawing.Size(86, 27);
            this.btnSearchPC.TabIndex = 4;
            this.btnSearchPC.Text = "PC 찾기";
            this.btnSearchPC.UseVisualStyleBackColor = true;
            // 
            // txtPCName
            // 
            this.txtPCName.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPCName.Location = new System.Drawing.Point(12, 13);
            this.txtPCName.Name = "txtPCName";
            this.txtPCName.Size = new System.Drawing.Size(106, 25);
            this.txtPCName.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(384, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 27);
            this.button1.TabIndex = 6;
            this.button1.Text = "전송";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // frmFileSend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(605, 386);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPCName);
            this.Controls.Add(this.btnSearchPC);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.lstAddedFile);
            this.Name = "frmFileSend";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "파일전송";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstAddedFile;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSearchPC;
        private System.Windows.Forms.TextBox txtPCName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList imageList;
    }
}

