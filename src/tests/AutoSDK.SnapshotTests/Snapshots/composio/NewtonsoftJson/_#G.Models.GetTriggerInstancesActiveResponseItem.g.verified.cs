//HintName: G.Models.GetTriggerInstancesActiveResponseItem.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetTriggerInstancesActiveResponseItem
    {
        /// <summary>
        /// Unique identifier of the trigger instance
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("uuid")]
        public string? Uuid { get; set; }

        /// <summary>
        /// Nano ID of the trigger instance
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// ID of the connected account this trigger is associated with
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("connected_account_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ConnectedAccountId { get; set; } = default!;

        /// <summary>
        /// Name of the trigger
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trigger_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string TriggerName { get; set; } = default!;

        /// <summary>
        /// UUID of the connected account this trigger is associated with
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("connected_account_uuid", Required = global::Newtonsoft.Json.Required.Always)]
        public string ConnectedAccountUuid { get; set; } = default!;

        /// <summary>
        /// ID of the user this trigger is associated with
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserId { get; set; } = default!;

        /// <summary>
        /// Additional data associated with the trigger instance
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trigger_data")]
        public string? TriggerData { get; set; }

        /// <summary>
        /// Version of the trigger instance
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version", Required = global::Newtonsoft.Json.Required.Always)]
        public string Version { get; set; } = default!;

        /// <summary>
        /// Configuration for the trigger
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trigger_config", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, object?> TriggerConfig { get; set; } = default!;

        /// <summary>
        /// State of the trigger instance
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, object?> State { get; set; } = default!;

        /// <summary>
        /// ISO 8601 timestamp when the trigger instance was updated
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string UpdatedAt { get; set; } = default!;

        /// <summary>
        /// ISO 8601 timestamp when the trigger instance was disabled, if applicable
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("disabled_at")]
        public string? DisabledAt { get; set; }

        /// <summary>
        /// DEPRECATED: This parameter will be removed in a future version. Please use disabled_at instead.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("disabledAt")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? DisabledAt2 { get; set; }

        /// <summary>
        /// DEPRECATED: This parameter will be removed in a future version. Please use connected_account_id instead.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("connectedAccountId", Required = global::Newtonsoft.Json.Required.Always)]
        public string ConnectedAccountId2 { get; set; } = default!;

        /// <summary>
        /// DEPRECATED: This parameter will be removed in a future version. Please use trigger_name instead.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("triggerName", Required = global::Newtonsoft.Json.Required.Always)]
        public string TriggerName2 { get; set; } = default!;

        /// <summary>
        /// DEPRECATED: This parameter will be removed in a future version. Please use updated_at instead.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updatedAt", Required = global::Newtonsoft.Json.Required.Always)]
        public string UpdatedAt2 { get; set; } = default!;

        /// <summary>
        /// DEPRECATED: This parameter will be removed in a future version. Please use trigger_config instead.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("triggerConfig", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, object?> TriggerConfig2 { get; set; } = default!;

        /// <summary>
        /// Deprecated fields for the trigger instance
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deprecated")]
        public global::G.GetTriggerInstancesActiveResponseItemDeprecated? Deprecated { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTriggerInstancesActiveResponseItem" /> class.
        /// </summary>
        /// <param name="id">
        /// Nano ID of the trigger instance
        /// </param>
        /// <param name="connectedAccountId">
        /// ID of the connected account this trigger is associated with
        /// </param>
        /// <param name="triggerName">
        /// Name of the trigger
        /// </param>
        /// <param name="connectedAccountUuid">
        /// UUID of the connected account this trigger is associated with
        /// </param>
        /// <param name="userId">
        /// ID of the user this trigger is associated with
        /// </param>
        /// <param name="version">
        /// Version of the trigger instance
        /// </param>
        /// <param name="triggerConfig">
        /// Configuration for the trigger
        /// </param>
        /// <param name="state">
        /// State of the trigger instance
        /// </param>
        /// <param name="updatedAt">
        /// ISO 8601 timestamp when the trigger instance was updated
        /// </param>
        /// <param name="connectedAccountId2">
        /// DEPRECATED: This parameter will be removed in a future version. Please use connected_account_id instead.
        /// </param>
        /// <param name="triggerName2">
        /// DEPRECATED: This parameter will be removed in a future version. Please use trigger_name instead.
        /// </param>
        /// <param name="updatedAt2">
        /// DEPRECATED: This parameter will be removed in a future version. Please use updated_at instead.
        /// </param>
        /// <param name="triggerConfig2">
        /// DEPRECATED: This parameter will be removed in a future version. Please use trigger_config instead.
        /// </param>
        /// <param name="uuid">
        /// Unique identifier of the trigger instance
        /// </param>
        /// <param name="triggerData">
        /// Additional data associated with the trigger instance
        /// </param>
        /// <param name="disabledAt">
        /// ISO 8601 timestamp when the trigger instance was disabled, if applicable
        /// </param>
        /// <param name="deprecated">
        /// Deprecated fields for the trigger instance
        /// </param>
        public GetTriggerInstancesActiveResponseItem(
            string id,
            string connectedAccountId,
            string triggerName,
            string connectedAccountUuid,
            string userId,
            string version,
            global::System.Collections.Generic.Dictionary<string, object?> triggerConfig,
            global::System.Collections.Generic.Dictionary<string, object?> state,
            string updatedAt,
            string connectedAccountId2,
            string triggerName2,
            string updatedAt2,
            global::System.Collections.Generic.Dictionary<string, object?> triggerConfig2,
            string? uuid,
            string? triggerData,
            string? disabledAt,
            global::G.GetTriggerInstancesActiveResponseItemDeprecated? deprecated)
        {
            this.Uuid = uuid;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ConnectedAccountId = connectedAccountId ?? throw new global::System.ArgumentNullException(nameof(connectedAccountId));
            this.TriggerName = triggerName ?? throw new global::System.ArgumentNullException(nameof(triggerName));
            this.ConnectedAccountUuid = connectedAccountUuid ?? throw new global::System.ArgumentNullException(nameof(connectedAccountUuid));
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.TriggerData = triggerData;
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.TriggerConfig = triggerConfig ?? throw new global::System.ArgumentNullException(nameof(triggerConfig));
            this.State = state ?? throw new global::System.ArgumentNullException(nameof(state));
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
            this.DisabledAt = disabledAt;
            this.ConnectedAccountId2 = connectedAccountId2 ?? throw new global::System.ArgumentNullException(nameof(connectedAccountId2));
            this.TriggerName2 = triggerName2 ?? throw new global::System.ArgumentNullException(nameof(triggerName2));
            this.UpdatedAt2 = updatedAt2 ?? throw new global::System.ArgumentNullException(nameof(updatedAt2));
            this.TriggerConfig2 = triggerConfig2 ?? throw new global::System.ArgumentNullException(nameof(triggerConfig2));
            this.Deprecated = deprecated;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTriggerInstancesActiveResponseItem" /> class.
        /// </summary>
        public GetTriggerInstancesActiveResponseItem()
        {
        }
    }
}