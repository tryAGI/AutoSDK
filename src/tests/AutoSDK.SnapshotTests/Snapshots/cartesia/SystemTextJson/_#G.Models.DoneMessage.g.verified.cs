//HintName: G.Models.DoneMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Acknowledgment message sent in response to a `done` command, indicating that the session is complete and the WebSocket will close.
    /// </summary>
    public sealed partial class DoneMessage
    {
        /// <summary>
        /// Unique identifier for this transcription session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DoneMessage" /> class.
        /// </summary>
        /// <param name="requestId">
        /// Unique identifier for this transcription session.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DoneMessage(
            string requestId)
        {
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DoneMessage" /> class.
        /// </summary>
        public DoneMessage()
        {
        }
    }
}