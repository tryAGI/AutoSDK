//HintName: G.Models.TraceVisibilityMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Included only in responses
    /// </summary>
    public enum TraceVisibilityMode
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
    public static class TraceVisibilityModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TraceVisibilityMode value)
        {
            return value switch
            {
                TraceVisibilityMode.Default => "default",
                TraceVisibilityMode.Hidden => "hidden",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TraceVisibilityMode? ToEnum(string value)
        {
            return value switch
            {
                "default" => TraceVisibilityMode.Default,
                "hidden" => TraceVisibilityMode.Hidden,
                _ => null,
            };
        }
    }
}