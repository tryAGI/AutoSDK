//HintName: G.Models.UpdatePresenterAttributesRequestVariant1VoiceGoogleType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdatePresenterAttributesRequestVariant1VoiceGoogleType
    {
        /// <summary>
        /// 
        /// </summary>
        Google,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdatePresenterAttributesRequestVariant1VoiceGoogleTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdatePresenterAttributesRequestVariant1VoiceGoogleType value)
        {
            return value switch
            {
                UpdatePresenterAttributesRequestVariant1VoiceGoogleType.Google => "google",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdatePresenterAttributesRequestVariant1VoiceGoogleType? ToEnum(string value)
        {
            return value switch
            {
                "google" => UpdatePresenterAttributesRequestVariant1VoiceGoogleType.Google,
                _ => null,
            };
        }
    }
}