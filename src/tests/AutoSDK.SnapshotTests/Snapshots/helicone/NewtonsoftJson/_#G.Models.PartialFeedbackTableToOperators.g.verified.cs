//HintName: G.Models.PartialFeedbackTableToOperators.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Make all properties in T optional
    /// </summary>
    public sealed partial class PartialFeedbackTableToOperators
    {
        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::G.PartialNumberOperators? Id { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::G.PartialTimestampOperators? CreatedAt { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rating")]
        public global::G.PartialBooleanOperators? Rating { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_id")]
        public global::G.PartialTextOperators? ResponseId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialFeedbackTableToOperators" /> class.
        /// </summary>
        /// <param name="id">
        /// Make all properties in T optional
        /// </param>
        /// <param name="createdAt">
        /// Make all properties in T optional
        /// </param>
        /// <param name="rating">
        /// Make all properties in T optional
        /// </param>
        /// <param name="responseId">
        /// Make all properties in T optional
        /// </param>
        public PartialFeedbackTableToOperators(
            global::G.PartialNumberOperators? id,
            global::G.PartialTimestampOperators? createdAt,
            global::G.PartialBooleanOperators? rating,
            global::G.PartialTextOperators? responseId)
        {
            this.Id = id;
            this.CreatedAt = createdAt;
            this.Rating = rating;
            this.ResponseId = responseId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialFeedbackTableToOperators" /> class.
        /// </summary>
        public PartialFeedbackTableToOperators()
        {
        }
    }
}