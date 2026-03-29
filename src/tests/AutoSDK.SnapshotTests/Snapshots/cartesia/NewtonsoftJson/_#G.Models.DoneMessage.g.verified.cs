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
        [global::Newtonsoft.Json.JsonProperty("request_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string RequestId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DoneMessage" /> class.
        /// </summary>
        /// <param name="requestId">
        /// Unique identifier for this transcription session.
        /// </param>
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