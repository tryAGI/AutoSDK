//HintName: G.ReposClient.ReposRemoveCollaborator.g.cs

#nullable enable

namespace G
{
    public partial class ReposClient
    {
        partial void PrepareReposRemoveCollaboratorArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref string username);
        partial void PrepareReposRemoveCollaboratorRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            string username);
        partial void ProcessReposRemoveCollaboratorResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReposRemoveCollaboratorResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Remove a repository collaborator<br/>
        /// Removes a collaborator from a repository.<br/>
        /// To use this endpoint, the authenticated user must either be an administrator of the repository or target themselves for removal.<br/>
        /// This endpoint also:<br/>
        /// - Cancels any outstanding invitations<br/>
        /// - Unasigns the user from any issues<br/>
        /// - Removes access to organization projects if the user is not an organization member and is not a collaborator on any other organization repositories.<br/>
        /// - Unstars the repository<br/>
        /// - Updates access permissions to packages<br/>
        /// Removing a user as a collaborator has the following effects on forks:<br/>
        ///  - If the user had access to a fork through their membership to this repository, the user will also be removed from the fork.<br/>
        ///  - If the user had their own fork of the repository, the fork will be deleted.<br/>
        ///  - If the user still has read access to the repository, open pull requests by this user from a fork will be denied.<br/>
        /// **Note**: A user can still have access to the repository through organization permissions like base repository permissions.<br/>
        /// Although the API responds immediately, the additional permission updates might take some extra time to complete in the background.<br/>
        /// For more information on fork permissions, see "[About permissions and visibility of forks](https://docs.github.com/pull-requests/collaborating-with-pull-requests/working-with-forks/about-permissions-and-visibility-of-forks)".
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="username"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ValidationError> ReposRemoveCollaboratorAsync(
            string owner,
            string repo,
            string username,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareReposRemoveCollaboratorArguments(
                httpClient: _httpClient,
                owner: ref owner,
                repo: ref repo,
                username: ref username);

            var __pathBuilder = new PathBuilder(
                path: $"/repos/{owner}/{repo}/collaborators/{username}",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareReposRemoveCollaboratorRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                owner: owner,
                repo: repo,
                username: username);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessReposRemoveCollaboratorResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessReposRemoveCollaboratorResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.ValidationError?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}