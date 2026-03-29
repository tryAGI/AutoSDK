//HintName: G.Models.PatchedLseProjectUpdateRequest.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Serializer get numbers from project queryset annotation,<br/>
    /// make sure, that you use correct one(Project.objects.with_counts())
    /// </summary>
    public sealed partial class PatchedLseProjectUpdateRequest
    {
        /// <summary>
        /// Methodology (Consensus / Pairwise Averaging)<br/>
        /// * `consensus` - Consensus<br/>
        /// * `pairwise` - Pairwise Averaging<br/>
        /// Default Value: pairwise
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agreement_methodology")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AgreementMethodologyEnumJsonConverter))]
        public global::G.AgreementMethodologyEnum? AgreementMethodology { get; set; }

        /// <summary>
        /// Agreement threshold
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agreement_threshold")]
        public string? AgreementThreshold { get; set; }

        /// <summary>
        /// Limit by number of tasks
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotation_limit_count")]
        public int? AnnotationLimitCount { get; set; }

        /// <summary>
        /// Limit by percentage of tasks
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotation_limit_percent")]
        public string? AnnotationLimitPercent { get; set; }

        /// <summary>
        /// Continuous Evaluation: Required tasks<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotator_evaluation_continuous_tasks")]
        public int? AnnotatorEvaluationContinuousTasks { get; set; }

        /// <summary>
        /// Evaluate all annotators against ground truth
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotator_evaluation_enabled")]
        public bool? AnnotatorEvaluationEnabled { get; set; }

        /// <summary>
        /// Score required to pass evaluation<br/>
        /// Default Value: 95.00
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotator_evaluation_minimum_score")]
        public string? AnnotatorEvaluationMinimumScore { get; set; }

        /// <summary>
        /// Number of tasks for evaluation<br/>
        /// Default Value: 10
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotator_evaluation_minimum_tasks")]
        public int? AnnotatorEvaluationMinimumTasks { get; set; }

        /// <summary>
        /// Onboarding Evaluation: Required tasks<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotator_evaluation_onboarding_tasks")]
        public int? AnnotatorEvaluationOnboardingTasks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignment_settings")]
        public global::G.AssignmentSettingsRequest? AssignmentSettings { get; set; }

        /// <summary>
        /// Color
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("color")]
        public string? Color { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment_classification_config")]
        public string? CommentClassificationConfig { get; set; }

        /// <summary>
        /// Dict of weights for each control tag in metric calculation. Keys are control tag names from the labeling config. At least one tag must have a non-zero overall weight.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("control_weights")]
        public global::System.Collections.Generic.Dictionary<string, global::G.ControlTagWeightRequest>? ControlWeights { get; set; }

        /// <summary>
        /// Project owner
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public global::G.UserSimpleRequest? CreatedBy { get; set; }

        /// <summary>
        /// Plugins
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_script")]
        public string? CustomScript { get; set; }

        /// <summary>
        /// Task reservation time. TTL in seconds (UI displays and edits this value in minutes).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_task_lock_ttl")]
        public int? CustomTaskLockTtl { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Allow empty annotations
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_empty_annotation")]
        public bool? EnableEmptyAnnotation { get; set; }

        /// <summary>
        /// Retrieve and display predictions when loading a task
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluate_predictions_automatically")]
        public bool? EvaluatePredictionsAutomatically { get; set; }

        /// <summary>
        /// Instructions
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expert_instruction")]
        public string? ExpertInstruction { get; set; }

        /// <summary>
        /// Whether or not the project is in the middle of being created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_draft")]
        public bool? IsDraft { get; set; }

        /// <summary>
        /// Whether or not the project is published to annotators
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_published")]
        public bool? IsPublished { get; set; }

        /// <summary>
        /// Labeling Configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label_config")]
        public string? LabelConfig { get; set; }

        /// <summary>
        /// Maximum additional annotators
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_additional_annotators_assignable")]
        public int? MaxAdditionalAnnotatorsAssignable { get; set; }

        /// <summary>
        /// Annotations per task
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maximum_annotations")]
        public int? MaximumAnnotations { get; set; }

        /// <summary>
        /// Minimum number of completed tasks after which model training is started
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_annotations_to_start_training")]
        public int? MinAnnotationsToStartTraining { get; set; }

        /// <summary>
        /// Machine learning model version
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_version")]
        public string? ModelVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        public int? Organization { get; set; }

        /// <summary>
        /// Annotations per task coverage
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overlap_cohort_percentage")]
        public int? OverlapCohortPercentage { get; set; }

        /// <summary>
        /// Pause annotator on failed evaluation<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pause_on_failed_annotator_evaluation")]
        public bool? PauseOnFailedAnnotatorEvaluation { get; set; }

        /// <summary>
        /// Pinned date and time
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pinned_at")]
        public global::System.DateTime? PinnedAt { get; set; }

        /// <summary>
        /// Require comment to skip<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("require_comment_on_skip")]
        public bool? RequireCommentOnSkip { get; set; }

        /// <summary>
        /// Reveal pre-annotations interactively
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reveal_preannotations_interactively")]
        public bool? RevealPreannotationsInteractively { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("review_settings")]
        public global::G.ReviewSettingsRequest? ReviewSettings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampling")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SamplingDe5EnumJsonConverter))]
        public global::G.SamplingDe5Enum? Sampling { get; set; }

        /// <summary>
        /// Show Data Manager to Annotators
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("show_annotation_history")]
        public bool? ShowAnnotationHistory { get; set; }

        /// <summary>
        /// Use predictions to pre-label Tasks
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("show_collab_predictions")]
        public bool? ShowCollabPredictions { get; set; }

        /// <summary>
        /// Onboarding mode (true): show ground truth tasks first in the labeling stream
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("show_ground_truth_first")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? ShowGroundTruthFirst { get; set; }

        /// <summary>
        /// Show instructions before labeling
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("show_instruction")]
        public bool? ShowInstruction { get; set; }

        /// <summary>
        /// Show tasks with overlap first
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("show_overlap_first")]
        public bool? ShowOverlapFirst { get; set; }

        /// <summary>
        /// Allow skipping tasks
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("show_skip_button")]
        public bool? ShowSkipButton { get; set; }

        /// <summary>
        /// Show only columns used in labeling configuration to Annotators. API uses inverse field semantics here: set false to show only used columns, set true to show all task.data columns.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("show_unused_data_columns_to_annotators")]
        public bool? ShowUnusedDataColumnsToAnnotators { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skip_queue")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SkipQueueEnumJsonConverter))]
        public global::G.SkipQueueEnum? SkipQueue { get; set; }

        /// <summary>
        /// Enforce strict overlap limit<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strict_task_overlap")]
        public bool? StrictTaskOverlap { get; set; }

        /// <summary>
        /// Login
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_data_login")]
        public string? TaskDataLogin { get; set; }

        /// <summary>
        /// Password
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_data_password")]
        public string? TaskDataPassword { get; set; }

        /// <summary>
        /// Project Name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Workspace
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace")]
        public int? Workspace { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedLseProjectUpdateRequest" /> class.
        /// </summary>
        /// <param name="agreementMethodology">
        /// Methodology (Consensus / Pairwise Averaging)<br/>
        /// * `consensus` - Consensus<br/>
        /// * `pairwise` - Pairwise Averaging<br/>
        /// Default Value: pairwise
        /// </param>
        /// <param name="agreementThreshold">
        /// Agreement threshold
        /// </param>
        /// <param name="annotationLimitCount">
        /// Limit by number of tasks
        /// </param>
        /// <param name="annotationLimitPercent">
        /// Limit by percentage of tasks
        /// </param>
        /// <param name="annotatorEvaluationContinuousTasks">
        /// Continuous Evaluation: Required tasks<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="annotatorEvaluationEnabled">
        /// Evaluate all annotators against ground truth
        /// </param>
        /// <param name="annotatorEvaluationMinimumScore">
        /// Score required to pass evaluation<br/>
        /// Default Value: 95.00
        /// </param>
        /// <param name="annotatorEvaluationMinimumTasks">
        /// Number of tasks for evaluation<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="annotatorEvaluationOnboardingTasks">
        /// Onboarding Evaluation: Required tasks<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="assignmentSettings"></param>
        /// <param name="color">
        /// Color
        /// </param>
        /// <param name="commentClassificationConfig"></param>
        /// <param name="controlWeights">
        /// Dict of weights for each control tag in metric calculation. Keys are control tag names from the labeling config. At least one tag must have a non-zero overall weight.
        /// </param>
        /// <param name="createdBy">
        /// Project owner
        /// </param>
        /// <param name="customScript">
        /// Plugins
        /// </param>
        /// <param name="customTaskLockTtl">
        /// Task reservation time. TTL in seconds (UI displays and edits this value in minutes).
        /// </param>
        /// <param name="description">
        /// Description
        /// </param>
        /// <param name="enableEmptyAnnotation">
        /// Allow empty annotations
        /// </param>
        /// <param name="evaluatePredictionsAutomatically">
        /// Retrieve and display predictions when loading a task
        /// </param>
        /// <param name="expertInstruction">
        /// Instructions
        /// </param>
        /// <param name="isDraft">
        /// Whether or not the project is in the middle of being created
        /// </param>
        /// <param name="isPublished">
        /// Whether or not the project is published to annotators
        /// </param>
        /// <param name="labelConfig">
        /// Labeling Configuration
        /// </param>
        /// <param name="maxAdditionalAnnotatorsAssignable">
        /// Maximum additional annotators
        /// </param>
        /// <param name="maximumAnnotations">
        /// Annotations per task
        /// </param>
        /// <param name="minAnnotationsToStartTraining">
        /// Minimum number of completed tasks after which model training is started
        /// </param>
        /// <param name="modelVersion">
        /// Machine learning model version
        /// </param>
        /// <param name="organization"></param>
        /// <param name="overlapCohortPercentage">
        /// Annotations per task coverage
        /// </param>
        /// <param name="pauseOnFailedAnnotatorEvaluation">
        /// Pause annotator on failed evaluation<br/>
        /// Default Value: false
        /// </param>
        /// <param name="pinnedAt">
        /// Pinned date and time
        /// </param>
        /// <param name="requireCommentOnSkip">
        /// Require comment to skip<br/>
        /// Default Value: false
        /// </param>
        /// <param name="revealPreannotationsInteractively">
        /// Reveal pre-annotations interactively
        /// </param>
        /// <param name="reviewSettings"></param>
        /// <param name="sampling"></param>
        /// <param name="showAnnotationHistory">
        /// Show Data Manager to Annotators
        /// </param>
        /// <param name="showCollabPredictions">
        /// Use predictions to pre-label Tasks
        /// </param>
        /// <param name="showInstruction">
        /// Show instructions before labeling
        /// </param>
        /// <param name="showOverlapFirst">
        /// Show tasks with overlap first
        /// </param>
        /// <param name="showSkipButton">
        /// Allow skipping tasks
        /// </param>
        /// <param name="showUnusedDataColumnsToAnnotators">
        /// Show only columns used in labeling configuration to Annotators. API uses inverse field semantics here: set false to show only used columns, set true to show all task.data columns.
        /// </param>
        /// <param name="skipQueue"></param>
        /// <param name="strictTaskOverlap">
        /// Enforce strict overlap limit<br/>
        /// Default Value: true
        /// </param>
        /// <param name="taskDataLogin">
        /// Login
        /// </param>
        /// <param name="taskDataPassword">
        /// Password
        /// </param>
        /// <param name="title">
        /// Project Name
        /// </param>
        /// <param name="workspace">
        /// Workspace
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchedLseProjectUpdateRequest(
            global::G.AgreementMethodologyEnum? agreementMethodology,
            string? agreementThreshold,
            int? annotationLimitCount,
            string? annotationLimitPercent,
            int? annotatorEvaluationContinuousTasks,
            bool? annotatorEvaluationEnabled,
            string? annotatorEvaluationMinimumScore,
            int? annotatorEvaluationMinimumTasks,
            int? annotatorEvaluationOnboardingTasks,
            global::G.AssignmentSettingsRequest? assignmentSettings,
            string? color,
            string? commentClassificationConfig,
            global::System.Collections.Generic.Dictionary<string, global::G.ControlTagWeightRequest>? controlWeights,
            global::G.UserSimpleRequest? createdBy,
            string? customScript,
            int? customTaskLockTtl,
            string? description,
            bool? enableEmptyAnnotation,
            bool? evaluatePredictionsAutomatically,
            string? expertInstruction,
            bool? isDraft,
            bool? isPublished,
            string? labelConfig,
            int? maxAdditionalAnnotatorsAssignable,
            int? maximumAnnotations,
            int? minAnnotationsToStartTraining,
            string? modelVersion,
            int? organization,
            int? overlapCohortPercentage,
            bool? pauseOnFailedAnnotatorEvaluation,
            global::System.DateTime? pinnedAt,
            bool? requireCommentOnSkip,
            bool? revealPreannotationsInteractively,
            global::G.ReviewSettingsRequest? reviewSettings,
            global::G.SamplingDe5Enum? sampling,
            bool? showAnnotationHistory,
            bool? showCollabPredictions,
            bool? showInstruction,
            bool? showOverlapFirst,
            bool? showSkipButton,
            bool? showUnusedDataColumnsToAnnotators,
            global::G.SkipQueueEnum? skipQueue,
            bool? strictTaskOverlap,
            string? taskDataLogin,
            string? taskDataPassword,
            string? title,
            int? workspace)
        {
            this.AgreementMethodology = agreementMethodology;
            this.AgreementThreshold = agreementThreshold;
            this.AnnotationLimitCount = annotationLimitCount;
            this.AnnotationLimitPercent = annotationLimitPercent;
            this.AnnotatorEvaluationContinuousTasks = annotatorEvaluationContinuousTasks;
            this.AnnotatorEvaluationEnabled = annotatorEvaluationEnabled;
            this.AnnotatorEvaluationMinimumScore = annotatorEvaluationMinimumScore;
            this.AnnotatorEvaluationMinimumTasks = annotatorEvaluationMinimumTasks;
            this.AnnotatorEvaluationOnboardingTasks = annotatorEvaluationOnboardingTasks;
            this.AssignmentSettings = assignmentSettings;
            this.Color = color;
            this.CommentClassificationConfig = commentClassificationConfig;
            this.ControlWeights = controlWeights;
            this.CreatedBy = createdBy;
            this.CustomScript = customScript;
            this.CustomTaskLockTtl = customTaskLockTtl;
            this.Description = description;
            this.EnableEmptyAnnotation = enableEmptyAnnotation;
            this.EvaluatePredictionsAutomatically = evaluatePredictionsAutomatically;
            this.ExpertInstruction = expertInstruction;
            this.IsDraft = isDraft;
            this.IsPublished = isPublished;
            this.LabelConfig = labelConfig;
            this.MaxAdditionalAnnotatorsAssignable = maxAdditionalAnnotatorsAssignable;
            this.MaximumAnnotations = maximumAnnotations;
            this.MinAnnotationsToStartTraining = minAnnotationsToStartTraining;
            this.ModelVersion = modelVersion;
            this.Organization = organization;
            this.OverlapCohortPercentage = overlapCohortPercentage;
            this.PauseOnFailedAnnotatorEvaluation = pauseOnFailedAnnotatorEvaluation;
            this.PinnedAt = pinnedAt;
            this.RequireCommentOnSkip = requireCommentOnSkip;
            this.RevealPreannotationsInteractively = revealPreannotationsInteractively;
            this.ReviewSettings = reviewSettings;
            this.Sampling = sampling;
            this.ShowAnnotationHistory = showAnnotationHistory;
            this.ShowCollabPredictions = showCollabPredictions;
            this.ShowInstruction = showInstruction;
            this.ShowOverlapFirst = showOverlapFirst;
            this.ShowSkipButton = showSkipButton;
            this.ShowUnusedDataColumnsToAnnotators = showUnusedDataColumnsToAnnotators;
            this.SkipQueue = skipQueue;
            this.StrictTaskOverlap = strictTaskOverlap;
            this.TaskDataLogin = taskDataLogin;
            this.TaskDataPassword = taskDataPassword;
            this.Title = title;
            this.Workspace = workspace;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedLseProjectUpdateRequest" /> class.
        /// </summary>
        public PatchedLseProjectUpdateRequest()
        {
        }
    }
}