//HintName: G.Models.DocumentStoreLoaderForRefresh.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DocumentStoreLoaderForRefresh
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("items")]
        public global::System.Collections.Generic.IList<global::G.DocumentStoreLoaderForUpsert>? Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentStoreLoaderForRefresh" /> class.
        /// </summary>
        /// <param name="items"></param>
        public DocumentStoreLoaderForRefresh(
            global::System.Collections.Generic.IList<global::G.DocumentStoreLoaderForUpsert>? items)
        {
            this.Items = items;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentStoreLoaderForRefresh" /> class.
        /// </summary>
        public DocumentStoreLoaderForRefresh()
        {
        }
    }
}