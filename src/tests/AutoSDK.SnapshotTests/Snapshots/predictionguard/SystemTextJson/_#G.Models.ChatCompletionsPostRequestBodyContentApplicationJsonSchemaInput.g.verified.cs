//HintName: G.Models.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Options to affect the input of the request.
    /// </summary>
    public sealed partial class ChatCompletionsPostRequestBodyContentApplicationJsonSchemaInput
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
        public global::System.Collections.Generic.IList<global::G.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItems>? EntityList { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionsPostRequestBodyContentApplicationJsonSchemaInput" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionsPostRequestBodyContentApplicationJsonSchemaInput(
            bool? blockPromptInjection,
            string? pii,
            string? piiReplaceMethod,
            global::System.Collections.Generic.IList<global::G.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItems>? entityList)
        {
            this.BlockPromptInjection = blockPromptInjection;
            this.Pii = pii;
            this.PiiReplaceMethod = piiReplaceMethod;
            this.EntityList = entityList;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionsPostRequestBodyContentApplicationJsonSchemaInput" /> class.
        /// </summary>
        public ChatCompletionsPostRequestBodyContentApplicationJsonSchemaInput()
        {
        }
    }
}