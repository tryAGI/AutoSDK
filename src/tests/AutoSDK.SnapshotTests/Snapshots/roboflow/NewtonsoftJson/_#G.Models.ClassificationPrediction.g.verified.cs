//HintName: G.Models.ClassificationPrediction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Classification prediction.<br/>
    /// Attributes:<br/>
    ///     class_name (str): The predicted class label.<br/>
    ///     class_id (int): Numeric ID associated with the class label.<br/>
    ///     confidence (float): The class label confidence as a fraction between 0 and 1.
    /// </summary>
    public sealed partial class ClassificationPrediction
    {
        /// <summary>
        /// The predicted class label
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("class", Required = global::Newtonsoft.Json.Required.Always)]
        public string Class { get; set; } = default!;

        /// <summary>
        /// Numeric ID associated with the class label
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("class_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int ClassId { get; set; } = default!;

        /// <summary>
        /// The class label confidence as a fraction between 0 and 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("confidence", Required = global::Newtonsoft.Json.Required.Always)]
        public double Confidence { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassificationPrediction" /> class.
        /// </summary>
        /// <param name="class">
        /// The predicted class label
        /// </param>
        /// <param name="classId">
        /// Numeric ID associated with the class label
        /// </param>
        /// <param name="confidence">
        /// The class label confidence as a fraction between 0 and 1
        /// </param>
        public ClassificationPrediction(
            string @class,
            int classId,
            double confidence)
        {
            this.Class = @class ?? throw new global::System.ArgumentNullException(nameof(@class));
            this.ClassId = classId;
            this.Confidence = confidence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassificationPrediction" /> class.
        /// </summary>
        public ClassificationPrediction()
        {
        }
    }
}