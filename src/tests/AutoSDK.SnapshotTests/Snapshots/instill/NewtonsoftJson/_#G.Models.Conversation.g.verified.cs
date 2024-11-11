//HintName: G.Models.Conversation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Conversation
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("uid")]
        public string? Uid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("namespaceId", Required = global::Newtonsoft.Json.Required.Always)]
        public string NamespaceId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("appId", Required = global::Newtonsoft.Json.Required.Always)]
        public string AppId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lastUsedCatalogUid")]
        public string? LastUsedCatalogUid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lastUsedTopK")]
        public long? LastUsedTopK { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Conversation" /> class.
        /// </summary>
        /// <param name="uid">
        /// Included only in responses
        /// </param>
        /// <param name="namespaceId"></param>
        /// <param name="appId"></param>
        /// <param name="id"></param>
        /// <param name="lastUsedCatalogUid"></param>
        /// <param name="lastUsedTopK"></param>
        /// <param name="createTime">
        /// Included only in responses
        /// </param>
        /// <param name="updateTime">
        /// Included only in responses
        /// </param>
        public Conversation(
            string namespaceId,
            string appId,
            string id,
            string? uid,
            string? lastUsedCatalogUid,
            long? lastUsedTopK,
            global::System.DateTime? createTime,
            global::System.DateTime? updateTime)
        {
            this.NamespaceId = namespaceId ?? throw new global::System.ArgumentNullException(nameof(namespaceId));
            this.AppId = appId ?? throw new global::System.ArgumentNullException(nameof(appId));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Uid = uid;
            this.LastUsedCatalogUid = lastUsedCatalogUid;
            this.LastUsedTopK = lastUsedTopK;
            this.CreateTime = createTime;
            this.UpdateTime = updateTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Conversation" /> class.
        /// </summary>
        public Conversation()
        {
        }
    }
}