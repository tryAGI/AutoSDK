//HintName: G.Models.SpeechHistoryItemResponseModelSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The source of the history item. Either TTS (text to speech), STS (speech to text) or STT (speech to text).
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SpeechHistoryItemResponseModelSource
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
        [global::System.Runtime.Serialization.EnumMember(Value="STT")]
        STT,
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
                SpeechHistoryItemResponseModelSource.TTS => "TTS",
                SpeechHistoryItemResponseModelSource.STS => "STS",
                SpeechHistoryItemResponseModelSource.STT => "STT",
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
                "TTS" => SpeechHistoryItemResponseModelSource.TTS,
                "STS" => SpeechHistoryItemResponseModelSource.STS,
                "STT" => SpeechHistoryItemResponseModelSource.STT,
                _ => null,
            };
        }
    }
}