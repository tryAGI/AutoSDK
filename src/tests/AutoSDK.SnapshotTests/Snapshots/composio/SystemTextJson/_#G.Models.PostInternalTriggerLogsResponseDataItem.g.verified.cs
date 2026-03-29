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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConnectionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entityId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EntityId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AppName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Log entity type (trigger or action)<br/>
        /// Example: trigger
        /// </summary>
        /// <example>trigger</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PostInternalTriggerLogsResponseDataItemTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PostInternalTriggerLogsResponseDataItemType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PostInternalTriggerLogsResponseDataItemMeta Meta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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