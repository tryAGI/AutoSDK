//HintName: G.Models.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceAmazonType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceAmazonType
    {
        /// <summary>
        /// 
        /// </summary>
        Amazon,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceAmazonTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceAmazonType value)
        {
            return value switch
            {
                PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceAmazonType.Amazon => "amazon",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceAmazonType? ToEnum(string value)
        {
            return value switch
            {
                "amazon" => PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceAmazonType.Amazon,
                _ => null,
            };
        }
    }
}