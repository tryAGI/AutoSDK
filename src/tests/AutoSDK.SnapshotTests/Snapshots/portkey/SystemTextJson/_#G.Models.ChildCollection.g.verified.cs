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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_updated_at")]
        public global::System.DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collection_details")]
        public global::G.CollectionDetails? CollectionDetails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChildCollection" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="lastUpdatedAt"></param>
        /// <param name="collectionDetails"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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