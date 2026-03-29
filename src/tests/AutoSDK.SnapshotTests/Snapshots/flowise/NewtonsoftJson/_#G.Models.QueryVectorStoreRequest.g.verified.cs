//HintName: G.Models.QueryVectorStoreRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QueryVectorStoreRequest
    {
        /// <summary>
        /// Document Store ID<br/>
        /// Example: 603a7b51-ae7c-4b0a-8865-e454ed2f6766
        /// </summary>
        /// <example>603a7b51-ae7c-4b0a-8865-e454ed2f6766</example>
        [global::Newtonsoft.Json.JsonProperty("storeId", Required = global::Newtonsoft.Json.Required.Always)]
        public string StoreId { get; set; } = default!;

        /// <summary>
        /// Query to search for<br/>
        /// Example: What is the capital of France?
        /// </summary>
        /// <example>What is the capital of France?</example>
        [global::Newtonsoft.Json.JsonProperty("query", Required = global::Newtonsoft.Json.Required.Always)]
        public string Query { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryVectorStoreRequest" /> class.
        /// </summary>
        /// <param name="storeId">
        /// Document Store ID<br/>
        /// Example: 603a7b51-ae7c-4b0a-8865-e454ed2f6766
        /// </param>
        /// <param name="query">
        /// Query to search for<br/>
        /// Example: What is the capital of France?
        /// </param>
        public QueryVectorStoreRequest(
            string storeId,
            string query)
        {
            this.StoreId = storeId ?? throw new global::System.ArgumentNullException(nameof(storeId));
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryVectorStoreRequest" /> class.
        /// </summary>
        public QueryVectorStoreRequest()
        {
        }
    }
}