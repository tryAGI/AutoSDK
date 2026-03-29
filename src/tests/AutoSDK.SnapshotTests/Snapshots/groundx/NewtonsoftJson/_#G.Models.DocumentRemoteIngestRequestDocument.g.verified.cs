//HintName: G.Models.DocumentRemoteIngestRequestDocument.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DocumentRemoteIngestRequestDocument
    {
        /// <summary>
        /// the bucketId of the bucket which this remote file will be ingested to.<br/>
        /// Example: 1234
        /// </summary>
        /// <example>1234</example>
        [global::Newtonsoft.Json.JsonProperty("bucketId", Required = global::Newtonsoft.Json.Required.Always)]
        public int BucketId { get; set; } = default!;

        /// <summary>
        /// The name of the file being ingested<br/>
        /// Example: my_file.txt
        /// </summary>
        /// <example>my_file.txt</example>
        [global::Newtonsoft.Json.JsonProperty("fileName")]
        public string? FileName { get; set; }

        /// <summary>
        /// The type of document (one of the seven currently supported file types)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fileType")]
        public global::G.DocumentType? FileType { get; set; }

        /// <summary>
        /// Custom metadata which can be used to influence GroundX's search functionality. This data can be used to further hone GroundX search.<br/>
        /// Example: {"key":"value"}
        /// </summary>
        /// <example>{"key":"value"}</example>
        [global::Newtonsoft.Json.JsonProperty("searchData")]
        public object? SearchData { get; set; }

        /// <summary>
        /// The URL of the document being ingested by GroundX.<br/>
        /// Example: https://my.source.url.com/file.txt
        /// </summary>
        /// <example>https://my.source.url.com/file.txt</example>
        [global::Newtonsoft.Json.JsonProperty("sourceUrl", Required = global::Newtonsoft.Json.Required.Always)]
        public string SourceUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentRemoteIngestRequestDocument" /> class.
        /// </summary>
        /// <param name="bucketId">
        /// the bucketId of the bucket which this remote file will be ingested to.<br/>
        /// Example: 1234
        /// </param>
        /// <param name="sourceUrl">
        /// The URL of the document being ingested by GroundX.<br/>
        /// Example: https://my.source.url.com/file.txt
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
        public DocumentRemoteIngestRequestDocument(
            int bucketId,
            string sourceUrl,
            string? fileName,
            global::G.DocumentType? fileType,
            object? searchData)
        {
            this.BucketId = bucketId;
            this.FileName = fileName;
            this.FileType = fileType;
            this.SearchData = searchData;
            this.SourceUrl = sourceUrl ?? throw new global::System.ArgumentNullException(nameof(sourceUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentRemoteIngestRequestDocument" /> class.
        /// </summary>
        public DocumentRemoteIngestRequestDocument()
        {
        }
    }
}