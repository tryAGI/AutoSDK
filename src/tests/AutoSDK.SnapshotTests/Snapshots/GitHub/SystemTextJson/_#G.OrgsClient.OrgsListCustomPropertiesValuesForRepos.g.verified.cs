//HintName: G.OrgsClient.OrgsListCustomPropertiesValuesForRepos.g.cs

#nullable enable

namespace G
{
    public partial class OrgsClient
    {
        partial void PrepareOrgsListCustomPropertiesValuesForReposArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref int? perPage,
            ref int? page,
            ref string? repositoryQuery);
        partial void PrepareOrgsListCustomPropertiesValuesForReposRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            int? perPage,
            int? page,
            string? repositoryQuery);
        partial void ProcessOrgsListCustomPropertiesValuesForReposResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessOrgsListCustomPropertiesValuesForReposResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List custom property values for organization repositories<br/>
        /// Lists organization repositories with all of their custom property values.<br/>
        /// Organization members can read these properties.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="repositoryQuery"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.OrgRepoCustomPropertyValues>> OrgsListCustomPropertiesValuesForReposAsync(
            string org,
            int? perPage = 30,
            int? page = 1,
            string? repositoryQuery = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareOrgsListCustomPropertiesValuesForReposArguments(
                httpClient: HttpClient,
                org: ref org,
                perPage: ref perPage,
                page: ref page,
                repositoryQuery: ref repositoryQuery);

            var __pathBuilder = new PathBuilder(
                path: $"/orgs/{org}/properties/values",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("per_page", perPage?.ToString()) 
                .AddOptionalParameter("page", page?.ToString()) 
                .AddOptionalParameter("repository_query", repositoryQuery) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareOrgsListCustomPropertiesValuesForReposRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                org: org,
                perPage: perPage,
                page: page,
                repositoryQuery: repositoryQuery);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessOrgsListCustomPropertiesValuesForReposResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessOrgsListCustomPropertiesValuesForReposResponseContent(
                httpClient: HttpClient,
                httpResponseMessage: __response,
                content: ref __content);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::System.InvalidOperationException(__content, __ex);
            }

            return
                global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::G.OrgRepoCustomPropertyValues>?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}