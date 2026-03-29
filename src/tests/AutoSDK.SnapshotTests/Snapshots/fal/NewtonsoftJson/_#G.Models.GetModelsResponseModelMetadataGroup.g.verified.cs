//HintName: G.Models.GetModelsResponseModelMetadataGroup.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Model group information (optional)
    /// </summary>
    public sealed partial class GetModelsResponseModelMetadataGroup
    {
        /// <summary>
        /// Group key identifier
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("key", Required = global::Newtonsoft.Json.Required.Always)]
        public string Key { get; set; } = default!;

        /// <summary>
        /// Human-readable group label
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("label", Required = global::Newtonsoft.Json.Required.Always)]
        public string Label { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModelsResponseModelMetadataGroup" /> class.
        /// </summary>
        /// <param name="key">
        /// Group key identifier
        /// </param>
        /// <param name="label">
        /// Human-readable group label
        /// </param>
        public GetModelsResponseModelMetadataGroup(
            string key,
            string label)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModelsResponseModelMetadataGroup" /> class.
        /// </summary>
        public GetModelsResponseModelMetadataGroup()
        {
        }
    }
}