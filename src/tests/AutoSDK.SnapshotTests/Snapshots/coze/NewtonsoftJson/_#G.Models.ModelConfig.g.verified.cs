//HintName: G.Models.ModelConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_id")]
        public string? ModelId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelConfig" /> class.
        /// </summary>
        /// <param name="modelId"></param>
        public ModelConfig(
            string? modelId)
        {
            this.ModelId = modelId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelConfig" /> class.
        /// </summary>
        public ModelConfig()
        {
        }
    }
}