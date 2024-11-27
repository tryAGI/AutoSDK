//HintName: G.OrgsClient.OrgsListOrgRoleTeams.g.cs

#nullable enable

namespace G
{
    public partial class OrgsClient
    {
        partial void PrepareOrgsListOrgRoleTeamsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref int roleId,
            ref int? perPage,
            ref int? page);
        partial void PrepareOrgsListOrgRoleTeamsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            int roleId,
            int? perPage,
            int? page);
        partial void ProcessOrgsListOrgRoleTeamsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessOrgsListOrgRoleTeamsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List teams that are assigned to an organization role<br/>
        /// Lists the teams that are assigned to an organization role. For more information on organization roles, see "[Using organization roles](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/using-organization-roles)."<br/>
        /// To use this endpoint, you must be an administrator for the organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="roleId"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.TeamRoleAssignment>> OrgsListOrgRoleTeamsAsync(
            string org,
            int roleId,
            int? perPage = default,
            int? page = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareOrgsListOrgRoleTeamsArguments(
                httpClient: HttpClient,
                org: ref org,
                roleId: ref roleId,
                perPage: ref perPage,
                page: ref page);

            var __pathBuilder = new PathBuilder(
                path: $"/orgs/{org}/organization-roles/{roleId}/teams",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
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
            PrepareOrgsListOrgRoleTeamsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                org: org,
                roleId: roleId,
                perPage: perPage,
                page: page);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessOrgsListOrgRoleTeamsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // 
            if ((int)__response.StatusCode == 404)
            {
                string? __content_404 = null;
                if (ReadResponseAsString)
                {
                    __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                }
                else
                {
                    var __contentStream_404 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                }

                throw new global::G.ApiException(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_404,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // 
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                if (ReadResponseAsString)
                {
                    __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                }
                else
                {
                    var __contentStream_422 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                }

                throw new global::G.ApiException(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_422,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessOrgsListOrgRoleTeamsResponseContent(
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
                    global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<global::G.TeamRoleAssignment>?>(__content, JsonSerializerOptions) ??
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
                    global::Newtonsoft.Json.JsonSerializer.Create(JsonSerializerOptions).Deserialize<global::System.Collections.Generic.IList<global::G.TeamRoleAssignment>?>(new global::Newtonsoft.Json.JsonTextReader(new global::System.IO.StreamReader(__content))) ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }
    }
}