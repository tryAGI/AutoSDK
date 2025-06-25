//HintName: G.Models.SafetyRating.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Safety rating for a piece of content. The safety rating contains the category of harm and the harm probability level in that category for a piece of content. Content is classified for safety across a number of harm categories and the probability of the harm classification is included here.
    /// </summary>
    public sealed partial class SafetyRating
    {
        /// <summary>
        /// Required. The category for this rating.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SafetyRatingCategoryJsonConverter))]
        public global::G.SafetyRatingCategory? Category { get; set; }

        /// <summary>
        /// Required. The probability of harm for this content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("probability")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SafetyRatingProbabilityJsonConverter))]
        public global::G.SafetyRatingProbability? Probability { get; set; }

        /// <summary>
        /// Was this content blocked because of this rating?
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocked")]
        public bool? Blocked { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SafetyRating" /> class.
        /// </summary>
        /// <param name="category">
        /// Required. The category for this rating.
        /// </param>
        /// <param name="probability">
        /// Required. The probability of harm for this content.
        /// </param>
        /// <param name="blocked">
        /// Was this content blocked because of this rating?
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SafetyRating(
            global::G.SafetyRatingCategory? category,
            global::G.SafetyRatingProbability? probability,
            bool? blocked)
        {
            this.Category = category;
            this.Probability = probability;
            this.Blocked = blocked;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SafetyRating" /> class.
        /// </summary>
        public SafetyRating()
        {
        }
    }
}