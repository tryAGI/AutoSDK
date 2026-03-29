//HintName: G.Models.ExpressiveAvatarExpressionPublicDtoVoiceGoogleType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ExpressiveAvatarExpressionPublicDtoVoiceGoogleType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="google")]
        Google,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExpressiveAvatarExpressionPublicDtoVoiceGoogleTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExpressiveAvatarExpressionPublicDtoVoiceGoogleType value)
        {
            return value switch
            {
                ExpressiveAvatarExpressionPublicDtoVoiceGoogleType.Google => "google",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExpressiveAvatarExpressionPublicDtoVoiceGoogleType? ToEnum(string value)
        {
            return value switch
            {
                "google" => ExpressiveAvatarExpressionPublicDtoVoiceGoogleType.Google,
                _ => null,
            };
        }
    }
}