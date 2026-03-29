//HintName: G.Models.MetadataSendTelemetryRequestEventVariant1Data.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MetadataSendTelemetryRequestEventVariant1Data
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startup_command")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StartupCommand { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("platform")]
        public string? Platform { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_version")]
        public string? NodeVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataSendTelemetryRequestEventVariant1Data" /> class.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="startupCommand"></param>
        /// <param name="agentId"></param>
        /// <param name="version"></param>
        /// <param name="platform"></param>
        /// <param name="nodeVersion"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MetadataSendTelemetryRequestEventVariant1Data(
            string sessionId,
            string startupCommand,
            string? agentId,
            string? version,
            string? platform,
            string? nodeVersion)
        {
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
            this.AgentId = agentId;
            this.StartupCommand = startupCommand ?? throw new global::System.ArgumentNullException(nameof(startupCommand));
            this.Version = version;
            this.Platform = platform;
            this.NodeVersion = nodeVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataSendTelemetryRequestEventVariant1Data" /> class.
        /// </summary>
        public MetadataSendTelemetryRequestEventVariant1Data()
        {
        }
    }
}