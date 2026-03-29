//HintName: G.Models.ServerMessageResponseTransferDestinationRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ServerMessageResponseTransferDestinationRequest
    {
        /// <summary>
        /// This is the destination you'd like the call to be transferred to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("destination")]
        public global::G.OneOf<global::G.TransferDestinationAssistant, global::G.TransferDestinationNumber, global::G.TransferDestinationSip>? Destination { get; set; }

        /// <summary>
        /// This is the message that will be spoken to the user as the tool is running.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public global::G.OneOf<global::G.ToolMessageStart, global::G.ToolMessageComplete, global::G.ToolMessageFailed, global::G.ToolMessageDelayed>? Message { get; set; }

        /// <summary>
        /// This is the error message if the transfer should not be made.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerMessageResponseTransferDestinationRequest" /> class.
        /// </summary>
        /// <param name="destination">
        /// This is the destination you'd like the call to be transferred to.
        /// </param>
        /// <param name="message">
        /// This is the message that will be spoken to the user as the tool is running.
        /// </param>
        /// <param name="error">
        /// This is the error message if the transfer should not be made.
        /// </param>
        public ServerMessageResponseTransferDestinationRequest(
            global::G.OneOf<global::G.TransferDestinationAssistant, global::G.TransferDestinationNumber, global::G.TransferDestinationSip>? destination,
            global::G.OneOf<global::G.ToolMessageStart, global::G.ToolMessageComplete, global::G.ToolMessageFailed, global::G.ToolMessageDelayed>? message,
            string? error)
        {
            this.Destination = destination;
            this.Message = message;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerMessageResponseTransferDestinationRequest" /> class.
        /// </summary>
        public ServerMessageResponseTransferDestinationRequest()
        {
        }
    }
}