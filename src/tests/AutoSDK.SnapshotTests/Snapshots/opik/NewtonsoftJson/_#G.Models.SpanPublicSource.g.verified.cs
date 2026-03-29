//HintName: G.Models.SpanPublicSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SpanPublicSource
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