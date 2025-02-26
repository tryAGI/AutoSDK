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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BetaCitationsDeltaTypeJsonConverter))]
        public global::G.BetaCitationsDeltaType Type { get; set; } = global::G.BetaCitationsDeltaType.CitationsDelta;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("citation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CitationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Citation Citation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCitationsDelta" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: citations_delta
        /// </param>
        /// <param name="citation"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaCitationsDelta(
            global::G.Citation citation,
            global::G.BetaCitationsDeltaType type = global::G.BetaCitationsDeltaType.CitationsDelta)
        {
            this.Citation = citation;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCitationsDelta" /> class.
        /// </summary>
        public BetaCitationsDelta()
        {
        }
    }
}