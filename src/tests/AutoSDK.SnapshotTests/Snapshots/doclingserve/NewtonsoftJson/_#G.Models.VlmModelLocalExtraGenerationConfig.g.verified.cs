//HintName: G.Models.VlmModelLocalExtraGenerationConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Config from https://huggingface.co/docs/transformers/en/main_classes/text_generation#transformers.GenerationConfig<br/>
    /// Default Value: {"max_new_tokens":800,"do_sample":false}
    /// </summary>
    public sealed partial class VlmModelLocalExtraGenerationConfig
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}