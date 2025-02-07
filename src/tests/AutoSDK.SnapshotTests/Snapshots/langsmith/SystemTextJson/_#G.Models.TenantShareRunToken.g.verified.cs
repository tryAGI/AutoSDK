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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TenantShareRunTokenTypeJsonConverter))]
        public global::G.TenantShareRunTokenType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("share_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ShareToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid RunId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_name")]
        public string? RunName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_type")]
        public string? RunType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public global::System.Guid? SessionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_name")]
        public string? SessionName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TenantShareRunToken(
            string shareToken,
            global::System.DateTime createdAt,
            global::System.Guid runId,
            global::G.TenantShareRunTokenType type,
            string? runName,
            string? runType,
            global::System.Guid? sessionId,
            string? sessionName)
        {
            this.ShareToken = shareToken ?? throw new global::System.ArgumentNullException(nameof(shareToken));
            this.CreatedAt = createdAt;
            this.RunId = runId;
            this.Type = type;
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