//HintName: G.Models.SpanUpdateSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SpanUpdateSource
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
    public static class SpanUpdateSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpanUpdateSource value)
        {
            return value switch
            {
                SpanUpdateSource.Experiment => "experiment",
                SpanUpdateSource.Optimization => "optimization",
                SpanUpdateSource.Playground => "playground",
                SpanUpdateSource.Sdk => "sdk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpanUpdateSource? ToEnum(string value)
        {
            return value switch
            {
                "experiment" => SpanUpdateSource.Experiment,
                "optimization" => SpanUpdateSource.Optimization,
                "playground" => SpanUpdateSource.Playground,
                "sdk" => SpanUpdateSource.Sdk,
                _ => null,
            };
        }
    }
}