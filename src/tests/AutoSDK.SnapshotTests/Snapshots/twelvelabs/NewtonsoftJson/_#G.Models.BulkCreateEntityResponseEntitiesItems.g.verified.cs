//HintName: G.Models.BulkCreateEntityResponseEntitiesItems.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BulkCreateEntityResponseEntitiesItems
    {
        /// <summary>
        /// The unique identifier of the entity.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("_id")]
        public string? Id { get; set; }

        /// <summary>
        /// The name of the entity.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The current status of the entity creation process.<br/>
        /// **Values**:<br/>
        /// - `processing`: The entity is being processed and is not yet ready for use in searches.<br/>
        /// - `ready``: The entity is fully processed and can be used in search queries.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkCreateEntityResponseEntitiesItems" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the entity.
        /// </param>
        /// <param name="name">
        /// The name of the entity.
        /// </param>
        /// <param name="status">
        /// The current status of the entity creation process.<br/>
        /// **Values**:<br/>
        /// - `processing`: The entity is being processed and is not yet ready for use in searches.<br/>
        /// - `ready``: The entity is fully processed and can be used in search queries.
        /// </param>
        public BulkCreateEntityResponseEntitiesItems(
            string? id,
            string? name,
            string? status)
        {
            this.Id = id;
            this.Name = name;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkCreateEntityResponseEntitiesItems" /> class.
        /// </summary>
        public BulkCreateEntityResponseEntitiesItems()
        {
        }
    }
}