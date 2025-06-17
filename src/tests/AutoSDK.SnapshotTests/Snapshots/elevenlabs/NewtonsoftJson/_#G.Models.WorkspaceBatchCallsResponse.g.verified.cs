//HintName: G.Models.WorkspaceBatchCallsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkspaceBatchCallsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("batch_calls", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.BatchCallResponse> BatchCalls { get; set; } = default!;

        /// <summary>
        /// The next document, used to paginate through the batch calls
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("next_doc")]
        public string? NextDoc { get; set; }

        /// <summary>
        /// Whether there are more batch calls to paginate through<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_more")]
        public bool? HasMore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceBatchCallsResponse" /> class.
        /// </summary>
        /// <param name="batchCalls"></param>
        /// <param name="nextDoc">
        /// The next document, used to paginate through the batch calls
        /// </param>
        /// <param name="hasMore">
        /// Whether there are more batch calls to paginate through<br/>
        /// Default Value: false
        /// </param>
        public WorkspaceBatchCallsResponse(
            global::System.Collections.Generic.IList<global::G.BatchCallResponse> batchCalls,
            string? nextDoc,
            bool? hasMore)
        {
            this.BatchCalls = batchCalls ?? throw new global::System.ArgumentNullException(nameof(batchCalls));
            this.NextDoc = nextDoc;
            this.HasMore = hasMore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceBatchCallsResponse" /> class.
        /// </summary>
        public WorkspaceBatchCallsResponse()
        {
        }
    }
}