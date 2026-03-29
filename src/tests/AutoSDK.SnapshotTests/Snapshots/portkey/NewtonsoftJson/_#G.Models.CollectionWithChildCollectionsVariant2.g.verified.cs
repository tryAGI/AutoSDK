//HintName: G.Models.CollectionWithChildCollectionsVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CollectionWithChildCollectionsVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("child_collections")]
        public global::System.Collections.Generic.IList<global::G.ChildCollection>? ChildCollections { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionWithChildCollectionsVariant2" /> class.
        /// </summary>
        /// <param name="childCollections"></param>
        public CollectionWithChildCollectionsVariant2(
            global::System.Collections.Generic.IList<global::G.ChildCollection>? childCollections)
        {
            this.ChildCollections = childCollections;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionWithChildCollectionsVariant2" /> class.
        /// </summary>
        public CollectionWithChildCollectionsVariant2()
        {
        }
    }
}