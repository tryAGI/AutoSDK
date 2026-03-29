//HintName: G.Models.GetInternalTriggerLogByIdResponseLogMeta.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetInternalTriggerLogByIdResponseLogMeta
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Log entity type (trigger or action)<br/>
        /// Example: trigger
        /// </summary>
        /// <example>trigger</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GetInternalTriggerLogByIdResponseLogMetaTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GetInternalTriggerLogByIdResponseLogMetaType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConnectionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggerProviderPayload")]
        public string? TriggerProviderPayload { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggerClientPayload")]
        public string? TriggerClientPayload { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggerClientError")]
        public string? TriggerClientError { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggerName")]
        public string? TriggerName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggerClientResponse")]
        public string? TriggerClientResponse { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggerId")]
        public string? TriggerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggerNanoId")]
        public string? TriggerNanoId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetInternalTriggerLogByIdResponseLogMeta" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="type">
        /// Log entity type (trigger or action)<br/>
        /// Example: trigger
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="provider"></param>
        /// <param name="clientId"></param>
        /// <param name="connectionId"></param>
        /// <param name="triggerProviderPayload"></param>
        /// <param name="triggerClientPayload"></param>
        /// <param name="triggerClientError"></param>
        /// <param name="triggerName"></param>
        /// <param name="triggerClientResponse"></param>
        /// <param name="triggerId"></param>
        /// <param name="triggerNanoId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetInternalTriggerLogByIdResponseLogMeta(
            string id,
            global::G.GetInternalTriggerLogByIdResponseLogMetaType type,
            string createdAt,
            string updatedAt,
            string provider,
            string clientId,
            string connectionId,
            string? triggerProviderPayload,
            string? triggerClientPayload,
            string? triggerClientError,
            string? triggerName,
            string? triggerClientResponse,
            string? triggerId,
            string? triggerNanoId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.ClientId = clientId ?? throw new global::System.ArgumentNullException(nameof(clientId));
            this.ConnectionId = connectionId ?? throw new global::System.ArgumentNullException(nameof(connectionId));
            this.TriggerProviderPayload = triggerProviderPayload;
            this.TriggerClientPayload = triggerClientPayload;
            this.TriggerClientError = triggerClientError;
            this.TriggerName = triggerName;
            this.TriggerClientResponse = triggerClientResponse;
            this.TriggerId = triggerId;
            this.TriggerNanoId = triggerNanoId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetInternalTriggerLogByIdResponseLogMeta" /> class.
        /// </summary>
        public GetInternalTriggerLogByIdResponseLogMeta()
        {
        }
    }
}