//HintName: G.Models.SpeechModel2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The speech model to use for the transcription.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SpeechModel2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="best")]
        Best,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="nano")]
        Nano,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeechModel2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeechModel2 value)
        {
            return value switch
            {
                SpeechModel2.Best => "best",
                SpeechModel2.Nano => "nano",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeechModel2? ToEnum(string value)
        {
            return value switch
            {
                "best" => SpeechModel2.Best,
                "nano" => SpeechModel2.Nano,
                _ => null,
            };
        }
    }
}