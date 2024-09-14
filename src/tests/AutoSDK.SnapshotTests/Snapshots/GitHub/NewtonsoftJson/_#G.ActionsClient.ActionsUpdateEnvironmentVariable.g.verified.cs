//HintName: G.ActionsClient.ActionsUpdateEnvironmentVariable.g.cs

#nullable enable

namespace G
{
    public partial class ActionsClient
    {
        partial void PrepareActionsUpdateEnvironmentVariableArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref string name,
            ref string environmentName,
            global::G.ActionsUpdateEnvironmentVariableRequest request);
        partial void PrepareActionsUpdateEnvironmentVariableRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            string name,
            string environmentName,
            global::G.ActionsUpdateEnvironmentVariableRequest request);
        partial void ProcessActionsUpdateEnvironmentVariableResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Update an environment variable<br/>
        /// Updates an environment variable that you can reference in a GitHub Actions workflow.<br/>
        /// Authenticated users must have collaborator access to a repository to create, update, or read variables.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="name"></param>
        /// <param name="environmentName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task ActionsUpdateEnvironmentVariableAsync(
            string owner,
            string repo,
            string name,
            string environmentName,
            global::G.ActionsUpdateEnvironmentVariableRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareActionsUpdateEnvironmentVariableArguments(
                httpClient: _httpClient,
                owner: ref owner,
                repo: ref repo,
                name: ref name,
                environmentName: ref environmentName,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/repos/{owner}/{repo}/environments/{environmentName}/variables/{name}", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::Newtonsoft.Json.JsonConvert.SerializeObject(request, JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareActionsUpdateEnvironmentVariableRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                owner: owner,
                repo: repo,
                name: name,
                environmentName: environmentName,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessActionsUpdateEnvironmentVariableResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);
            response.EnsureSuccessStatusCode();
        }

        /// <summary>
        /// Update an environment variable<br/>
        /// Updates an environment variable that you can reference in a GitHub Actions workflow.<br/>
        /// Authenticated users must have collaborator access to a repository to create, update, or read variables.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="name"></param>
        /// <param name="environmentName"></param>
        /// <param name="requestName">
        /// The name of the variable.
        /// </param>
        /// <param name="value">
        /// The value of the variable.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task ActionsUpdateEnvironmentVariableAsync(
            string owner,
            string repo,
            string name,
            string environmentName,
            string? requestName = default,
            string? value = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.ActionsUpdateEnvironmentVariableRequest
            {
                Name = requestName,
                Value = value,
            };

            await ActionsUpdateEnvironmentVariableAsync(
                owner: owner,
                repo: repo,
                name: name,
                environmentName: environmentName,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}