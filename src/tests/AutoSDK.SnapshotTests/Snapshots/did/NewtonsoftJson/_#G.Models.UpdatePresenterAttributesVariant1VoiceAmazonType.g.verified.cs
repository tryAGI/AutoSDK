//HintName: G.Models.UpdatePresenterAttributesVariant1VoiceAmazonType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UpdatePresenterAttributesVariant1VoiceAmazonType
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
    public static class UpdatePresenterAttributesVariant1VoiceAmazonTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdatePresenterAttributesVariant1VoiceAmazonType value)
        {
            return value switch
            {
                UpdatePresenterAttributesVariant1VoiceAmazonType.Amazon => "amazon",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdatePresenterAttributesVariant1VoiceAmazonType? ToEnum(string value)
        {
            return value switch
            {
                "amazon" => UpdatePresenterAttributesVariant1VoiceAmazonType.Amazon,
                _ => null,
            };
        }
    }
}