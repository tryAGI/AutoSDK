//HintName: G.DataExplorerClient.ApiDatasetsImportCreate.g.cs

#nullable enable

namespace G
{
    public partial class DataExplorerClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_ApiDatasetsImportCreateSecurityRequirement0 =
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
        private static readonly global::G.EndPointSecurityRequirement[] s_ApiDatasetsImportCreateSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_ApiDatasetsImportCreateSecurityRequirement0,
            };
        partial void PrepareApiDatasetsImportCreateArguments(
            global::System.Net.Http.HttpClient httpClient,
            object? additionalFilters,
            ref int? dataset,
            object? excluded,
            object? included,
            ref int? project,
            ref int? view);
        partial void PrepareApiDatasetsImportCreateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            object? additionalFilters,
            int? dataset,
            object? excluded,
            object? included,
            int? project,
            int? view);
        partial void ProcessApiDatasetsImportCreateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Export candidate tasks to project<br/>
        ///     Export Candidate task for a specific dataset to project.<br/>
        ///     
        /// </summary>
        /// <param name="additionalFilters"></param>
        /// <param name="dataset"></param>
        /// <param name="excluded"></param>
        /// <param name="included"></param>
        /// <param name="project"></param>
        /// <param name="view"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task ApiDatasetsImportCreateAsync(
            object? additionalFilters = default,
            int? dataset = default,
            object? excluded = default,
            object? included = default,
            int? project = default,
            int? view = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareApiDatasetsImportCreateArguments(
                httpClient: HttpClient,
                additionalFilters: additionalFilters,
                dataset: ref dataset,
                excluded: excluded,
                included: included,
                project: ref project,
                view: ref view);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ApiDatasetsImportCreateSecurityRequirements,
                operationName: "ApiDatasetsImportCreateAsync");

            var __pathBuilder = new global::G.PathBuilder(
                path: "/api/datasets/import",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("additional_filters", additionalFilters?.ToString())
                .AddOptionalParameter("dataset", dataset?.ToString())
                .AddOptionalParameter("excluded", excluded?.ToString())
                .AddOptionalParameter("included", included?.ToString())
                .AddOptionalParameter("project", project?.ToString())
                .AddOptionalParameter("view", view?.ToString()) 
                ; 
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

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareApiDatasetsImportCreateRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                additionalFilters: additionalFilters,
                dataset: dataset,
                excluded: excluded,
                included: included,
                project: project,
                view: view);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessApiDatasetsImportCreateResponse(
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