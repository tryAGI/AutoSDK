//HintName: G.Models.GuardrailsListGuardrailsResponse200.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GuardrailsListGuardrailsResponse200
    {
        /// <summary>
        /// List of guardrails
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.GuardrailsGetResponsesContentApplicationJsonSchemaDataItems> Data { get; set; }

        /// <summary>
        /// Total number of guardrails
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailsListGuardrailsResponse200" /> class.
        /// </summary>
        /// <param name="data">
        /// List of guardrails
        /// </param>
        /// <param name="totalCount">
        /// Total number of guardrails
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GuardrailsListGuardrailsResponse200(
            global::System.Collections.Generic.IList<global::G.GuardrailsGetResponsesContentApplicationJsonSchemaDataItems> data,
            double totalCount)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.TotalCount = totalCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailsListGuardrailsResponse200" /> class.
        /// </summary>
        public GuardrailsListGuardrailsResponse200()
        {
        }
    }
}