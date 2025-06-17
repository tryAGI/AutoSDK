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
        [global::System.Text.Json.Serialization.JsonPropertyName("batch_calls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.BatchCallResponse> BatchCalls { get; set; }

        /// <summary>
        /// The next document, used to paginate through the batch calls
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_doc")]
        public string? NextDoc { get; set; }

        /// <summary>
        /// Whether there are more batch calls to paginate through<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        public bool? HasMore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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