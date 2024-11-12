//HintName: G.EntitlementsClient.GetDropsEntitlements.g.cs

#nullable enable

namespace G
{
    public partial class EntitlementsClient
    {
        partial void PrepareGetDropsEntitlementsArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Collections.Generic.IList<string>? id,
            ref string? userId,
            ref string? gameId,
            ref global::G.GetDropsEntitlementsFulfillmentStatus? fulfillmentStatus,
            ref string? after,
            ref int? first);
        partial void PrepareGetDropsEntitlementsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Collections.Generic.IList<string>? id,
            string? userId,
            string? gameId,
            global::G.GetDropsEntitlementsFulfillmentStatus? fulfillmentStatus,
            string? after,
            int? first);
        partial void ProcessGetDropsEntitlementsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetDropsEntitlementsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Gets an organization’s list of entitlements that have been granted to a game, a user, or both.<br/>
        /// Gets an organization’s list of entitlements that have been granted to a game, a user, or both.<br/>
        /// **NOTE:** Entitlements returned in the response body data are not guaranteed to be sorted by any field returned by the API. To retrieve **CLAIMED** or **FULFILLED** entitlements, use the `fulfillment_status` query parameter to filter results. To retrieve entitlements for a specific game, use the `game_id` query parameter to filter results.<br/>
        /// The following table identifies the request parameters that you may specify based on the type of access token used.<br/>
        /// | Access token type | Parameter | Description |<br/>
        /// | - | - | - |<br/>
        /// | App | None | If you don’t specify request parameters, the request returns all entitlements that your organization owns. |<br/>
        /// | App | user_id | The request returns all entitlements for any game that the organization granted to the specified user. |<br/>
        /// | App | user_id, game_id | The request returns all entitlements that the specified game granted to the specified user. |<br/>
        /// | App | game_id | The request returns all entitlements that the specified game granted to all entitled users. |<br/>
        /// | User | None | If you don’t specify request parameters, the request returns all entitlements for any game that the organization granted to the user identified in the access token. |<br/>
        /// | User | user_id | Invalid. |<br/>
        /// | User | user_id, game_id | Invalid. |<br/>
        /// | User | game_id | The request returns all entitlements that the specified game granted to the user identified in the access token. |<br/>
        /// __Authorization:__<br/>
        /// Requires an [app access token](https://dev.twitch.tv/docs/authentication#app-access-tokens) or [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens). The client ID in the access token must own the game.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userId"></param>
        /// <param name="gameId"></param>
        /// <param name="fulfillmentStatus"></param>
        /// <param name="after"></param>
        /// <param name="first"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.GetDropsEntitlementsResponse> GetDropsEntitlementsAsync(
            global::System.Collections.Generic.IList<string>? id = default,
            string? userId = default,
            string? gameId = default,
            global::G.GetDropsEntitlementsFulfillmentStatus? fulfillmentStatus = default,
            string? after = default,
            int? first = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetDropsEntitlementsArguments(
                httpClient: HttpClient,
                id: id,
                userId: ref userId,
                gameId: ref gameId,
                fulfillmentStatus: ref fulfillmentStatus,
                after: ref after,
                first: ref first);

            var __pathBuilder = new PathBuilder(
                path: "/entitlements/drops",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("id", id, delimiter: ",", explode: true) 
                .AddOptionalParameter("user_id", userId) 
                .AddOptionalParameter("game_id", gameId) 
                .AddOptionalParameter("fulfillment_status", fulfillmentStatus?.ToValueString()) 
                .AddOptionalParameter("after", after) 
                .AddOptionalParameter("first", first?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
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

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareGetDropsEntitlementsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                id: id,
                userId: userId,
                gameId: gameId,
                fulfillmentStatus: fulfillmentStatus,
                after: after,
                first: first);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetDropsEntitlementsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // 
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                if (ReadResponseAsString)
                {
                    __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                }
                else
                {
                    var __contentStream_400 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                }

                throw new global::G.ApiException(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_400,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // 
            if ((int)__response.StatusCode == 401)
            {
                string? __content_401 = null;
                if (ReadResponseAsString)
                {
                    __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                }
                else
                {
                    var __contentStream_401 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                }

                throw new global::G.ApiException(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_401,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // 
            if ((int)__response.StatusCode == 403)
            {
                string? __content_403 = null;
                if (ReadResponseAsString)
                {
                    __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                }
                else
                {
                    var __contentStream_403 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                }

                throw new global::G.ApiException(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_403,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // 
            if ((int)__response.StatusCode == 500)
            {
                string? __content_500 = null;
                if (ReadResponseAsString)
                {
                    __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                }
                else
                {
                    var __contentStream_500 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                }

                throw new global::G.ApiException(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_500,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessGetDropsEntitlementsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
                {
                    throw new global::G.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }

                return
                    global::G.GetDropsEntitlementsResponse.FromJson(__content, JsonSerializerOptions) ??
                    throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
                {
                    throw new global::G.ApiException(
                        message: __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }

                using var __responseStream = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);

                var __responseValue = await global::G.GetDropsEntitlementsResponse.FromJsonStreamAsync(__responseStream, JsonSerializerOptions).ConfigureAwait(false);

                return
                    __responseValue ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }
    }
}