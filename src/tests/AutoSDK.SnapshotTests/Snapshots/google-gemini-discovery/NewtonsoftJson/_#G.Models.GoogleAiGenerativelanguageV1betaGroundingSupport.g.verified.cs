//HintName: G.Models.GoogleAiGenerativelanguageV1betaGroundingSupport.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Grounding support.
    /// </summary>
    public sealed partial class GoogleAiGenerativelanguageV1betaGroundingSupport
    {
        /// <summary>
        /// Segment of the content.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("segment")]
        public global::G.GoogleAiGenerativelanguageV1betaSegment? Segment { get; set; }

        /// <summary>
        /// Optional. A list of indices (into 'grounding_chunk' in `response.candidate.grounding_metadata`) specifying the citations associated with the claim. For instance [1,3,4] means that grounding_chunk[1], grounding_chunk[3], grounding_chunk[4] are the retrieved content attributed to the claim. If the response is streaming, the grounding_chunk_indices refer to the indices across all responses. It is the client's responsibility to accumulate the grounding chunks from all responses (while maintaining the same order).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("groundingChunkIndices")]
        public global::System.Collections.Generic.IList<int>? GroundingChunkIndices { get; set; }

        /// <summary>
        /// Optional. Confidence score of the support references. Ranges from 0 to 1. 1 is the most confident. This list must have the same size as the grounding_chunk_indices.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("confidenceScores")]
        public global::System.Collections.Generic.IList<float>? ConfidenceScores { get; set; }

        /// <summary>
        /// Output only. Indices into the `parts` field of the candidate's content. These indices specify which rendered parts are associated with this support source.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("renderedParts")]
        public global::System.Collections.Generic.IList<int>? RenderedParts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleAiGenerativelanguageV1betaGroundingSupport" /> class.
        /// </summary>
        /// <param name="segment">
        /// Segment of the content.
        /// </param>
        /// <param name="groundingChunkIndices">
        /// Optional. A list of indices (into 'grounding_chunk' in `response.candidate.grounding_metadata`) specifying the citations associated with the claim. For instance [1,3,4] means that grounding_chunk[1], grounding_chunk[3], grounding_chunk[4] are the retrieved content attributed to the claim. If the response is streaming, the grounding_chunk_indices refer to the indices across all responses. It is the client's responsibility to accumulate the grounding chunks from all responses (while maintaining the same order).
        /// </param>
        /// <param name="confidenceScores">
        /// Optional. Confidence score of the support references. Ranges from 0 to 1. 1 is the most confident. This list must have the same size as the grounding_chunk_indices.
        /// </param>
        /// <param name="renderedParts">
        /// Output only. Indices into the `parts` field of the candidate's content. These indices specify which rendered parts are associated with this support source.<br/>
        /// Included only in responses
        /// </param>
        public GoogleAiGenerativelanguageV1betaGroundingSupport(
            global::G.GoogleAiGenerativelanguageV1betaSegment? segment,
            global::System.Collections.Generic.IList<int>? groundingChunkIndices,
            global::System.Collections.Generic.IList<float>? confidenceScores,
            global::System.Collections.Generic.IList<int>? renderedParts)
        {
            this.Segment = segment;
            this.GroundingChunkIndices = groundingChunkIndices;
            this.ConfidenceScores = confidenceScores;
            this.RenderedParts = renderedParts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleAiGenerativelanguageV1betaGroundingSupport" /> class.
        /// </summary>
        public GoogleAiGenerativelanguageV1betaGroundingSupport()
        {
        }
    }
}