//HintName: G.Models.TTSRequestVoiceSpecifierMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TTSRequestVoiceSpecifierMode
    {
        /// <summary>
        /// 
        /// </summary>
        Id,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TTSRequestVoiceSpecifierModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TTSRequestVoiceSpecifierMode value)
        {
            return value switch
            {
                TTSRequestVoiceSpecifierMode.Id => "id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TTSRequestVoiceSpecifierMode? ToEnum(string value)
        {
            return value switch
            {
                "id" => TTSRequestVoiceSpecifierMode.Id,
                _ => null,
            };
        }
    }
}