//HintName: G.ExperimentsClient.CreateExperiment.g.cs

#nullable enable

namespace G
{
    public partial class ExperimentsClient
    {
        partial void PrepareCreateExperimentArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.ExperimentWrite request);
        partial void PrepareCreateExperimentRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.ExperimentWrite request);
        partial void ProcessCreateExperimentResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Create experiment<br/>
        /// Create experiment
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task CreateExperimentAsync(

            global::G.ExperimentWrite request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateExperimentArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/private/experiments",
                baseUri: HttpClient.BaseAddress);
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreateExperimentRequest(
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
            ProcessCreateExperimentResponse(
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

                try
                {
                    __response.EnsureSuccessStatusCode();

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
        /// Create experiment<br/>
        /// Create experiment
        /// </summary>
        /// <param name="id"></param>
        /// <param name="datasetName"></param>
        /// <param name="projectId">
        /// Project ID. Takes precedence over project_name when both are provided.
        /// </param>
        /// <param name="projectName">
        /// Project name. Creates project if it doesn't exist. Ignored when project_id is provided.
        /// </param>
        /// <param name="name"></param>
        /// <param name="metadata"></param>
        /// <param name="tags"></param>
        /// <param name="type"></param>
        /// <param name="evaluationMethod"></param>
        /// <param name="optimizationId"></param>
        /// <param name="status"></param>
        /// <param name="experimentScores"></param>
        /// <param name="promptVersion"></param>
        /// <param name="promptVersions"></param>
        /// <param name="datasetVersionId">
        /// ID of the dataset version this experiment is linked to. If not provided at creation, experiment will be automatically linked to the latest version.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task CreateExperimentAsync(
            global::System.Guid? id = default,
            string? datasetName = default,
            global::System.Guid? projectId = default,
            string? projectName = default,
            string? name = default,
            global::G.JsonListStringWrite? metadata = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::G.ExperimentWriteType? type = default,
            global::G.ExperimentWriteEvaluationMethod? evaluationMethod = default,
            global::System.Guid? optimizationId = default,
            global::G.ExperimentWriteStatus? status = default,
            global::System.Collections.Generic.IList<global::G.ExperimentScoreWrite>? experimentScores = default,
            global::G.PromptVersionLinkWrite? promptVersion = default,
            global::System.Collections.Generic.IList<global::G.PromptVersionLinkWrite>? promptVersions = default,
            global::System.Guid? datasetVersionId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.ExperimentWrite
            {
                Id = id,
                DatasetName = datasetName,
                ProjectId = projectId,
                ProjectName = projectName,
                Name = name,
                Metadata = metadata,
                Tags = tags,
                Type = type,
                EvaluationMethod = evaluationMethod,
                OptimizationId = optimizationId,
                Status = status,
                ExperimentScores = experimentScores,
                PromptVersion = promptVersion,
                PromptVersions = promptVersions,
                DatasetVersionId = datasetVersionId,
            };

            await CreateExperimentAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}