//HintName: G.OrgsClient.OrgsUpdatePatAccess.g.cs

#nullable enable

namespace G
{
    public partial class OrgsClient
    {
        /// <summary>
        /// Update the access a fine-grained personal access token has to organization resources
        /// </summary>
        /// <param name="org"></param>
        /// <param name="patId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<BasicError> OrgsUpdatePatAccessAsync(
            string org,
            int patId,
            OrgsUpdatePatAccessRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/orgs/{org}/personal-access-tokens/{patId}", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::System.Text.Json.JsonSerializer.Serialize(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::System.Text.Json.JsonSerializer.Deserialize<BasicError?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update the access a fine-grained personal access token has to organization resources
        /// </summary>
        /// <param name="org"></param>
        /// <param name="patId"></param>
        /// <param name="action"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<BasicError> OrgsUpdatePatAccessAsync(
            string org,
            int patId,
            OrgsUpdatePatAccessRequestAction action,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new OrgsUpdatePatAccessRequest
            {
                Action = action,
            };

            return await OrgsUpdatePatAccessAsync(
                org: org,
                patId: patId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}