//HintName: G.Models.GetContentsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetContentsResponse
    {
        /// <summary>
        /// Unique identifier for the request<br/>
        /// Example: e492118ccdedcba5088bfc4357a8a125
        /// </summary>
        /// <example>e492118ccdedcba5088bfc4357a8a125</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestId")]
        public string? RequestId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        public global::System.Collections.Generic.IList<global::G.ResultWithContent>? Results { get; set; }

        /// <summary>
        /// A formatted string of the search results ready for LLMs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public string? Context { get; set; }

        /// <summary>
        /// Status information for each requested URL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statuses")]
        public global::System.Collections.Generic.IList<global::G.GetContentsResponseStatuse>? Statuses { get; set; }

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
        /// Initializes a new instance of the <see cref="GetContentsResponse" /> class.
        /// </summary>
        /// <param name="requestId">
        /// Unique identifier for the request<br/>
        /// Example: e492118ccdedcba5088bfc4357a8a125
        /// </param>
        /// <param name="results"></param>
        /// <param name="context">
        /// A formatted string of the search results ready for LLMs.
        /// </param>
        /// <param name="statuses">
        /// Status information for each requested URL
        /// </param>
        /// <param name="costDollars"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetContentsResponse(
            string? requestId,
            global::System.Collections.Generic.IList<global::G.ResultWithContent>? results,
            string? context,
            global::System.Collections.Generic.IList<global::G.GetContentsResponseStatuse>? statuses,
            global::G.CostDollars? costDollars)
        {
            this.RequestId = requestId;
            this.Results = results;
            this.Context = context;
            this.Statuses = statuses;
            this.CostDollars = costDollars;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetContentsResponse" /> class.
        /// </summary>
        public GetContentsResponse()
        {
        }
    }
}