//HintName: G.Models.UpdatePresenterAttributesRequestVariant1VoiceAmazonType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdatePresenterAttributesRequestVariant1VoiceAmazonType
    {
        /// <summary>
        /// 
        /// </summary>
        Amazon,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdatePresenterAttributesRequestVariant1VoiceAmazonTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdatePresenterAttributesRequestVariant1VoiceAmazonType value)
        {
            return value switch
            {
                UpdatePresenterAttributesRequestVariant1VoiceAmazonType.Amazon => "amazon",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdatePresenterAttributesRequestVariant1VoiceAmazonType? ToEnum(string value)
        {
            return value switch
            {
                "amazon" => UpdatePresenterAttributesRequestVariant1VoiceAmazonType.Amazon,
                _ => null,
            };
        }
    }
}