//HintName: G.Models.ExpressiveAvatarExpressionPublicDtoVoiceMicrosoftType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ExpressiveAvatarExpressionPublicDtoVoiceMicrosoftType
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
    public static class ExpressiveAvatarExpressionPublicDtoVoiceMicrosoftTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExpressiveAvatarExpressionPublicDtoVoiceMicrosoftType value)
        {
            return value switch
            {
                ExpressiveAvatarExpressionPublicDtoVoiceMicrosoftType.Microsoft => "microsoft",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExpressiveAvatarExpressionPublicDtoVoiceMicrosoftType? ToEnum(string value)
        {
            return value switch
            {
                "microsoft" => ExpressiveAvatarExpressionPublicDtoVoiceMicrosoftType.Microsoft,
                _ => null,
            };
        }
    }
}