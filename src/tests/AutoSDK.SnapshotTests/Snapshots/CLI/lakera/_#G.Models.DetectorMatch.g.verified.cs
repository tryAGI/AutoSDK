//HintName: G.Models.DetectorMatch.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DetectorMatch
    {
        /// <summary>
        /// The matched text span.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Start character offset of the match in the original text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        public int? Start { get; set; }

        /// <summary>
        /// End character offset of the match in the original text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        public int? End { get; set; }

        /// <summary>
        /// The type of entity detected (for PII detector), e.g., email, phone_number, credit_card.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity_type")]
        public string? EntityType { get; set; }

        /// <summary>
        /// Confidence score for this specific match.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        public double? Confidence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectorMatch" /> class.
        /// </summary>
        /// <param name="text">
        /// The matched text span.
        /// </param>
        /// <param name="start">
        /// Start character offset of the match in the original text.
        /// </param>
        /// <param name="end">
        /// End character offset of the match in the original text.
        /// </param>
        /// <param name="entityType">
        /// The type of entity detected (for PII detector), e.g., email, phone_number, credit_card.
        /// </param>
        /// <param name="confidence">
        /// Confidence score for this specific match.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DetectorMatch(
            string? text,
            int? start,
            int? end,
            string? entityType,
            double? confidence)
        {
            this.Text = text;
            this.Start = start;
            this.End = end;
            this.EntityType = entityType;
            this.Confidence = confidence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectorMatch" /> class.
        /// </summary>
        public DetectorMatch()
        {
        }
    }
}