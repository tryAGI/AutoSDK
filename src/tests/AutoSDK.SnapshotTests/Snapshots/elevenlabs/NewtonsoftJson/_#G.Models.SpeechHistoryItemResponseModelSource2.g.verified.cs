//HintName: G.Models.SpeechHistoryItemResponseModelSource2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SpeechHistoryItemResponseModelSource2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="TTS")]
        Tts,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STS")]
        Sts,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Projects")]
        Projects,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PD")]
        Pd,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="AN")]
        An,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Dubbing")]
        Dubbing,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PlayAPI")]
        PlayAPI,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ConvAI")]
        ConvAI,
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
                SpeechHistoryItemResponseModelSource2.Tts => "TTS",
                SpeechHistoryItemResponseModelSource2.Sts => "STS",
                SpeechHistoryItemResponseModelSource2.Projects => "Projects",
                SpeechHistoryItemResponseModelSource2.Pd => "PD",
                SpeechHistoryItemResponseModelSource2.An => "AN",
                SpeechHistoryItemResponseModelSource2.Dubbing => "Dubbing",
                SpeechHistoryItemResponseModelSource2.PlayAPI => "PlayAPI",
                SpeechHistoryItemResponseModelSource2.ConvAI => "ConvAI",
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
                "TTS" => SpeechHistoryItemResponseModelSource2.Tts,
                "STS" => SpeechHistoryItemResponseModelSource2.Sts,
                "Projects" => SpeechHistoryItemResponseModelSource2.Projects,
                "PD" => SpeechHistoryItemResponseModelSource2.Pd,
                "AN" => SpeechHistoryItemResponseModelSource2.An,
                "Dubbing" => SpeechHistoryItemResponseModelSource2.Dubbing,
                "PlayAPI" => SpeechHistoryItemResponseModelSource2.PlayAPI,
                "ConvAI" => SpeechHistoryItemResponseModelSource2.ConvAI,
                _ => null,
            };
        }
    }
}