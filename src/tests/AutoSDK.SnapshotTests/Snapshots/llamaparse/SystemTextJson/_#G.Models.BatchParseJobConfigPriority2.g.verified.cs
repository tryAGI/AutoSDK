//HintName: G.Models.BatchParseJobConfigPriority2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BatchParseJobConfigPriority2
    {
        /// <summary>
        /// 
        /// </summary>
        Critical,
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        Medium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BatchParseJobConfigPriority2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchParseJobConfigPriority2 value)
        {
            return value switch
            {
                BatchParseJobConfigPriority2.Critical => "critical",
                BatchParseJobConfigPriority2.High => "high",
                BatchParseJobConfigPriority2.Low => "low",
                BatchParseJobConfigPriority2.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchParseJobConfigPriority2? ToEnum(string value)
        {
            return value switch
            {
                "critical" => BatchParseJobConfigPriority2.Critical,
                "high" => BatchParseJobConfigPriority2.High,
                "low" => BatchParseJobConfigPriority2.Low,
                "medium" => BatchParseJobConfigPriority2.Medium,
                _ => null,
            };
        }
    }
}