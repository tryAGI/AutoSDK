//HintName: G.CatalogClient.CreateCatalog.g.cs

#nullable enable

namespace G
{
    public partial class CatalogClient
    {
        partial void PrepareCreateCatalogArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string namespaceId,
            global::G.CreateCatalogBody request);
        partial void PrepareCreateCatalogRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string namespaceId,
            global::G.CreateCatalogBody request);
        partial void ProcessCreateCatalogResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateCatalogResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a catalog
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreateCatalogResponse> CreateCatalogAsync(
            string namespaceId,
            global::G.CreateCatalogBody request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCreateCatalogArguments(
                httpClient: _httpClient,
                namespaceId: ref namespaceId,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/v1alpha/namespaces/{namespaceId}/catalogs", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCreateCatalogRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                namespaceId: namespaceId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessCreateCatalogResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCreateCatalogResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateCatalogResponse?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create a catalog
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="name">
        /// The catalog name.
        /// </param>
        /// <param name="description">
        /// The catalog description.
        /// </param>
        /// <param name="tags">
        /// The catalog tags.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreateCatalogResponse> CreateCatalogAsync(
            string namespaceId,
            string? name = default,
            string? description = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.CreateCatalogBody
            {
                Name = name,
                Description = description,
                Tags = tags,
            };

            return await CreateCatalogAsync(
                namespaceId: namespaceId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}