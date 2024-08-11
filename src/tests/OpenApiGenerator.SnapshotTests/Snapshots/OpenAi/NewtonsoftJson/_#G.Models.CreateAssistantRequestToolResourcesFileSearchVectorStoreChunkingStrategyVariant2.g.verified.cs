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
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2Type Type { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("static", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2Static Static { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}