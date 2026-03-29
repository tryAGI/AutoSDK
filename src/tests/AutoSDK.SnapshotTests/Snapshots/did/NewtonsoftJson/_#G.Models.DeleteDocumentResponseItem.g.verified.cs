//HintName: G.Models.DeleteDocumentResponseItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteDocumentResponseItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("s3", Required = global::Newtonsoft.Json.Required.Always)]
        public bool S3 { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embeddings", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Embeddings { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("document", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Document { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteDocumentResponseItem" /> class.
        /// </summary>
        /// <param name="s3"></param>
        /// <param name="embeddings"></param>
        /// <param name="document"></param>
        /// <param name="id"></param>
        public DeleteDocumentResponseItem(
            bool s3,
            bool embeddings,
            bool document,
            string id)
        {
            this.S3 = s3;
            this.Embeddings = embeddings;
            this.Document = document;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteDocumentResponseItem" /> class.
        /// </summary>
        public DeleteDocumentResponseItem()
        {
        }
    }
}