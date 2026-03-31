//HintName: G.Models.TextScriptProviderElevenLabsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TextScriptProviderElevenLabsType
    {
        /// <summary>
        /// 
        /// </summary>
        Elevenlabs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextScriptProviderElevenLabsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextScriptProviderElevenLabsType value)
        {
            return value switch
            {
                TextScriptProviderElevenLabsType.Elevenlabs => "elevenlabs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextScriptProviderElevenLabsType? ToEnum(string value)
        {
            return value switch
            {
                "elevenlabs" => TextScriptProviderElevenLabsType.Elevenlabs,
                _ => null,
            };
        }
    }
}