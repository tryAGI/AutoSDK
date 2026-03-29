//HintName: G.Models.SpanPublicSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SpanPublicSource
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
    public static class SpanPublicSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpanPublicSource value)
        {
            return value switch
            {
                SpanPublicSource.Experiment => "experiment",
                SpanPublicSource.Optimization => "optimization",
                SpanPublicSource.Playground => "playground",
                SpanPublicSource.Sdk => "sdk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpanPublicSource? ToEnum(string value)
        {
            return value switch
            {
                "experiment" => SpanPublicSource.Experiment,
                "optimization" => SpanPublicSource.Optimization,
                "playground" => SpanPublicSource.Playground,
                "sdk" => SpanPublicSource.Sdk,
                _ => null,
            };
        }
    }
}