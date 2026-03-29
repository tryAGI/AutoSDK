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
        [global::Newtonsoft.Json.JsonProperty("session_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string SessionId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("startup_command", Required = global::Newtonsoft.Json.Required.Always)]
        public string StartupCommand { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version")]
        public string? Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("platform")]
        public string? Platform { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_version")]
        public string? NodeVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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