//HintName: G.Models.TraceUpdateSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TraceUpdateSource
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
    public static class TraceUpdateSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TraceUpdateSource value)
        {
            return value switch
            {
                TraceUpdateSource.Experiment => "experiment",
                TraceUpdateSource.Optimization => "optimization",
                TraceUpdateSource.Playground => "playground",
                TraceUpdateSource.Sdk => "sdk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TraceUpdateSource? ToEnum(string value)
        {
            return value switch
            {
                "experiment" => TraceUpdateSource.Experiment,
                "optimization" => TraceUpdateSource.Optimization,
                "playground" => TraceUpdateSource.Playground,
                "sdk" => TraceUpdateSource.Sdk,
                _ => null,
            };
        }
    }
}