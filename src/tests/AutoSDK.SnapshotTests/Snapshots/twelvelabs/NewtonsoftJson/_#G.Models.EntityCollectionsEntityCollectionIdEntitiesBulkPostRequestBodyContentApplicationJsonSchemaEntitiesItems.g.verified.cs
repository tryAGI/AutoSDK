//HintName: G.Models.EntityCollectionsEntityCollectionIdEntitiesBulkPostRequestBodyContentApplicationJsonSchemaEntitiesItems.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EntityCollectionsEntityCollectionIdEntitiesBulkPostRequestBodyContentApplicationJsonSchemaEntitiesItems
    {
        /// <summary>
        /// The name of the entity.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Optional description of the entity.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Optional metadata for the entity, provided as key-value pairs.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::G.EntityCollectionsEntityCollectionIdEntitiesBulkPostRequestBodyContentApplicationJsonSchemaEntitiesItemsMetadata? Metadata { get; set; }

        /// <summary>
        /// An array of asset IDs to associate with the entity. At least one asset ID is required.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("asset_ids", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> AssetIds { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EntityCollectionsEntityCollectionIdEntitiesBulkPostRequestBodyContentApplicationJsonSchemaEntitiesItems" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the entity.
        /// </param>
        /// <param name="assetIds">
        /// An array of asset IDs to associate with the entity. At least one asset ID is required.
        /// </param>
        /// <param name="description">
        /// Optional description of the entity.
        /// </param>
        /// <param name="metadata">
        /// Optional metadata for the entity, provided as key-value pairs.
        /// </param>
        public EntityCollectionsEntityCollectionIdEntitiesBulkPostRequestBodyContentApplicationJsonSchemaEntitiesItems(
            string name,
            global::System.Collections.Generic.IList<string> assetIds,
            string? description,
            global::G.EntityCollectionsEntityCollectionIdEntitiesBulkPostRequestBodyContentApplicationJsonSchemaEntitiesItemsMetadata? metadata)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Metadata = metadata;
            this.AssetIds = assetIds ?? throw new global::System.ArgumentNullException(nameof(assetIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EntityCollectionsEntityCollectionIdEntitiesBulkPostRequestBodyContentApplicationJsonSchemaEntitiesItems" /> class.
        /// </summary>
        public EntityCollectionsEntityCollectionIdEntitiesBulkPostRequestBodyContentApplicationJsonSchemaEntitiesItems()
        {
        }
    }
}