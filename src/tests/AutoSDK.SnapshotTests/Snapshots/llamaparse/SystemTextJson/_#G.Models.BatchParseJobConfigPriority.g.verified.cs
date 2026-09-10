//HintName: G.Models.BatchParseJobConfigPriority.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BatchParseJobConfigPriority
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
    public static class BatchParseJobConfigPriorityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchParseJobConfigPriority value)
        {
            return value switch
            {
                BatchParseJobConfigPriority.Critical => "critical",
                BatchParseJobConfigPriority.High => "high",
                BatchParseJobConfigPriority.Low => "low",
                BatchParseJobConfigPriority.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchParseJobConfigPriority? ToEnum(string value)
        {
            return value switch
            {
                "critical" => BatchParseJobConfigPriority.Critical,
                "high" => BatchParseJobConfigPriority.High,
                "low" => BatchParseJobConfigPriority.Low,
                "medium" => BatchParseJobConfigPriority.Medium,
                _ => null,
            };
        }
    }
}