namespace PID
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
            this.lbIP = new System.Windows.Forms.Label();
            this.lbPort = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lbP = new System.Windows.Forms.Label();
            this.lbI = new System.Windows.Forms.Label();
            this.lbD = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.tbContent = new System.Windows.Forms.TextBox();
            this.tbIp = new System.Windows.Forms.TextBox();
            this.tbP = new System.Windows.Forms.TextBox();
            this.tbI = new System.Windows.Forms.TextBox();
            this.tbD = new System.Windows.Forms.TextBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbIP
            // 
            this.lbIP.AutoSize = true;
            this.lbIP.Location = new System.Drawing.Point(12, 22);
            this.lbIP.Name = "lbIP";
            this.lbIP.Size = new System.Drawing.Size(24, 12);
            this.lbIP.TabIndex = 0;
            this.lbIP.Text = "IP :";
            // 
            // lbPort
            // 
            this.lbPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPort.AutoSize = true;
            this.lbPort.Location = new System.Drawing.Point(445, 22);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(35, 12);
            this.lbPort.TabIndex = 1;
            this.lbPort.Text = "Port :";
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnect.Location = new System.Drawing.Point(592, 19);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "연결";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lbP
            // 
            this.lbP.AutoSize = true;
            this.lbP.Location = new System.Drawing.Point(12, 73);
            this.lbP.Name = "lbP";
            this.lbP.Size = new System.Drawing.Size(21, 12);
            this.lbP.TabIndex = 3;
            this.lbP.Text = "P :";
            // 
            // lbI
            // 
            this.lbI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbI.AutoSize = true;
            this.lbI.Location = new System.Drawing.Point(238, 73);
            this.lbI.Name = "lbI";
            this.lbI.Size = new System.Drawing.Size(16, 12);
            this.lbI.TabIndex = 4;
            this.lbI.Text = "I :";
            // 
            // lbD
            // 
            this.lbD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbD.AutoSize = true;
            this.lbD.Location = new System.Drawing.Point(459, 73);
            this.lbD.Name = "lbD";
            this.lbD.Size = new System.Drawing.Size(21, 12);
            this.lbD.TabIndex = 5;
            this.lbD.Text = "D :";
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(592, 68);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "보내기";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // tbContent
            // 
            this.tbContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbContent.Location = new System.Drawing.Point(12, 110);
            this.tbContent.Multiline = true;
            this.tbContent.Name = "tbContent";
            this.tbContent.Size = new System.Drawing.Size(734, 283);
            this.tbContent.TabIndex = 7;
            // 
            // tbIp
            // 
            this.tbIp.Location = new System.Drawing.Point(56, 19);
            this.tbIp.Name = "tbIp";
            this.tbIp.Size = new System.Drawing.Size(100, 21);
            this.tbIp.TabIndex = 8;
            // 
            // tbP
            // 
            this.tbP.Location = new System.Drawing.Point(56, 70);
            this.tbP.Name = "tbP";
            this.tbP.Size = new System.Drawing.Size(100, 21);
            this.tbP.TabIndex = 9;
            // 
            // tbI
            // 
            this.tbI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbI.Location = new System.Drawing.Point(260, 70);
            this.tbI.Name = "tbI";
            this.tbI.Size = new System.Drawing.Size(100, 21);
            this.tbI.TabIndex = 10;
            // 
            // tbD
            // 
            this.tbD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbD.Location = new System.Drawing.Point(486, 70);
            this.tbD.Name = "tbD";
            this.tbD.Size = new System.Drawing.Size(100, 21);
            this.tbD.TabIndex = 11;
            // 
            // tbPort
            // 
            this.tbPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPort.Location = new System.Drawing.Point(486, 19);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(100, 21);
            this.tbPort.TabIndex = 12;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(673, 17);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 74);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 413);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.tbD);
            this.Controls.Add(this.tbI);
            this.Controls.Add(this.tbP);
            this.Controls.Add(this.tbIp);
            this.Controls.Add(this.tbContent);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lbD);
            this.Controls.Add(this.lbI);
            this.Controls.Add(this.lbP);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lbPort);
            this.Controls.Add(this.lbIP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbIP;
        private System.Windows.Forms.Label lbPort;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lbP;
        private System.Windows.Forms.Label lbI;
        private System.Windows.Forms.Label lbD;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tbContent;
        private System.Windows.Forms.TextBox tbIp;
        private System.Windows.Forms.TextBox tbP;
        private System.Windows.Forms.TextBox tbI;
        private System.Windows.Forms.TextBox tbD;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Button btnClear;
    }
}

