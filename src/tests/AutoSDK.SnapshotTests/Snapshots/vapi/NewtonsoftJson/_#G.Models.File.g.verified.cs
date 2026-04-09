//HintName: G.Models.File.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class File
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.FileObjectJsonConverter))]
        public global::G.FileObject? Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.FileStatusJsonConverter))]
        public global::G.FileStatus? Status { get; set; }

        /// <summary>
        /// This is the name of the file. This is just for your own reference.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("originalName")]
        public string? OriginalName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bytes")]
        public double? Bytes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("purpose")]
        public string? Purpose { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mimetype")]
        public string? Mimetype { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("key")]
        public string? Key { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("path")]
        public string? Path { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bucket")]
        public string? Bucket { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parsedTextUrl")]
        public string? ParsedTextUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parsedTextBytes")]
        public double? ParsedTextBytes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// This is the unique identifier for the file.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// This is the unique identifier for the org that this file belongs to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("orgId", Required = global::Newtonsoft.Json.Required.Always)]
        public string OrgId { get; set; } = default!;

        /// <summary>
        /// This is the ISO 8601 date-time string of when the file was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// This is the ISO 8601 date-time string of when the file was last updated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updatedAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="File" /> class.
        /// </summary>
        /// <param name="id">
        /// This is the unique identifier for the file.
        /// </param>
        /// <param name="orgId">
        /// This is the unique identifier for the org that this file belongs to.
        /// </param>
        /// <param name="createdAt">
        /// This is the ISO 8601 date-time string of when the file was created.
        /// </param>
        /// <param name="updatedAt">
        /// This is the ISO 8601 date-time string of when the file was last updated.
        /// </param>
        /// <param name="object"></param>
        /// <param name="status"></param>
        /// <param name="name">
        /// This is the name of the file. This is just for your own reference.
        /// </param>
        /// <param name="originalName"></param>
        /// <param name="bytes"></param>
        /// <param name="purpose"></param>
        /// <param name="mimetype"></param>
        /// <param name="key"></param>
        /// <param name="path"></param>
        /// <param name="bucket"></param>
        /// <param name="url"></param>
        /// <param name="parsedTextUrl"></param>
        /// <param name="parsedTextBytes"></param>
        /// <param name="metadata"></param>
        public File(
            string id,
            string orgId,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::G.FileObject? @object,
            global::G.FileStatus? status,
            string? name,
            string? originalName,
            double? bytes,
            string? purpose,
            string? mimetype,
            string? key,
            string? path,
            string? bucket,
            string? url,
            string? parsedTextUrl,
            double? parsedTextBytes,
            object? metadata)
        {
            this.Object = @object;
            this.Status = status;
            this.Name = name;
            this.OriginalName = originalName;
            this.Bytes = bytes;
            this.Purpose = purpose;
            this.Mimetype = mimetype;
            this.Key = key;
            this.Path = path;
            this.Bucket = bucket;
            this.Url = url;
            this.ParsedTextUrl = parsedTextUrl;
            this.ParsedTextBytes = parsedTextBytes;
            this.Metadata = metadata;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.OrgId = orgId ?? throw new global::System.ArgumentNullException(nameof(orgId));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="File" /> class.
        /// </summary>
        public File()
        {
        }
    }
}