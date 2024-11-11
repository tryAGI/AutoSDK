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
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("fileUid")]
        public string FileUid { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.FileType Type { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("processStatus")]
        public global::G.FileProcessStatus? ProcessStatus { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("processOutcome")]
        public string? ProcessOutcome { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("retrievable")]
        public bool? Retrievable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ownerUid")]
        public string? OwnerUid { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("creatorUid")]
        public string? CreatorUid { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("catalogUid")]
        public string? CatalogUid { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createTime")]
        public global::System.DateTime? CreateTime { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updateTime")]
        public global::System.DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deleteTime")]
        public global::System.DateTime? DeleteTime { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("size")]
        public string? Size { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("totalChunks")]
        public int? TotalChunks { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("totalTokens")]
        public int? TotalTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("externalMetadata")]
        public object? ExternalMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="File" /> class.
        /// </summary>
        /// <param name="fileUid">
        /// Included only in responses
        /// </param>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="processStatus">
        /// Included only in responses
        /// </param>
        /// <param name="processOutcome">
        /// Included only in responses
        /// </param>
        /// <param name="retrievable">
        /// Included only in responses
        /// </param>
        /// <param name="content"></param>
        /// <param name="ownerUid">
        /// Included only in responses
        /// </param>
        /// <param name="creatorUid">
        /// Included only in responses
        /// </param>
        /// <param name="catalogUid">
        /// Included only in responses
        /// </param>
        /// <param name="createTime">
        /// Included only in responses
        /// </param>
        /// <param name="updateTime">
        /// Included only in responses
        /// </param>
        /// <param name="deleteTime">
        /// Included only in responses
        /// </param>
        /// <param name="size">
        /// Included only in responses
        /// </param>
        /// <param name="totalChunks">
        /// Included only in responses
        /// </param>
        /// <param name="totalTokens">
        /// Included only in responses
        /// </param>
        /// <param name="externalMetadata"></param>
        public File(
            string name,
            global::G.FileType type,
            global::G.FileProcessStatus? processStatus,
            string? processOutcome,
            bool? retrievable,
            string? content,
            string? ownerUid,
            string? creatorUid,
            string? catalogUid,
            global::System.DateTime? createTime,
            global::System.DateTime? updateTime,
            global::System.DateTime? deleteTime,
            string? size,
            int? totalChunks,
            int? totalTokens,
            object? externalMetadata,
            string fileUid = default!)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.FileUid = fileUid;
            this.ProcessStatus = processStatus;
            this.ProcessOutcome = processOutcome;
            this.Retrievable = retrievable;
            this.Content = content;
            this.OwnerUid = ownerUid;
            this.CreatorUid = creatorUid;
            this.CatalogUid = catalogUid;
            this.CreateTime = createTime;
            this.UpdateTime = updateTime;
            this.DeleteTime = deleteTime;
            this.Size = size;
            this.TotalChunks = totalChunks;
            this.TotalTokens = totalTokens;
            this.ExternalMetadata = externalMetadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="File" /> class.
        /// </summary>
        public File()
        {
        }
    }
}