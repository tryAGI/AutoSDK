//HintName: G.Models.SpeechHistoryItemResponseModelSource2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SpeechHistoryItemResponseModelSource2
    {
        /// <summary>
        /// 
        /// </summary>
        An,
        /// <summary>
        /// 
        /// </summary>
        ConvAI,
        /// <summary>
        /// 
        /// </summary>
        Dubbing,
        /// <summary>
        /// 
        /// </summary>
        Pd,
        /// <summary>
        /// 
        /// </summary>
        PlayAPI,
        /// <summary>
        /// 
        /// </summary>
        Projects,
        /// <summary>
        /// 
        /// </summary>
        Sts,
        /// <summary>
        /// 
        /// </summary>
        Tts,
        /// <summary>
        /// 
        /// </summary>
        VoiceGeneration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeechHistoryItemResponseModelSource2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeechHistoryItemResponseModelSource2 value)
        {
            return value switch
            {
                SpeechHistoryItemResponseModelSource2.An => "AN",
                SpeechHistoryItemResponseModelSource2.ConvAI => "ConvAI",
                SpeechHistoryItemResponseModelSource2.Dubbing => "Dubbing",
                SpeechHistoryItemResponseModelSource2.Pd => "PD",
                SpeechHistoryItemResponseModelSource2.PlayAPI => "PlayAPI",
                SpeechHistoryItemResponseModelSource2.Projects => "Projects",
                SpeechHistoryItemResponseModelSource2.Sts => "STS",
                SpeechHistoryItemResponseModelSource2.Tts => "TTS",
                SpeechHistoryItemResponseModelSource2.VoiceGeneration => "VoiceGeneration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeechHistoryItemResponseModelSource2? ToEnum(string value)
        {
            return value switch
            {
                "AN" => SpeechHistoryItemResponseModelSource2.An,
                "ConvAI" => SpeechHistoryItemResponseModelSource2.ConvAI,
                "Dubbing" => SpeechHistoryItemResponseModelSource2.Dubbing,
                "PD" => SpeechHistoryItemResponseModelSource2.Pd,
                "PlayAPI" => SpeechHistoryItemResponseModelSource2.PlayAPI,
                "Projects" => SpeechHistoryItemResponseModelSource2.Projects,
                "STS" => SpeechHistoryItemResponseModelSource2.Sts,
                "TTS" => SpeechHistoryItemResponseModelSource2.Tts,
                "VoiceGeneration" => SpeechHistoryItemResponseModelSource2.VoiceGeneration,
                _ => null,
            };
        }
    }
}