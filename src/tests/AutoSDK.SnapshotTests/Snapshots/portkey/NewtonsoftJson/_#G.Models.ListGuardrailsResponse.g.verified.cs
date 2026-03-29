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
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GuardrailSummary> Data { get; set; } = default!;

        /// <summary>
        /// Total number of guardrails available
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total", Required = global::Newtonsoft.Json.Required.Always)]
        public int Total { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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