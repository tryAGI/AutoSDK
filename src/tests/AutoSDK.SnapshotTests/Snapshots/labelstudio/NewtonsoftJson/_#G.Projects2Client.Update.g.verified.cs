//HintName: G.Projects2Client.Update.g.cs

#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace G
{
    public partial class Projects2Client
    {


        private static readonly global::G.EndPointSecurityRequirement s_UpdateSecurityRequirement0 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::G.EndPointSecurityRequirement[] s_UpdateSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_UpdateSecurityRequirement0,
            };
        partial void PrepareUpdateArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int id,
            ref int? membersLimit,
            global::G.PatchedLseProjectUpdateRequest request);
        partial void PrepareUpdateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int id,
            int? membersLimit,
            global::G.PatchedLseProjectUpdateRequest request);
        partial void ProcessUpdateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update project details<br/>
        /// Update the details of a specific project.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="membersLimit">
        /// Default Value: 10
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.LseProjectUpdate> UpdateAsync(
            int id,

            global::G.PatchedLseProjectUpdateRequest request,
            int? membersLimit = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareUpdateArguments(
                httpClient: HttpClient,
                id: ref id,
                membersLimit: ref membersLimit,
                request: request);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_UpdateSecurityRequirements,
                operationName: "UpdateAsync");

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/api/projects/{id}/",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("members_limit", membersLimit?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareUpdateRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                id: id,
                membersLimit: membersLimit,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessUpdateResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessUpdateResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.LseProjectUpdate.FromJson(__content, JsonSerializerOptions) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::G.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::G.LseProjectUpdate.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::G.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.LseProjectUpdate> UpdateAsync(
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
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.PatchedLseProjectUpdateRequest
            {
                AgreementMethodology = agreementMethodology,
                AgreementThreshold = agreementThreshold,
                AnnotationLimitCount = annotationLimitCount,
                AnnotationLimitPercent = annotationLimitPercent,
                AnnotatorEvaluationContinuousTasks = annotatorEvaluationContinuousTasks,
                AnnotatorEvaluationEnabled = annotatorEvaluationEnabled,
                AnnotatorEvaluationMinimumScore = annotatorEvaluationMinimumScore,
                AnnotatorEvaluationMinimumTasks = annotatorEvaluationMinimumTasks,
                AnnotatorEvaluationOnboardingTasks = annotatorEvaluationOnboardingTasks,
                AssignmentSettings = assignmentSettings,
                Color = color,
                CommentClassificationConfig = commentClassificationConfig,
                ControlWeights = controlWeights,
                CreatedBy = createdBy,
                CustomScript = customScript,
                CustomTaskLockTtl = customTaskLockTtl,
                Description = description,
                EnableEmptyAnnotation = enableEmptyAnnotation,
                EvaluatePredictionsAutomatically = evaluatePredictionsAutomatically,
                ExpertInstruction = expertInstruction,
                IsDraft = isDraft,
                IsPublished = isPublished,
                LabelConfig = labelConfig,
                MaxAdditionalAnnotatorsAssignable = maxAdditionalAnnotatorsAssignable,
                MaximumAnnotations = maximumAnnotations,
                MinAnnotationsToStartTraining = minAnnotationsToStartTraining,
                ModelVersion = modelVersion,
                Organization = organization,
                OverlapCohortPercentage = overlapCohortPercentage,
                PauseOnFailedAnnotatorEvaluation = pauseOnFailedAnnotatorEvaluation,
                PinnedAt = pinnedAt,
                RequireCommentOnSkip = requireCommentOnSkip,
                RevealPreannotationsInteractively = revealPreannotationsInteractively,
                ReviewSettings = reviewSettings,
                Sampling = sampling,
                ShowAnnotationHistory = showAnnotationHistory,
                ShowCollabPredictions = showCollabPredictions,
                ShowInstruction = showInstruction,
                ShowOverlapFirst = showOverlapFirst,
                ShowSkipButton = showSkipButton,
                ShowUnusedDataColumnsToAnnotators = showUnusedDataColumnsToAnnotators,
                SkipQueue = skipQueue,
                StrictTaskOverlap = strictTaskOverlap,
                TaskDataLogin = taskDataLogin,
                TaskDataPassword = taskDataPassword,
                Title = title,
                Workspace = workspace,
            };

            return await UpdateAsync(
                id: id,
                membersLimit: membersLimit,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}