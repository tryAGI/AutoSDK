//HintName: G.ScoresClient.ScoreListV2EntityProjectScoresGet.g.cs

#nullable enable

namespace G
{
    public partial class ScoresClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_ScoreListV2EntityProjectScoresGetSecurityRequirement0 =
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
        private static readonly global::G.EndPointSecurityRequirement[] s_ScoreListV2EntityProjectScoresGetSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_ScoreListV2EntityProjectScoresGetSecurityRequirement0,
            };
        partial void PrepareScoreListV2EntityProjectScoresGetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string entity,
            ref string project,
            ref string? evaluationRunId,
            int? limit,
            int? offset);
        partial void PrepareScoreListV2EntityProjectScoresGetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string entity,
            string project,
            string? evaluationRunId,
            int? limit,
            int? offset);
        partial void ProcessScoreListV2EntityProjectScoresGetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Score List<br/>
        /// List scores.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="project"></param>
        /// <param name="evaluationRunId">
        /// Filter by evaluation run ID
        /// </param>
        /// <param name="limit">
        /// Maximum number of scores to return
        /// </param>
        /// <param name="offset">
        /// Number of scores to skip
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Collections.Generic.IAsyncEnumerable<global::G.ScoreReadRes> ScoreListV2EntityProjectScoresGetAsync(
            string entity,
            string project,
            string? evaluationRunId = default,
            int? limit = default,
            int? offset = default,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareScoreListV2EntityProjectScoresGetArguments(
                httpClient: HttpClient,
                entity: ref entity,
                project: ref project,
                evaluationRunId: ref evaluationRunId,
                limit: limit,
                offset: offset);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ScoreListV2EntityProjectScoresGetSecurityRequirements,
                operationName: "ScoreListV2EntityProjectScoresGetAsync");

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/v2/{entity}/{project}/scores",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("evaluation_run_id", evaluationRunId)
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
            PrepareScoreListV2EntityProjectScoresGetRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                entity: entity,
                project: project,
                evaluationRunId: evaluationRunId,
                limit: limit,
                offset: offset);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseHeadersRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessScoreListV2EntityProjectScoresGetResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
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

            using var __stream = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                cancellationToken
#endif
            ).ConfigureAwait(false);

            using var __reader = new global::System.IO.StreamReader(__stream);

            while (!__reader.EndOfStream && !cancellationToken.IsCancellationRequested)
            {
                var __content = await __reader.ReadLineAsync().ConfigureAwait(false) ?? string.Empty;
                if (global::System.String.IsNullOrWhiteSpace(__content))
                {
                    continue;
                }

                var __streamedResponse = global::G.ScoreReadRes.FromJson(__content, JsonSerializerOptions) ??
                                       throw new global::G.ApiException(
                                           message: $"Response deserialization failed for \"{__content}\" ",
                                           statusCode: __response.StatusCode)
                                       {
                                           ResponseBody = __content,
                                           ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                               __response.Headers,
                                               h => h.Key,
                                               h => h.Value),
                                       };

                yield return __streamedResponse;
            }
        }
    }
}