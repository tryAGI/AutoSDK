//HintName: G.Models.Session.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Session
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updatedAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// The Project ID linked to the Session.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectId", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("startedAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime StartedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("endedAt")]
        public global::System.DateTime? EndedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expiresAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime ExpiresAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SessionStatusJsonConverter))]
        public global::G.SessionStatus Status { get; set; } = default!;

        /// <summary>
        /// Bytes used via the [Proxy](/features/stealth-mode#proxies-and-residential-ips)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("proxyBytes", Required = global::Newtonsoft.Json.Required.Always)]
        public long ProxyBytes { get; set; } = default!;

        /// <summary>
        /// Indicates if the Session was created to be kept alive upon disconnections
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("keepAlive", Required = global::Newtonsoft.Json.Required.Always)]
        public bool KeepAlive { get; set; } = default!;

        /// <summary>
        /// Optional. The Context linked to the Session.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("contextId")]
        public string? ContextId { get; set; }

        /// <summary>
        /// The region where the Session is running.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("region", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SessionRegionJsonConverter))]
        public global::G.SessionRegion Region { get; set; } = default!;

        /// <summary>
        /// Arbitrary user metadata to attach to the session. To learn more about user metadata, see [User Metadata](/features/sessions#user-metadata).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("userMetadata")]
        public object? UserMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Session" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="projectId">
        /// The Project ID linked to the Session.
        /// </param>
        /// <param name="startedAt"></param>
        /// <param name="expiresAt"></param>
        /// <param name="status"></param>
        /// <param name="proxyBytes">
        /// Bytes used via the [Proxy](/features/stealth-mode#proxies-and-residential-ips)
        /// </param>
        /// <param name="keepAlive">
        /// Indicates if the Session was created to be kept alive upon disconnections
        /// </param>
        /// <param name="region">
        /// The region where the Session is running.
        /// </param>
        /// <param name="endedAt"></param>
        /// <param name="contextId">
        /// Optional. The Context linked to the Session.
        /// </param>
        /// <param name="userMetadata">
        /// Arbitrary user metadata to attach to the session. To learn more about user metadata, see [User Metadata](/features/sessions#user-metadata).
        /// </param>
        public Session(
            string id,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string projectId,
            global::System.DateTime startedAt,
            global::System.DateTime expiresAt,
            global::G.SessionStatus status,
            long proxyBytes,
            bool keepAlive,
            global::G.SessionRegion region,
            global::System.DateTime? endedAt,
            string? contextId,
            object? userMetadata)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.StartedAt = startedAt;
            this.EndedAt = endedAt;
            this.ExpiresAt = expiresAt;
            this.Status = status;
            this.ProxyBytes = proxyBytes;
            this.KeepAlive = keepAlive;
            this.ContextId = contextId;
            this.Region = region;
            this.UserMetadata = userMetadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Session" /> class.
        /// </summary>
        public Session()
        {
        }
    }
}