//HintName: G.Models.PatchedCommentRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Comment Serializer with FSM state support.<br/>
    /// Note: The 'state' field will be populated from the queryset annotation<br/>
    /// if present, preventing N+1 queries. Use .with_state() on your queryset.<br/>
    /// The state field display is controlled by both:<br/>
    /// - fflag_feat_fit_568_finite_state_management (FSM background calculations)<br/>
    /// - fflag_feat_fit_710_fsm_state_fields (state field display in APIs)
    /// </summary>
    public sealed partial class PatchedCommentRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("annotation")]
        public int? Annotation { get; set; }

        /// <summary>
        /// Classifications applied by a reviewer or annotator
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("classifications")]
        public object? Classifications { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("draft")]
        public int? Draft { get; set; }

        /// <summary>
        /// True if the comment is resolved
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_resolved")]
        public bool? IsResolved { get; set; }

        /// <summary>
        /// Set if this comment is related to a specific part of the annotation. Normally contains region ID and control name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("region_ref")]
        public object? RegionRef { get; set; }

        /// <summary>
        /// Reviewer or annotator comment
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedCommentRequest" /> class.
        /// </summary>
        /// <param name="annotation"></param>
        /// <param name="classifications">
        /// Classifications applied by a reviewer or annotator
        /// </param>
        /// <param name="draft"></param>
        /// <param name="isResolved">
        /// True if the comment is resolved
        /// </param>
        /// <param name="regionRef">
        /// Set if this comment is related to a specific part of the annotation. Normally contains region ID and control name.
        /// </param>
        /// <param name="text">
        /// Reviewer or annotator comment
        /// </param>
        public PatchedCommentRequest(
            int? annotation,
            object? classifications,
            int? draft,
            bool? isResolved,
            object? regionRef,
            string? text)
        {
            this.Annotation = annotation;
            this.Classifications = classifications;
            this.Draft = draft;
            this.IsResolved = isResolved;
            this.RegionRef = regionRef;
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedCommentRequest" /> class.
        /// </summary>
        public PatchedCommentRequest()
        {
        }
    }
}