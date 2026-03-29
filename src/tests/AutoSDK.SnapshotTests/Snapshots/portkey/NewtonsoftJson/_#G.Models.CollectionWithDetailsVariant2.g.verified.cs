//HintName: G.Models.CollectionWithDetailsVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CollectionWithDetailsVariant2
    {
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
        /// Initializes a new instance of the <see cref="CollectionWithDetailsVariant2" /> class.
        /// </summary>
        /// <param name="collectionDetails"></param>
        public CollectionWithDetailsVariant2(
            global::G.CollectionDetails? collectionDetails)
        {
            this.CollectionDetails = collectionDetails;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionWithDetailsVariant2" /> class.
        /// </summary>
        public CollectionWithDetailsVariant2()
        {
        }
    }
}