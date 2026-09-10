//HintName: G.Models.ModelVerbosity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ModelVerbosity
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
        Medium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelVerbosityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelVerbosity value)
        {
            return value switch
            {
                ModelVerbosity.High => "high",
                ModelVerbosity.Low => "low",
                ModelVerbosity.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelVerbosity? ToEnum(string value)
        {
            return value switch
            {
                "high" => ModelVerbosity.High,
                "low" => ModelVerbosity.Low,
                "medium" => ModelVerbosity.Medium,
                _ => null,
            };
        }
    }
}