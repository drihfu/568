namespace SocketSendString
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSend = new System.Windows.Forms.Button();
            this.textBoxShowTxtContent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.buttonChoiseFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.labelIp = new System.Windows.Forms.Label();
            this.textBoxIp = new System.Windows.Forms.TextBox();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(397, 318);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 0;
            this.buttonSend.Text = "发送";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.button_Click_SendTxt);
            // 
            // textBoxShowTxtContent
            // 
            this.textBoxShowTxtContent.Location = new System.Drawing.Point(29, 39);
            this.textBoxShowTxtContent.Multiline = true;
            this.textBoxShowTxtContent.Name = "textBoxShowTxtContent";
            this.textBoxShowTxtContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxShowTxtContent.Size = new System.Drawing.Size(462, 273);
            this.textBoxShowTxtContent.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "选择文件";
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Location = new System.Drawing.Point(84, 12);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.Size = new System.Drawing.Size(284, 21);
            this.textBoxFilePath.TabIndex = 3;
            // 
            // buttonChoiseFile
            // 
            this.buttonChoiseFile.Location = new System.Drawing.Point(397, 10);
            this.buttonChoiseFile.Name = "buttonChoiseFile";
            this.buttonChoiseFile.Size = new System.Drawing.Size(75, 23);
            this.buttonChoiseFile.TabIndex = 4;
            this.buttonChoiseFile.Text = "选择";
            this.buttonChoiseFile.UseVisualStyleBackColor = true;
            this.buttonChoiseFile.Click += new System.EventHandler(this.button_Click_ChoseFile);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // labelIp
            // 
            this.labelIp.AutoSize = true;
            this.labelIp.Location = new System.Drawing.Point(28, 323);
            this.labelIp.Name = "labelIp";
            this.labelIp.Size = new System.Drawing.Size(23, 12);
            this.labelIp.TabIndex = 5;
            this.labelIp.Text = "IP:";
            // 
            // textBoxIp
            // 
            this.textBoxIp.Location = new System.Drawing.Point(57, 320);
            this.textBoxIp.Name = "textBoxIp";
            this.textBoxIp.Size = new System.Drawing.Size(126, 21);
            this.textBoxIp.TabIndex = 6;
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(244, 320);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(53, 21);
            this.textBoxPort.TabIndex = 7;
            this.textBoxPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPort_KeyPress);
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(203, 323);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(35, 12);
            this.labelPort.TabIndex = 8;
            this.labelPort.Text = "Port:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 354);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.textBoxIp);
            this.Controls.Add(this.labelIp);
            this.Controls.Add(this.buttonChoiseFile);
            this.Controls.Add(this.textBoxFilePath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxShowTxtContent);
            this.Controls.Add(this.buttonSend);
            this.Name = "Form1";
            this.Text = "socket发送txt测试工具 —— by Su，2018年9月28日";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.TextBox textBoxShowTxtContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.Button buttonChoiseFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label labelIp;
        private System.Windows.Forms.TextBox textBoxIp;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Label labelPort;
    }
}

