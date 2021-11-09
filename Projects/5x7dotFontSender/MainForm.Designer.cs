﻿
namespace _5x7dotFontSender
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.tbxMessage = new System.Windows.Forms.TextBox();
            this.lblSendText = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.gbxTextSend = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblConnect = new System.Windows.Forms.Label();
            this.btnSerialOpen = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.gbxTextSend.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxMessage
            // 
            this.tbxMessage.Location = new System.Drawing.Point(6, 44);
            this.tbxMessage.Multiline = true;
            this.tbxMessage.Name = "tbxMessage";
            this.tbxMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxMessage.Size = new System.Drawing.Size(707, 160);
            this.tbxMessage.TabIndex = 3;
            // 
            // lblSendText
            // 
            this.lblSendText.AutoSize = true;
            this.lblSendText.Location = new System.Drawing.Point(6, 26);
            this.lblSendText.Name = "lblSendText";
            this.lblSendText.Size = new System.Drawing.Size(53, 12);
            this.lblSendText.TabIndex = 0;
            this.lblSendText.Text = "送信文字";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(638, 209);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "送　信";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // gbxTextSend
            // 
            this.gbxTextSend.Controls.Add(this.btnStop);
            this.gbxTextSend.Controls.Add(this.lblConnect);
            this.gbxTextSend.Controls.Add(this.btnSerialOpen);
            this.gbxTextSend.Controls.Add(this.btnClean);
            this.gbxTextSend.Controls.Add(this.lblSendText);
            this.gbxTextSend.Controls.Add(this.btnSend);
            this.gbxTextSend.Controls.Add(this.tbxMessage);
            this.gbxTextSend.Location = new System.Drawing.Point(12, 3);
            this.gbxTextSend.Name = "gbxTextSend";
            this.gbxTextSend.Size = new System.Drawing.Size(719, 240);
            this.gbxTextSend.TabIndex = 0;
            this.gbxTextSend.TabStop = false;
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(557, 209);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "送信停止";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblConnect
            // 
            this.lblConnect.AutoSize = true;
            this.lblConnect.Location = new System.Drawing.Point(82, 26);
            this.lblConnect.Name = "lblConnect";
            this.lblConnect.Size = new System.Drawing.Size(63, 12);
            this.lblConnect.TabIndex = 1;
            this.lblConnect.Text = "接続ポート: ";
            // 
            // btnSerialOpen
            // 
            this.btnSerialOpen.Location = new System.Drawing.Point(532, 11);
            this.btnSerialOpen.Name = "btnSerialOpen";
            this.btnSerialOpen.Size = new System.Drawing.Size(181, 23);
            this.btnSerialOpen.TabIndex = 2;
            this.btnSerialOpen.Text = "シリアルポートの選択";
            this.btnSerialOpen.UseVisualStyleBackColor = true;
            this.btnSerialOpen.Click += new System.EventHandler(this.btnSerialOpen_Click);
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(6, 209);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(75, 23);
            this.btnClean.TabIndex = 4;
            this.btnClean.Text = "文字消去";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 249);
            this.Controls.Add(this.gbxTextSend);
            this.Name = "MainForm";
            this.Text = "マイクロビットに5x7ドット文字を送信します";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gbxTextSend.ResumeLayout(false);
            this.gbxTextSend.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbxMessage;
        private System.Windows.Forms.Label lblSendText;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.GroupBox gbxTextSend;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnSerialOpen;
        private System.Windows.Forms.Label lblConnect;
        private System.Windows.Forms.Button btnStop;
    }
}
