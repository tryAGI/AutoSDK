//HintName: G.ReposClient.ReposListForOrg.g.cs

#nullable enable

namespace G
{
    public partial class ReposClient
    {
        partial void PrepareReposListForOrgArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref global::G.ReposListForOrgType? type,
            ref global::G.ReposListForOrgSort? sort,
            ref global::G.ReposListForOrgDirection? direction,
            ref int? perPage,
            ref int? page);
        partial void PrepareReposListForOrgRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            global::G.ReposListForOrgType? type,
            global::G.ReposListForOrgSort? sort,
            global::G.ReposListForOrgDirection? direction,
            int? perPage,
            int? page);
        partial void ProcessReposListForOrgResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReposListForOrgResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List organization repositories<br/>
        /// Lists repositories for the specified organization.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; In order to see the `security_and_analysis` block for a repository you must have admin permissions for the repository or be an owner or security manager for the organization that owns the repository. For more information, see "[Managing security managers in your organization](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization)."
        /// </summary>
        /// <param name="org"></param>
        /// <param name="type">
        /// Default Value: all
        /// </param>
        /// <param name="sort">
        /// Default Value: created
        /// </param>
        /// <param name="direction"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.MinimalRepository>> ReposListForOrgAsync(
            string org,
            global::G.ReposListForOrgType? type = default,
            global::G.ReposListForOrgSort? sort = default,
            global::G.ReposListForOrgDirection? direction = default,
            int? perPage = default,
            int? page = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareReposListForOrgArguments(
                httpClient: HttpClient,
                org: ref org,
                type: ref type,
                sort: ref sort,
                direction: ref direction,
                perPage: ref perPage,
                page: ref page);

            var typeValue = type switch
            {
                global::G.ReposListForOrgType.All => "all",
                global::G.ReposListForOrgType.Public => "public",
                global::G.ReposListForOrgType.Private => "private",
                global::G.ReposListForOrgType.Forks => "forks",
                global::G.ReposListForOrgType.Sources => "sources",
                global::G.ReposListForOrgType.Member => "member",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var sortValue = sort switch
            {
                global::G.ReposListForOrgSort.Created => "created",
                global::G.ReposListForOrgSort.Updated => "updated",
                global::G.ReposListForOrgSort.Pushed => "pushed",
                global::G.ReposListForOrgSort.FullName => "full_name",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var directionValue = direction switch
            {
                global::G.ReposListForOrgDirection.Asc => "asc",
                global::G.ReposListForOrgDirection.Desc => "desc",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new PathBuilder(
                path: $"/orgs/{org}/repos",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("type", typeValue?.ToString()) 
                .AddOptionalParameter("sort", sortValue?.ToString()) 
                .AddOptionalParameter("direction", directionValue?.ToString()) 
                .AddOptionalParameter("per_page", perPage?.ToString()) 
                .AddOptionalParameter("page", page?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareReposListForOrgRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                org: org,
                type: type,
                sort: sort,
                direction: direction,
                perPage: perPage,
                page: page);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessReposListForOrgResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessReposListForOrgResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
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

                return
                    global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<global::G.MinimalRepository>?>(__content, JsonSerializerOptions) ??
                    throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
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

                using var __content = await __response.Content.ReadAsStreamAsync().ConfigureAwait(false);

                return
                    global::Newtonsoft.Json.JsonSerializer.Create(JsonSerializerOptions).Deserialize<global::System.Collections.Generic.IList<global::G.MinimalRepository>?>(new global::Newtonsoft.Json.JsonTextReader(new global::System.IO.StreamReader(__content))) ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }
    }
}