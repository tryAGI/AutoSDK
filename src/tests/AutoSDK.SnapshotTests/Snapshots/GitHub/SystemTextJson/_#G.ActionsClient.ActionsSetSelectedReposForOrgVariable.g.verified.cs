//HintName: G.ActionsClient.ActionsSetSelectedReposForOrgVariable.g.cs

#nullable enable

namespace G
{
    public partial class ActionsClient
    {
        partial void PrepareActionsSetSelectedReposForOrgVariableArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref string name,
            global::G.ActionsSetSelectedReposForOrgVariableRequest request);
        partial void PrepareActionsSetSelectedReposForOrgVariableRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            string name,
            global::G.ActionsSetSelectedReposForOrgVariableRequest request);
        partial void ProcessActionsSetSelectedReposForOrgVariableResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Set selected repositories for an organization variable<br/>
        /// Replaces all repositories for an organization variable that is available<br/>
        /// to selected repositories. Organization variables that are available to selected<br/>
        /// repositories have their `visibility` field set to `selected`.<br/>
        /// Authenticated users must have collaborator access to a repository to create, update, or read variables.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint. If the repository is private, the `repo` scope is also required.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="name"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task ActionsSetSelectedReposForOrgVariableAsync(
            string org,
            string name,
            global::G.ActionsSetSelectedReposForOrgVariableRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareActionsSetSelectedReposForOrgVariableArguments(
                httpClient: HttpClient,
                org: ref org,
                name: ref name,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/orgs/{org}/actions/variables/{name}/repositories",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareActionsSetSelectedReposForOrgVariableRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                org: org,
                name: name,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessActionsSetSelectedReposForOrgVariableResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            __response.EnsureSuccessStatusCode();
        }

        /// <summary>
        /// Set selected repositories for an organization variable<br/>
        /// Replaces all repositories for an organization variable that is available<br/>
        /// to selected repositories. Organization variables that are available to selected<br/>
        /// repositories have their `visibility` field set to `selected`.<br/>
        /// Authenticated users must have collaborator access to a repository to create, update, or read variables.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint. If the repository is private, the `repo` scope is also required.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="name"></param>
        /// <param name="selectedRepositoryIds">
        /// The IDs of the repositories that can access the organization variable.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task ActionsSetSelectedReposForOrgVariableAsync(
            string org,
            string name,
            global::System.Collections.Generic.IList<int> selectedRepositoryIds,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.ActionsSetSelectedReposForOrgVariableRequest
            {
                SelectedRepositoryIds = selectedRepositoryIds,
            };

            await ActionsSetSelectedReposForOrgVariableAsync(
                org: org,
                name: name,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}