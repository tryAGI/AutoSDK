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
        /// 
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
                _ => null,
            };
        }
    }
}