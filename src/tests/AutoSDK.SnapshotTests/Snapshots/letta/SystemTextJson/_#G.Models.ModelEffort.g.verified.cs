//HintName: G.Models.ModelEffort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ModelEffort
    {
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
        Max,
        /// <summary>
        /// 
        /// </summary>
        Medium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelEffort value)
        {
            return value switch
            {
                ModelEffort.High => "high",
                ModelEffort.Low => "low",
                ModelEffort.Max => "max",
                ModelEffort.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelEffort? ToEnum(string value)
        {
            return value switch
            {
                "high" => ModelEffort.High,
                "low" => ModelEffort.Low,
                "max" => ModelEffort.Max,
                "medium" => ModelEffort.Medium,
                _ => null,
            };
        }
    }
}