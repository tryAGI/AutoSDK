﻿//HintName: G.Models.SafetyRating.g.cs

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
        [global::Newtonsoft.Json.JsonProperty("category")]
        public global::G.SafetyRatingCategory? Category { get; set; }

        /// <summary>
        /// Required. The probability of harm for this content.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("probability")]
        public global::G.SafetyRatingProbability? Probability { get; set; }

        /// <summary>
        /// Was this content blocked because of this rating?
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("blocked")]
        public bool? Blocked { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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