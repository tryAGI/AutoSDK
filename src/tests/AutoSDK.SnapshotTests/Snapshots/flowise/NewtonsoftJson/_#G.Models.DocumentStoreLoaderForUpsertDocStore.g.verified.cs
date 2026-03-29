//HintName: G.Models.DocumentStoreLoaderForUpsertDocStore.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Only when createNewDocStore is true, pass in the new document store configuration
    /// </summary>
    public sealed partial class DocumentStoreLoaderForUpsertDocStore
    {
        /// <summary>
        /// Name of the new document store to be created<br/>
        /// Example: plainText
        /// </summary>
        /// <example>plainText</example>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Description of the new document store to be created<br/>
        /// Example: plainText
        /// </summary>
        /// <example>plainText</example>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentStoreLoaderForUpsertDocStore" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the new document store to be created<br/>
        /// Example: plainText
        /// </param>
        /// <param name="description">
        /// Description of the new document store to be created<br/>
        /// Example: plainText
        /// </param>
        public DocumentStoreLoaderForUpsertDocStore(
            string? name,
            string? description)
        {
            this.Name = name;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentStoreLoaderForUpsertDocStore" /> class.
        /// </summary>
        public DocumentStoreLoaderForUpsertDocStore()
        {
        }
    }
}