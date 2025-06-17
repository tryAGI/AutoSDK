﻿//HintName: G.Models.ClassifyResponseClassification.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Included only in responses
    /// </summary>
    public sealed partial class ClassifyResponseClassification
    {
        /// <summary>
        /// The type of classification performed<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("classification_type")]
        public global::G.ClassifyResponseClassificationClassificationType ClassificationType { get; set; } = default!;

        /// <summary>
        /// The confidence score for the top predicted class (only filled for single-label classification)<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("confidence")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public float? Confidence { get; set; }

        /// <summary>
        /// An array containing the confidence scores of all the predictions in the same order<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("confidences")]
        public global::System.Collections.Generic.IList<float> Confidences { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The input text that was classified<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input")]
        public string? Input { get; set; }

        /// <summary>
        /// A map containing each label and its confidence score according to the classifier. All the confidence scores add up to 1 for single-label classification. For multi-label classification the label confidences are independent of each other, so they don't have to sum up to 1.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("labels")]
        public global::System.Collections.Generic.Dictionary<string, global::G.ClassifyResponseClassificationLabels2> Labels { get; set; } = default!;

        /// <summary>
        /// The predicted label for the associated query (only filled for single-label models)<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prediction")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? Prediction { get; set; }

        /// <summary>
        /// An array containing the predicted labels for the associated query (only filled for single-label classification)<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("predictions")]
        public global::System.Collections.Generic.IList<string> Predictions { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifyResponseClassification" /> class.
        /// </summary>
        /// <param name="classificationType">
        /// The type of classification performed<br/>
        /// Included only in responses
        /// </param>
        /// <param name="confidences">
        /// An array containing the confidence scores of all the predictions in the same order<br/>
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="input">
        /// The input text that was classified<br/>
        /// Included only in responses
        /// </param>
        /// <param name="labels">
        /// A map containing each label and its confidence score according to the classifier. All the confidence scores add up to 1 for single-label classification. For multi-label classification the label confidences are independent of each other, so they don't have to sum up to 1.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="predictions">
        /// An array containing the predicted labels for the associated query (only filled for single-label classification)<br/>
        /// Included only in responses
        /// </param>
        public ClassifyResponseClassification(
            string? input,
            global::G.ClassifyResponseClassificationClassificationType classificationType = default!,
            global::System.Collections.Generic.IList<float> confidences = default!,
            string id = default!,
            global::System.Collections.Generic.Dictionary<string, global::G.ClassifyResponseClassificationLabels2> labels = default!,
            global::System.Collections.Generic.IList<string> predictions = default!)
        {
            this.ClassificationType = classificationType;
            this.Confidences = confidences;
            this.Id = id;
            this.Input = input;
            this.Labels = labels;
            this.Predictions = predictions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifyResponseClassification" /> class.
        /// </summary>
        public ClassifyResponseClassification()
        {
        }
    }
}