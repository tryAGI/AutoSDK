//HintName: G.Models.Project.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Serializer get numbers from project queryset annotation,<br/>
    /// make sure, that you use correct one(Project.objects.with_counts())
    /// </summary>
    public sealed partial class Project
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
        /// Flag to detect is project ready for labeling<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("config_has_control_tags")]
        public bool ConfigHasControlTags { get; set; } = default!;

        /// <summary>
        /// Flag to detect is project ready for bulk annotation<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("config_suitable_for_bulk_annotation")]
        public bool ConfigSuitableForBulkAnnotation { get; set; } = default!;

        /// <summary>
        /// Dict of weights for each control tag in metric calculation. Keys are control tag names from the labeling config. At least one tag must have a non-zero overall weight.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("control_weights")]
        public global::System.Collections.Generic.Dictionary<string, global::G.ControlTagWeight>? ControlWeights { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Project owner
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_by")]
        public global::G.UserSimple? CreatedBy { get; set; }

        /// <summary>
        /// Project description
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
        /// Finished tasks<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("finished_task_number")]
        public int FinishedTaskNumber { get; set; } = default!;

        /// <summary>
        /// Honeypot annotation number in project<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("ground_truth_number")]
        public int GroundTruthNumber { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public int Id { get; set; } = default!;

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
        /// Tasks with annotations count<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("num_tasks_with_annotations")]
        public int NumTasksWithAnnotations { get; set; } = default!;

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
        /// JSON-formatted labeling configuration<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("parsed_label_config")]
        public object ParsedLabelConfig { get; set; } = default!;

        /// <summary>
        /// Pinned date and time
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pinned_at")]
        public global::System.DateTime? PinnedAt { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("queue_done")]
        public int QueueDone { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("queue_total")]
        public int QueueTotal { get; set; } = default!;

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
        /// Skipped by collaborators annotation number in project<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("skipped_annotations_number")]
        public int SkippedAnnotationsNumber { get; set; } = default!;

        /// <summary>
        /// Start model training after any annotations are submitted or updated<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("start_training_on_annotation_update")]
        public bool StartTrainingOnAnnotationUpdate { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("state")]
        public string State { get; set; } = default!;

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
        /// Total task number in project<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("task_number")]
        public int TaskNumber { get; set; } = default!;

        /// <summary>
        /// Project name. Must be between 3 and 50 characters long.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Total annotations number in project including skipped_annotations_number and ground_truth_number.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("total_annotations_number")]
        public int TotalAnnotationsNumber { get; set; } = default!;

        /// <summary>
        /// Total predictions number in project including skipped_annotations_number, ground_truth_number, and useful_annotation_number.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("total_predictions_number")]
        public int TotalPredictionsNumber { get; set; } = default!;

        /// <summary>
        /// Useful annotation number in project not including skipped_annotations_number and ground_truth_number. Total annotations = annotation_number + skipped_annotations_number + ground_truth_number<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("useful_annotation_number")]
        public int UsefulAnnotationNumber { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Project" /> class.
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
        /// Project description
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
        /// Project name. Must be between 3 and 50 characters long.
        /// </param>
        /// <param name="configHasControlTags">
        /// Flag to detect is project ready for labeling<br/>
        /// Included only in responses
        /// </param>
        /// <param name="configSuitableForBulkAnnotation">
        /// Flag to detect is project ready for bulk annotation<br/>
        /// Included only in responses
        /// </param>
        /// <param name="createdAt">
        /// Included only in responses
        /// </param>
        /// <param name="finishedTaskNumber">
        /// Finished tasks<br/>
        /// Included only in responses
        /// </param>
        /// <param name="groundTruthNumber">
        /// Honeypot annotation number in project<br/>
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="numTasksWithAnnotations">
        /// Tasks with annotations count<br/>
        /// Included only in responses
        /// </param>
        /// <param name="parsedLabelConfig">
        /// JSON-formatted labeling configuration<br/>
        /// Included only in responses
        /// </param>
        /// <param name="queueDone">
        /// Included only in responses
        /// </param>
        /// <param name="queueTotal">
        /// Included only in responses
        /// </param>
        /// <param name="skippedAnnotationsNumber">
        /// Skipped by collaborators annotation number in project<br/>
        /// Included only in responses
        /// </param>
        /// <param name="startTrainingOnAnnotationUpdate">
        /// Start model training after any annotations are submitted or updated<br/>
        /// Included only in responses
        /// </param>
        /// <param name="state">
        /// Included only in responses
        /// </param>
        /// <param name="taskNumber">
        /// Total task number in project<br/>
        /// Included only in responses
        /// </param>
        /// <param name="totalAnnotationsNumber">
        /// Total annotations number in project including skipped_annotations_number and ground_truth_number.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="totalPredictionsNumber">
        /// Total predictions number in project including skipped_annotations_number, ground_truth_number, and useful_annotation_number.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="usefulAnnotationNumber">
        /// Useful annotation number in project not including skipped_annotations_number and ground_truth_number. Total annotations = annotation_number + skipped_annotations_number + ground_truth_number<br/>
        /// Included only in responses
        /// </param>
        public Project(
            bool? annotatorEvaluationEnabled,
            string? color,
            global::System.Collections.Generic.Dictionary<string, global::G.ControlTagWeight>? controlWeights,
            global::G.UserSimple? createdBy,
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
            bool configHasControlTags = default!,
            bool configSuitableForBulkAnnotation = default!,
            global::System.DateTime createdAt = default!,
            int finishedTaskNumber = default!,
            int groundTruthNumber = default!,
            int id = default!,
            int numTasksWithAnnotations = default!,
            object parsedLabelConfig = default!,
            int queueDone = default!,
            int queueTotal = default!,
            int skippedAnnotationsNumber = default!,
            bool startTrainingOnAnnotationUpdate = default!,
            string state = default!,
            int taskNumber = default!,
            int totalAnnotationsNumber = default!,
            int totalPredictionsNumber = default!,
            int usefulAnnotationNumber = default!)
        {
            this.AnnotatorEvaluationEnabled = annotatorEvaluationEnabled;
            this.Color = color;
            this.ConfigHasControlTags = configHasControlTags;
            this.ConfigSuitableForBulkAnnotation = configSuitableForBulkAnnotation;
            this.ControlWeights = controlWeights;
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.Description = description;
            this.EnableEmptyAnnotation = enableEmptyAnnotation;
            this.EvaluatePredictionsAutomatically = evaluatePredictionsAutomatically;
            this.ExpertInstruction = expertInstruction;
            this.FinishedTaskNumber = finishedTaskNumber;
            this.GroundTruthNumber = groundTruthNumber;
            this.Id = id;
            this.IsDraft = isDraft;
            this.IsPublished = isPublished;
            this.LabelConfig = labelConfig;
            this.MaximumAnnotations = maximumAnnotations;
            this.MinAnnotationsToStartTraining = minAnnotationsToStartTraining;
            this.ModelVersion = modelVersion;
            this.NumTasksWithAnnotations = numTasksWithAnnotations;
            this.Organization = organization;
            this.OverlapCohortPercentage = overlapCohortPercentage;
            this.ParsedLabelConfig = parsedLabelConfig;
            this.PinnedAt = pinnedAt;
            this.QueueDone = queueDone;
            this.QueueTotal = queueTotal;
            this.RevealPreannotationsInteractively = revealPreannotationsInteractively;
            this.Sampling = sampling;
            this.ShowAnnotationHistory = showAnnotationHistory;
            this.ShowCollabPredictions = showCollabPredictions;
            this.ShowInstruction = showInstruction;
            this.ShowOverlapFirst = showOverlapFirst;
            this.ShowSkipButton = showSkipButton;
            this.SkipQueue = skipQueue;
            this.SkippedAnnotationsNumber = skippedAnnotationsNumber;
            this.StartTrainingOnAnnotationUpdate = startTrainingOnAnnotationUpdate;
            this.State = state;
            this.TaskDataLogin = taskDataLogin;
            this.TaskDataPassword = taskDataPassword;
            this.TaskNumber = taskNumber;
            this.Title = title;
            this.TotalAnnotationsNumber = totalAnnotationsNumber;
            this.TotalPredictionsNumber = totalPredictionsNumber;
            this.UsefulAnnotationNumber = usefulAnnotationNumber;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Project" /> class.
        /// </summary>
        public Project()
        {
        }
    }
}