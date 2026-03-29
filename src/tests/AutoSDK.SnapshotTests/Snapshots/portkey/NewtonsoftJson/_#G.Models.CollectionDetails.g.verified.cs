//HintName: G.Models.CollectionDetails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CollectionDetails
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("child_collections_count")]
        public int? ChildCollectionsCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompts_count")]
        public int? PromptsCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("child_collections_last_updated_at")]
        public global::System.DateTime? ChildCollectionsLastUpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompts_last_updated_at")]
        public global::System.DateTime? PromptsLastUpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionDetails" /> class.
        /// </summary>
        /// <param name="childCollectionsCount"></param>
        /// <param name="promptsCount"></param>
        /// <param name="childCollectionsLastUpdatedAt"></param>
        /// <param name="promptsLastUpdatedAt"></param>
        public CollectionDetails(
            int? childCollectionsCount,
            int? promptsCount,
            global::System.DateTime? childCollectionsLastUpdatedAt,
            global::System.DateTime? promptsLastUpdatedAt)
        {
            this.ChildCollectionsCount = childCollectionsCount;
            this.PromptsCount = promptsCount;
            this.ChildCollectionsLastUpdatedAt = childCollectionsLastUpdatedAt;
            this.PromptsLastUpdatedAt = promptsLastUpdatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionDetails" /> class.
        /// </summary>
        public CollectionDetails()
        {
        }
    }
}