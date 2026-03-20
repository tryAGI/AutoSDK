//HintName: G.Models.TTSModelFamily.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TTSModelFamily
    {
        /// <summary>
        /// Deprecated: Use flash instead.
        /// </summary>
        Turbo,
        /// <summary>
        /// 
        /// </summary>
        Flash,
        /// <summary>
        /// 
        /// </summary>
        Multilingual,
        /// <summary>
        /// 
        /// </summary>
        V3Conversational,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TTSModelFamilyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TTSModelFamily value)
        {
            return value switch
            {
                TTSModelFamily.Turbo => "turbo",
                TTSModelFamily.Flash => "flash",
                TTSModelFamily.Multilingual => "multilingual",
                TTSModelFamily.V3Conversational => "v3_conversational",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TTSModelFamily? ToEnum(string value)
        {
            return value switch
            {
                "turbo" => TTSModelFamily.Turbo,
                "flash" => TTSModelFamily.Flash,
                "multilingual" => TTSModelFamily.Multilingual,
                "v3_conversational" => TTSModelFamily.V3Conversational,
                _ => null,
            };
        }
    }
}