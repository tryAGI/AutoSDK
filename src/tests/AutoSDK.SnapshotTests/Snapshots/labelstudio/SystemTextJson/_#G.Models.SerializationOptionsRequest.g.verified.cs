//HintName: G.Models.SerializationOptionsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SerializationOptionsRequest
    {
        /// <summary>
        /// JSON dict with parameters
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotations__completed_by")]
        public global::G.SerializationOptionRequest? AnnotationsCompletedBy { get; set; }

        /// <summary>
        /// JSON dict with parameters
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("drafts")]
        public global::G.SerializationOptionRequest? Drafts { get; set; }

        /// <summary>
        /// Include annotation history<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_annotation_history")]
        public bool? IncludeAnnotationHistory { get; set; }

        /// <summary>
        /// Interpolate video key frames<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interpolate_key_frames")]
        public bool? InterpolateKeyFrames { get; set; }

        /// <summary>
        /// JSON dict with parameters
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("predictions")]
        public global::G.SerializationOptionRequest? Predictions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializationOptionsRequest" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SerializationOptionsRequest(
            global::G.SerializationOptionRequest? annotationsCompletedBy,
            global::G.SerializationOptionRequest? drafts,
            bool? includeAnnotationHistory,
            bool? interpolateKeyFrames,
            global::G.SerializationOptionRequest? predictions)
        {
            this.AnnotationsCompletedBy = annotationsCompletedBy;
            this.Drafts = drafts;
            this.IncludeAnnotationHistory = includeAnnotationHistory;
            this.InterpolateKeyFrames = interpolateKeyFrames;
            this.Predictions = predictions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializationOptionsRequest" /> class.
        /// </summary>
        public SerializationOptionsRequest()
        {
        }
    }
}