//HintName: G.Models.ExperimentItemCompareTraceVisibilityMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Included only in responses
    /// </summary>
    public enum ExperimentItemCompareTraceVisibilityMode
    {
        /// <summary>
        /// 
        /// </summary>
        Default,
        /// <summary>
        /// 
        /// </summary>
        Hidden,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExperimentItemCompareTraceVisibilityModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExperimentItemCompareTraceVisibilityMode value)
        {
            return value switch
            {
                ExperimentItemCompareTraceVisibilityMode.Default => "default",
                ExperimentItemCompareTraceVisibilityMode.Hidden => "hidden",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExperimentItemCompareTraceVisibilityMode? ToEnum(string value)
        {
            return value switch
            {
                "default" => ExperimentItemCompareTraceVisibilityMode.Default,
                "hidden" => ExperimentItemCompareTraceVisibilityMode.Hidden,
                _ => null,
            };
        }
    }
}