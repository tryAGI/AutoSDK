//HintName: G.Models.ChildCollection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChildCollection
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_updated_at")]
        public global::System.DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("collection_details")]
        public global::G.CollectionDetails? CollectionDetails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChildCollection" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="lastUpdatedAt"></param>
        /// <param name="collectionDetails"></param>
        public ChildCollection(
            global::System.Guid? id,
            string? name,
            global::System.DateTime? lastUpdatedAt,
            global::G.CollectionDetails? collectionDetails)
        {
            this.Id = id;
            this.Name = name;
            this.LastUpdatedAt = lastUpdatedAt;
            this.CollectionDetails = collectionDetails;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChildCollection" /> class.
        /// </summary>
        public ChildCollection()
        {
        }
    }
}