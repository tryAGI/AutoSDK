//HintName: G.Models.TextToSpeechProvidersAmazonType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TextToSpeechProvidersAmazonType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="amazon")]
        Amazon,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextToSpeechProvidersAmazonTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextToSpeechProvidersAmazonType value)
        {
            return value switch
            {
                TextToSpeechProvidersAmazonType.Amazon => "amazon",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextToSpeechProvidersAmazonType? ToEnum(string value)
        {
            return value switch
            {
                "amazon" => TextToSpeechProvidersAmazonType.Amazon,
                _ => null,
            };
        }
    }
}