//HintName: G.Models.DocumentLocalIngestRequestItemMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DocumentLocalIngestRequestItemMetadata
    {
        /// <summary>
        /// the bucketId of the bucket which this local file will be ingested to.<br/>
        /// Example: 1234
        /// </summary>
        /// <example>1234</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("bucketId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int BucketId { get; set; }

        /// <summary>
        /// The name of the file being ingested<br/>
        /// Example: my_file.txt
        /// </summary>
        /// <example>my_file.txt</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileName { get; set; }

        /// <summary>
        /// The type of document (one of the seven currently supported file types)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.DocumentTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DocumentType FileType { get; set; }

        /// <summary>
        /// Custom metadata which can be used to influence GroundX's search functionality. This data can be used to further hone GroundX search.<br/>
        /// Example: {"key":"value"}
        /// </summary>
        /// <example>{"key":"value"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("searchData")]
        public object? SearchData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentLocalIngestRequestItemMetadata" /> class.
        /// </summary>
        /// <param name="bucketId">
        /// the bucketId of the bucket which this local file will be ingested to.<br/>
        /// Example: 1234
        /// </param>
        /// <param name="fileName">
        /// The name of the file being ingested<br/>
        /// Example: my_file.txt
        /// </param>
        /// <param name="fileType">
        /// The type of document (one of the seven currently supported file types)
        /// </param>
        /// <param name="searchData">
        /// Custom metadata which can be used to influence GroundX's search functionality. This data can be used to further hone GroundX search.<br/>
        /// Example: {"key":"value"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DocumentLocalIngestRequestItemMetadata(
            int bucketId,
            string fileName,
            global::G.DocumentType fileType,
            object? searchData)
        {
            this.BucketId = bucketId;
            this.FileName = fileName ?? throw new global::System.ArgumentNullException(nameof(fileName));
            this.FileType = fileType;
            this.SearchData = searchData;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentLocalIngestRequestItemMetadata" /> class.
        /// </summary>
        public DocumentLocalIngestRequestItemMetadata()
        {
        }
    }
}