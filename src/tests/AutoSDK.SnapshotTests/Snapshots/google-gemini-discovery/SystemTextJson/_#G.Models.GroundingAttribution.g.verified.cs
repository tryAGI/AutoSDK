//HintName: G.Models.GroundingAttribution.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Attribution for a source that contributed to an answer.
    /// </summary>
    public sealed partial class GroundingAttribution
    {
        /// <summary>
        /// Identifier for the source contributing to this attribution.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceId")]
        public global::G.AttributionSourceId? SourceId { get; set; }

        /// <summary>
        /// The base structured datatype containing multi-part content of a message. A `Content` includes a `role` field designating the producer of the `Content` and a `parts` field containing multi-part data that contains the content of the message turn.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public global::G.Content? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GroundingAttribution" /> class.
        /// </summary>
        /// <param name="sourceId">
        /// Identifier for the source contributing to this attribution.
        /// </param>
        /// <param name="content">
        /// The base structured datatype containing multi-part content of a message. A `Content` includes a `role` field designating the producer of the `Content` and a `parts` field containing multi-part data that contains the content of the message turn.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GroundingAttribution(
            global::G.AttributionSourceId? sourceId,
            global::G.Content? content)
        {
            this.SourceId = sourceId;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroundingAttribution" /> class.
        /// </summary>
        public GroundingAttribution()
        {
        }
    }
}