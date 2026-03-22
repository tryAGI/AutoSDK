//HintName: G.Models.GetSpeechHistorySource2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetSpeechHistorySource2
    {
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetSpeechHistorySource2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSpeechHistorySource2 value)
        {
            return value switch
            {
                GetSpeechHistorySource2.Sts => "STS",
                GetSpeechHistorySource2.Tts => "TTS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSpeechHistorySource2? ToEnum(string value)
        {
            return value switch
            {
                "STS" => GetSpeechHistorySource2.Sts,
                "TTS" => GetSpeechHistorySource2.Tts,
                _ => null,
            };
        }
    }
}