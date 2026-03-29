//HintName: G.Models.ListGuardrailsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListGuardrailsResponse
    {
        /// <summary>
        /// Array of guardrail summaries
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.GuardrailSummary> Data { get; set; }

        /// <summary>
        /// Total number of guardrails available
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Total { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListGuardrailsResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// Array of guardrail summaries
        /// </param>
        /// <param name="total">
        /// Total number of guardrails available
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListGuardrailsResponse(
            global::System.Collections.Generic.IList<global::G.GuardrailSummary> data,
            int total)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListGuardrailsResponse" /> class.
        /// </summary>
        public ListGuardrailsResponse()
        {
        }
    }
}