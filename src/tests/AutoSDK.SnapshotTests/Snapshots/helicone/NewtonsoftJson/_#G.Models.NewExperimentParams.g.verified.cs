//HintName: G.Models.NewExperimentParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NewExperimentParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("datasetId", Required = global::Newtonsoft.Json.Required.Always)]
        public string DatasetId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("promptVersion", Required = global::Newtonsoft.Json.Required.Always)]
        public string PromptVersion { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("providerKeyId", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProviderKeyId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("meta")]
        public object? Meta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NewExperimentParams" /> class.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="promptVersion"></param>
        /// <param name="model"></param>
        /// <param name="providerKeyId"></param>
        /// <param name="meta"></param>
        public NewExperimentParams(
            string datasetId,
            string promptVersion,
            string model,
            string providerKeyId,
            object? meta)
        {
            this.DatasetId = datasetId ?? throw new global::System.ArgumentNullException(nameof(datasetId));
            this.PromptVersion = promptVersion ?? throw new global::System.ArgumentNullException(nameof(promptVersion));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.ProviderKeyId = providerKeyId ?? throw new global::System.ArgumentNullException(nameof(providerKeyId));
            this.Meta = meta;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewExperimentParams" /> class.
        /// </summary>
        public NewExperimentParams()
        {
        }
    }
}