//HintName: G.Models.LLMSchemaOverridePrompt.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Prompt override for the LLM. If not provided, the original schema description is used.
    /// </summary>
    public sealed partial class LLMSchemaOverridePrompt
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}