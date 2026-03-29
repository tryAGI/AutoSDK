//HintName: G.Models.SpanUserDefinedMetricPythonCodePublic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpanUserDefinedMetricPythonCodePublic
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metric", Required = global::Newtonsoft.Json.Required.Always)]
        public string Metric { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("arguments", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, string> Arguments { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpanUserDefinedMetricPythonCodePublic" /> class.
        /// </summary>
        /// <param name="metric"></param>
        /// <param name="arguments"></param>
        public SpanUserDefinedMetricPythonCodePublic(
            string metric,
            global::System.Collections.Generic.Dictionary<string, string> arguments)
        {
            this.Metric = metric ?? throw new global::System.ArgumentNullException(nameof(metric));
            this.Arguments = arguments ?? throw new global::System.ArgumentNullException(nameof(arguments));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpanUserDefinedMetricPythonCodePublic" /> class.
        /// </summary>
        public SpanUserDefinedMetricPythonCodePublic()
        {
        }
    }
}