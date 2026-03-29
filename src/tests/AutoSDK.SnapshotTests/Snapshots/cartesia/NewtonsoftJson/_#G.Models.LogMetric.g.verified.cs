//HintName: G.Models.LogMetric.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LogMetric
    {
        /// <summary>
        /// The name of the metric.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The value of the metric.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public double Value { get; set; } = default!;

        /// <summary>
        /// The timestamp when the metric was received relative to the start of the call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timestamp", Required = global::Newtonsoft.Json.Required.Always)]
        public double Timestamp { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LogMetric" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the metric.
        /// </param>
        /// <param name="value">
        /// The value of the metric.
        /// </param>
        /// <param name="timestamp">
        /// The timestamp when the metric was received relative to the start of the call.
        /// </param>
        public LogMetric(
            string name,
            double value,
            double timestamp)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Value = value;
            this.Timestamp = timestamp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LogMetric" /> class.
        /// </summary>
        public LogMetric()
        {
        }
    }
}