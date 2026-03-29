//HintName: G.Models.ExperimentItemPublicTraceVisibilityMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Included only in responses
    /// </summary>
    public enum ExperimentItemPublicTraceVisibilityMode
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
    public static class ExperimentItemPublicTraceVisibilityModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExperimentItemPublicTraceVisibilityMode value)
        {
            return value switch
            {
                ExperimentItemPublicTraceVisibilityMode.Default => "default",
                ExperimentItemPublicTraceVisibilityMode.Hidden => "hidden",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExperimentItemPublicTraceVisibilityMode? ToEnum(string value)
        {
            return value switch
            {
                "default" => ExperimentItemPublicTraceVisibilityMode.Default,
                "hidden" => ExperimentItemPublicTraceVisibilityMode.Hidden,
                _ => null,
            };
        }
    }
}