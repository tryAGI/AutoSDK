//HintName: G.Models.SerializationOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SerializationOptions
    {
        /// <summary>
        /// JSON dict with parameters
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("annotations__completed_by")]
        public global::G.SerializationOption? AnnotationsCompletedBy { get; set; }

        /// <summary>
        /// JSON dict with parameters
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("drafts")]
        public global::G.SerializationOption? Drafts { get; set; }

        /// <summary>
        /// Include annotation history<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("include_annotation_history")]
        public bool? IncludeAnnotationHistory { get; set; }

        /// <summary>
        /// Interpolate video key frames<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("interpolate_key_frames")]
        public bool? InterpolateKeyFrames { get; set; }

        /// <summary>
        /// JSON dict with parameters
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("predictions")]
        public global::G.SerializationOption? Predictions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializationOptions" /> class.
        /// </summary>
        /// <param name="annotationsCompletedBy">
        /// JSON dict with parameters
        /// </param>
        /// <param name="drafts">
        /// JSON dict with parameters
        /// </param>
        /// <param name="includeAnnotationHistory">
        /// Include annotation history<br/>
        /// Default Value: false
        /// </param>
        /// <param name="interpolateKeyFrames">
        /// Interpolate video key frames<br/>
        /// Default Value: false
        /// </param>
        /// <param name="predictions">
        /// JSON dict with parameters
        /// </param>
        public SerializationOptions(
            global::G.SerializationOption? annotationsCompletedBy,
            global::G.SerializationOption? drafts,
            bool? includeAnnotationHistory,
            bool? interpolateKeyFrames,
            global::G.SerializationOption? predictions)
        {
            this.AnnotationsCompletedBy = annotationsCompletedBy;
            this.Drafts = drafts;
            this.IncludeAnnotationHistory = includeAnnotationHistory;
            this.InterpolateKeyFrames = interpolateKeyFrames;
            this.Predictions = predictions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializationOptions" /> class.
        /// </summary>
        public SerializationOptions()
        {
        }
    }
}