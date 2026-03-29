//HintName: G.Models.PictureClassificationMetaField.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Picture classification metadata field.
    /// </summary>
    public sealed partial class PictureClassificationMetaField
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("predictions")]
        public global::System.Collections.Generic.IList<global::G.PictureClassificationPrediction>? Predictions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PictureClassificationMetaField" /> class.
        /// </summary>
        /// <param name="predictions"></param>
        public PictureClassificationMetaField(
            global::System.Collections.Generic.IList<global::G.PictureClassificationPrediction>? predictions)
        {
            this.Predictions = predictions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PictureClassificationMetaField" /> class.
        /// </summary>
        public PictureClassificationMetaField()
        {
        }
    }
}