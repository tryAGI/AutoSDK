//HintName: G.Models.FindSimilarResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FindSimilarResponse
    {
        /// <summary>
        /// Unique identifier for the request<br/>
        /// Example: c6958155d5c89ffa0663b7c90c407396
        /// </summary>
        /// <example>c6958155d5c89ffa0663b7c90c407396</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestId")]
        public string? RequestId { get; set; }

        /// <summary>
        /// A formatted string of the search results ready for LLMs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public string? Context { get; set; }

        /// <summary>
        /// A list of search results containing title, URL, published date, author, and score.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        public global::System.Collections.Generic.IList<global::G.ResultWithContent>? Results { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("costDollars")]
        public global::G.CostDollars? CostDollars { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FindSimilarResponse" /> class.
        /// </summary>
        /// <param name="requestId">
        /// Unique identifier for the request<br/>
        /// Example: c6958155d5c89ffa0663b7c90c407396
        /// </param>
        /// <param name="context">
        /// A formatted string of the search results ready for LLMs.
        /// </param>
        /// <param name="results">
        /// A list of search results containing title, URL, published date, author, and score.
        /// </param>
        /// <param name="costDollars"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FindSimilarResponse(
            string? requestId,
            string? context,
            global::System.Collections.Generic.IList<global::G.ResultWithContent>? results,
            global::G.CostDollars? costDollars)
        {
            this.RequestId = requestId;
            this.Context = context;
            this.Results = results;
            this.CostDollars = costDollars;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FindSimilarResponse" /> class.
        /// </summary>
        public FindSimilarResponse()
        {
        }
    }
}