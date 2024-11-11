//HintName: G.Models.StreamingIceRequestCandidate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StreamingIceRequestCandidate
    {
        /// <summary>
        /// Example: &lt;CANDIDATE&gt;
        /// </summary>
        /// <example>&lt;CANDIDATE&gt;</example>
        [global::Newtonsoft.Json.JsonProperty("candidate")]
        public string? Candidate { get; set; }

        /// <summary>
        /// Example: &lt;SDP_MLINE_INDEX&gt;
        /// </summary>
        /// <example>&lt;SDP_MLINE_INDEX&gt;</example>
        [global::Newtonsoft.Json.JsonProperty("sdpMLineIndex")]
        public string? SdpMLineIndex { get; set; }

        /// <summary>
        /// Example: &lt;SDP_MID&gt;
        /// </summary>
        /// <example>&lt;SDP_MID&gt;</example>
        [global::Newtonsoft.Json.JsonProperty("sdpMid")]
        public string? SdpMid { get; set; }

        /// <summary>
        /// Example: &lt;USERNAME_FRAGMENT&gt;
        /// </summary>
        /// <example>&lt;USERNAME_FRAGMENT&gt;</example>
        [global::Newtonsoft.Json.JsonProperty("usernameFragment")]
        public string? UsernameFragment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamingIceRequestCandidate" /> class.
        /// </summary>
        /// <param name="candidate">
        /// Example: &lt;CANDIDATE&gt;
        /// </param>
        /// <param name="sdpMLineIndex">
        /// Example: &lt;SDP_MLINE_INDEX&gt;
        /// </param>
        /// <param name="sdpMid">
        /// Example: &lt;SDP_MID&gt;
        /// </param>
        /// <param name="usernameFragment">
        /// Example: &lt;USERNAME_FRAGMENT&gt;
        /// </param>
        public StreamingIceRequestCandidate(
            string? candidate,
            string? sdpMLineIndex,
            string? sdpMid,
            string? usernameFragment)
        {
            this.Candidate = candidate;
            this.SdpMLineIndex = sdpMLineIndex;
            this.SdpMid = sdpMid;
            this.UsernameFragment = usernameFragment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamingIceRequestCandidate" /> class.
        /// </summary>
        public StreamingIceRequestCandidate()
        {
        }
    }
}