//HintName: G.Models.BatchJobType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of batch processing operation.
    /// </summary>
    public enum BatchJobType
    {
        /// <summary>
        /// 
        /// </summary>
        Classify,
        /// <summary>
        /// 
        /// </summary>
        Extract,
        /// <summary>
        /// 
        /// </summary>
        Parse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BatchJobTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchJobType value)
        {
            return value switch
            {
                BatchJobType.Classify => "classify",
                BatchJobType.Extract => "extract",
                BatchJobType.Parse => "parse",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchJobType? ToEnum(string value)
        {
            return value switch
            {
                "classify" => BatchJobType.Classify,
                "extract" => BatchJobType.Extract,
                "parse" => BatchJobType.Parse,
                _ => null,
            };
        }
    }
}