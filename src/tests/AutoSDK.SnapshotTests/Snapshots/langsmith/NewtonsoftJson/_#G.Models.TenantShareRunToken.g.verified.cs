//HintName: G.Models.TenantShareRunToken.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TenantShareRunToken
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("share_token", Required = global::Newtonsoft.Json.Required.Always)]
        public string ShareToken { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("run_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid RunId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("run_name")]
        public string? RunName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("run_type")]
        public string? RunType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("session_id")]
        public global::System.Guid? SessionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("session_name")]
        public string? SessionName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TenantShareRunToken" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="shareToken"></param>
        /// <param name="createdAt"></param>
        /// <param name="runId"></param>
        /// <param name="runName"></param>
        /// <param name="runType"></param>
        /// <param name="sessionId"></param>
        /// <param name="sessionName"></param>
        public TenantShareRunToken(
            string type,
            string shareToken,
            global::System.DateTime createdAt,
            global::System.Guid runId,
            string? runName,
            string? runType,
            global::System.Guid? sessionId,
            string? sessionName)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.ShareToken = shareToken ?? throw new global::System.ArgumentNullException(nameof(shareToken));
            this.CreatedAt = createdAt;
            this.RunId = runId;
            this.RunName = runName;
            this.RunType = runType;
            this.SessionId = sessionId;
            this.SessionName = sessionName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TenantShareRunToken" /> class.
        /// </summary>
        public TenantShareRunToken()
        {
        }
    }
}