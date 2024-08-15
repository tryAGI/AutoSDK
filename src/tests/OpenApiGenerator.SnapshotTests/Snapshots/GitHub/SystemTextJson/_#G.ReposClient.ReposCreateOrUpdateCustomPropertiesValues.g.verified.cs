//HintName: G.ReposClient.ReposCreateOrUpdateCustomPropertiesValues.g.cs

#nullable enable

namespace G
{
    public partial class ReposClient
    {
        partial void PrepareReposCreateOrUpdateCustomPropertiesValuesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            global::G.ReposCreateOrUpdateCustomPropertiesValuesRequest request);
        partial void PrepareReposCreateOrUpdateCustomPropertiesValuesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            global::G.ReposCreateOrUpdateCustomPropertiesValuesRequest request);
        partial void ProcessReposCreateOrUpdateCustomPropertiesValuesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReposCreateOrUpdateCustomPropertiesValuesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create or update custom property values for a repository<br/>
        /// Create new or update existing custom property values for a repository.<br/>
        /// Using a value of `null` for a custom property will remove or 'unset' the property value from the repository.<br/>
        /// Repository admins and other users with the repository-level "edit custom property values" fine-grained permission can use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.BasicError> ReposCreateOrUpdateCustomPropertiesValuesAsync(
            string owner,
            string repo,
            global::G.ReposCreateOrUpdateCustomPropertiesValuesRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareReposCreateOrUpdateCustomPropertiesValuesArguments(
                httpClient: _httpClient,
                owner: ref owner,
                repo: ref repo,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/repos/{owner}/{repo}/properties/values", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, _jsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareReposCreateOrUpdateCustomPropertiesValuesRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                owner: owner,
                repo: repo,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessReposCreateOrUpdateCustomPropertiesValuesResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessReposCreateOrUpdateCustomPropertiesValuesResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.BasicError?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create or update custom property values for a repository<br/>
        /// Create new or update existing custom property values for a repository.<br/>
        /// Using a value of `null` for a custom property will remove or 'unset' the property value from the repository.<br/>
        /// Repository admins and other users with the repository-level "edit custom property values" fine-grained permission can use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="properties">
        /// A list of custom property names and associated values to apply to the repositories.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.BasicError> ReposCreateOrUpdateCustomPropertiesValuesAsync(
            string owner,
            string repo,
            global::System.Collections.Generic.IList<global::G.CustomPropertyValue> properties,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.ReposCreateOrUpdateCustomPropertiesValuesRequest
            {
                Properties = properties,
            };

            return await ReposCreateOrUpdateCustomPropertiesValuesAsync(
                owner: owner,
                repo: repo,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}