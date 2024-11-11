//HintName: G.Models.ObjectURL.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ObjectURL
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("uid")]
        public string? Uid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("namespaceUid")]
        public string? NamespaceUid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("objectUid")]
        public string? ObjectUid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("urlExpireAt")]
        public global::System.DateTime? UrlExpireAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("minioUrlPath")]
        public string? MinioUrlPath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("encodedUrlPath")]
        public string? EncodedUrlPath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createTime")]
        public global::System.DateTime? CreateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updateTime")]
        public global::System.DateTime? UpdateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deleteTime")]
        public global::System.DateTime? DeleteTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectURL" /> class.
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="namespaceUid"></param>
        /// <param name="objectUid"></param>
        /// <param name="urlExpireAt"></param>
        /// <param name="minioUrlPath"></param>
        /// <param name="encodedUrlPath"></param>
        /// <param name="type"></param>
        /// <param name="createTime"></param>
        /// <param name="updateTime"></param>
        /// <param name="deleteTime"></param>
        public ObjectURL(
            string? uid,
            string? namespaceUid,
            string? objectUid,
            global::System.DateTime? urlExpireAt,
            string? minioUrlPath,
            string? encodedUrlPath,
            string? type,
            global::System.DateTime? createTime,
            global::System.DateTime? updateTime,
            global::System.DateTime? deleteTime)
        {
            this.Uid = uid;
            this.NamespaceUid = namespaceUid;
            this.ObjectUid = objectUid;
            this.UrlExpireAt = urlExpireAt;
            this.MinioUrlPath = minioUrlPath;
            this.EncodedUrlPath = encodedUrlPath;
            this.Type = type;
            this.CreateTime = createTime;
            this.UpdateTime = updateTime;
            this.DeleteTime = deleteTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectURL" /> class.
        /// </summary>
        public ObjectURL()
        {
        }
    }
}