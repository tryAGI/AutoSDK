//HintName: G.ActionsClient.ActionsUpdateOrgVariable.g.cs

#nullable enable

namespace G
{
    public partial class ActionsClient
    {
        /// <summary>
        /// Update an organization variable
        /// </summary>
        /// <param name="org"></param>
        /// <param name="name"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task ActionsUpdateOrgVariableAsync(
            string org,
            string name,
            ActionsUpdateOrgVariableRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Patch,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/orgs/{org}/actions/variables/{name}", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::System.Text.Json.JsonSerializer.Serialize(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }

        /// <summary>
        /// Update an organization variable
        /// </summary>
        /// <param name="org"></param>
        /// <param name="name"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="visibility"></param>
        /// <param name="selectedRepositoryIds"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task ActionsUpdateOrgVariableAsync(
            string org,
            string name,
            string? name = default,
            string? value = default,
            ActionsUpdateOrgVariableRequestVisibility? visibility = default,
            global::System.Collections.Generic.IList<int>? selectedRepositoryIds = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new ActionsUpdateOrgVariableRequest
            {
                Name = name,
                Value = value,
                Visibility = visibility,
                SelectedRepositoryIds = selectedRepositoryIds,
            };

            await ActionsUpdateOrgVariableAsync(
                org: org,
                name: name,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}