//HintName: G.Models.PingResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"message":"pong"}
    /// </summary>
    public sealed partial class PingResponse
    {
        /// <summary>
        /// The message
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PingResponse" /> class.
        /// </summary>
        /// <param name="message">
        /// The message
        /// </param>
        public PingResponse(
            string? message)
        {
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PingResponse" /> class.
        /// </summary>
        public PingResponse()
        {
        }
    }
}