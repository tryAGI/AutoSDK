//HintName: G.Models.DetectorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DetectorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="NIGHTFALL_DETECTOR")]
        NightfallDetector,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="REGEX")]
        Regex,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="WORD_LIST")]
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