//HintName: G.Models.LseProjectCreateRequest.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Serializer get numbers from project queryset annotation,<br/>
    /// make sure, that you use correct one(Project.objects.with_counts())
    /// </summary>
    public sealed partial class LseProjectCreateRequest
    {
        /// <summary>
        /// Enable annotator evaluation for the project
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("annotator_evaluation_enabled")]
        public bool? AnnotatorEvaluationEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("color")]
        public string? Color { get; set; }

        /// <summary>
        /// Dict of weights for each control tag in metric calculation. Keys are control tag names from the labeling config. At least one tag must have a non-zero overall weight.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("control_weights")]
        public global::System.Collections.Generic.Dictionary<string, global::G.ControlTagWeightRequest>? ControlWeights { get; set; }

        /// <summary>
        /// Project owner
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_by")]
        public global::G.UserSimpleRequest? CreatedBy { get; set; }

        /// <summary>
        /// Project Description
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Allow annotators to submit empty annotations
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enable_empty_annotation")]
        public bool? EnableEmptyAnnotation { get; set; }

        /// <summary>
        /// Retrieve and display predictions when loading a task
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("evaluate_predictions_automatically")]
        public bool? EvaluatePredictionsAutomatically { get; set; }

        /// <summary>
        /// Labeling instructions in HTML format
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expert_instruction")]
        public string? ExpertInstruction { get; set; }

        /// <summary>
        /// Whether or not the project is in the middle of being created
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_draft")]
        public bool? IsDraft { get; set; }

        /// <summary>
        /// Whether or not the project is published to annotators
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_published")]
        public bool? IsPublished { get; set; }

        /// <summary>
        /// Label config in XML format. See more about it in documentation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("label_config")]
        public string? LabelConfig { get; set; }

        /// <summary>
        /// Maximum number of annotations for one task. If the number of annotations per task is equal or greater to this value, the task is completed (is_labeled=True)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("maximum_annotations")]
        public int? MaximumAnnotations { get; set; }

        /// <summary>
        /// Minimum number of completed tasks after which model training is started
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("min_annotations_to_start_training")]
        public int? MinAnnotationsToStartTraining { get; set; }

        /// <summary>
        /// Machine learning model version
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_version")]
        public string? ModelVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization")]
        public int? Organization { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("overlap_cohort_percentage")]
        public int? OverlapCohortPercentage { get; set; }

        /// <summary>
        /// Pinned date and time
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pinned_at")]
        public global::System.DateTime? PinnedAt { get; set; }

        /// <summary>
        /// Reveal pre-annotations interactively
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reveal_preannotations_interactively")]
        public bool? RevealPreannotationsInteractively { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sampling")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SamplingDe5EnumJsonConverter))]
        public global::G.SamplingDe5Enum? Sampling { get; set; }

        /// <summary>
        /// Show annotation history to annotator
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("show_annotation_history")]
        public bool? ShowAnnotationHistory { get; set; }

        /// <summary>
        /// If set, the annotator can view model predictions
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("show_collab_predictions")]
        public bool? ShowCollabPredictions { get; set; }

        /// <summary>
        /// Onboarding mode (true): show ground truth tasks first in the labeling stream
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("show_ground_truth_first")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? ShowGroundTruthFirst { get; set; }

        /// <summary>
        /// Show instructions to the annotator before they start
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("show_instruction")]
        public bool? ShowInstruction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("show_overlap_first")]
        public bool? ShowOverlapFirst { get; set; }

        /// <summary>
        /// Show a skip button in interface and allow annotators to skip the task
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("show_skip_button")]
        public bool? ShowSkipButton { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("skip_queue")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SkipQueueEnumJsonConverter))]
        public global::G.SkipQueueEnum? SkipQueue { get; set; }

        /// <summary>
        /// Task data credentials: login
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("task_data_login")]
        public string? TaskDataLogin { get; set; }

        /// <summary>
        /// Task data credentials: password
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("task_data_password")]
        public string? TaskDataPassword { get; set; }

        /// <summary>
        /// Project Title
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// In Workspace
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workspace")]
        public int? Workspace { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LseProjectCreateRequest" /> class.
        /// </summary>
        /// <param name="annotatorEvaluationEnabled">
        /// Enable annotator evaluation for the project
        /// </param>
        /// <param name="color"></param>
        /// <param name="controlWeights">
        /// Dict of weights for each control tag in metric calculation. Keys are control tag names from the labeling config. At least one tag must have a non-zero overall weight.
        /// </param>
        /// <param name="createdBy">
        /// Project owner
        /// </param>
        /// <param name="description">
        /// Project Description
        /// </param>
        /// <param name="enableEmptyAnnotation">
        /// Allow annotators to submit empty annotations
        /// </param>
        /// <param name="evaluatePredictionsAutomatically">
        /// Retrieve and display predictions when loading a task
        /// </param>
        /// <param name="expertInstruction">
        /// Labeling instructions in HTML format
        /// </param>
        /// <param name="isDraft">
        /// Whether or not the project is in the middle of being created
        /// </param>
        /// <param name="isPublished">
        /// Whether or not the project is published to annotators
        /// </param>
        /// <param name="labelConfig">
        /// Label config in XML format. See more about it in documentation
        /// </param>
        /// <param name="maximumAnnotations">
        /// Maximum number of annotations for one task. If the number of annotations per task is equal or greater to this value, the task is completed (is_labeled=True)
        /// </param>
        /// <param name="minAnnotationsToStartTraining">
        /// Minimum number of completed tasks after which model training is started
        /// </param>
        /// <param name="modelVersion">
        /// Machine learning model version
        /// </param>
        /// <param name="organization"></param>
        /// <param name="overlapCohortPercentage"></param>
        /// <param name="pinnedAt">
        /// Pinned date and time
        /// </param>
        /// <param name="revealPreannotationsInteractively">
        /// Reveal pre-annotations interactively
        /// </param>
        /// <param name="sampling"></param>
        /// <param name="showAnnotationHistory">
        /// Show annotation history to annotator
        /// </param>
        /// <param name="showCollabPredictions">
        /// If set, the annotator can view model predictions
        /// </param>
        /// <param name="showInstruction">
        /// Show instructions to the annotator before they start
        /// </param>
        /// <param name="showOverlapFirst"></param>
        /// <param name="showSkipButton">
        /// Show a skip button in interface and allow annotators to skip the task
        /// </param>
        /// <param name="skipQueue"></param>
        /// <param name="taskDataLogin">
        /// Task data credentials: login
        /// </param>
        /// <param name="taskDataPassword">
        /// Task data credentials: password
        /// </param>
        /// <param name="title">
        /// Project Title
        /// </param>
        /// <param name="workspace">
        /// In Workspace
        /// </param>
        public LseProjectCreateRequest(
            bool? annotatorEvaluationEnabled,
            string? color,
            global::System.Collections.Generic.Dictionary<string, global::G.ControlTagWeightRequest>? controlWeights,
            global::G.UserSimpleRequest? createdBy,
            string? description,
            bool? enableEmptyAnnotation,
            bool? evaluatePredictionsAutomatically,
            string? expertInstruction,
            bool? isDraft,
            bool? isPublished,
            string? labelConfig,
            int? maximumAnnotations,
            int? minAnnotationsToStartTraining,
            string? modelVersion,
            int? organization,
            int? overlapCohortPercentage,
            global::System.DateTime? pinnedAt,
            bool? revealPreannotationsInteractively,
            global::G.SamplingDe5Enum? sampling,
            bool? showAnnotationHistory,
            bool? showCollabPredictions,
            bool? showInstruction,
            bool? showOverlapFirst,
            bool? showSkipButton,
            global::G.SkipQueueEnum? skipQueue,
            string? taskDataLogin,
            string? taskDataPassword,
            string? title,
            int? workspace)
        {
            this.AnnotatorEvaluationEnabled = annotatorEvaluationEnabled;
            this.Color = color;
            this.ControlWeights = controlWeights;
            this.CreatedBy = createdBy;
            this.Description = description;
            this.EnableEmptyAnnotation = enableEmptyAnnotation;
            this.EvaluatePredictionsAutomatically = evaluatePredictionsAutomatically;
            this.ExpertInstruction = expertInstruction;
            this.IsDraft = isDraft;
            this.IsPublished = isPublished;
            this.LabelConfig = labelConfig;
            this.MaximumAnnotations = maximumAnnotations;
            this.MinAnnotationsToStartTraining = minAnnotationsToStartTraining;
            this.ModelVersion = modelVersion;
            this.Organization = organization;
            this.OverlapCohortPercentage = overlapCohortPercentage;
            this.PinnedAt = pinnedAt;
            this.RevealPreannotationsInteractively = revealPreannotationsInteractively;
            this.Sampling = sampling;
            this.ShowAnnotationHistory = showAnnotationHistory;
            this.ShowCollabPredictions = showCollabPredictions;
            this.ShowInstruction = showInstruction;
            this.ShowOverlapFirst = showOverlapFirst;
            this.ShowSkipButton = showSkipButton;
            this.SkipQueue = skipQueue;
            this.TaskDataLogin = taskDataLogin;
            this.TaskDataPassword = taskDataPassword;
            this.Title = title;
            this.Workspace = workspace;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LseProjectCreateRequest" /> class.
        /// </summary>
        public LseProjectCreateRequest()
        {
        }
    }
}