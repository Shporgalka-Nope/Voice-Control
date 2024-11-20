using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Recognition;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using VoiceControl.Model;
using VoiceControl.VM;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace VoiceControl
{
    /// <summary>
    /// Логика взаимодействия для win_Main.xaml
    /// </summary>
    public partial class win_Main : Window
    {
        public static TextBlock tb_Process
        {
            get { return tb_Process; }
            set { tb_Process = value; }
        }
        VoiceRecognitionModel model;
        public win_Main()
        {
            InitializeComponent();
            tb_Process = tb_process;
            model = new VoiceRecognitionModel();
            model.sr.SpeechDetected += new EventHandler<SpeechDetectedEventArgs>(speechDetected);
        }

        public static void speechDetected(object sender, SpeechDetectedEventArgs e)
        {
            tb_Process.Text = "[Speech Detected]";

        }

    }
}
