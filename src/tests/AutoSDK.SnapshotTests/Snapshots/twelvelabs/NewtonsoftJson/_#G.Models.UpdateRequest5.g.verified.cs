//HintName: G.Models.UpdateRequest5.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateRequest5
    {
        /// <summary>
        /// The new name for the entity.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// An updated description for the entity.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Updated metadata for the entity. If provided, this completely replaces the existing metadata. Use this to store custom key-value pairs related to the entity.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::G.EntityCollectionsEntityCollectionIdEntitiesEntityIdPatchRequestBodyContentApplicationJsonSchemaMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRequest5" /> class.
        /// </summary>
        /// <param name="name">
        /// The new name for the entity.
        /// </param>
        /// <param name="description">
        /// An updated description for the entity.
        /// </param>
        /// <param name="metadata">
        /// Updated metadata for the entity. If provided, this completely replaces the existing metadata. Use this to store custom key-value pairs related to the entity.
        /// </param>
        public UpdateRequest5(
            string? name,
            string? description,
            global::G.EntityCollectionsEntityCollectionIdEntitiesEntityIdPatchRequestBodyContentApplicationJsonSchemaMetadata? metadata)
        {
            this.Name = name;
            this.Description = description;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRequest5" /> class.
        /// </summary>
        public UpdateRequest5()
        {
        }
    }
}