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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CitationsDeltaTypeJsonConverter))]
        public global::G.CitationsDeltaType Type { get; set; } = global::G.CitationsDeltaType.CitationsDelta;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("citation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.Citation2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Citation2 Citation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CitationsDelta" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: citations_delta
        /// </param>
        /// <param name="citation"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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