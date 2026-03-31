//HintName: G.EvalsClient.EvalLaunch.g.cs

#nullable enable

namespace G
{
    public partial class EvalsClient
    {
        partial void PrepareEvalLaunchArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.RunEval request);
        partial void PrepareEvalLaunchRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.RunEval request);
        partial void ProcessEvalLaunchResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessEvalLaunchResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Launch an eval<br/>
        /// Launch an evaluation. This is the API-equivalent of the `Eval` function that is built into the Braintrust SDK. In the Eval API, you provide pointers to a dataset, task function, and scoring functions. The API will then run the evaluation, create an experiment, and return the results along with a link to the experiment. To learn more about evals, see the [Evals guide](https://www.braintrust.dev/docs/evaluate).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.SummarizeExperimentResponse> EvalLaunchAsync(

            global::G.RunEval request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareEvalLaunchArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/eval",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
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
            PrepareEvalLaunchRequest(
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
            ProcessEvalLaunchResponse(
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
                ProcessEvalLaunchResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.SummarizeExperimentResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.SummarizeExperimentResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Launch an eval<br/>
        /// Launch an evaluation. This is the API-equivalent of the `Eval` function that is built into the Braintrust SDK. In the Eval API, you provide pointers to a dataset, task function, and scoring functions. The API will then run the evaluation, create an experiment, and return the results along with a link to the experiment. To learn more about evals, see the [Evals guide](https://www.braintrust.dev/docs/evaluate).
        /// </summary>
        /// <param name="projectId">
        /// Unique identifier for the project to run the eval in
        /// </param>
        /// <param name="data">
        /// The dataset to use
        /// </param>
        /// <param name="name">
        /// The name of the eval to run when multiple evals available
        /// </param>
        /// <param name="parameters">
        /// Values for any parameters used in the eval
        /// </param>
        /// <param name="task">
        /// The function to evaluate
        /// </param>
        /// <param name="scores">
        /// The functions to score the eval on
        /// </param>
        /// <param name="experimentName">
        /// An optional name for the experiment created by this eval. If it conflicts with an existing experiment, it will be suffixed with a unique identifier.
        /// </param>
        /// <param name="metadata">
        /// Optional experiment-level metadata to store about the evaluation. You can later use this to slice &amp; dice across experiments.
        /// </param>
        /// <param name="parent"></param>
        /// <param name="stream">
        /// Whether to stream the results of the eval. If true, the request will return two events: one to indicate the experiment has started, and another upon completion. If false, the request will return the evaluation's summary upon completion.
        /// </param>
        /// <param name="trialCount">
        /// The number of times to run the evaluator per input. This is useful for evaluating applications that have non-deterministic behavior and gives you both a stronger aggregate measure and a sense of the variance in the results.
        /// </param>
        /// <param name="isPublic">
        /// Whether the experiment should be public. Defaults to false.
        /// </param>
        /// <param name="timeout">
        /// The maximum duration, in milliseconds, to run the evaluation. Defaults to undefined, in which case there is no timeout.
        /// </param>
        /// <param name="maxConcurrency">
        /// The maximum number of tasks/scorers that will be run concurrently. Defaults to 10. If null is provided, no max concurrency will be used.<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="baseExperimentName">
        /// An optional experiment name to use as a base. If specified, the new experiment will be summarized and compared to this experiment.
        /// </param>
        /// <param name="baseExperimentId">
        /// An optional experiment id to use as a base. If specified, the new experiment will be summarized and compared to this experiment.
        /// </param>
        /// <param name="gitMetadataSettings">
        /// Optional settings for collecting git metadata. By default, will collect all git metadata fields allowed in org-level settings.
        /// </param>
        /// <param name="repoInfo"></param>
        /// <param name="strict">
        /// If true, throw an error if one of the variables in the prompt is not present in the input
        /// </param>
        /// <param name="stopToken">
        /// The token to stop the run
        /// </param>
        /// <param name="extraMessages">
        /// A template path of extra messages to append to the conversion. These messages will be appended to the end of the conversation, after the last message.
        /// </param>
        /// <param name="tags">
        /// Optional tags that will be added to the experiment.
        /// </param>
        /// <param name="mcpAuth"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.SummarizeExperimentResponse> EvalLaunchAsync(
            string projectId,
            global::G.AnyOf<global::G.RunEvalDataDatasetId, global::G.RunEvalDataProjectDatasetName, global::G.RunEvalDataDatasetRows> data,
            global::G.FunctionId task,
            global::System.Collections.Generic.IList<global::G.AllOf<global::G.FunctionId?, object>> scores,
            string? name = default,
            global::System.Collections.Generic.Dictionary<string, object?>? parameters = default,
            string? experimentName = default,
            global::System.Collections.Generic.Dictionary<string, object?>? metadata = default,
            global::G.AllOf<global::G.InvokeParent?, object>? parent = default,
            bool? stream = default,
            double? trialCount = default,
            bool? isPublic = default,
            double? timeout = default,
            double? maxConcurrency = default,
            string? baseExperimentName = default,
            string? baseExperimentId = default,
            global::G.GitMetadataSettings? gitMetadataSettings = default,
            global::G.AllOf<global::G.RepoInfo, object>? repoInfo = default,
            bool? strict = default,
            string? stopToken = default,
            string? extraMessages = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::System.Collections.Generic.Dictionary<string, global::G.RunEvalMcpAuth2>? mcpAuth = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            var __request = new global::G.RunEval
            {
                ProjectId = projectId,
                Data = data,
                Name = name,
                Parameters = parameters,
                Task = task,
                Scores = scores,
                ExperimentName = experimentName,
                Metadata = metadata,
                Parent = parent,
                Stream = stream,
                TrialCount = trialCount,
                IsPublic = isPublic,
                Timeout = timeout,
                MaxConcurrency = maxConcurrency,
                BaseExperimentName = baseExperimentName,
                BaseExperimentId = baseExperimentId,
                GitMetadataSettings = gitMetadataSettings,
                RepoInfo = repoInfo,
                Strict = strict,
                StopToken = stopToken,
                ExtraMessages = extraMessages,
                Tags = tags,
                McpAuth = mcpAuth,
            };

            return await EvalLaunchAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}