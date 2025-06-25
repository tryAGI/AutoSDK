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
        [global::System.Text.Json.Serialization.JsonPropertyName("candidate")]
        public global::G.StreamingIceRequestCandidate? Candidate { get; set; }

        /// <summary>
        /// Example: &lt;SESSION_ID&gt;
        /// </summary>
        /// <example>&lt;SESSION_ID&gt;</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamingIceRequest" /> class.
        /// </summary>
        /// <param name="candidate"></param>
        /// <param name="sessionId">
        /// Example: &lt;SESSION_ID&gt;
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StreamingIceRequest(
            global::G.StreamingIceRequestCandidate? candidate,
            string? sessionId)
        {
            this.Candidate = candidate;
            this.SessionId = sessionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamingIceRequest" /> class.
        /// </summary>
        public StreamingIceRequest()
        {
        }
    }
}