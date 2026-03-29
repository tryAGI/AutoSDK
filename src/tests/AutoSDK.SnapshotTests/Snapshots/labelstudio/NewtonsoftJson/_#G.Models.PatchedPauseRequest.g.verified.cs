//HintName: G.Models.PatchedPauseRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A ModelSerializer that takes additional arguments for<br/>
    /// "fields", "omit" and "expand" in order to<br/>
    /// control which fields are displayed, and whether to replace simple<br/>
    /// values with complex, nested serializations
    /// </summary>
    public sealed partial class PatchedPauseRequest
    {
        /// <summary>
        /// Reason for pausing<br/>
        /// * `MANUAL` - Manual<br/>
        /// * `BEHAVIOR_BASED` - Behavior-based<br/>
        /// * `ANNOTATOR_EVALUATION` - Annotator evaluation<br/>
        /// * `ANNOTATION_LIMIT` - Annotation limit<br/>
        /// * `CUSTOM_SCRIPT` - Custom script
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reason")]
        public global::G.ReasonEnum? Reason { get; set; }

        /// <summary>
        /// Detailed description of why the project is paused, will be readable by paused annotators
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("verbose_reason")]
        public string? VerboseReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedPauseRequest" /> class.
        /// </summary>
        /// <param name="reason">
        /// Reason for pausing<br/>
        /// * `MANUAL` - Manual<br/>
        /// * `BEHAVIOR_BASED` - Behavior-based<br/>
        /// * `ANNOTATOR_EVALUATION` - Annotator evaluation<br/>
        /// * `ANNOTATION_LIMIT` - Annotation limit<br/>
        /// * `CUSTOM_SCRIPT` - Custom script
        /// </param>
        /// <param name="verboseReason">
        /// Detailed description of why the project is paused, will be readable by paused annotators
        /// </param>
        public PatchedPauseRequest(
            global::G.ReasonEnum? reason,
            string? verboseReason)
        {
            this.Reason = reason;
            this.VerboseReason = verboseReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedPauseRequest" /> class.
        /// </summary>
        public PatchedPauseRequest()
        {
        }
    }
}