//HintName: G.SearchClient.SearchUsers.g.cs

#nullable enable

namespace G
{
    public partial class SearchClient
    {
        partial void PrepareSearchUsersArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string q,
            ref global::G.SearchUsersSort? sort,
            ref global::G.SearchUsersOrder? order,
            ref int perPage,
            ref int page);
        partial void PrepareSearchUsersRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string q,
            global::G.SearchUsersSort? sort,
            global::G.SearchUsersOrder? order,
            int perPage,
            int page);
        partial void ProcessSearchUsersResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessSearchUsersResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Search users<br/>
        /// Find users via various criteria. This method returns up to 100 results [per page](https://docs.github.com/rest/guides/using-pagination-in-the-rest-api).<br/>
        /// When searching for users, you can get text match metadata for the issue **login**, public **email**, and **name** fields when you pass the `text-match` media type. For more details about highlighting search results, see [Text match metadata](https://docs.github.com/rest/search/search#text-match-metadata). For more details about how to receive highlighted search results, see [Text match metadata](https://docs.github.com/rest/search/search#text-match-metadata).<br/>
        /// For example, if you're looking for a list of popular users, you might try this query:<br/>
        /// `q=tom+repos:%3E42+followers:%3E1000`<br/>
        /// This query searches for users with the name `tom`. The results are restricted to users with more than 42 repositories and over 1,000 followers.<br/>
        /// This endpoint does not accept authentication and will only include publicly visible users. As an alternative, you can use the GraphQL API. The GraphQL API requires authentication and will return private users, including Enterprise Managed Users (EMUs), that you are authorized to view. For more information, see "[GraphQL Queries](https://docs.github.com/graphql/reference/queries#search)."
        /// </summary>
        /// <param name="q"></param>
        /// <param name="sort"></param>
        /// <param name="order">
        /// Default Value: desc
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.SearchUsersResponse> SearchUsersAsync(
            string q,
            global::G.SearchUsersSort? sort = default,
            global::G.SearchUsersOrder? order = global::G.SearchUsersOrder.Desc,
            int perPage = 30,
            int page = 1,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareSearchUsersArguments(
                httpClient: _httpClient,
                q: ref q,
                sort: ref sort,
                order: ref order,
                perPage: ref perPage,
                page: ref page);

            var sortValue = sort switch
            {
                global::G.SearchUsersSort.Followers => "followers",
                global::G.SearchUsersSort.Repositories => "repositories",
                global::G.SearchUsersSort.Joined => "joined",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var orderValue = order switch
            {
                global::G.SearchUsersOrder.Desc => "desc",
                global::G.SearchUsersOrder.Asc => "asc",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/search/users?q={q}&sort={(global::System.Uri.EscapeDataString(sortValue?.ToString() ?? string.Empty))}&order={(global::System.Uri.EscapeDataString(orderValue?.ToString() ?? string.Empty))}&per_page={perPage}&page={page}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareSearchUsersRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                q: q,
                sort: sort,
                order: order,
                perPage: perPage,
                page: page);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessSearchUsersResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessSearchUsersResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.SearchUsersResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}