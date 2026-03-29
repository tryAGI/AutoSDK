//HintName: G.Models.SpanExperimentItemBulkWriteViewSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SpanExperimentItemBulkWriteViewSource
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
    public static class SpanExperimentItemBulkWriteViewSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpanExperimentItemBulkWriteViewSource value)
        {
            return value switch
            {
                SpanExperimentItemBulkWriteViewSource.Experiment => "experiment",
                SpanExperimentItemBulkWriteViewSource.Optimization => "optimization",
                SpanExperimentItemBulkWriteViewSource.Playground => "playground",
                SpanExperimentItemBulkWriteViewSource.Sdk => "sdk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpanExperimentItemBulkWriteViewSource? ToEnum(string value)
        {
            return value switch
            {
                "experiment" => SpanExperimentItemBulkWriteViewSource.Experiment,
                "optimization" => SpanExperimentItemBulkWriteViewSource.Optimization,
                "playground" => SpanExperimentItemBulkWriteViewSource.Playground,
                "sdk" => SpanExperimentItemBulkWriteViewSource.Sdk,
                _ => null,
            };
        }
    }
}