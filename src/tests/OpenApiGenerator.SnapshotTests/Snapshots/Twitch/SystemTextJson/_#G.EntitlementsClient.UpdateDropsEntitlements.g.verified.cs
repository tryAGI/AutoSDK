//HintName: G.EntitlementsClient.UpdateDropsEntitlements.g.cs

#nullable enable

namespace G
{
    public partial class EntitlementsClient
    {
        /// <summary>
        /// Updates the Drop entitlement’s fulfillment status.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<UpdateDropsEntitlementsResponse> UpdateDropsEntitlementsAsync(
            UpdateDropsEntitlementsBody request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Patch,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + "/entitlements/drops", global::System.UriKind.RelativeOrAbsolute));
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
                global::System.Text.Json.JsonSerializer.Deserialize<UpdateDropsEntitlementsResponse>(content) ??
                throw new global::System.InvalidOperationException("Response deserialization failed for \"{content}\" ");
        }

        /// <summary>
        /// Updates the Drop entitlement’s fulfillment status.
        /// </summary>
        /// <param name="entitlementIds"></param>
        /// <param name="fulfillmentStatus"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<UpdateDropsEntitlementsResponse> UpdateDropsEntitlementsAsync(
            global::System.Collections.Generic.IList<string?>? entitlementIds = default,
            UpdateDropsEntitlementsBodyFulfillmentStatus? fulfillmentStatus = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new UpdateDropsEntitlementsBody
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