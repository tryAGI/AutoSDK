//HintName: G.Models.ServerMessageResponseHandoffDestinationRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ServerMessageResponseHandoffDestinationRequest
    {
        /// <summary>
        /// This is the local tool result message returned for the handoff tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public string? Result { get; set; }

        /// <summary>
        /// This is the destination you'd like the call to be transferred to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destination")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Destination { get; set; }

        /// <summary>
        /// This is the error message if the handoff should not be made.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerMessageResponseHandoffDestinationRequest" /> class.
        /// </summary>
        /// <param name="destination">
        /// This is the destination you'd like the call to be transferred to.
        /// </param>
        /// <param name="result">
        /// This is the local tool result message returned for the handoff tool call.
        /// </param>
        /// <param name="error">
        /// This is the error message if the handoff should not be made.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ServerMessageResponseHandoffDestinationRequest(
            object destination,
            string? result,
            string? error)
        {
            this.Result = result;
            this.Destination = destination ?? throw new global::System.ArgumentNullException(nameof(destination));
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerMessageResponseHandoffDestinationRequest" /> class.
        /// </summary>
        public ServerMessageResponseHandoffDestinationRequest()
        {
        }
    }
}