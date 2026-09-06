//HintName: G.Models.SpeechHistoryItemResponseModelSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SpeechHistoryItemResponseModelSource
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="AN")]
        An,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ConvAI")]
        ConvAI,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Dubbing")]
        Dubbing,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PD")]
        Pd,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PlayAPI")]
        PlayAPI,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Projects")]
        Projects,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STS")]
        Sts,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="TTS")]
        Tts,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="VoiceGeneration")]
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