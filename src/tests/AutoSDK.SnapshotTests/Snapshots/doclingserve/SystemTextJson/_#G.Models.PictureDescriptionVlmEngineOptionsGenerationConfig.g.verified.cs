//HintName: G.Models.PictureDescriptionVlmEngineOptionsGenerationConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Generation configuration for text generation. Controls output length, sampling strategy, temperature, etc.<br/>
    /// Default Value: {"max_new_tokens":200,"do_sample":false}
    /// </summary>
    public sealed partial class PictureDescriptionVlmEngineOptionsGenerationConfig
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}