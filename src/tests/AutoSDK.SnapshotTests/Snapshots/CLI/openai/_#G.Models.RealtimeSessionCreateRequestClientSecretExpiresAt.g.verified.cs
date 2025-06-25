//HintName: G.Models.RealtimeSessionCreateRequestClientSecretExpiresAt.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for the ephemeral token expiration.
    /// </summary>
    public sealed partial class RealtimeSessionCreateRequestClientSecretExpiresAt
    {
        /// <summary>
        /// The anchor point for the ephemeral token expiration. Only `created_at` is currently supported.<br/>
        /// Default Value: created_at
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("anchor")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RealtimeSessionCreateRequestClientSecretExpiresAtAnchorJsonConverter))]
        public global::G.RealtimeSessionCreateRequestClientSecretExpiresAtAnchor? Anchor { get; set; }

        /// <summary>
        /// The number of seconds from the anchor point to the expiration. Select a value between `10` and `7200`.<br/>
        /// Default Value: 600
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seconds")]
        public int? Seconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSessionCreateRequestClientSecretExpiresAt" /> class.
        /// </summary>
        /// <param name="anchor">
        /// The anchor point for the ephemeral token expiration. Only `created_at` is currently supported.<br/>
        /// Default Value: created_at
        /// </param>
        /// <param name="seconds">
        /// The number of seconds from the anchor point to the expiration. Select a value between `10` and `7200`.<br/>
        /// Default Value: 600
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeSessionCreateRequestClientSecretExpiresAt(
            global::G.RealtimeSessionCreateRequestClientSecretExpiresAtAnchor? anchor,
            int? seconds)
        {
            this.Anchor = anchor;
            this.Seconds = seconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSessionCreateRequestClientSecretExpiresAt" /> class.
        /// </summary>
        public RealtimeSessionCreateRequestClientSecretExpiresAt()
        {
        }
    }
}