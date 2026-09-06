//HintName: G.Models.ExtractJobCreatePriority.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ExtractJobCreatePriority
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
    public static class ExtractJobCreatePriorityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExtractJobCreatePriority value)
        {
            return value switch
            {
                ExtractJobCreatePriority.Critical => "critical",
                ExtractJobCreatePriority.High => "high",
                ExtractJobCreatePriority.Low => "low",
                ExtractJobCreatePriority.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExtractJobCreatePriority? ToEnum(string value)
        {
            return value switch
            {
                "critical" => ExtractJobCreatePriority.Critical,
                "high" => ExtractJobCreatePriority.High,
                "low" => ExtractJobCreatePriority.Low,
                "medium" => ExtractJobCreatePriority.Medium,
                _ => null,
            };
        }
    }
}