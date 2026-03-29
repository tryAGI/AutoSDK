//HintName: G.Models.ShotstackTextToSpeechOptionsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of asset to generate - set to `text-to-speech` for text-to-speech.<br/>
    /// Default Value: text-to-speech
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ShotstackTextToSpeechOptionsType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text-to-speech")]
        TextToSpeech,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ShotstackTextToSpeechOptionsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ShotstackTextToSpeechOptionsType value)
        {
            return value switch
            {
                ShotstackTextToSpeechOptionsType.TextToSpeech => "text-to-speech",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ShotstackTextToSpeechOptionsType? ToEnum(string value)
        {
            return value switch
            {
                "text-to-speech" => ShotstackTextToSpeechOptionsType.TextToSpeech,
                _ => null,
            };
        }
    }
}