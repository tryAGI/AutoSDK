//HintName: G.Models.GetPromptTemplateModelParameterOverrides.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Optional dictionary of model parameter overrides to use with the prompt template. This will override the parameters at runtime for the specified model and will try to make sure the model supports these parameters. For example, if you supply `maxOutputTokens` for OpenAI, it will be converted to `max_completion_tokens`.<br/>
    /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
    /// </summary>
    public sealed partial class GetPromptTemplateModelParameterOverrides
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}