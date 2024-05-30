//HintName: G.ExtensionsClient.UpdateExtensionBitsProduct.g.cs

#nullable enable

namespace G
{
    public partial class ExtensionsClient
    {
        /// <summary>
        /// Adds or updates a Bits product that the extension created.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<UpdateExtensionBitsProductResponse> UpdateExtensionBitsProductAsync(
            UpdateExtensionBitsProductBody request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + "/bits/extensions", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::System.Text.Json.JsonSerializer.Serialize(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::System.Text.Json.JsonSerializer.Deserialize<UpdateExtensionBitsProductResponse?>(content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{content}\" ");
        }

        /// <summary>
        /// Adds or updates a Bits product that the extension created.
        /// </summary>
        /// <param name="sku"></param>
        /// <param name="cost"></param>
        /// <param name="displayName"></param>
        /// <param name="inDevelopment"></param>
        /// <param name="expiration"></param>
        /// <param name="isBroadcast"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<UpdateExtensionBitsProductResponse> UpdateExtensionBitsProductAsync(
            string sku,
            UpdateExtensionBitsProductBodyCost cost,
            string displayName,
            bool inDevelopment = default,
            global::System.DateTime expiration = default,
            bool isBroadcast = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new UpdateExtensionBitsProductBody
            {
                Sku = sku,
                Cost = cost,
                DisplayName = displayName,
                InDevelopment = inDevelopment,
                Expiration = expiration,
                IsBroadcast = isBroadcast,
            };

            return await UpdateExtensionBitsProductAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}