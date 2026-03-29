//HintName: G.Models.DetectorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DetectorType
    {
        /// <summary>
        /// 
        /// </summary>
        NightfallDetector,
        /// <summary>
        /// 
        /// </summary>
        Regex,
        /// <summary>
        /// 
        /// </summary>
        WordList,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DetectorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DetectorType value)
        {
            return value switch
            {
                DetectorType.NightfallDetector => "NIGHTFALL_DETECTOR",
                DetectorType.Regex => "REGEX",
                DetectorType.WordList => "WORD_LIST",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DetectorType? ToEnum(string value)
        {
            return value switch
            {
                "NIGHTFALL_DETECTOR" => DetectorType.NightfallDetector,
                "REGEX" => DetectorType.Regex,
                "WORD_LIST" => DetectorType.WordList,
                _ => null,
            };
        }
    }
}