//HintName: G.EntitlementsClient.UpdateDropsEntitlements.g.cs

#nullable enable

namespace G
{
    public partial class EntitlementsClient
    {
        partial void PrepareUpdateDropsEntitlementsArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.UpdateDropsEntitlementsBody request);
        partial void PrepareUpdateDropsEntitlementsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.UpdateDropsEntitlementsBody request);
        partial void ProcessUpdateDropsEntitlementsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdateDropsEntitlementsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

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

            PrepareArguments(
                client: HttpClient);
            PrepareUpdateDropsEntitlementsArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/entitlements/drops",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareUpdateDropsEntitlementsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessUpdateDropsEntitlementsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessUpdateDropsEntitlementsResponseContent(
                httpClient: HttpClient,
                httpResponseMessage: __response,
                content: ref __content);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::System.InvalidOperationException(__content, __ex);
            }

            return
                global::G.UpdateDropsEntitlementsResponse.FromJson(__content, JsonSerializerOptions) ??
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
        /// <param name="entitlementIds">
        /// A list of IDs that identify the entitlements to update. You may specify a maximum of 100 IDs.
        /// </param>
        /// <param name="fulfillmentStatus">
        /// The fulfillment status to set the entitlements to. Possible values are:  <br/>
        ///   <br/>
        /// * CLAIMED — The user claimed the benefit.<br/>
        /// * FULFILLED — The developer granted the benefit that the user claimed.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.UpdateDropsEntitlementsResponse> UpdateDropsEntitlementsAsync(
            global::System.Collections.Generic.IList<string>? entitlementIds = default,
            global::G.UpdateDropsEntitlementsBodyFulfillmentStatus? fulfillmentStatus = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.UpdateDropsEntitlementsBody
            {
                EntitlementIds = entitlementIds,
                FulfillmentStatus = fulfillmentStatus,
            };

            return await UpdateDropsEntitlementsAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}