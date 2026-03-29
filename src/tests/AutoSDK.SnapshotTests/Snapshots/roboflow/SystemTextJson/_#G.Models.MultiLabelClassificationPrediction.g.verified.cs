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
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Confidence { get; set; }

        /// <summary>
        /// Numeric ID associated with the class label
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("class_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ClassId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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