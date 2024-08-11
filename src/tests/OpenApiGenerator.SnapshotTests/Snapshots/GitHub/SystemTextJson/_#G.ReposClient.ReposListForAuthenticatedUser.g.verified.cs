//HintName: G.ReposClient.ReposListForAuthenticatedUser.g.cs

#nullable enable

namespace G
{
    public partial class ReposClient
    {
        partial void PrepareReposListForAuthenticatedUserArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::G.ReposListForAuthenticatedUserVisibility? visibility,
            ref string? affiliation,
            ref global::G.ReposListForAuthenticatedUserType? type,
            ref global::G.ReposListForAuthenticatedUserSort? sort,
            ref global::G.ReposListForAuthenticatedUserDirection? direction,
            ref int perPage,
            ref int page,
            global::System.DateTime since,
            global::System.DateTime before);
        partial void PrepareReposListForAuthenticatedUserRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.ReposListForAuthenticatedUserVisibility? visibility,
            string? affiliation,
            global::G.ReposListForAuthenticatedUserType? type,
            global::G.ReposListForAuthenticatedUserSort? sort,
            global::G.ReposListForAuthenticatedUserDirection? direction,
            int perPage,
            int page,
            global::System.DateTime since,
            global::System.DateTime before);
        partial void ProcessReposListForAuthenticatedUserResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReposListForAuthenticatedUserResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List repositories for the authenticated user<br/>
        /// Lists repositories that the authenticated user has explicit permission (`:read`, `:write`, or `:admin`) to access.<br/>
        /// The authenticated user has explicit permission to access repositories they own, repositories where they are a collaborator, and repositories that they can access through an organization membership.
        /// </summary>
        /// <param name="visibility">
        /// Default Value: all
        /// </param>
        /// <param name="affiliation">
        /// Default Value: owner,collaborator,organization_member
        /// </param>
        /// <param name="type">
        /// Default Value: all
        /// </param>
        /// <param name="sort">
        /// Default Value: full_name
        /// </param>
        /// <param name="direction"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="since"></param>
        /// <param name="before"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Repository>> ReposListForAuthenticatedUserAsync(
            global::G.ReposListForAuthenticatedUserVisibility? visibility,
            string? affiliation,
            global::G.ReposListForAuthenticatedUserType? type,
            global::G.ReposListForAuthenticatedUserSort? sort,
            global::G.ReposListForAuthenticatedUserDirection? direction,
            int perPage,
            int page,
            global::System.DateTime since,
            global::System.DateTime before,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareReposListForAuthenticatedUserArguments(
                httpClient: _httpClient,
                visibility: ref visibility,
                affiliation: ref affiliation,
                type: ref type,
                sort: ref sort,
                direction: ref direction,
                perPage: ref perPage,
                page: ref page,
                since: since,
                before: before);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/user/repos?visibility={visibility}&affiliation={affiliation}&type={type}&sort={sort}&direction={direction}&per_page={perPage}&page={page}&since={since:yyyy-MM-ddTHH:mm:ssZ}&before={before:yyyy-MM-ddTHH:mm:ssZ}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareReposListForAuthenticatedUserRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                visibility: visibility,
                affiliation: affiliation,
                type: type,
                sort: sort,
                direction: direction,
                perPage: perPage,
                page: page,
                since: since,
                before: before);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessReposListForAuthenticatedUserResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessReposListForAuthenticatedUserResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::G.Repository>?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}