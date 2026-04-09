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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Log entity type (trigger or action)<br/>
        /// Example: trigger
        /// </summary>
        /// <example>trigger</example>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.GetInternalTriggerLogByIdResponseLogMetaTypeJsonConverter))]
        public global::G.GetInternalTriggerLogByIdResponseLogMetaType Type { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAt", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updatedAt", Required = global::Newtonsoft.Json.Required.Always)]
        public string UpdatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider", Required = global::Newtonsoft.Json.Required.Always)]
        public string Provider { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("clientId", Required = global::Newtonsoft.Json.Required.Always)]
        public string ClientId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("connectionId", Required = global::Newtonsoft.Json.Required.Always)]
        public string ConnectionId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("triggerProviderPayload")]
        public string? TriggerProviderPayload { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("triggerClientPayload")]
        public string? TriggerClientPayload { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("triggerClientError")]
        public string? TriggerClientError { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("triggerName")]
        public string? TriggerName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("triggerClientResponse")]
        public string? TriggerClientResponse { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("triggerId")]
        public string? TriggerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("triggerNanoId")]
        public string? TriggerNanoId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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