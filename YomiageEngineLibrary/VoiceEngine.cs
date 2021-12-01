using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yomiage.SDK;
using Yomiage.SDK.Talk;
using Yomiage.SDK.VoiceEffects;

namespace YomiageEngineLibrary
{
    public class VoiceEngine : VoiceEngineBase
    {
        public override async Task<double[]> Play(VoiceConfig mainVoice, VoiceConfig subVoice, TalkScript talkScript, MasterEffectValue masterEffect, Action<int> setSamplingRate_Hz)
        {
            return await base.Play(mainVoice, subVoice, talkScript, masterEffect, setSamplingRate_Hz);
        }
    }
}
