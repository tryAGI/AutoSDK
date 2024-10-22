//HintName: G.ActionsClient.ActionsUpdateOrgVariable.g.cs

#nullable enable

namespace G
{
    public partial class ActionsClient
    {
        partial void PrepareActionsUpdateOrgVariableArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref string name,
            global::G.ActionsUpdateOrgVariableRequest request);
        partial void PrepareActionsUpdateOrgVariableRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            string name,
            global::G.ActionsUpdateOrgVariableRequest request);
        partial void ProcessActionsUpdateOrgVariableResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Update an organization variable<br/>
        /// Updates an organization variable that you can reference in a GitHub Actions workflow.<br/>
        /// Authenticated users must have collaborator access to a repository to create, update, or read variables.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint. If the repository is private, the `repo` scope is also required.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="name"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task ActionsUpdateOrgVariableAsync(
            string org,
            string name,
            global::G.ActionsUpdateOrgVariableRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareActionsUpdateOrgVariableArguments(
                httpClient: HttpClient,
                org: ref org,
                name: ref name,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/orgs/{org}/actions/variables/{name}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
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
            PrepareActionsUpdateOrgVariableRequest(
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
            ProcessActionsUpdateOrgVariableResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            __response.EnsureSuccessStatusCode();
        }

        /// <summary>
        /// Update an organization variable<br/>
        /// Updates an organization variable that you can reference in a GitHub Actions workflow.<br/>
        /// Authenticated users must have collaborator access to a repository to create, update, or read variables.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint. If the repository is private, the `repo` scope is also required.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="name"></param>
        /// <param name="requestName">
        /// The name of the variable.
        /// </param>
        /// <param name="value">
        /// The value of the variable.
        /// </param>
        /// <param name="visibility">
        /// The type of repositories in the organization that can access the variable. `selected` means only the repositories specified by `selected_repository_ids` can access the variable.
        /// </param>
        /// <param name="selectedRepositoryIds">
        /// An array of repository ids that can access the organization variable. You can only provide a list of repository ids when the `visibility` is set to `selected`.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task ActionsUpdateOrgVariableAsync(
            string org,
            string name,
            string? requestName = default,
            string? value = default,
            global::G.ActionsUpdateOrgVariableRequestVisibility? visibility = default,
            global::System.Collections.Generic.IList<int>? selectedRepositoryIds = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.ActionsUpdateOrgVariableRequest
            {
                Name = requestName,
                Value = value,
                Visibility = visibility,
                SelectedRepositoryIds = selectedRepositoryIds,
            };

            await ActionsUpdateOrgVariableAsync(
                org: org,
                name: name,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}