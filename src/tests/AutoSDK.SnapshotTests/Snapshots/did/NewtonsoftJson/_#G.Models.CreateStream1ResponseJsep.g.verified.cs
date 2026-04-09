//HintName: G.Models.CreateStream1ResponseJsep.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Jsep offer object used to create a peer connection
    /// </summary>
    public sealed partial class CreateStream1ResponseJsep
    {
        /// <summary>
        /// The session description object describes the initial proposal in an offer/answer exchange.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CreateStream1ResponseJsepTypeJsonConverter))]
        public global::G.CreateStream1ResponseJsepType Type { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateStream1ResponseJsep" /> class.
        /// </summary>
        /// <param name="sdp">
        /// Describe the media communication sessions to accept the session the is being negotiated
        /// </param>
        /// <param name="type">
        /// The session description object describes the initial proposal in an offer/answer exchange.
        /// </param>
        public CreateStream1ResponseJsep(
            string sdp,
            global::G.CreateStream1ResponseJsepType type)
        {
            this.Type = type;
            this.Sdp = sdp ?? throw new global::System.ArgumentNullException(nameof(sdp));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStream1ResponseJsep" /> class.
        /// </summary>
        public CreateStream1ResponseJsep()
        {
        }
    }
}