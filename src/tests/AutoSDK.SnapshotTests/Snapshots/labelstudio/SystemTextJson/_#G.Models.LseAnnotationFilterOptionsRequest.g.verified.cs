//HintName: G.Models.LseAnnotationFilterOptionsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LseAnnotationFilterOptionsRequest
    {
        /// <summary>
        /// Include ground truth annotations
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ground_truth")]
        public bool? GroundTruth { get; set; }

        /// <summary>
        /// `only` - include all tasks with at least one not reviewed annotation`exclude` - exclude with at least one not reviewed annotation<br/>
        /// * `only` - only<br/>
        /// * `exclude` - exclude<br/>
        /// * `None` - None
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reviewed")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ReviewedEnumJsonConverter))]
        public global::G.ReviewedEnum? Reviewed { get; set; }

        /// <summary>
        /// Include skipped annotations
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skipped")]
        public bool? Skipped { get; set; }

        /// <summary>
        /// Include not skipped and not ground truth annotations<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usual")]
        public bool? Usual { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LseAnnotationFilterOptionsRequest" /> class.
        /// </summary>
        /// <param name="groundTruth">
        /// Include ground truth annotations
        /// </param>
        /// <param name="reviewed">
        /// `only` - include all tasks with at least one not reviewed annotation`exclude` - exclude with at least one not reviewed annotation<br/>
        /// * `only` - only<br/>
        /// * `exclude` - exclude<br/>
        /// * `None` - None
        /// </param>
        /// <param name="skipped">
        /// Include skipped annotations
        /// </param>
        /// <param name="usual">
        /// Include not skipped and not ground truth annotations<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LseAnnotationFilterOptionsRequest(
            bool? groundTruth,
            global::G.ReviewedEnum? reviewed,
            bool? skipped,
            bool? usual)
        {
            this.GroundTruth = groundTruth;
            this.Reviewed = reviewed;
            this.Skipped = skipped;
            this.Usual = usual;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LseAnnotationFilterOptionsRequest" /> class.
        /// </summary>
        public LseAnnotationFilterOptionsRequest()
        {
        }
    }
}