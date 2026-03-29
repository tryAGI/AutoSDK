//HintName: G.Models.MultiLabelClassificationPrediction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Multi-label Classification prediction.<br/>
    /// Attributes:<br/>
    ///     confidence (float): The class label confidence as a fraction between 0 and 1.
    /// </summary>
    public sealed partial class MultiLabelClassificationPrediction
    {
        /// <summary>
        /// The class label confidence as a fraction between 0 and 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("confidence", Required = global::Newtonsoft.Json.Required.Always)]
        public double Confidence { get; set; } = default!;

        /// <summary>
        /// Numeric ID associated with the class label
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("class_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int ClassId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MultiLabelClassificationPrediction" /> class.
        /// </summary>
        /// <param name="confidence">
        /// The class label confidence as a fraction between 0 and 1
        /// </param>
        /// <param name="classId">
        /// Numeric ID associated with the class label
        /// </param>
        public MultiLabelClassificationPrediction(
            double confidence,
            int classId)
        {
            this.Confidence = confidence;
            this.ClassId = classId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultiLabelClassificationPrediction" /> class.
        /// </summary>
        public MultiLabelClassificationPrediction()
        {
        }
    }
}