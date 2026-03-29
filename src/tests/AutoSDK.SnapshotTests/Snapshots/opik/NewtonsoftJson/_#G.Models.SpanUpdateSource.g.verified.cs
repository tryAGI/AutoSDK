//HintName: G.Models.SpanUpdateSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SpanUpdateSource
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="experiment")]
        Experiment,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="optimization")]
        Optimization,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="playground")]
        Playground,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sdk")]
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