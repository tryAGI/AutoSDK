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
        /// 文件字节数
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bytes")]
        public int? Bytes { get; set; }

        /// <summary>
        /// 上传时间戳，单位s
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public int? CreatedAt { get; set; }

        /// <summary>
        /// 文件名
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_name")]
        public string? FileName { get; set; }

        /// <summary>
        /// 文件ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="File" /> class.
        /// </summary>
        /// <param name="bytes">
        /// 文件字节数
        /// </param>
        /// <param name="createdAt">
        /// 上传时间戳，单位s
        /// </param>
        /// <param name="fileName">
        /// 文件名
        /// </param>
        /// <param name="id">
        /// 文件ID
        /// </param>
        public File(
            int? bytes,
            int? createdAt,
            string? fileName,
            string? id)
        {
            this.Bytes = bytes;
            this.CreatedAt = createdAt;
            this.FileName = fileName;
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="File" /> class.
        /// </summary>
        public File()
        {
        }
    }
}