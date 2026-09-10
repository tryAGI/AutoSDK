//HintName: G.Models.SpeechHistoryItemResponseModelSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SpeechHistoryItemResponseModelSource
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
    public static class SpeechHistoryItemResponseModelSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeechHistoryItemResponseModelSource value)
        {
            return value switch
            {
                SpeechHistoryItemResponseModelSource.An => "AN",
                SpeechHistoryItemResponseModelSource.ConvAI => "ConvAI",
                SpeechHistoryItemResponseModelSource.Dubbing => "Dubbing",
                SpeechHistoryItemResponseModelSource.Pd => "PD",
                SpeechHistoryItemResponseModelSource.PlayAPI => "PlayAPI",
                SpeechHistoryItemResponseModelSource.Projects => "Projects",
                SpeechHistoryItemResponseModelSource.Sts => "STS",
                SpeechHistoryItemResponseModelSource.Tts => "TTS",
                SpeechHistoryItemResponseModelSource.VoiceGeneration => "VoiceGeneration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeechHistoryItemResponseModelSource? ToEnum(string value)
        {
            return value switch
            {
                "AN" => SpeechHistoryItemResponseModelSource.An,
                "ConvAI" => SpeechHistoryItemResponseModelSource.ConvAI,
                "Dubbing" => SpeechHistoryItemResponseModelSource.Dubbing,
                "PD" => SpeechHistoryItemResponseModelSource.Pd,
                "PlayAPI" => SpeechHistoryItemResponseModelSource.PlayAPI,
                "Projects" => SpeechHistoryItemResponseModelSource.Projects,
                "STS" => SpeechHistoryItemResponseModelSource.Sts,
                "TTS" => SpeechHistoryItemResponseModelSource.Tts,
                "VoiceGeneration" => SpeechHistoryItemResponseModelSource.VoiceGeneration,
                _ => null,
            };
        }
    }
}