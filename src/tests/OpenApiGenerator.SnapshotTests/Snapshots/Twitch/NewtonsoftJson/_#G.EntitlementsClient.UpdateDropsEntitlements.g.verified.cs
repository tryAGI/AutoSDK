//HintName: G.EntitlementsClient.UpdateDropsEntitlements.g.cs

#nullable enable

namespace G
{
    public partial class EntitlementsClient
    {
        /// <summary>
        /// Updates the Drop entitlement’s fulfillment status.<br/>
        /// Updates the Drop entitlement’s fulfillment status.<br/>
        /// The following table identifies which entitlements are updated based on the type of access token used.<br/>
        /// | Access token type | Data that’s updated |<br/>
        /// | - | - |<br/>
        /// | App | Updates all entitlements with benefits owned by the organization in the access token. |<br/>
        /// | User | Updates all entitlements owned by the user in the access token and where the benefits are owned by the organization in the access token. |<br/>
        /// __Authorization:__<br/>
        /// Requires an [app access token](https://dev.twitch.tv/docs/authentication#app-access-tokens) or [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens). The client ID in the access token must own the game.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.UpdateDropsEntitlementsResponse> UpdateDropsEntitlementsAsync(
            global::G.UpdateDropsEntitlementsBody request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Patch,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + "/entitlements/drops", global::System.UriKind.RelativeOrAbsolute));
            var __json = global::Newtonsoft.Json.JsonConvert.SerializeObject(request, _jsonSerializerOptions);
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: __json,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.UpdateDropsEntitlementsResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Updates the Drop entitlement’s fulfillment status.<br/>
        /// Updates the Drop entitlement’s fulfillment status.<br/>
        /// The following table identifies which entitlements are updated based on the type of access token used.<br/>
        /// | Access token type | Data that’s updated |<br/>
        /// | - | - |<br/>
        /// | App | Updates all entitlements with benefits owned by the organization in the access token. |<br/>
        /// | User | Updates all entitlements owned by the user in the access token and where the benefits are owned by the organization in the access token. |<br/>
        /// __Authorization:__<br/>
        /// Requires an [app access token](https://dev.twitch.tv/docs/authentication#app-access-tokens) or [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens). The client ID in the access token must own the game.
        /// </summary>
        /// <param name="entitlementIds"></param>
        /// <param name="fulfillmentStatus"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.UpdateDropsEntitlementsResponse> UpdateDropsEntitlementsAsync(
            global::System.Collections.Generic.IList<string?>? entitlementIds = default,
            global::G.UpdateDropsEntitlementsBodyFulfillmentStatus? fulfillmentStatus = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.UpdateDropsEntitlementsBody
            {
                EntitlementIds = entitlementIds,
                FulfillmentStatus = fulfillmentStatus,
            };

            return await UpdateDropsEntitlementsAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}