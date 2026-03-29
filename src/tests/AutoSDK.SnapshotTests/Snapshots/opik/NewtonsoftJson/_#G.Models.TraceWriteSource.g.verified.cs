//HintName: G.Models.TraceWriteSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TraceWriteSource
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
    public static class TraceWriteSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TraceWriteSource value)
        {
            return value switch
            {
                TraceWriteSource.Experiment => "experiment",
                TraceWriteSource.Optimization => "optimization",
                TraceWriteSource.Playground => "playground",
                TraceWriteSource.Sdk => "sdk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TraceWriteSource? ToEnum(string value)
        {
            return value switch
            {
                "experiment" => TraceWriteSource.Experiment,
                "optimization" => TraceWriteSource.Optimization,
                "playground" => TraceWriteSource.Playground,
                "sdk" => TraceWriteSource.Sdk,
                _ => null,
            };
        }
    }
}