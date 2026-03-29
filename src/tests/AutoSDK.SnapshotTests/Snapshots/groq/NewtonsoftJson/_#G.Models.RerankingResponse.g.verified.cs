//HintName: G.Models.RerankingResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RerankingResponse
    {
        /// <summary>
        /// List of documents sorted by relevance score in descending order.<br/>
        /// Each result contains the original document text and its relevance score.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("results", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.RerankingResult> Results { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankingResponse" /> class.
        /// </summary>
        /// <param name="results">
        /// List of documents sorted by relevance score in descending order.<br/>
        /// Each result contains the original document text and its relevance score.
        /// </param>
        public RerankingResponse(
            global::System.Collections.Generic.IList<global::G.RerankingResult> results)
        {
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankingResponse" /> class.
        /// </summary>
        public RerankingResponse()
        {
        }
    }
}