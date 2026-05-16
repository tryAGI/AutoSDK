//HintName: G.Models.RealtimeTranscriptionSessionCreated.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// session.created server event.
    /// </summary>
    public sealed partial class RealtimeTranscriptionSessionCreated
    {
        /// <summary>
        /// Must be 'session.created'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RealtimeTranscriptionSessionCreatedTypeJsonConverter))]
        public global::G.RealtimeTranscriptionSessionCreatedType Type { get; set; }

        /// <summary>
        /// Session description echoed by the server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RealtimeTranscriptionSession Session { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranscriptionSessionCreated" /> class.
        /// </summary>
        /// <param name="session">
        /// Session description echoed by the server.
        /// </param>
        /// <param name="type">
        /// Must be 'session.created'.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeTranscriptionSessionCreated(
            global::G.RealtimeTranscriptionSession session,
            global::G.RealtimeTranscriptionSessionCreatedType type)
        {
            this.Type = type;
            this.Session = session ?? throw new global::System.ArgumentNullException(nameof(session));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranscriptionSessionCreated" /> class.
        /// </summary>
        public RealtimeTranscriptionSessionCreated()
        {
        }

    }
}