//HintName: G.Models.CitationsDelta.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CitationsDelta
    {
        /// <summary>
        /// Default Value: citations_delta
        /// </summary>
        /// <default>global::G.CitationsDeltaType.CitationsDelta</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.CitationsDeltaType Type { get; set; } = global::G.CitationsDeltaType.CitationsDelta;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("citation", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Citation2 Citation { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CitationsDelta" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: citations_delta
        /// </param>
        /// <param name="citation"></param>
        public CitationsDelta(
            global::G.Citation2 citation,
            global::G.CitationsDeltaType type = global::G.CitationsDeltaType.CitationsDelta)
        {
            this.Citation = citation;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CitationsDelta" /> class.
        /// </summary>
        public CitationsDelta()
        {
        }
    }
}