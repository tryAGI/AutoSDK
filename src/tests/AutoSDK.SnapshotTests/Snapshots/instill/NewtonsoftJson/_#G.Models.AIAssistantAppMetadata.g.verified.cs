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
        [global::Newtonsoft.Json.JsonProperty("catalogUid", Required = global::Newtonsoft.Json.Required.Always)]
        public string CatalogUid { get; set; } = default!;

        /// <summary>
        /// The AI assistant app top k.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("topK", Required = global::Newtonsoft.Json.Required.Always)]
        public int TopK { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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