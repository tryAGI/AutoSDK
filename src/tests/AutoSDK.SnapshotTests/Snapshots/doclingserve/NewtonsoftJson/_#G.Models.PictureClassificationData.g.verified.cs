//HintName: G.Models.PictureClassificationData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// PictureClassificationData.
    /// </summary>
    public sealed partial class PictureClassificationData
    {
        /// <summary>
        /// Default Value: classification
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("kind")]
        public string? Kind { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provenance", Required = global::Newtonsoft.Json.Required.Always)]
        public string Provenance { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("predicted_classes", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.PictureClassificationClass> PredictedClasses { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PictureClassificationData" /> class.
        /// </summary>
        /// <param name="provenance"></param>
        /// <param name="predictedClasses"></param>
        /// <param name="kind">
        /// Default Value: classification
        /// </param>
        public PictureClassificationData(
            string provenance,
            global::System.Collections.Generic.IList<global::G.PictureClassificationClass> predictedClasses,
            string? kind)
        {
            this.Kind = kind;
            this.Provenance = provenance ?? throw new global::System.ArgumentNullException(nameof(provenance));
            this.PredictedClasses = predictedClasses ?? throw new global::System.ArgumentNullException(nameof(predictedClasses));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PictureClassificationData" /> class.
        /// </summary>
        public PictureClassificationData()
        {
        }
    }
}