//HintName: G.Models.TextToSpeechProvidersMicrosoftType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TextToSpeechProvidersMicrosoftType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="microsoft")]
        Microsoft,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextToSpeechProvidersMicrosoftTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextToSpeechProvidersMicrosoftType value)
        {
            return value switch
            {
                TextToSpeechProvidersMicrosoftType.Microsoft => "microsoft",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextToSpeechProvidersMicrosoftType? ToEnum(string value)
        {
            return value switch
            {
                "microsoft" => TextToSpeechProvidersMicrosoftType.Microsoft,
                _ => null,
            };
        }
    }
}