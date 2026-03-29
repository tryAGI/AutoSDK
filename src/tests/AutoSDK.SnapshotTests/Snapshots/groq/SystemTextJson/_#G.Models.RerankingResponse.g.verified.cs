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
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.RerankingResult> Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankingResponse" /> class.
        /// </summary>
        /// <param name="results">
        /// List of documents sorted by relevance score in descending order.<br/>
        /// Each result contains the original document text and its relevance score.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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