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
        TTS,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STS")]
        STS,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Projects")]
        Projects,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PD")]
        PD,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="AN")]
        AN,
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
                SpeechHistoryItemResponseModelSource2.TTS => "TTS",
                SpeechHistoryItemResponseModelSource2.STS => "STS",
                SpeechHistoryItemResponseModelSource2.Projects => "Projects",
                SpeechHistoryItemResponseModelSource2.PD => "PD",
                SpeechHistoryItemResponseModelSource2.AN => "AN",
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
                "TTS" => SpeechHistoryItemResponseModelSource2.TTS,
                "STS" => SpeechHistoryItemResponseModelSource2.STS,
                "Projects" => SpeechHistoryItemResponseModelSource2.Projects,
                "PD" => SpeechHistoryItemResponseModelSource2.PD,
                "AN" => SpeechHistoryItemResponseModelSource2.AN,
                "Dubbing" => SpeechHistoryItemResponseModelSource2.Dubbing,
                "PlayAPI" => SpeechHistoryItemResponseModelSource2.PlayAPI,
                "ConvAI" => SpeechHistoryItemResponseModelSource2.ConvAI,
                _ => null,
            };
        }
    }
}