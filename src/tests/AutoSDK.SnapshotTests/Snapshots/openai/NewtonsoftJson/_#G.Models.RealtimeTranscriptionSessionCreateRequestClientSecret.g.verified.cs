//HintName: G.Models.RealtimeTranscriptionSessionCreateRequestClientSecret.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration options for the generated client secret.
    /// </summary>
    public sealed partial class RealtimeTranscriptionSessionCreateRequestClientSecret
    {
        /// <summary>
        /// Configuration for the ephemeral token expiration.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expires_at")]
        public global::G.RealtimeTranscriptionSessionCreateRequestClientSecretExpiresAt? ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranscriptionSessionCreateRequestClientSecret" /> class.
        /// </summary>
        /// <param name="expiresAt">
        /// Configuration for the ephemeral token expiration.
        /// </param>
        public RealtimeTranscriptionSessionCreateRequestClientSecret(
            global::G.RealtimeTranscriptionSessionCreateRequestClientSecretExpiresAt? expiresAt)
        {
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranscriptionSessionCreateRequestClientSecret" /> class.
        /// </summary>
        public RealtimeTranscriptionSessionCreateRequestClientSecret()
        {
        }
    }
}