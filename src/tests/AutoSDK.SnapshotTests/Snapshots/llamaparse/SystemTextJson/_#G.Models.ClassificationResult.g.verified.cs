//HintName: G.Models.ClassificationResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Result of classifying a single file.
    /// </summary>
    public sealed partial class ClassificationResult
    {
        /// <summary>
        /// Step-by-step explanation of why this classification was chosen and the confidence score assigned
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Reasoning { get; set; }

        /// <summary>
        /// Confidence score of the classification (0.0-1.0)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Confidence { get; set; }

        /// <summary>
        /// The document type that best matches, or null if no match.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassificationResult" /> class.
        /// </summary>
        /// <param name="reasoning">
        /// Step-by-step explanation of why this classification was chosen and the confidence score assigned
        /// </param>
        /// <param name="confidence">
        /// Confidence score of the classification (0.0-1.0)
        /// </param>
        /// <param name="type">
        /// The document type that best matches, or null if no match.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClassificationResult(
            string reasoning,
            double confidence,
            string? type)
        {
            this.Reasoning = reasoning ?? throw new global::System.ArgumentNullException(nameof(reasoning));
            this.Confidence = confidence;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassificationResult" /> class.
        /// </summary>
        public ClassificationResult()
        {
        }
    }
}