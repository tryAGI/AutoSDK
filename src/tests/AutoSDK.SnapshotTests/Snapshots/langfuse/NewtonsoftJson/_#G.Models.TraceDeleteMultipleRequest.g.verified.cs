//HintName: G.Models.TraceDeleteMultipleRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TraceDeleteMultipleRequest
    {
        /// <summary>
        /// List of trace IDs to delete
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("traceIds", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> TraceIds { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TraceDeleteMultipleRequest" /> class.
        /// </summary>
        /// <param name="traceIds">
        /// List of trace IDs to delete
        /// </param>
        public TraceDeleteMultipleRequest(
            global::System.Collections.Generic.IList<string> traceIds)
        {
            this.TraceIds = traceIds ?? throw new global::System.ArgumentNullException(nameof(traceIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TraceDeleteMultipleRequest" /> class.
        /// </summary>
        public TraceDeleteMultipleRequest()
        {
        }
    }
}