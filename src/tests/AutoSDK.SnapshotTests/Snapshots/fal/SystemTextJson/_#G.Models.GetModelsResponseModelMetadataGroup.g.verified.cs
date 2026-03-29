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
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// Human-readable group label
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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