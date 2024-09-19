//HintName: G.ExtensionsClient.UpdateExtensionBitsProduct.g.cs

#nullable enable

namespace G
{
    public partial class ExtensionsClient
    {
        partial void PrepareUpdateExtensionBitsProductArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.UpdateExtensionBitsProductBody request);
        partial void PrepareUpdateExtensionBitsProductRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.UpdateExtensionBitsProductBody request);
        partial void ProcessUpdateExtensionBitsProductResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdateExtensionBitsProductResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Adds or updates a Bits product that the extension created.<br/>
        /// Adds or updates a Bits product that the extension created. If the SKU doesn’t exist, the product is added. You may update all fields except the `sku` field.<br/>
        /// __Authorization:__<br/>
        /// Requires an [app access token](https://dev.twitch.tv/docs/authentication#app-access-tokens). The client ID in the app access token must match the extension’s client ID.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.UpdateExtensionBitsProductResponse> UpdateExtensionBitsProductAsync(
            global::G.UpdateExtensionBitsProductBody request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareUpdateExtensionBitsProductArguments(
                httpClient: _httpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/bits/extensions",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareUpdateExtensionBitsProductRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessUpdateExtensionBitsProductResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessUpdateExtensionBitsProductResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.UpdateExtensionBitsProductResponse?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Adds or updates a Bits product that the extension created.<br/>
        /// Adds or updates a Bits product that the extension created. If the SKU doesn’t exist, the product is added. You may update all fields except the `sku` field.<br/>
        /// __Authorization:__<br/>
        /// Requires an [app access token](https://dev.twitch.tv/docs/authentication#app-access-tokens). The client ID in the app access token must match the extension’s client ID.
        /// </summary>
        /// <param name="sku">
        /// The product's SKU. The SKU must be unique within an extension. The product's SKU cannot be changed. The SKU may contain only alphanumeric characters, dashes (-), underscores (\_), and periods (.) and is limited to a maximum of 255 characters. No spaces.
        /// </param>
        /// <param name="cost">
        /// An object that contains the product's cost information.
        /// </param>
        /// <param name="displayName">
        /// The product's name as displayed in the extension. The maximum length is 255 characters.
        /// </param>
        /// <param name="inDevelopment">
        /// A Boolean value that indicates whether the product is in development. Set to **true** if the product is in development and not available for public use. The default is **false**.
        /// </param>
        /// <param name="expiration">
        /// The date and time, in RFC3339 format, when the product expires. If not set, the product does not expire. To disable the product, set the expiration date to a date in the past.
        /// </param>
        /// <param name="isBroadcast">
        /// A Boolean value that determines whether Bits product purchase events are broadcast to all instances of the extension on a channel. The events are broadcast via the `onTransactionComplete` helper callback. The default is **false**.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.UpdateExtensionBitsProductResponse> UpdateExtensionBitsProductAsync(
            string sku,
            global::G.UpdateExtensionBitsProductBodyCost cost,
            string displayName,
            bool? inDevelopment = default,
            global::System.DateTime? expiration = default,
            bool? isBroadcast = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.UpdateExtensionBitsProductBody
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