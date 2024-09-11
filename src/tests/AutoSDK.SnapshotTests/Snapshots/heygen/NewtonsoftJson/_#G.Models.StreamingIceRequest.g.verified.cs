//HintName: G.Models.StreamingIceRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StreamingIceRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("candidate")]
        public global::G.StreamingIceRequestCandidate? Candidate { get; set; }

        /// <summary>
        /// Example: &lt;SESSION_ID&gt;
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}