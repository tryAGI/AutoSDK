//HintName: G.Models.TracePublicSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TracePublicSource
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
    public static class TracePublicSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TracePublicSource value)
        {
            return value switch
            {
                TracePublicSource.Experiment => "experiment",
                TracePublicSource.Optimization => "optimization",
                TracePublicSource.Playground => "playground",
                TracePublicSource.Sdk => "sdk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TracePublicSource? ToEnum(string value)
        {
            return value switch
            {
                "experiment" => TracePublicSource.Experiment,
                "optimization" => TracePublicSource.Optimization,
                "playground" => TracePublicSource.Playground,
                "sdk" => TracePublicSource.Sdk,
                _ => null,
            };
        }
    }
}