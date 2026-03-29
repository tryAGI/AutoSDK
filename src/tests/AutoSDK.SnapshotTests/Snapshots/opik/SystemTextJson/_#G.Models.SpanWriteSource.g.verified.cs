//HintName: G.Models.SpanWriteSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SpanWriteSource
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
    public static class SpanWriteSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpanWriteSource value)
        {
            return value switch
            {
                SpanWriteSource.Experiment => "experiment",
                SpanWriteSource.Optimization => "optimization",
                SpanWriteSource.Playground => "playground",
                SpanWriteSource.Sdk => "sdk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpanWriteSource? ToEnum(string value)
        {
            return value switch
            {
                "experiment" => SpanWriteSource.Experiment,
                "optimization" => SpanWriteSource.Optimization,
                "playground" => SpanWriteSource.Playground,
                "sdk" => SpanWriteSource.Sdk,
                _ => null,
            };
        }
    }
}