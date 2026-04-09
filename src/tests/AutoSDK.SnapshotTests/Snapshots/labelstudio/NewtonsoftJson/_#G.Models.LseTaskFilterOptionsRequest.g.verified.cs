//HintName: G.Models.LseTaskFilterOptionsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LseTaskFilterOptionsRequest
    {
        /// <summary>
        /// `only` - include all tasks with at least one not skipped annotation`exclude` - exclude all tasks with at least one not skipped annotation<br/>
        /// * `only` - only<br/>
        /// * `exclude` - exclude<br/>
        /// * `None` - None
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("annotated")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.AnnotatedEnumJsonConverter))]
        public global::G.AnnotatedEnum? Annotated { get; set; }

        /// <summary>
        /// `only` - include all finished tasks (is_labeled = true)`exclude` - exclude all finished tasks<br/>
        /// * `only` - only<br/>
        /// * `exclude` - exclude<br/>
        /// * `None` - None
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("finished")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.FinishedEnumJsonConverter))]
        public global::G.FinishedEnum? Finished { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("only_with_annotations")]
        public bool? OnlyWithAnnotations { get; set; }

        /// <summary>
        /// `only` - include all reviewed tasks`exclude` - exclude all reviewed tasks<br/>
        /// * `only` - only<br/>
        /// * `exclude` - exclude<br/>
        /// * `None` - None
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reviewed")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ReviewedEnumJsonConverter))]
        public global::G.ReviewedEnum? Reviewed { get; set; }

        /// <summary>
        /// `only` - include all tasks with skipped annotations`exclude` - exclude all tasks with skipped annotations<br/>
        /// * `only` - only<br/>
        /// * `exclude` - exclude<br/>
        /// * `None` - None
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("skipped")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SkippedEnumJsonConverter))]
        public global::G.SkippedEnum? Skipped { get; set; }

        /// <summary>
        /// Apply filters from the view ID (a tab from the Data Manager)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("view")]
        public int? View { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LseTaskFilterOptionsRequest" /> class.
        /// </summary>
        /// <param name="annotated">
        /// `only` - include all tasks with at least one not skipped annotation`exclude` - exclude all tasks with at least one not skipped annotation<br/>
        /// * `only` - only<br/>
        /// * `exclude` - exclude<br/>
        /// * `None` - None
        /// </param>
        /// <param name="finished">
        /// `only` - include all finished tasks (is_labeled = true)`exclude` - exclude all finished tasks<br/>
        /// * `only` - only<br/>
        /// * `exclude` - exclude<br/>
        /// * `None` - None
        /// </param>
        /// <param name="onlyWithAnnotations">
        /// Default Value: false
        /// </param>
        /// <param name="reviewed">
        /// `only` - include all reviewed tasks`exclude` - exclude all reviewed tasks<br/>
        /// * `only` - only<br/>
        /// * `exclude` - exclude<br/>
        /// * `None` - None
        /// </param>
        /// <param name="skipped">
        /// `only` - include all tasks with skipped annotations`exclude` - exclude all tasks with skipped annotations<br/>
        /// * `only` - only<br/>
        /// * `exclude` - exclude<br/>
        /// * `None` - None
        /// </param>
        /// <param name="view">
        /// Apply filters from the view ID (a tab from the Data Manager)
        /// </param>
        public LseTaskFilterOptionsRequest(
            global::G.AnnotatedEnum? annotated,
            global::G.FinishedEnum? finished,
            bool? onlyWithAnnotations,
            global::G.ReviewedEnum? reviewed,
            global::G.SkippedEnum? skipped,
            int? view)
        {
            this.Annotated = annotated;
            this.Finished = finished;
            this.OnlyWithAnnotations = onlyWithAnnotations;
            this.Reviewed = reviewed;
            this.Skipped = skipped;
            this.View = view;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LseTaskFilterOptionsRequest" /> class.
        /// </summary>
        public LseTaskFilterOptionsRequest()
        {
        }
    }
}