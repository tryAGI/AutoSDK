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
        [global::System.Text.Json.Serialization.JsonPropertyName("datasetId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DatasetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptVersion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerKeyId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProviderKeyId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        public object? Meta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NewExperimentParams" /> class.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="promptVersion"></param>
        /// <param name="model"></param>
        /// <param name="providerKeyId"></param>
        /// <param name="meta"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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