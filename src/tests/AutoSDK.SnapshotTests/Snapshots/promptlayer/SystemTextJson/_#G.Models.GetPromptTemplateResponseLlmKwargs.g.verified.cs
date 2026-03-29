//HintName: G.Models.GetPromptTemplateResponseLlmKwargs.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// When you optionally specify `provider` in the body, `llm_kwargs` will be returned for that specific provider and you can pass these kwargs to the provider's API directly. **Important:** This object's structure is provider-specific and may change without notice as LLM providers update their APIs. For stable, provider-agnostic prompt data, use `prompt_template` instead.
    /// </summary>
    public sealed partial class GetPromptTemplateResponseLlmKwargs
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}