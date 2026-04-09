//HintName: G.ExportClient.DownloadSync.g.cs

#nullable enable

namespace G
{
    public partial class ExportClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_DownloadSyncSecurityRequirement0 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "Token",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::G.EndPointSecurityRequirement[] s_DownloadSyncSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_DownloadSyncSecurityRequirement0,
            };
        partial void PrepareDownloadSyncArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref bool? downloadAllTasks,
            ref bool? downloadResources,
            ref string? exportType,
            ref int id,
            global::System.Collections.Generic.IList<string>? ids);
        partial void PrepareDownloadSyncRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            bool? downloadAllTasks,
            bool? downloadResources,
            string? exportType,
            int id,
            global::System.Collections.Generic.IList<string>? ids);
        partial void ProcessDownloadSyncResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessDownloadSyncResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref byte[] content);

        /// <summary>
        /// [Deprecated] Easy export of tasks and annotations<br/>
        ///         This endpoint is deprecated in Enterprise. Use the async export API instead:<br/>
        ///         POST /api/projects/{id}/exports/ (see [Create new export](/api#operation/api_projects_exports_create)).<br/>
        ///         In Label Studio Enterprise, this endpoint will always return a 404 Not Found response with instructions to use the async export API.<br/>
        ///         &lt;i&gt;Note: if you have a large project it's recommended to use<br/>
        ///         export snapshots, this easy export endpoint might have timeouts.&lt;/i&gt;&lt;br/&gt;<br/>
        ///         Export annotated tasks as a file in a specific format.<br/>
        ///         For example, to export JSON annotations for a project to a file called `annotations.json`,<br/>
        ///         run the following from the command line:<br/>
        ///         ```bash<br/>
        ///         curl -X GET http://localhost:8000/api/projects/{id}/export?exportType=JSON -H 'Authorization: Token abc123' --output 'annotations.json'<br/>
        ///         ```<br/>
        ///         To export all tasks, including skipped tasks and others without annotations, run the following from the command line:<br/>
        ///         ```bash<br/>
        ///         curl -X GET http://localhost:8000/api/projects/{id}/export?exportType=JSON&amp;download_all_tasks=true -H 'Authorization: Token abc123' --output 'annotations.json'<br/>
        ///         ```<br/>
        ///         To export specific tasks with IDs of 123 and 345, run the following from the command line:<br/>
        ///         ```bash<br/>
        ///         curl -X GET 'http://localhost:8000/api/projects/{id}/export?ids[]=123&amp;ids[]=345' -H 'Authorization: Token abc123' --output 'annotations.json'<br/>
        ///         ```<br/>
        ///         
        /// </summary>
        /// <param name="downloadAllTasks"></param>
        /// <param name="downloadResources"></param>
        /// <param name="exportType"></param>
        /// <param name="id"></param>
        /// <param name="ids"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        public async global::System.Threading.Tasks.Task<byte[]> DownloadSyncAsync(
            int id,
            bool? downloadAllTasks = default,
            bool? downloadResources = default,
            string? exportType = default,
            global::System.Collections.Generic.IList<string>? ids = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareDownloadSyncArguments(
                httpClient: HttpClient,
                downloadAllTasks: ref downloadAllTasks,
                downloadResources: ref downloadResources,
                exportType: ref exportType,
                id: ref id,
                ids: ids);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_DownloadSyncSecurityRequirements,
                operationName: "DownloadSyncAsync");

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/api/projects/{id}/export",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("download_all_tasks", downloadAllTasks?.ToString().ToLowerInvariant())
                .AddOptionalParameter("download_resources", downloadResources?.ToString().ToLowerInvariant())
                .AddOptionalParameter("export_type", exportType)
                .AddOptionalParameter("ids", ids, delimiter: ",", explode: true) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            var __cookies = new global::System.Collections.Generic.List<string>();
            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
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
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Cookie")
                {
                    var __cookieValue = global::System.Uri.EscapeDataString(__authorization.Value);
                    __cookies.Add($"{__authorization.Name}={__cookieValue}");
                }
            }

            if (__cookies.Count > 0)
            {
                __httpRequest.Headers.TryAddWithoutValidation("Cookie", string.Join("; ", __cookies));
            }

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareDownloadSyncRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                downloadAllTasks: downloadAllTasks,
                downloadResources: downloadResources,
                exportType: exportType,
                id: id,
                ids: ids);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessDownloadSyncResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsByteArrayAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessDownloadSyncResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return __content;
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::G.ApiException(
                        message: __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
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
                    var __content = await __response.Content.ReadAsByteArrayAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return __content;
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