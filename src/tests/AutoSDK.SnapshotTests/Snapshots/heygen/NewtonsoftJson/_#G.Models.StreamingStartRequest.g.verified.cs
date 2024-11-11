//HintName: G.Models.StreamingStartRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StreamingStartRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sdp")]
        public global::G.StreamingStartRequestSdp? Sdp { get; set; }

        /// <summary>
        /// Example: f8c1f5bd-edbd-11ee-ac61-06daf6be75b4
        /// </summary>
        /// <example>f8c1f5bd-edbd-11ee-ac61-06daf6be75b4</example>
        [global::Newtonsoft.Json.JsonProperty("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamingStartRequest" /> class.
        /// </summary>
        /// <param name="sdp"></param>
        /// <param name="sessionId">
        /// Example: f8c1f5bd-edbd-11ee-ac61-06daf6be75b4
        /// </param>
        public StreamingStartRequest(
            global::G.StreamingStartRequestSdp? sdp,
            string? sessionId)
        {
            this.Sdp = sdp;
            this.SessionId = sessionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamingStartRequest" /> class.
        /// </summary>
        public StreamingStartRequest()
        {
        }
    }
}