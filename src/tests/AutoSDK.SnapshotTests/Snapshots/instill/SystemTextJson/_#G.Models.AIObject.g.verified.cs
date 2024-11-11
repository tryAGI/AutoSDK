//HintName: G.Models.AIObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AIObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uid")]
        public string? Uid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public string? Size { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentType")]
        public string? ContentType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("namespaceUid")]
        public string? NamespaceUid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator")]
        public string? Creator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isUploaded")]
        public bool? IsUploaded { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("objectExpireDays")]
        public int? ObjectExpireDays { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastModifiedTime")]
        public global::System.DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdTime")]
        public global::System.DateTime? CreatedTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedTime")]
        public global::System.DateTime? UpdatedTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AIObject" /> class.
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="name"></param>
        /// <param name="size"></param>
        /// <param name="contentType"></param>
        /// <param name="namespaceUid"></param>
        /// <param name="creator"></param>
        /// <param name="isUploaded"></param>
        /// <param name="path"></param>
        /// <param name="objectExpireDays"></param>
        /// <param name="lastModifiedTime"></param>
        /// <param name="createdTime"></param>
        /// <param name="updatedTime"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public AIObject(
            string? uid,
            string? name,
            string? size,
            string? contentType,
            string? namespaceUid,
            string? creator,
            bool? isUploaded,
            string? path,
            int? objectExpireDays,
            global::System.DateTime? lastModifiedTime,
            global::System.DateTime? createdTime,
            global::System.DateTime? updatedTime)
        {
            this.Uid = uid;
            this.Name = name;
            this.Size = size;
            this.ContentType = contentType;
            this.NamespaceUid = namespaceUid;
            this.Creator = creator;
            this.IsUploaded = isUploaded;
            this.Path = path;
            this.ObjectExpireDays = objectExpireDays;
            this.LastModifiedTime = lastModifiedTime;
            this.CreatedTime = createdTime;
            this.UpdatedTime = updatedTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AIObject" /> class.
        /// </summary>
        public AIObject()
        {
        }
    }
}