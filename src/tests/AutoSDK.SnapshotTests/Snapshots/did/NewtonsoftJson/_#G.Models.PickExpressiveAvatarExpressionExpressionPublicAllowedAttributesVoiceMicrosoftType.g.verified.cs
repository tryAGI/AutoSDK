//HintName: G.Models.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceMicrosoftType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceMicrosoftType
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
    public static class PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceMicrosoftTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceMicrosoftType value)
        {
            return value switch
            {
                PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceMicrosoftType.Microsoft => "microsoft",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceMicrosoftType? ToEnum(string value)
        {
            return value switch
            {
                "microsoft" => PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceMicrosoftType.Microsoft,
                _ => null,
            };
        }
    }
}