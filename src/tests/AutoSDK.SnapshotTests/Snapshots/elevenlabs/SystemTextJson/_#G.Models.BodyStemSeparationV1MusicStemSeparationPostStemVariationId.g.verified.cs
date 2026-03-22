//HintName: G.Models.BodyStemSeparationV1MusicStemSeparationPostStemVariationId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The id of the stem variation to use.<br/>
    /// Default Value: six_stems_v1
    /// </summary>
    public enum BodyStemSeparationV1MusicStemSeparationPostStemVariationId
    {
        /// <summary>
        /// 
        /// </summary>
        SixStemsV1,
        /// <summary>
        /// 
        /// </summary>
        TwoStemsV1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BodyStemSeparationV1MusicStemSeparationPostStemVariationIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyStemSeparationV1MusicStemSeparationPostStemVariationId value)
        {
            return value switch
            {
                BodyStemSeparationV1MusicStemSeparationPostStemVariationId.SixStemsV1 => "six_stems_v1",
                BodyStemSeparationV1MusicStemSeparationPostStemVariationId.TwoStemsV1 => "two_stems_v1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyStemSeparationV1MusicStemSeparationPostStemVariationId? ToEnum(string value)
        {
            return value switch
            {
                "six_stems_v1" => BodyStemSeparationV1MusicStemSeparationPostStemVariationId.SixStemsV1,
                "two_stems_v1" => BodyStemSeparationV1MusicStemSeparationPostStemVariationId.TwoStemsV1,
                _ => null,
            };
        }
    }
}