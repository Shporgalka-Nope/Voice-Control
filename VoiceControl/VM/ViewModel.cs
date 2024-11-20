using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoiceControl.Model;

namespace VoiceControl.VM
{
    internal class ViewModel
    {
        VoiceRecognitionModel voice;
        public string result {  get; set; }
        public ViewModel() 
        {
            voice = new VoiceRecognitionModel();
        }
    }
}
