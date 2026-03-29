//HintName: G.Models.CompletionsPostRequestBodyContentApplicationJsonSchemaInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Options to affect the input of the request.
    /// </summary>
    public sealed partial class CompletionsPostRequestBodyContentApplicationJsonSchemaInput
    {
        /// <summary>
        /// Set to true to detect prompt injection attacks.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("block_prompt_injection")]
        public bool? BlockPromptInjection { get; set; }

        /// <summary>
        /// Set to either 'block' or 'replace'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pii")]
        public string? Pii { get; set; }

        /// <summary>
        /// Set to either 'random', 'fake', 'category', 'mask'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pii_replace_method")]
        public string? PiiReplaceMethod { get; set; }

        /// <summary>
        /// An array of entity types that the PII check should ignore.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("entity_list")]
        public global::System.Collections.Generic.IList<global::G.CompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItems>? EntityList { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionsPostRequestBodyContentApplicationJsonSchemaInput" /> class.
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
        public CompletionsPostRequestBodyContentApplicationJsonSchemaInput(
            bool? blockPromptInjection,
            string? pii,
            string? piiReplaceMethod,
            global::System.Collections.Generic.IList<global::G.CompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItems>? entityList)
        {
            this.BlockPromptInjection = blockPromptInjection;
            this.Pii = pii;
            this.PiiReplaceMethod = piiReplaceMethod;
            this.EntityList = entityList;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionsPostRequestBodyContentApplicationJsonSchemaInput" /> class.
        /// </summary>
        public CompletionsPostRequestBodyContentApplicationJsonSchemaInput()
        {
        }
    }
}