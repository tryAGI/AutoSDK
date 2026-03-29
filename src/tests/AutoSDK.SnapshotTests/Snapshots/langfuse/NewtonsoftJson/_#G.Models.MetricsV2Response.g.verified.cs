//HintName: G.Models.MetricsV2Response.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MetricsV2Response
    {
        /// <summary>
        /// The metrics data. Each item in the list contains the metric values and dimensions requested in the query.<br/>
        /// Format varies based on the query parameters.<br/>
        /// Histograms will return an array with [lower, upper, height] tuples.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<object> Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricsV2Response" /> class.
        /// </summary>
        /// <param name="data">
        /// The metrics data. Each item in the list contains the metric values and dimensions requested in the query.<br/>
        /// Format varies based on the query parameters.<br/>
        /// Histograms will return an array with [lower, upper, height] tuples.
        /// </param>
        public MetricsV2Response(
            global::System.Collections.Generic.IList<object> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricsV2Response" /> class.
        /// </summary>
        public MetricsV2Response()
        {
        }
    }
}