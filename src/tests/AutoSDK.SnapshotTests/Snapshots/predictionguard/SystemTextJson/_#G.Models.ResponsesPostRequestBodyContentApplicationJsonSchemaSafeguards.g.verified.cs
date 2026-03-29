//HintName: G.Models.ResponsesPostRequestBodyContentApplicationJsonSchemaSafeguards.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Safeguards to run on the request.
    /// </summary>
    public sealed partial class ResponsesPostRequestBodyContentApplicationJsonSchemaSafeguards
    {
        /// <summary>
        /// Set to true to detect prompt injection attacks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("block_prompt_injection")]
        public bool? BlockPromptInjection { get; set; }

        /// <summary>
        /// Set to either 'block' or 'replace'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pii")]
        public string? Pii { get; set; }

        /// <summary>
        /// Set to either 'random', 'fake', 'category', 'mask'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pii_replace_method")]
        public string? PiiReplaceMethod { get; set; }

        /// <summary>
        /// An array of entity types that the PII check should ignore.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity_list")]
        public global::System.Collections.Generic.IList<global::G.ResponsesPostRequestBodyContentApplicationJsonSchemaSafeguardsEntityListItems>? EntityList { get; set; }

        /// <summary>
        /// Set to true to turn on factuality processing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("factuality")]
        public bool? Factuality { get; set; }

        /// <summary>
        /// Set to true to turn on toxicity processing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toxicity")]
        public bool? Toxicity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesPostRequestBodyContentApplicationJsonSchemaSafeguards" /> class.
        /// </summary>
        /// <param name="blockPromptInjection">
        /// Set to true to detect prompt injection attacks.
        /// </param>
        /// <param name="pii">
        /// Set to either 'block' or 'replace'.
        /// </param>
        /// <param name="piiReplaceMethod">
        /// Set to either 'random', 'fake', 'category', 'mask'.
        /// </param>
        /// <param name="entityList">
        /// An array of entity types that the PII check should ignore.
        /// </param>
        /// <param name="factuality">
        /// Set to true to turn on factuality processing.
        /// </param>
        /// <param name="toxicity">
        /// Set to true to turn on toxicity processing.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesPostRequestBodyContentApplicationJsonSchemaSafeguards(
            bool? blockPromptInjection,
            string? pii,
            string? piiReplaceMethod,
            global::System.Collections.Generic.IList<global::G.ResponsesPostRequestBodyContentApplicationJsonSchemaSafeguardsEntityListItems>? entityList,
            bool? factuality,
            bool? toxicity)
        {
            this.BlockPromptInjection = blockPromptInjection;
            this.Pii = pii;
            this.PiiReplaceMethod = piiReplaceMethod;
            this.EntityList = entityList;
            this.Factuality = factuality;
            this.Toxicity = toxicity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesPostRequestBodyContentApplicationJsonSchemaSafeguards" /> class.
        /// </summary>
        public ResponsesPostRequestBodyContentApplicationJsonSchemaSafeguards()
        {
        }
    }
}