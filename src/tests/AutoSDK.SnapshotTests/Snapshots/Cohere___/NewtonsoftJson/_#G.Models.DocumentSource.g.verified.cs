//HintName: G.Models.DocumentSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A document source object containing the unique identifier of the document and the document itself.
    /// </summary>
    public sealed partial class DocumentSource
    {
        /// <summary>
        /// The unique identifier of the document
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("document")]
        public object? Document { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentSource" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the document
        /// </param>
        /// <param name="document"></param>
        public DocumentSource(
            string? id,
            object? document)
        {
            this.Id = id;
            this.Document = document;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentSource" /> class.
        /// </summary>
        public DocumentSource()
        {
        }
    }
}