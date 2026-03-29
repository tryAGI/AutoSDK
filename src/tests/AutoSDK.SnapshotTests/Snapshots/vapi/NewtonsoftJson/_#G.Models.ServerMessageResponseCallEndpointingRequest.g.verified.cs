//HintName: G.Models.ServerMessageResponseCallEndpointingRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ServerMessageResponseCallEndpointingRequest
    {
        /// <summary>
        /// This is the timeout in seconds to wait before considering the user's speech as finished.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timeoutSeconds", Required = global::Newtonsoft.Json.Required.Always)]
        public double TimeoutSeconds { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerMessageResponseCallEndpointingRequest" /> class.
        /// </summary>
        /// <param name="timeoutSeconds">
        /// This is the timeout in seconds to wait before considering the user's speech as finished.
        /// </param>
        public ServerMessageResponseCallEndpointingRequest(
            double timeoutSeconds)
        {
            this.TimeoutSeconds = timeoutSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerMessageResponseCallEndpointingRequest" /> class.
        /// </summary>
        public ServerMessageResponseCallEndpointingRequest()
        {
        }
    }
}