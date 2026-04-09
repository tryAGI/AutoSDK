//HintName: G.Models.BetaCitationsDelta.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaCitationsDelta
    {
        /// <summary>
        /// Default Value: citations_delta
        /// </summary>
        /// <default>global::G.BetaCitationsDeltaType.CitationsDelta</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.BetaCitationsDeltaTypeJsonConverter))]
        public global::G.BetaCitationsDeltaType Type { get; set; } = global::G.BetaCitationsDeltaType.CitationsDelta;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("citation", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Citation Citation { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCitationsDelta" /> class.
        /// </summary>
        /// <param name="citation"></param>
        /// <param name="type">
        /// Default Value: citations_delta
        /// </param>
        public BetaCitationsDelta(
            global::G.Citation citation,
            global::G.BetaCitationsDeltaType type = global::G.BetaCitationsDeltaType.CitationsDelta)
        {
            this.Type = type;
            this.Citation = citation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCitationsDelta" /> class.
        /// </summary>
        public BetaCitationsDelta()
        {
        }
    }
}