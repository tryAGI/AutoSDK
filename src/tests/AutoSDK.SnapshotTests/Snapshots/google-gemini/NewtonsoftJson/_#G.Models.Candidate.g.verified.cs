//HintName: G.Models.Candidate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A response candidate generated from the model.
    /// </summary>
    public sealed partial class Candidate
    {
        /// <summary>
        /// The base structured datatype containing multi-part content of a message. A `Content` includes a `role` field designating the producer of the `Content` and a `parts` field containing multi-part data that contains the content of the message turn.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content")]
        public global::G.Content? Content { get; set; }

        /// <summary>
        /// Optional. Output only. The reason why the model stopped generating tokens. If empty, the model has not stopped generating the tokens.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("finishReason")]
        public global::G.CandidateFinishReason? FinishReason { get; set; }

        /// <summary>
        /// A collection of source attributions for a piece of content.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("citationMetadata")]
        public global::G.CitationMetadata? CitationMetadata { get; set; }

        /// <summary>
        /// Output only. Index of the candidate in the list of candidates.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index")]
        public int? Index { get; set; }

        /// <summary>
        /// Output only. Token count for this candidate.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tokenCount")]
        public int? TokenCount { get; set; }

        /// <summary>
        /// List of ratings for the safety of a response candidate. There is at most one rating per category.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("safetyRatings")]
        public global::System.Collections.Generic.IList<global::G.SafetyRating>? SafetyRatings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Candidate" /> class.
        /// </summary>
        /// <param name="content">
        /// The base structured datatype containing multi-part content of a message. A `Content` includes a `role` field designating the producer of the `Content` and a `parts` field containing multi-part data that contains the content of the message turn.
        /// </param>
        /// <param name="finishReason">
        /// Optional. Output only. The reason why the model stopped generating tokens. If empty, the model has not stopped generating the tokens.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="citationMetadata">
        /// A collection of source attributions for a piece of content.
        /// </param>
        /// <param name="index">
        /// Output only. Index of the candidate in the list of candidates.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="tokenCount">
        /// Output only. Token count for this candidate.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="safetyRatings">
        /// List of ratings for the safety of a response candidate. There is at most one rating per category.
        /// </param>
        public Candidate(
            global::G.Content? content,
            global::G.CandidateFinishReason? finishReason,
            global::G.CitationMetadata? citationMetadata,
            int? index,
            int? tokenCount,
            global::System.Collections.Generic.IList<global::G.SafetyRating>? safetyRatings)
        {
            this.Content = content;
            this.FinishReason = finishReason;
            this.CitationMetadata = citationMetadata;
            this.Index = index;
            this.TokenCount = tokenCount;
            this.SafetyRatings = safetyRatings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Candidate" /> class.
        /// </summary>
        public Candidate()
        {
        }
    }
}