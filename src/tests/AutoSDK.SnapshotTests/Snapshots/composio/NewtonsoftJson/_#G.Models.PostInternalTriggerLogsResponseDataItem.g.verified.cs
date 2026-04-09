//HintName: G.Models.PostInternalTriggerLogsResponseDataItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostInternalTriggerLogsResponseDataItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("connectionId", Required = global::Newtonsoft.Json.Required.Always)]
        public string ConnectionId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("clientId", Required = global::Newtonsoft.Json.Required.Always)]
        public string ClientId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("entityId", Required = global::Newtonsoft.Json.Required.Always)]
        public string EntityId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public string Status { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("appName", Required = global::Newtonsoft.Json.Required.Always)]
        public string AppName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAt", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// Log entity type (trigger or action)<br/>
        /// Example: trigger
        /// </summary>
        /// <example>trigger</example>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.PostInternalTriggerLogsResponseDataItemTypeJsonConverter))]
        public global::G.PostInternalTriggerLogsResponseDataItemType Type { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("meta", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PostInternalTriggerLogsResponseDataItemMeta Meta { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostInternalTriggerLogsResponseDataItem" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="connectionId"></param>
        /// <param name="clientId"></param>
        /// <param name="entityId"></param>
        /// <param name="status"></param>
        /// <param name="appName"></param>
        /// <param name="createdAt"></param>
        /// <param name="type">
        /// Log entity type (trigger or action)<br/>
        /// Example: trigger
        /// </param>
        /// <param name="meta"></param>
        public PostInternalTriggerLogsResponseDataItem(
            string id,
            string connectionId,
            string clientId,
            string entityId,
            string status,
            string appName,
            string createdAt,
            global::G.PostInternalTriggerLogsResponseDataItemType type,
            global::G.PostInternalTriggerLogsResponseDataItemMeta meta)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ConnectionId = connectionId ?? throw new global::System.ArgumentNullException(nameof(connectionId));
            this.ClientId = clientId ?? throw new global::System.ArgumentNullException(nameof(clientId));
            this.EntityId = entityId ?? throw new global::System.ArgumentNullException(nameof(entityId));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.AppName = appName ?? throw new global::System.ArgumentNullException(nameof(appName));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Type = type;
            this.Meta = meta ?? throw new global::System.ArgumentNullException(nameof(meta));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostInternalTriggerLogsResponseDataItem" /> class.
        /// </summary>
        public PostInternalTriggerLogsResponseDataItem()
        {
        }
    }
}