//HintName: G.Models.McpIntegrationMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class McpIntegrationMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("server_name")]
        public string? ServerName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("server_version")]
        public string? ServerVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("protocol_version")]
        public string? ProtocolVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("capability_flags")]
        public object? CapabilityFlags { get; set; }

        /// <summary>
        /// Example: pending
        /// </summary>
        /// <example>pending</example>
        [global::Newtonsoft.Json.JsonProperty("sync_status")]
        public string? SyncStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_synced_at")]
        public global::System.DateTime? LastSyncedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sync_error")]
        public string? SyncError { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpIntegrationMetadata" /> class.
        /// </summary>
        /// <param name="serverName"></param>
        /// <param name="serverVersion"></param>
        /// <param name="protocolVersion"></param>
        /// <param name="capabilityFlags"></param>
        /// <param name="syncStatus">
        /// Example: pending
        /// </param>
        /// <param name="lastSyncedAt"></param>
        /// <param name="syncError"></param>
        public McpIntegrationMetadata(
            string? serverName,
            string? serverVersion,
            string? protocolVersion,
            object? capabilityFlags,
            string? syncStatus,
            global::System.DateTime? lastSyncedAt,
            string? syncError)
        {
            this.ServerName = serverName;
            this.ServerVersion = serverVersion;
            this.ProtocolVersion = protocolVersion;
            this.CapabilityFlags = capabilityFlags;
            this.SyncStatus = syncStatus;
            this.LastSyncedAt = lastSyncedAt;
            this.SyncError = syncError;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpIntegrationMetadata" /> class.
        /// </summary>
        public McpIntegrationMetadata()
        {
        }
    }
}