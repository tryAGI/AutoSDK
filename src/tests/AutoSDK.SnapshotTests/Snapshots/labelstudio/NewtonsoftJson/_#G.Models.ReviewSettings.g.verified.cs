//HintName: G.Models.ReviewSettings.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReviewSettings
    {
        /// <summary>
        /// Hide annotator names from annotations while review
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("anonymize_annotations")]
        public bool? AnonymizeAnnotations { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Instructions
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("instruction")]
        public string? Instruction { get; set; }

        /// <summary>
        /// Show only finished tasks in the review stream
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("only_finished_tasks")]
        public bool? OnlyFinishedTasks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project")]
        public int? Project { get; set; }

        /// <summary>
        /// Remove rejected annotations from labeling queue / Requeue rejected annotations back to annotators / Allow reviewer to decide: Remove or Requeue<br/>
        /// * `requeue` - Requeue<br/>
        /// * `remove` - Remove<br/>
        /// * `flexible` - Flexible
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requeue_rejected_tasks_mode")]
        public global::G.RequeueRejectedTasksModeEnum? RequeueRejectedTasksMode { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("requeue_rejected_tasks_to_annotator")]
        public bool RequeueRejectedTasksToAnnotator { get; set; } = default!;

        /// <summary>
        /// Reviewers must leave a comment on reject
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("require_comment_on_reject")]
        public bool? RequireCommentOnReject { get; set; }

        /// <summary>
        /// Task is reviewed after at least one accepted annotation / Task is reviewed when all annotations are reviewed<br/>
        /// * `all` - Task is reviewed if all annotations are reviewed<br/>
        /// * `one` - Task is reviewed if at least one annotation is reviewed
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("review_criteria")]
        public global::G.ReviewCriteriaEnum? ReviewCriteria { get; set; }

        /// <summary>
        /// Show only manually assigned tasks in the review stream
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("review_only_manual_assignments")]
        public bool? ReviewOnlyManualAssignments { get; set; }

        /// <summary>
        /// Task limit (%)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("review_task_limit_percent")]
        public string? ReviewTaskLimitPercent { get; set; }

        /// <summary>
        /// By Task ID / Random<br/>
        /// * `task_id` - By Task ID<br/>
        /// * `random` - Random
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sampling")]
        public global::G.ReviewSettingsSamplingEnum? Sampling { get; set; }

        /// <summary>
        /// Show agreement to reviewers in the Data Manager
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("show_agreement_to_reviewers")]
        public bool? ShowAgreementToReviewers { get; set; }

        /// <summary>
        /// Show the Data Manager to reviewers
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("show_data_manager_to_reviewers")]
        public bool? ShowDataManagerToReviewers { get; set; }

        /// <summary>
        /// Show before reviewing
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("show_instruction")]
        public bool? ShowInstruction { get; set; }

        /// <summary>
        /// Show unused task data columns to reviewers in the Data Manager
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("show_unused_data_columns_to_reviewers")]
        public bool? ShowUnusedDataColumnsToReviewers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReviewSettings" /> class.
        /// </summary>
        /// <param name="anonymizeAnnotations">
        /// Hide annotator names from annotations while review
        /// </param>
        /// <param name="instruction">
        /// Instructions
        /// </param>
        /// <param name="onlyFinishedTasks">
        /// Show only finished tasks in the review stream
        /// </param>
        /// <param name="project"></param>
        /// <param name="requeueRejectedTasksMode">
        /// Remove rejected annotations from labeling queue / Requeue rejected annotations back to annotators / Allow reviewer to decide: Remove or Requeue<br/>
        /// * `requeue` - Requeue<br/>
        /// * `remove` - Remove<br/>
        /// * `flexible` - Flexible
        /// </param>
        /// <param name="requireCommentOnReject">
        /// Reviewers must leave a comment on reject
        /// </param>
        /// <param name="reviewCriteria">
        /// Task is reviewed after at least one accepted annotation / Task is reviewed when all annotations are reviewed<br/>
        /// * `all` - Task is reviewed if all annotations are reviewed<br/>
        /// * `one` - Task is reviewed if at least one annotation is reviewed
        /// </param>
        /// <param name="reviewOnlyManualAssignments">
        /// Show only manually assigned tasks in the review stream
        /// </param>
        /// <param name="reviewTaskLimitPercent">
        /// Task limit (%)
        /// </param>
        /// <param name="sampling">
        /// By Task ID / Random<br/>
        /// * `task_id` - By Task ID<br/>
        /// * `random` - Random
        /// </param>
        /// <param name="showAgreementToReviewers">
        /// Show agreement to reviewers in the Data Manager
        /// </param>
        /// <param name="showDataManagerToReviewers">
        /// Show the Data Manager to reviewers
        /// </param>
        /// <param name="showInstruction">
        /// Show before reviewing
        /// </param>
        /// <param name="showUnusedDataColumnsToReviewers">
        /// Show unused task data columns to reviewers in the Data Manager
        /// </param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="requeueRejectedTasksToAnnotator">
        /// Included only in responses
        /// </param>
        public ReviewSettings(
            bool? anonymizeAnnotations,
            string? instruction,
            bool? onlyFinishedTasks,
            int? project,
            global::G.RequeueRejectedTasksModeEnum? requeueRejectedTasksMode,
            bool? requireCommentOnReject,
            global::G.ReviewCriteriaEnum? reviewCriteria,
            bool? reviewOnlyManualAssignments,
            string? reviewTaskLimitPercent,
            global::G.ReviewSettingsSamplingEnum? sampling,
            bool? showAgreementToReviewers,
            bool? showDataManagerToReviewers,
            bool? showInstruction,
            bool? showUnusedDataColumnsToReviewers,
            int id = default!,
            bool requeueRejectedTasksToAnnotator = default!)
        {
            this.AnonymizeAnnotations = anonymizeAnnotations;
            this.Id = id;
            this.Instruction = instruction;
            this.OnlyFinishedTasks = onlyFinishedTasks;
            this.Project = project;
            this.RequeueRejectedTasksMode = requeueRejectedTasksMode;
            this.RequeueRejectedTasksToAnnotator = requeueRejectedTasksToAnnotator;
            this.RequireCommentOnReject = requireCommentOnReject;
            this.ReviewCriteria = reviewCriteria;
            this.ReviewOnlyManualAssignments = reviewOnlyManualAssignments;
            this.ReviewTaskLimitPercent = reviewTaskLimitPercent;
            this.Sampling = sampling;
            this.ShowAgreementToReviewers = showAgreementToReviewers;
            this.ShowDataManagerToReviewers = showDataManagerToReviewers;
            this.ShowInstruction = showInstruction;
            this.ShowUnusedDataColumnsToReviewers = showUnusedDataColumnsToReviewers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReviewSettings" /> class.
        /// </summary>
        public ReviewSettings()
        {
        }
    }
}