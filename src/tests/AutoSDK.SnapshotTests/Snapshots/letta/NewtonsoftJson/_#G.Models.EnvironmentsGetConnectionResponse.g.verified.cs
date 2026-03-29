//HintName: G.Models.EnvironmentsGetConnectionResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EnvironmentsGetConnectionResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("connectionId")]
        public string? ConnectionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deviceId", Required = global::Newtonsoft.Json.Required.Always)]
        public string DeviceId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("connectionName", Required = global::Newtonsoft.Json.Required.Always)]
        public string ConnectionName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organizationId", Required = global::Newtonsoft.Json.Required.Always)]
        public string OrganizationId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("userId")]
        public string? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("apiKeyOwner")]
        public string? ApiKeyOwner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("podId")]
        public string? PodId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("connectedAt")]
        public double? ConnectedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lastHeartbeat")]
        public double? LastHeartbeat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lastSeenAt", Required = global::Newtonsoft.Json.Required.Always)]
        public double LastSeenAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("firstSeenAt", Required = global::Newtonsoft.Json.Required.Always)]
        public double FirstSeenAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("currentMode")]
        public global::G.EnvironmentsGetConnectionResponseCurrentMode? CurrentMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::G.EnvironmentsGetConnectionResponseMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentsGetConnectionResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="deviceId"></param>
        /// <param name="connectionName"></param>
        /// <param name="organizationId"></param>
        /// <param name="lastSeenAt"></param>
        /// <param name="firstSeenAt"></param>
        /// <param name="connectionId"></param>
        /// <param name="userId"></param>
        /// <param name="apiKeyOwner"></param>
        /// <param name="podId"></param>
        /// <param name="connectedAt"></param>
        /// <param name="lastHeartbeat"></param>
        /// <param name="currentMode"></param>
        /// <param name="metadata"></param>
        public EnvironmentsGetConnectionResponse(
            string id,
            string deviceId,
            string connectionName,
            string organizationId,
            double lastSeenAt,
            double firstSeenAt,
            string? connectionId,
            string? userId,
            string? apiKeyOwner,
            string? podId,
            double? connectedAt,
            double? lastHeartbeat,
            global::G.EnvironmentsGetConnectionResponseCurrentMode? currentMode,
            global::G.EnvironmentsGetConnectionResponseMetadata? metadata)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ConnectionId = connectionId;
            this.DeviceId = deviceId ?? throw new global::System.ArgumentNullException(nameof(deviceId));
            this.ConnectionName = connectionName ?? throw new global::System.ArgumentNullException(nameof(connectionName));
            this.OrganizationId = organizationId ?? throw new global::System.ArgumentNullException(nameof(organizationId));
            this.UserId = userId;
            this.ApiKeyOwner = apiKeyOwner;
            this.PodId = podId;
            this.ConnectedAt = connectedAt;
            this.LastHeartbeat = lastHeartbeat;
            this.LastSeenAt = lastSeenAt;
            this.FirstSeenAt = firstSeenAt;
            this.CurrentMode = currentMode;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentsGetConnectionResponse" /> class.
        /// </summary>
        public EnvironmentsGetConnectionResponse()
        {
        }
    }
}