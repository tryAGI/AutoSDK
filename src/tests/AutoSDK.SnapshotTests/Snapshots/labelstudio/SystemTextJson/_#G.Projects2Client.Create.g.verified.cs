//HintName: G.Projects2Client.Create.g.cs

#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace G
{
    public partial class Projects2Client
    {


        private static readonly global::G.EndPointSecurityRequirement s_CreateSecurityRequirement0 =
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
        private static readonly global::G.EndPointSecurityRequirement[] s_CreateSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_CreateSecurityRequirement0,
            };
        partial void PrepareCreateArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.LseProjectCreateRequest request);
        partial void PrepareCreateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.LseProjectCreateRequest request);
        partial void ProcessCreateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a project<br/>
        /// Create a project for a specific organization.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.LseProjectCreate> CreateAsync(

            global::G.LseProjectCreateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateSecurityRequirements,
                operationName: "CreateAsync");

            var __pathBuilder = new global::G.PathBuilder(
                path: "/api/projects/",
                baseUri: HttpClient.BaseAddress);
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
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
            PrepareCreateRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateResponse(
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
                ProcessCreateResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.LseProjectCreate.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.LseProjectCreate.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Create a project<br/>
        /// Create a project for a specific organization.
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.LseProjectCreate> CreateAsync(
            bool? annotatorEvaluationEnabled = default,
            string? color = default,
            global::System.Collections.Generic.Dictionary<string, global::G.ControlTagWeightRequest>? controlWeights = default,
            global::G.UserSimpleRequest? createdBy = default,
            string? description = default,
            bool? enableEmptyAnnotation = default,
            bool? evaluatePredictionsAutomatically = default,
            string? expertInstruction = default,
            bool? isDraft = default,
            bool? isPublished = default,
            string? labelConfig = default,
            int? maximumAnnotations = default,
            int? minAnnotationsToStartTraining = default,
            string? modelVersion = default,
            int? organization = default,
            int? overlapCohortPercentage = default,
            global::System.DateTime? pinnedAt = default,
            bool? revealPreannotationsInteractively = default,
            global::G.SamplingDe5Enum? sampling = default,
            bool? showAnnotationHistory = default,
            bool? showCollabPredictions = default,
            bool? showInstruction = default,
            bool? showOverlapFirst = default,
            bool? showSkipButton = default,
            global::G.SkipQueueEnum? skipQueue = default,
            string? taskDataLogin = default,
            string? taskDataPassword = default,
            string? title = default,
            int? workspace = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.LseProjectCreateRequest
            {
                AnnotatorEvaluationEnabled = annotatorEvaluationEnabled,
                Color = color,
                ControlWeights = controlWeights,
                CreatedBy = createdBy,
                Description = description,
                EnableEmptyAnnotation = enableEmptyAnnotation,
                EvaluatePredictionsAutomatically = evaluatePredictionsAutomatically,
                ExpertInstruction = expertInstruction,
                IsDraft = isDraft,
                IsPublished = isPublished,
                LabelConfig = labelConfig,
                MaximumAnnotations = maximumAnnotations,
                MinAnnotationsToStartTraining = minAnnotationsToStartTraining,
                ModelVersion = modelVersion,
                Organization = organization,
                OverlapCohortPercentage = overlapCohortPercentage,
                PinnedAt = pinnedAt,
                RevealPreannotationsInteractively = revealPreannotationsInteractively,
                Sampling = sampling,
                ShowAnnotationHistory = showAnnotationHistory,
                ShowCollabPredictions = showCollabPredictions,
                ShowInstruction = showInstruction,
                ShowOverlapFirst = showOverlapFirst,
                ShowSkipButton = showSkipButton,
                SkipQueue = skipQueue,
                TaskDataLogin = taskDataLogin,
                TaskDataPassword = taskDataPassword,
                Title = title,
                Workspace = workspace,
            };

            return await CreateAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}