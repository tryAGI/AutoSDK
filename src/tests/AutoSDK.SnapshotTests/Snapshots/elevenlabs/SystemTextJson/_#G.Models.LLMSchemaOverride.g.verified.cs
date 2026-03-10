//HintName: G.Models.LLMSchemaOverride.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LLMSchemaOverride
    {
        /// <summary>
        /// Default Value: llm
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public string? Source { get; set; }

        /// <summary>
        /// Prompt override for the LLM. If not provided, the original schema description is used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMSchemaOverride" /> class.
        /// </summary>
        /// <param name="source">
        /// Default Value: llm
        /// </param>
        /// <param name="prompt">
        /// Prompt override for the LLM. If not provided, the original schema description is used.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LLMSchemaOverride(
            string? source,
            string? prompt)
        {
            this.Source = source;
            this.Prompt = prompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMSchemaOverride" /> class.
        /// </summary>
        public LLMSchemaOverride()
        {
        }
    }
}