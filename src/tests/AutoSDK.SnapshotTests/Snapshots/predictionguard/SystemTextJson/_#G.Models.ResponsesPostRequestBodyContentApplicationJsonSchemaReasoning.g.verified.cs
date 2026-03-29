//HintName: G.Models.ResponsesPostRequestBodyContentApplicationJsonSchemaReasoning.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Constrains effort on reasoning for reasoning models.
    /// </summary>
    public sealed partial class ResponsesPostRequestBodyContentApplicationJsonSchemaReasoning
    {
        /// <summary>
        /// Effort level for reasoning, currently supported values are `low`, `medium`, and `high`. Reducing reasoning effort can result in faster responses and fewer tokens used on reasoning in a response. Only supported by reasoning models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effort")]
        public string? Effort { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesPostRequestBodyContentApplicationJsonSchemaReasoning" /> class.
        /// </summary>
        /// <param name="effort">
        /// Effort level for reasoning, currently supported values are `low`, `medium`, and `high`. Reducing reasoning effort can result in faster responses and fewer tokens used on reasoning in a response. Only supported by reasoning models.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesPostRequestBodyContentApplicationJsonSchemaReasoning(
            string? effort)
        {
            this.Effort = effort;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesPostRequestBodyContentApplicationJsonSchemaReasoning" /> class.
        /// </summary>
        public ResponsesPostRequestBodyContentApplicationJsonSchemaReasoning()
        {
        }
    }
}