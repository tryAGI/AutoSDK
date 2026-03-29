//HintName: G.Models.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceElevenLabsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceElevenLabsType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="elevenlabs")]
        Elevenlabs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceElevenLabsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceElevenLabsType value)
        {
            return value switch
            {
                PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceElevenLabsType.Elevenlabs => "elevenlabs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceElevenLabsType? ToEnum(string value)
        {
            return value switch
            {
                "elevenlabs" => PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceElevenLabsType.Elevenlabs,
                _ => null,
            };
        }
    }
}