//HintName: G.Models.CreateStreamResponseJsep2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Jsep offer object used to create a peer connection
    /// </summary>
    public sealed partial class CreateStreamResponseJsep2
    {
        /// <summary>
        /// The session description object describes the initial proposal in an offer/answer exchange.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CreateStreamResponseJsepType2JsonConverter))]
        public global::G.CreateStreamResponseJsepType2 Type { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateStreamResponseJsep2" /> class.
        /// </summary>
        /// <param name="sdp">
        /// Describe the media communication sessions to accept the session the is being negotiated
        /// </param>
        /// <param name="type">
        /// The session description object describes the initial proposal in an offer/answer exchange.
        /// </param>
        public CreateStreamResponseJsep2(
            string sdp,
            global::G.CreateStreamResponseJsepType2 type)
        {
            this.Type = type;
            this.Sdp = sdp ?? throw new global::System.ArgumentNullException(nameof(sdp));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStreamResponseJsep2" /> class.
        /// </summary>
        public CreateStreamResponseJsep2()
        {
        }
    }
}