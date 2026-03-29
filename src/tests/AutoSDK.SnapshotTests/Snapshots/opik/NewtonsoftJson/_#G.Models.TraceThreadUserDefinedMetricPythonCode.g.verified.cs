//HintName: G.Models.TraceThreadUserDefinedMetricPythonCode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TraceThreadUserDefinedMetricPythonCode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metric", Required = global::Newtonsoft.Json.Required.Always)]
        public string Metric { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TraceThreadUserDefinedMetricPythonCode" /> class.
        /// </summary>
        /// <param name="metric"></param>
        public TraceThreadUserDefinedMetricPythonCode(
            string metric)
        {
            this.Metric = metric ?? throw new global::System.ArgumentNullException(nameof(metric));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TraceThreadUserDefinedMetricPythonCode" /> class.
        /// </summary>
        public TraceThreadUserDefinedMetricPythonCode()
        {
        }
    }
}