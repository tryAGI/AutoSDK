//HintName: G.Models.ClassifyResponseClassification.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClassifyResponseClassification
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The input text that was classified
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input")]
        public string? Input { get; set; }

        /// <summary>
        /// The predicted label for the associated query (only filled for single-label models)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prediction")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? Prediction { get; set; }

        /// <summary>
        /// An array containing the predicted labels for the associated query (only filled for single-label classification)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("predictions", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Predictions { get; set; } = default!;

        /// <summary>
        /// The confidence score for the top predicted class (only filled for single-label classification)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("confidence")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public float Confidence { get; set; }

        /// <summary>
        /// An array containing the confidence scores of all the predictions in the same order
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("confidences", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<float> Confidences { get; set; } = default!;

        /// <summary>
        /// A map containing each label and its confidence score according to the classifier. All the confidence scores add up to 1 for single-label classification. For multi-label classification the label confidences are independent of each other, so they don't have to sum up to 1.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("labels", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ClassifyResponseClassificationLabels Labels { get; set; } = default!;

        /// <summary>
        /// The type of classification performed
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("classification_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ClassifyResponseClassificationClassificationType ClassificationType { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}