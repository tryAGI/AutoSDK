//HintName: G.EvaluationRunsClient.EvaluationRunListV2EntityProjectEvaluationRunsGet.g.cs

#nullable enable

namespace G
{
    public partial class EvaluationRunsClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_EvaluationRunListV2EntityProjectEvaluationRunsGetSecurityRequirement0 =
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
        private static readonly global::G.EndPointSecurityRequirement[] s_EvaluationRunListV2EntityProjectEvaluationRunsGetSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_EvaluationRunListV2EntityProjectEvaluationRunsGetSecurityRequirement0,
            };
        partial void PrepareEvaluationRunListV2EntityProjectEvaluationRunsGetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string entity,
            ref string project,
            global::System.Collections.Generic.IList<string>? evaluations,
            global::System.Collections.Generic.IList<string>? models,
            global::System.Collections.Generic.IList<string>? evaluationRunIds,
            int? limit,
            int? offset);
        partial void PrepareEvaluationRunListV2EntityProjectEvaluationRunsGetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string entity,
            string project,
            global::System.Collections.Generic.IList<string>? evaluations,
            global::System.Collections.Generic.IList<string>? models,
            global::System.Collections.Generic.IList<string>? evaluationRunIds,
            int? limit,
            int? offset);
        partial void ProcessEvaluationRunListV2EntityProjectEvaluationRunsGetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessEvaluationRunListV2EntityProjectEvaluationRunsGetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Evaluation Run List<br/>
        /// List evaluation runs.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="project"></param>
        /// <param name="evaluations">
        /// Filter by evaluation references
        /// </param>
        /// <param name="models">
        /// Filter by model references
        /// </param>
        /// <param name="evaluationRunIds">
        /// Filter by evaluation run IDs
        /// </param>
        /// <param name="limit">
        /// Maximum number of evaluation runs to return
        /// </param>
        /// <param name="offset">
        /// Number of evaluation runs to skip
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.EvaluationRunReadRes>> EvaluationRunListV2EntityProjectEvaluationRunsGetAsync(
            string entity,
            string project,
            global::System.Collections.Generic.IList<string>? evaluations = default,
            global::System.Collections.Generic.IList<string>? models = default,
            global::System.Collections.Generic.IList<string>? evaluationRunIds = default,
            int? limit = default,
            int? offset = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareEvaluationRunListV2EntityProjectEvaluationRunsGetArguments(
                httpClient: HttpClient,
                entity: ref entity,
                project: ref project,
                evaluations: evaluations,
                models: models,
                evaluationRunIds: evaluationRunIds,
                limit: limit,
                offset: offset);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_EvaluationRunListV2EntityProjectEvaluationRunsGetSecurityRequirements,
                operationName: "EvaluationRunListV2EntityProjectEvaluationRunsGetAsync");

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/v2/{entity}/{project}/evaluation_runs",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("evaluations", evaluations?.ToString())
                .AddOptionalParameter("models", models?.ToString())
                .AddOptionalParameter("evaluation_run_ids", evaluationRunIds?.ToString())
                .AddOptionalParameter("limit", limit?.ToString())
                .AddOptionalParameter("offset", offset?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
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

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareEvaluationRunListV2EntityProjectEvaluationRunsGetRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                entity: entity,
                project: project,
                evaluations: evaluations,
                models: models,
                evaluationRunIds: evaluationRunIds,
                limit: limit,
                offset: offset);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessEvaluationRunListV2EntityProjectEvaluationRunsGetResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Validation Error
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::System.Exception? __exception_422 = null;
                global::G.HTTPValidationError? __value_422 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_422 = global::G.HTTPValidationError.FromJson(__content_422, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_422 = global::G.HTTPValidationError.FromJson(__content_422, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_422 = __ex;
                }

                throw new global::G.ApiException<global::G.HTTPValidationError>(
                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_422,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_422,
                    ResponseObject = __value_422,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

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
                ProcessEvaluationRunListV2EntityProjectEvaluationRunsGetResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<global::G.EvaluationRunReadRes>?>(__content, JsonSerializerOptions) ??
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
                        global::Newtonsoft.Json.JsonSerializer.Create(JsonSerializerOptions).Deserialize<global::System.Collections.Generic.IList<global::G.EvaluationRunReadRes>?>(new global::Newtonsoft.Json.JsonTextReader(new global::System.IO.StreamReader(__content))) ??
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
    }
}