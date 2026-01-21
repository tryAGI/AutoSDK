//HintName: G.Models.FileResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FileResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Example: file
        /// </summary>
        /// <example>file</example>
        [global::Newtonsoft.Json.JsonProperty("object", Required = global::Newtonsoft.Json.Required.Always)]
        public string Object { get; set; } = default!;

        /// <summary>
        /// Example: 1715021438
        /// </summary>
        /// <example>1715021438</example>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public int CreatedAt { get; set; } = default!;

        /// <summary>
        /// Example: my_file.jsonl
        /// </summary>
        /// <example>my_file.jsonl</example>
        [global::Newtonsoft.Json.JsonProperty("filename", Required = global::Newtonsoft.Json.Required.Always)]
        public string Filename { get; set; } = default!;

        /// <summary>
        /// Example: 2664
        /// </summary>
        /// <example>2664</example>
        [global::Newtonsoft.Json.JsonProperty("bytes", Required = global::Newtonsoft.Json.Required.Always)]
        public int Bytes { get; set; } = default!;

        /// <summary>
        /// Example: fine-tune
        /// </summary>
        /// <example>fine-tune</example>
        [global::Newtonsoft.Json.JsonProperty("purpose")]
        public global::G.FileResponsePurpose Purpose { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("Processed", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Processed { get; set; } = default!;

        /// <summary>
        /// Example: jsonl
        /// </summary>
        /// <example>jsonl</example>
        [global::Newtonsoft.Json.JsonProperty("FileType", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.FileResponseFileType FileType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("LineCount", Required = global::Newtonsoft.Json.Required.Always)]
        public int LineCount { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="object">
        /// Example: file
        /// </param>
        /// <param name="createdAt">
        /// Example: 1715021438
        /// </param>
        /// <param name="filename">
        /// Example: my_file.jsonl
        /// </param>
        /// <param name="bytes">
        /// Example: 2664
        /// </param>
        /// <param name="purpose">
        /// Example: fine-tune
        /// </param>
        /// <param name="processed"></param>
        /// <param name="fileType">
        /// Example: jsonl
        /// </param>
        /// <param name="lineCount"></param>
        public FileResponse(
            string id,
            string @object,
            int createdAt,
            string filename,
            int bytes,
            bool processed,
            global::G.FileResponseFileType fileType,
            int lineCount,
            global::G.FileResponsePurpose purpose)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object ?? throw new global::System.ArgumentNullException(nameof(@object));
            this.CreatedAt = createdAt;
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.Bytes = bytes;
            this.Processed = processed;
            this.FileType = fileType;
            this.LineCount = lineCount;
            this.Purpose = purpose;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileResponse" /> class.
        /// </summary>
        public FileResponse()
        {
        }
    }
}