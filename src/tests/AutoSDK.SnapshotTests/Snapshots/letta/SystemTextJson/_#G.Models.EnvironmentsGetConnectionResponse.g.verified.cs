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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectionId")]
        public string? ConnectionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deviceId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DeviceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectionName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConnectionName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organizationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        public string? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiKeyOwner")]
        public string? ApiKeyOwner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("podId")]
        public string? PodId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectedAt")]
        public double? ConnectedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastHeartbeat")]
        public double? LastHeartbeat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastSeenAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double LastSeenAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("firstSeenAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double FirstSeenAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currentMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EnvironmentsGetConnectionResponseCurrentModeJsonConverter))]
        public global::G.EnvironmentsGetConnectionResponseCurrentMode? CurrentMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::G.EnvironmentsGetConnectionResponseMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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