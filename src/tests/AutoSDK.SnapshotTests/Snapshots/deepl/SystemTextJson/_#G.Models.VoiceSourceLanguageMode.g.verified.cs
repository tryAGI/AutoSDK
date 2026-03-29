//HintName: G.Models.VoiceSourceLanguageMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Controls how the source_language value is used.<br/>
    /// - `auto`: Treats source language as a hint; server can override<br/>
    /// - `fixed`: Treats source language as mandatory; server must use this language<br/>
    /// Default Value: auto<br/>
    /// Example: auto
    /// </summary>
    public enum VoiceSourceLanguageMode
    {
        /// <summary>
        /// Treats source language as a hint; server can override
        /// </summary>
        Auto,
        /// <summary>
        /// Treats source language as mandatory; server must use this language
        /// </summary>
        Fixed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoiceSourceLanguageModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceSourceLanguageMode value)
        {
            return value switch
            {
                VoiceSourceLanguageMode.Auto => "auto",
                VoiceSourceLanguageMode.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceSourceLanguageMode? ToEnum(string value)
        {
            return value switch
            {
                "auto" => VoiceSourceLanguageMode.Auto,
                "fixed" => VoiceSourceLanguageMode.Fixed,
                _ => null,
            };
        }
    }
}