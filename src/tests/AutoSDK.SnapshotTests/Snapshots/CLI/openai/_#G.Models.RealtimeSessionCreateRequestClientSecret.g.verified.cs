//HintName: G.Models.RealtimeSessionCreateRequestClientSecret.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration options for the generated client secret.
    /// </summary>
    public sealed partial class RealtimeSessionCreateRequestClientSecret
    {
        /// <summary>
        /// Configuration for the ephemeral token expiration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public global::G.RealtimeSessionCreateRequestClientSecretExpiresAt? ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSessionCreateRequestClientSecret" /> class.
        /// </summary>
        /// <param name="expiresAt">
        /// Configuration for the ephemeral token expiration.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeSessionCreateRequestClientSecret(
            global::G.RealtimeSessionCreateRequestClientSecretExpiresAt? expiresAt)
        {
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSessionCreateRequestClientSecret" /> class.
        /// </summary>
        public RealtimeSessionCreateRequestClientSecret()
        {
        }
    }
}