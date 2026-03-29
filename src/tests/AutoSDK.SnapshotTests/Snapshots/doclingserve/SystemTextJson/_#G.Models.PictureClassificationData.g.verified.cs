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
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        public string? Kind { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provenance")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provenance { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("predicted_classes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.PictureClassificationClass> PredictedClasses { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PictureClassificationData" /> class.
        /// </summary>
        /// <param name="provenance"></param>
        /// <param name="predictedClasses"></param>
        /// <param name="kind">
        /// Default Value: classification
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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