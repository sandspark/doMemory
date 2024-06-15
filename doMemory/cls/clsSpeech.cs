using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;

namespace doMemory.cls
{
    public class clsSpeech
    {
        public SpeechSynthesizer speech = new SpeechSynthesizer();
        public int Volume = 100;
        public int rate = 1;
        public int pich = 0;
        public string text = "";
        public string language = "zh-CN";
        public Dictionary<string,object> voicels = new  Dictionary<string, object>();
        public bool isSpeek = false;
        public void initspeech()
        {
            // 设置语音音量
            speech.Volume = Volume;

            // 设置语音速度
            speech.Rate = rate;

            // 设置语音音调
            //speechTools.Pitch = 0;

            // 设置输出语音的语言
            voicels.Clear();
            foreach (InstalledVoice voice in speech.GetInstalledVoices())
            {
                VoiceInfo info = voice.VoiceInfo;
                voicels[info.Culture.ToString()]=info.Name;
            }
            // 例如: "en-US" 表示英语，"zh-CN" 表示中文
            //speech.SelectVoice("Microsoft Lili");//设置播音员（中文）
            //speech.SelectVoice("Microsoft Anna"); //英文
            if(voicels.ContainsKey(language))
                speech.SelectVoice(voicels[language].ToString());//设置播音员（中文）
            else
                speech.SelectVoice(voicels.Values.ToList()[0].ToString());//设置播音员（中文）

        }

        public void speechtext(string tlanguage = "zh-CN", string ttext = "我爱我的祖国")
        {
            if (isSpeek == false)
            {
                language = tlanguage;
                speech = new SpeechSynthesizer();
                language = tlanguage;
                if (voicels.ContainsKey(language))
                    speech.SelectVoice(voicels[language].ToString());//设置播音员（中文）
                else
                    speech.SelectVoice(voicels.Values.ToList()[0].ToString());//设置播音员（中文）
                text = ttext;
                new Thread(Speak).Start();
                speech.SpeakCompleted += speech_SpeakCompleted;//绑定事件
                isSpeek = true;
            }
        }

        private void Speak()
        {
            speech.SpeakAsync(text);//语音阅读方法
        }

        /// <summary>
        /// 语音阅读完成触发此事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void speech_SpeakCompleted(object sender, SpeakCompletedEventArgs e)
        {
            isSpeek = false ;
        }

        public void stopspeech()
        {
            speech.SpeakAsyncCancelAll();//停止阅读
        }

    }

    /*
      * public partial class Form1 : Form
        {
        private SpeechSynthesizer speech;

        /// <summary>
        /// 音量
        /// </summary>
        private int value=100;
        /// <summary>
        /// 语速
        /// </summary>
        private int rate;
        public Form1()
        {
        InitializeComponent();

        comboBox1.SelectedIndex = 10;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        string text=textBox1.Text;

        if (text.Trim().Length == 0) {
        MessageBox.Show("不能阅读空内容!","错误提示");
        return;
        }

        if (button1.Text == "语音试听") {

        speech = new SpeechSynthesizer();

        new Thread(Speak).Start();

        button1.Text = "停止试听";

        }else if(button1.Text=="停止试听"){

        speech.SpeakAsyncCancelAll();//停止阅读

        button1.Text = "语音试听";
        }
        }


        private void Speak() {

        speech.Rate =rate;
        speech.SelectVoice("Microsoft Lili");//设置播音员（中文）
        //speech.SelectVoice("Microsoft Anna"); //英文
        speech.Volume = value;
        speech.SpeakAsync(textBox1.Text);//语音阅读方法
        speech.SpeakCompleted += speech_SpeakCompleted;//绑定事件
        }

        /// <summary>
        /// 语音阅读完成触发此事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void speech_SpeakCompleted(object sender, SpeakCompletedEventArgs e)
        {
        button1.Text = "语音试听";
        }


        /// <summary>
        /// 拖动进度条事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
        //因为trackBar1的值为（0-10）之间而音量值为（0-100）所以要乘10；
        value = trackBar1.Value * 10;
        }

        private void button2_Click(object sender, EventArgs e)
        {



        string text = textBox1.Text;

        if (text.Trim().Length == 0)
        {
        MessageBox.Show("空内容无法生成!", "错误提示");
        return;
        }

        this.SaveFile(text);

        }

        /// <summary>
        /// 生成语音文件的方法
        /// </summary>
        /// <param name="text"></param>
        private void SaveFile(string text) {
        speech = new SpeechSynthesizer();
        var dialog = new SaveFileDialog();
        dialog.Filter = "*.wav|*.wav|*.mp3|*.mp3";
        dialog.ShowDialog();

        string path = dialog.FileName;
        if (path.Trim().Length == 0)
        {
        return;
        }
        speech.SetOutputToWaveFile(path);
        speech.Volume = value;
        speech.Rate = rate;
        speech.Speak(text);
        speech.SetOutputToNull();
        MessageBox.Show("生成成功!在" + path + "路径中！", "提示");

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        rate = Int32.Parse(comboBox1.Text);
        }

        private void 打开文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        this.ReadlocalFile();

        }

        /// <summary>
        /// 读取本地文本文件的方法
        /// </summary>
        private void ReadlocalFile() {
        var open = new OpenFileDialog();

        open.ShowDialog();

        //得到文件路径
        string path = open.FileName;

        if (path.Trim().Length == 0)
        {

        return;
        }

        var os = new StreamReader(path, Encoding.UTF8);
        string str = os.ReadToEnd();
        textBox1.Text = str;
        }
        private void 清空内容ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        textBox1.Text = "";
        }

        }
        }
     */
}
