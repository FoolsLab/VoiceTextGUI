using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Collections.Specialized;

namespace voicetextTest1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_speech_Click(object sender, EventArgs e)
        {
            var apikey = tb_APIKey.Text;
            var sentense = tb_sentense.Text;
            var speaker = cb_speaker.Text;

            var emotion = cb_emotion.Text;
            var emotionLv = tbar_emotionLv.Value;
            var pitch = tbar_pitch.Value;
            var spd = tbar_spd.Value;
            var volume = tbar_vol.Value;

            
            var url = "https://api.voicetext.jp/v1/tts";

            var client = new WebClient();

            {
                var namePassword = string.Format("{0}:", apikey);
                var chars = System.Text.Encoding.ASCII.GetBytes(namePassword);
                var base64 = Convert.ToBase64String(chars);
                client.Headers[HttpRequestHeader.Authorization] = "Basic " + base64;
            }

            var query = new NameValueCollection();
            query.Add("text", sentense);
            query.Add("speaker", speaker);

            if(emotion != "-")
            {
                query.Add("emotion", emotion);
                query.Add("emotion_level", emotionLv.ToString());
            }
            query.Add("pitch", pitch.ToString());
            query.Add("speed", spd.ToString());
            query.Add("volume", volume.ToString());

            try
            {
                var dat = client.UploadValues(url, query);

                File.WriteAllBytes("test.wav", dat);
                new System.Media.SoundPlayer(new MemoryStream(dat)).Play();
            }
            catch(WebException exception)
            {
                var stream = exception.Response.GetResponseStream();

                var buf = new byte[256];
                using (MemoryStream ms = new MemoryStream())
                {

                    while (true)
                    {
                        int read = stream.Read(buf, 0, buf.Length);

                        if (read > 0)
                        {
                            ms.Write(buf, 0, read);
                        }
                        else
                        {
                            break;
                        }
                    }
                    
                    MessageBox.Show(Encoding.ASCII.GetString(ms.ToArray()));
                }
            }
        }
    }
}
