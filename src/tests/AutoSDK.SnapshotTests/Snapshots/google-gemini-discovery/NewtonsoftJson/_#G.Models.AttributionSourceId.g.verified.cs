//HintName: G.Models.AttributionSourceId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Identifier for the source contributing to this attribution.
    /// </summary>
    public sealed partial class AttributionSourceId
    {
        /// <summary>
        /// Identifier for a part within a `GroundingPassage`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("groundingPassage")]
        public global::G.GroundingPassageId? GroundingPassage { get; set; }

        /// <summary>
        /// Identifier for a `Chunk` retrieved via Semantic Retriever specified in the `GenerateAnswerRequest` using `SemanticRetrieverConfig`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("semanticRetrieverChunk")]
        public global::G.SemanticRetrieverChunk? SemanticRetrieverChunk { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AttributionSourceId" /> class.
        /// </summary>
        /// <param name="groundingPassage">
        /// Identifier for a part within a `GroundingPassage`.
        /// </param>
        /// <param name="semanticRetrieverChunk">
        /// Identifier for a `Chunk` retrieved via Semantic Retriever specified in the `GenerateAnswerRequest` using `SemanticRetrieverConfig`.
        /// </param>
        public AttributionSourceId(
            global::G.GroundingPassageId? groundingPassage,
            global::G.SemanticRetrieverChunk? semanticRetrieverChunk)
        {
            this.GroundingPassage = groundingPassage;
            this.SemanticRetrieverChunk = semanticRetrieverChunk;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AttributionSourceId" /> class.
        /// </summary>
        public AttributionSourceId()
        {
        }
    }
}