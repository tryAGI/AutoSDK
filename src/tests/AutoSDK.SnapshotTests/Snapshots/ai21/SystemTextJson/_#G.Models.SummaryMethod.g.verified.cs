//HintName: G.Models.SummaryMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An enumeration.
    /// </summary>
    public enum SummaryMethod
    {
        /// <summary>
        /// 
        /// </summary>
        FullDocument,
        /// <summary>
        /// 
        /// </summary>
        Guided,
        /// <summary>
        /// 
        /// </summary>
        Segments,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SummaryMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SummaryMethod value)
        {
            return value switch
            {
                SummaryMethod.FullDocument => "fullDocument",
                SummaryMethod.Guided => "guided",
                SummaryMethod.Segments => "segments",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SummaryMethod? ToEnum(string value)
        {
            return value switch
            {
                "fullDocument" => SummaryMethod.FullDocument,
                "guided" => SummaryMethod.Guided,
                "segments" => SummaryMethod.Segments,
                _ => null,
            };
        }
    }
}