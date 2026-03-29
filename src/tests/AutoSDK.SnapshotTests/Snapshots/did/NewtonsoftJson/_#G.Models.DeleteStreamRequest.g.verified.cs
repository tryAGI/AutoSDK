//HintName: G.Models.DeleteStreamRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteStreamRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteStreamRequest" /> class.
        /// </summary>
        /// <param name="sessionId"></param>
        public DeleteStreamRequest(
            string? sessionId)
        {
            this.SessionId = sessionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteStreamRequest" /> class.
        /// </summary>
        public DeleteStreamRequest()
        {
        }
    }
}