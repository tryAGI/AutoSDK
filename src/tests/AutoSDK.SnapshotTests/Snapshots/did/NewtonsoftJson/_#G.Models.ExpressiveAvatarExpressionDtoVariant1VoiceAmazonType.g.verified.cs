//HintName: G.Models.ExpressiveAvatarExpressionDtoVariant1VoiceAmazonType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ExpressiveAvatarExpressionDtoVariant1VoiceAmazonType
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
    public static class ExpressiveAvatarExpressionDtoVariant1VoiceAmazonTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExpressiveAvatarExpressionDtoVariant1VoiceAmazonType value)
        {
            return value switch
            {
                ExpressiveAvatarExpressionDtoVariant1VoiceAmazonType.Amazon => "amazon",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExpressiveAvatarExpressionDtoVariant1VoiceAmazonType? ToEnum(string value)
        {
            return value switch
            {
                "amazon" => ExpressiveAvatarExpressionDtoVariant1VoiceAmazonType.Amazon,
                _ => null,
            };
        }
    }
}