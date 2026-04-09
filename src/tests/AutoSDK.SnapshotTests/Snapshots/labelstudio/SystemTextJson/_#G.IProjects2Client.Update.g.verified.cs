//HintName: G.IProjects2Client.Update.g.cs
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace G
{
    public partial interface IProjects2Client
    {
        /// <summary>
        /// Update project details<br/>
        /// Update the details of a specific project.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="membersLimit">
        /// Default Value: 10
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.LseProjectUpdate> UpdateAsync(
            int id,

            global::G.PatchedLseProjectUpdateRequest request,
            int? membersLimit = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update project details<br/>
        /// Update the details of a specific project.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="membersLimit">
        /// Default Value: 10
        /// </param>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.LseProjectUpdate> UpdateAsync(
            int id,
            int? membersLimit = default,
            global::G.AgreementMethodologyEnum? agreementMethodology = default,
            string? agreementThreshold = default,
            int? annotationLimitCount = default,
            string? annotationLimitPercent = default,
            int? annotatorEvaluationContinuousTasks = default,
            bool? annotatorEvaluationEnabled = default,
            string? annotatorEvaluationMinimumScore = default,
            int? annotatorEvaluationMinimumTasks = default,
            int? annotatorEvaluationOnboardingTasks = default,
            global::G.AssignmentSettingsRequest? assignmentSettings = default,
            string? color = default,
            string? commentClassificationConfig = default,
            global::System.Collections.Generic.Dictionary<string, global::G.ControlTagWeightRequest>? controlWeights = default,
            global::G.UserSimpleRequest? createdBy = default,
            string? customScript = default,
            int? customTaskLockTtl = default,
            string? description = default,
            bool? enableEmptyAnnotation = default,
            bool? evaluatePredictionsAutomatically = default,
            string? expertInstruction = default,
            bool? isDraft = default,
            bool? isPublished = default,
            string? labelConfig = default,
            int? maxAdditionalAnnotatorsAssignable = default,
            int? maximumAnnotations = default,
            int? minAnnotationsToStartTraining = default,
            string? modelVersion = default,
            int? organization = default,
            int? overlapCohortPercentage = default,
            bool? pauseOnFailedAnnotatorEvaluation = default,
            global::System.DateTime? pinnedAt = default,
            bool? requireCommentOnSkip = default,
            bool? revealPreannotationsInteractively = default,
            global::G.ReviewSettingsRequest? reviewSettings = default,
            global::G.SamplingDe5Enum? sampling = default,
            bool? showAnnotationHistory = default,
            bool? showCollabPredictions = default,
            bool? showInstruction = default,
            bool? showOverlapFirst = default,
            bool? showSkipButton = default,
            bool? showUnusedDataColumnsToAnnotators = default,
            global::G.SkipQueueEnum? skipQueue = default,
            bool? strictTaskOverlap = default,
            string? taskDataLogin = default,
            string? taskDataPassword = default,
            string? title = default,
            int? workspace = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}