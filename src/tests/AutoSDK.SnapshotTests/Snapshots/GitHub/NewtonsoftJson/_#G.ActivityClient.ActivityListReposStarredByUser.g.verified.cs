//HintName: G.ActivityClient.ActivityListReposStarredByUser.g.cs

#nullable enable

namespace G
{
    public partial class ActivityClient
    {
        partial void PrepareActivityListReposStarredByUserArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string username,
            ref global::G.ActivityListReposStarredByUserSort? sort,
            ref global::G.ActivityListReposStarredByUserDirection? direction,
            ref int? perPage,
            ref int? page);
        partial void PrepareActivityListReposStarredByUserRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string username,
            global::G.ActivityListReposStarredByUserSort? sort,
            global::G.ActivityListReposStarredByUserDirection? direction,
            int? perPage,
            int? page);
        partial void ProcessActivityListReposStarredByUserResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessActivityListReposStarredByUserResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List repositories starred by a user<br/>
        /// Lists repositories a user has starred.<br/>
        /// This endpoint supports the following custom media types. For more information, see "[Media types](https://docs.github.com/rest/using-the-rest-api/getting-started-with-the-rest-api#media-types)."<br/>
        /// - **`application/vnd.github.star+json`**: Includes a timestamp of when the star was created.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="sort">
        /// Default Value: created
        /// </param>
        /// <param name="direction">
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
        public async global::System.Threading.Tasks.Task<global::G.AnyOf<global::System.Collections.Generic.IList<global::G.StarredRepository>, global::System.Collections.Generic.IList<global::G.Repository>>> ActivityListReposStarredByUserAsync(
            string username,
            global::G.ActivityListReposStarredByUserSort? sort = global::G.ActivityListReposStarredByUserSort.Created,
            global::G.ActivityListReposStarredByUserDirection? direction = global::G.ActivityListReposStarredByUserDirection.Desc,
            int? perPage = 30,
            int? page = 1,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareActivityListReposStarredByUserArguments(
                httpClient: _httpClient,
                username: ref username,
                sort: ref sort,
                direction: ref direction,
                perPage: ref perPage,
                page: ref page);

            var sortValue = sort switch
            {
                global::G.ActivityListReposStarredByUserSort.Created => "created",
                global::G.ActivityListReposStarredByUserSort.Updated => "updated",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var directionValue = direction switch
            {
                global::G.ActivityListReposStarredByUserDirection.Asc => "asc",
                global::G.ActivityListReposStarredByUserDirection.Desc => "desc",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new PathBuilder(
                path: $"/users/{username}/starred",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("sort", sortValue?.ToString()) 
                .AddOptionalParameter("direction", directionValue?.ToString()) 
                .AddOptionalParameter("per_page", perPage?.ToString()) 
                .AddOptionalParameter("page", page?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareActivityListReposStarredByUserRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                username: username,
                sort: sort,
                direction: direction,
                perPage: perPage,
                page: page);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessActivityListReposStarredByUserResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessActivityListReposStarredByUserResponseContent(
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
                global::G.AnyOf<global::System.Collections.Generic.IList<global::G.StarredRepository>, global::System.Collections.Generic.IList<global::G.Repository>>.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}