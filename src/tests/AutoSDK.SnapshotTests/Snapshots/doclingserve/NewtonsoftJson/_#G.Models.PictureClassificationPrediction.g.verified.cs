//HintName: G.Models.PictureClassificationPrediction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Picture classification instance.
    /// </summary>
    public sealed partial class PictureClassificationPrediction
    {
        /// <summary>
        /// The confidence of the prediction.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("confidence")]
        public double? Confidence { get; set; }

        /// <summary>
        /// The origin of the prediction.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("class_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ClassName { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PictureClassificationPrediction" /> class.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="confidence">
        /// The confidence of the prediction.
        /// </param>
        /// <param name="createdBy">
        /// The origin of the prediction.
        /// </param>
        public PictureClassificationPrediction(
            string className,
            double? confidence,
            string? createdBy)
        {
            this.Confidence = confidence;
            this.CreatedBy = createdBy;
            this.ClassName = className ?? throw new global::System.ArgumentNullException(nameof(className));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PictureClassificationPrediction" /> class.
        /// </summary>
        public PictureClassificationPrediction()
        {
        }
    }
}