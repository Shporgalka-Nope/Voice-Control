using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech;
using System.Speech.Recognition;
using System.Windows.Controls;

namespace VoiceControl.Model
{
    internal class VoiceRecognitionModel
    {
        public GrammarBuilder gb
        {
            get { return _gb; }
            set { _gb = value; }
        }
        private GrammarBuilder _gb;
        
        private SpeechRecognitionEngine sr;

        public VoiceRecognitionModel()
        {
            sr.SetInputToDefaultAudioDevice();
            gb.Append(new Choices("Left", "Right", "Up", "Down"));
            sr.UnloadAllGrammars();

        }

        public void AppendNewChoices(List<string> choices)
        {
            //TO-DO
        }
    }
}
