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
        [global::System.Text.Json.Serialization.JsonPropertyName("candidate")]
        public string? Candidate { get; set; }

        /// <summary>
        /// Example: &lt;SDP_MLINE_INDEX&gt;
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sdpMLineIndex")]
        public string? SdpMLineIndex { get; set; }

        /// <summary>
        /// Example: &lt;SDP_MID&gt;
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sdpMid")]
        public string? SdpMid { get; set; }

        /// <summary>
        /// Example: &lt;USERNAME_FRAGMENT&gt;
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usernameFragment")]
        public string? UsernameFragment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}