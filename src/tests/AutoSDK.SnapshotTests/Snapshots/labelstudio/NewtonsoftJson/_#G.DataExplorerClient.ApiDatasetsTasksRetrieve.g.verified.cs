//HintName: G.DataExplorerClient.ApiDatasetsTasksRetrieve.g.cs

#nullable enable

namespace G
{
    public partial class DataExplorerClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_ApiDatasetsTasksRetrieveSecurityRequirement0 =
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
        private static readonly global::G.EndPointSecurityRequirement[] s_ApiDatasetsTasksRetrieveSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_ApiDatasetsTasksRetrieveSecurityRequirement0,
            };
        partial void PrepareApiDatasetsTasksRetrieveArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? dataset,
            ref double? maxThreshold,
            ref double? minThreshold,
            ref int? page,
            ref int? pageSize,
            ref int? view);
        partial void PrepareApiDatasetsTasksRetrieveRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? dataset,
            double? maxThreshold,
            double? minThreshold,
            int? page,
            int? pageSize,
            int? view);
        partial void ProcessApiDatasetsTasksRetrieveResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessApiDatasetsTasksRetrieveResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Data Explorer tasks list<br/>
        ///     Retrieve a list of Data Explorer tasks with pagination for a specific view or dataset, by using filters and ordering.<br/>
        ///     
        /// </summary>
        /// <param name="dataset"></param>
        /// <param name="maxThreshold"></param>
        /// <param name="minThreshold"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="view"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.DatasetView> ApiDatasetsTasksRetrieveAsync(
            int? dataset = default,
            double? maxThreshold = default,
            double? minThreshold = default,
            int? page = default,
            int? pageSize = default,
            int? view = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareApiDatasetsTasksRetrieveArguments(
                httpClient: HttpClient,
                dataset: ref dataset,
                maxThreshold: ref maxThreshold,
                minThreshold: ref minThreshold,
                page: ref page,
                pageSize: ref pageSize,
                view: ref view);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ApiDatasetsTasksRetrieveSecurityRequirements,
                operationName: "ApiDatasetsTasksRetrieveAsync");

            var __pathBuilder = new global::G.PathBuilder(
                path: "/api/datasets/tasks",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("dataset", dataset?.ToString())
                .AddOptionalParameter("max_threshold", maxThreshold?.ToString())
                .AddOptionalParameter("min_threshold", minThreshold?.ToString())
                .AddOptionalParameter("page", page?.ToString())
                .AddOptionalParameter("page_size", pageSize?.ToString())
                .AddOptionalParameter("view", view?.ToString()) 
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
            PrepareApiDatasetsTasksRetrieveRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                dataset: dataset,
                maxThreshold: maxThreshold,
                minThreshold: minThreshold,
                page: page,
                pageSize: pageSize,
                view: view);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessApiDatasetsTasksRetrieveResponse(
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
                ProcessApiDatasetsTasksRetrieveResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.DatasetView.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.DatasetView.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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