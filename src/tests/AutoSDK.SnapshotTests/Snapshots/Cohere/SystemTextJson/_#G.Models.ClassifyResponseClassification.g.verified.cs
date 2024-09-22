//HintName: G.Models.ClassifyResponseClassification.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Included only in responses
    /// </summary>
    public sealed partial class ClassifyResponseClassification
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The input text that was classified<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public string? Input { get; set; }

        /// <summary>
        /// The predicted label for the associated query (only filled for single-label models)<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prediction")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? Prediction { get; set; }

        /// <summary>
        /// An array containing the predicted labels for the associated query (only filled for single-label classification)<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("predictions")]
        public global::System.Collections.Generic.IList<string> Predictions { get; set; } = default!;

        /// <summary>
        /// The confidence score for the top predicted class (only filled for single-label classification)<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public float? Confidence { get; set; }

        /// <summary>
        /// An array containing the confidence scores of all the predictions in the same order<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidences")]
        public global::System.Collections.Generic.IList<float> Confidences { get; set; } = default!;

        /// <summary>
        /// A map containing each label and its confidence score according to the classifier. All the confidence scores add up to 1 for single-label classification. For multi-label classification the label confidences are independent of each other, so they don't have to sum up to 1.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        public global::G.ClassifyResponseClassificationLabels Labels { get; set; } = default!;

        /// <summary>
        /// The type of classification performed<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classification_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ClassifyResponseClassificationClassificationTypeJsonConverter))]
        public global::G.ClassifyResponseClassificationClassificationType ClassificationType { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}