//HintName: G.Models.ModelEffort2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ModelEffort2
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
    public static class ModelEffort2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelEffort2 value)
        {
            return value switch
            {
                ModelEffort2.High => "high",
                ModelEffort2.Low => "low",
                ModelEffort2.Max => "max",
                ModelEffort2.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelEffort2? ToEnum(string value)
        {
            return value switch
            {
                "high" => ModelEffort2.High,
                "low" => ModelEffort2.Low,
                "max" => ModelEffort2.Max,
                "medium" => ModelEffort2.Medium,
                _ => null,
            };
        }
    }
}