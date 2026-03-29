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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// The Project ID linked to the Session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endedAt")]
        public global::System.DateTime? EndedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiresAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ExpiresAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SessionStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SessionStatus Status { get; set; }

        /// <summary>
        /// Bytes used via the [Proxy](/features/stealth-mode#proxies-and-residential-ips)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("proxyBytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long ProxyBytes { get; set; }

        /// <summary>
        /// Indicates if the Session was created to be kept alive upon disconnections
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keepAlive")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool KeepAlive { get; set; }

        /// <summary>
        /// Optional. The Context linked to the Session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contextId")]
        public string? ContextId { get; set; }

        /// <summary>
        /// The region where the Session is running.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SessionRegionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SessionRegion Region { get; set; }

        /// <summary>
        /// Arbitrary user metadata to attach to the session. To learn more about user metadata, see [User Metadata](/features/sessions#user-metadata).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userMetadata")]
        public object? UserMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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