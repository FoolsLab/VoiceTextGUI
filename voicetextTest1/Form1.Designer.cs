namespace voicetextTest1
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.tb_APIKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_sentense = new System.Windows.Forms.TextBox();
            this.btn_speech = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_speaker = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_emotion = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbar_emotionLv = new System.Windows.Forms.TrackBar();
            this.tbar_pitch = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbar_spd = new System.Windows.Forms.TrackBar();
            this.tbar_vol = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_emotionLv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_pitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_spd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_vol)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_APIKey
            // 
            this.tb_APIKey.Location = new System.Drawing.Point(128, 6);
            this.tb_APIKey.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_APIKey.Name = "tb_APIKey";
            this.tb_APIKey.Size = new System.Drawing.Size(357, 35);
            this.tb_APIKey.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "API Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sentense:";
            // 
            // tb_sentense
            // 
            this.tb_sentense.Location = new System.Drawing.Point(12, 91);
            this.tb_sentense.Multiline = true;
            this.tb_sentense.Name = "tb_sentense";
            this.tb_sentense.Size = new System.Drawing.Size(473, 385);
            this.tb_sentense.TabIndex = 3;
            // 
            // btn_speech
            // 
            this.btn_speech.Location = new System.Drawing.Point(350, 49);
            this.btn_speech.Name = "btn_speech";
            this.btn_speech.Size = new System.Drawing.Size(135, 35);
            this.btn_speech.TabIndex = 4;
            this.btn_speech.Text = "Speech";
            this.btn_speech.UseVisualStyleBackColor = true;
            this.btn_speech.Click += new System.EventHandler(this.btn_speech_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 505);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Speaker";
            // 
            // cb_speaker
            // 
            this.cb_speaker.FormattingEnabled = true;
            this.cb_speaker.Items.AddRange(new object[] {
            "hikari",
            "haruka",
            "takeru",
            "show",
            "santa",
            "bear"});
            this.cb_speaker.Location = new System.Drawing.Point(195, 502);
            this.cb_speaker.Name = "cb_speaker";
            this.cb_speaker.Size = new System.Drawing.Size(178, 36);
            this.cb_speaker.TabIndex = 6;
            this.cb_speaker.Text = "hikari";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 547);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "emotion";
            // 
            // cb_emotion
            // 
            this.cb_emotion.FormattingEnabled = true;
            this.cb_emotion.Items.AddRange(new object[] {
            "-",
            "happiness",
            "anger",
            "sadness"});
            this.cb_emotion.Location = new System.Drawing.Point(195, 544);
            this.cb_emotion.Name = "cb_emotion";
            this.cb_emotion.Size = new System.Drawing.Size(178, 36);
            this.cb_emotion.TabIndex = 8;
            this.cb_emotion.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 593);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 28);
            this.label5.TabIndex = 9;
            this.label5.Text = "emotion_level";
            // 
            // tbar_emotionLv
            // 
            this.tbar_emotionLv.LargeChange = 1;
            this.tbar_emotionLv.Location = new System.Drawing.Point(185, 592);
            this.tbar_emotionLv.Maximum = 4;
            this.tbar_emotionLv.Minimum = 1;
            this.tbar_emotionLv.Name = "tbar_emotionLv";
            this.tbar_emotionLv.Size = new System.Drawing.Size(300, 69);
            this.tbar_emotionLv.TabIndex = 10;
            this.tbar_emotionLv.Value = 2;
            // 
            // tbar_pitch
            // 
            this.tbar_pitch.Location = new System.Drawing.Point(185, 645);
            this.tbar_pitch.Maximum = 200;
            this.tbar_pitch.Minimum = 50;
            this.tbar_pitch.Name = "tbar_pitch";
            this.tbar_pitch.Size = new System.Drawing.Size(300, 69);
            this.tbar_pitch.TabIndex = 12;
            this.tbar_pitch.TickFrequency = 10;
            this.tbar_pitch.Value = 100;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(109, 645);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 28);
            this.label6.TabIndex = 11;
            this.label6.Text = "pitch";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(99, 701);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 28);
            this.label7.TabIndex = 13;
            this.label7.Text = "speed";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(86, 764);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 28);
            this.label8.TabIndex = 15;
            this.label8.Text = "volume";
            // 
            // tbar_spd
            // 
            this.tbar_spd.Location = new System.Drawing.Point(185, 701);
            this.tbar_spd.Maximum = 200;
            this.tbar_spd.Minimum = 50;
            this.tbar_spd.Name = "tbar_spd";
            this.tbar_spd.Size = new System.Drawing.Size(300, 69);
            this.tbar_spd.TabIndex = 16;
            this.tbar_spd.TickFrequency = 10;
            this.tbar_spd.Value = 100;
            // 
            // tbar_vol
            // 
            this.tbar_vol.Location = new System.Drawing.Point(185, 764);
            this.tbar_vol.Maximum = 200;
            this.tbar_vol.Minimum = 50;
            this.tbar_vol.Name = "tbar_vol";
            this.tbar_vol.Size = new System.Drawing.Size(300, 69);
            this.tbar_vol.TabIndex = 17;
            this.tbar_vol.TickFrequency = 10;
            this.tbar_vol.Value = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 824);
            this.Controls.Add(this.tbar_vol);
            this.Controls.Add(this.tbar_spd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbar_pitch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbar_emotionLv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_emotion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_speaker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_speech);
            this.Controls.Add(this.tb_sentense);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_APIKey);
            this.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "VoiceText";
            ((System.ComponentModel.ISupportInitialize)(this.tbar_emotionLv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_pitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_spd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_vol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_APIKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_sentense;
        private System.Windows.Forms.Button btn_speech;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_speaker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_emotion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar tbar_emotionLv;
        private System.Windows.Forms.TrackBar tbar_pitch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar tbar_spd;
        private System.Windows.Forms.TrackBar tbar_vol;
    }
}

