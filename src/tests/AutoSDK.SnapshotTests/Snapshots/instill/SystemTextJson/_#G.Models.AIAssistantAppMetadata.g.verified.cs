//HintName: G.Models.AIAssistantAppMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// AIAssistantAppMetadata represents the metadata for the AI assistant app.
    /// </summary>
    public sealed partial class AIAssistantAppMetadata
    {
        /// <summary>
        /// The AI assistant app catalog uid.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("catalogUid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CatalogUid { get; set; }

        /// <summary>
        /// The AI assistant app top k.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topK")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TopK { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AIAssistantAppMetadata" /> class.
        /// </summary>
        /// <param name="catalogUid">
        /// The AI assistant app catalog uid.
        /// </param>
        /// <param name="topK">
        /// The AI assistant app top k.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public AIAssistantAppMetadata(
            string catalogUid,
            int topK)
        {
            this.CatalogUid = catalogUid ?? throw new global::System.ArgumentNullException(nameof(catalogUid));
            this.TopK = topK;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AIAssistantAppMetadata" /> class.
        /// </summary>
        public AIAssistantAppMetadata()
        {
        }
    }
}