//HintName: G.Models.ExpressiveAvatarExpressionPublicDtoVoiceAmazonType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ExpressiveAvatarExpressionPublicDtoVoiceAmazonType
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
    public static class ExpressiveAvatarExpressionPublicDtoVoiceAmazonTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExpressiveAvatarExpressionPublicDtoVoiceAmazonType value)
        {
            return value switch
            {
                ExpressiveAvatarExpressionPublicDtoVoiceAmazonType.Amazon => "amazon",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExpressiveAvatarExpressionPublicDtoVoiceAmazonType? ToEnum(string value)
        {
            return value switch
            {
                "amazon" => ExpressiveAvatarExpressionPublicDtoVoiceAmazonType.Amazon,
                _ => null,
            };
        }
    }
}