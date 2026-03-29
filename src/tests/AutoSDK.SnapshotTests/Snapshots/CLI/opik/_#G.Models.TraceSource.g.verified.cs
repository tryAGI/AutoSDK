//HintName: G.Models.TraceSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TraceSource
    {
        /// <summary>
        /// 
        /// </summary>
        Experiment,
        /// <summary>
        /// 
        /// </summary>
        Optimization,
        /// <summary>
        /// 
        /// </summary>
        Playground,
        /// <summary>
        /// 
        /// </summary>
        Sdk,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TraceSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TraceSource value)
        {
            return value switch
            {
                TraceSource.Experiment => "experiment",
                TraceSource.Optimization => "optimization",
                TraceSource.Playground => "playground",
                TraceSource.Sdk => "sdk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TraceSource? ToEnum(string value)
        {
            return value switch
            {
                "experiment" => TraceSource.Experiment,
                "optimization" => TraceSource.Optimization,
                "playground" => TraceSource.Playground,
                "sdk" => TraceSource.Sdk,
                _ => null,
            };
        }
    }
}