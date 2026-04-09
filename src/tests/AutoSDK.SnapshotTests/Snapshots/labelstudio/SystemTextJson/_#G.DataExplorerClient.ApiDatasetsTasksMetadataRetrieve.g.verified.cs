//HintName: G.DataExplorerClient.ApiDatasetsTasksMetadataRetrieve.g.cs

#nullable enable

namespace G
{
    public partial class DataExplorerClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_ApiDatasetsTasksMetadataRetrieveSecurityRequirement0 =
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
        private static readonly global::G.EndPointSecurityRequirement[] s_ApiDatasetsTasksMetadataRetrieveSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_ApiDatasetsTasksMetadataRetrieveSecurityRequirement0,
            };
        partial void PrepareApiDatasetsTasksMetadataRetrieveArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? candidateTaskId,
            ref int? dataset,
            ref string? vectordbId);
        partial void PrepareApiDatasetsTasksMetadataRetrieveRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? candidateTaskId,
            int? dataset,
            string? vectordbId);
        partial void ProcessApiDatasetsTasksMetadataRetrieveResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Get Candidate task metadata<br/>
        ///     Retrieve Candidate task metadata for a specific dataset, by using candidate_task_id or weaviate_id.<br/>
        ///     
        /// </summary>
        /// <param name="candidateTaskId"></param>
        /// <param name="dataset"></param>
        /// <param name="vectordbId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task ApiDatasetsTasksMetadataRetrieveAsync(
            string? candidateTaskId = default,
            int? dataset = default,
            string? vectordbId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareApiDatasetsTasksMetadataRetrieveArguments(
                httpClient: HttpClient,
                candidateTaskId: ref candidateTaskId,
                dataset: ref dataset,
                vectordbId: ref vectordbId);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ApiDatasetsTasksMetadataRetrieveSecurityRequirements,
                operationName: "ApiDatasetsTasksMetadataRetrieveAsync");

            var __pathBuilder = new global::G.PathBuilder(
                path: "/api/datasets/tasks/metadata",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("candidate_task_id", candidateTaskId)
                .AddOptionalParameter("dataset", dataset?.ToString())
                .AddOptionalParameter("vectordb_id", vectordbId) 
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
            PrepareApiDatasetsTasksMetadataRetrieveRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                candidateTaskId: candidateTaskId,
                dataset: dataset,
                vectordbId: vectordbId);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessApiDatasetsTasksMetadataRetrieveResponse(
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
    }
}