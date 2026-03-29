//HintName: G.Models.AnswerJsep.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnswerJsep
    {
        /// <summary>
        /// The SDP contained in the sdp property is the definitive choice in the exchange. In other words, this session<br/>
        /// description describes the agreed-upon configuration, and is being sent to finalize negotiation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.AnswerJsepType Type { get; set; }

        /// <summary>
        /// Describe the media communication sessions to accept the session the is being negotiated
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sdp", Required = global::Newtonsoft.Json.Required.Always)]
        public string Sdp { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnswerJsep" /> class.
        /// </summary>
        /// <param name="sdp">
        /// Describe the media communication sessions to accept the session the is being negotiated
        /// </param>
        /// <param name="type">
        /// The SDP contained in the sdp property is the definitive choice in the exchange. In other words, this session<br/>
        /// description describes the agreed-upon configuration, and is being sent to finalize negotiation.
        /// </param>
        public AnswerJsep(
            string sdp,
            global::G.AnswerJsepType type)
        {
            this.Type = type;
            this.Sdp = sdp ?? throw new global::System.ArgumentNullException(nameof(sdp));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnswerJsep" /> class.
        /// </summary>
        public AnswerJsep()
        {
        }
    }
}