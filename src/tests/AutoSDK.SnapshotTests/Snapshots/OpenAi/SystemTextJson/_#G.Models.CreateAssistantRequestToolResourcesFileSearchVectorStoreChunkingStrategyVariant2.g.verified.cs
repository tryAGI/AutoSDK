//HintName: G.Models.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2
    {
        /// <summary>
        /// Always `static`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2TypeJsonConverter))]
        public global::G.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("static")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2Static Static { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// Always `static`.
        /// </param>
        /// <param name="static"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2(
            global::G.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2Static @static,
            global::G.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2Type type)
        {
            this.Static = @static ?? throw new global::System.ArgumentNullException(nameof(@static));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2" /> class.
        /// </summary>
        public CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2()
        {
        }
    }
}