//HintName: G.Models.ExpressiveAvatarExpressionDtoVariant1VoiceGoogleType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ExpressiveAvatarExpressionDtoVariant1VoiceGoogleType
    {
        /// <summary>
        /// 
        /// </summary>
        Google,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExpressiveAvatarExpressionDtoVariant1VoiceGoogleTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExpressiveAvatarExpressionDtoVariant1VoiceGoogleType value)
        {
            return value switch
            {
                ExpressiveAvatarExpressionDtoVariant1VoiceGoogleType.Google => "google",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExpressiveAvatarExpressionDtoVariant1VoiceGoogleType? ToEnum(string value)
        {
            return value switch
            {
                "google" => ExpressiveAvatarExpressionDtoVariant1VoiceGoogleType.Google,
                _ => null,
            };
        }
    }
}