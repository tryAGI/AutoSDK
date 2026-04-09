//HintName: G.FineTunesClient.FineTunesListVoices.g.cs

#nullable enable

namespace G
{
    public partial class FineTunesClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_FineTunesListVoicesSecurityRequirement0 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::G.EndPointSecurityRequirement[] s_FineTunesListVoicesSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_FineTunesListVoicesSecurityRequirement0,
            };
        partial void PrepareFineTunesListVoicesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::G.FineTunesListVoicesCartesiaVersion cartesiaVersion,
            ref string id,
            ref int? limit,
            ref string? startingAfter,
            ref string? endingBefore);
        partial void PrepareFineTunesListVoicesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.FineTunesListVoicesCartesiaVersion cartesiaVersion,
            string id,
            int? limit,
            string? startingAfter,
            string? endingBefore);
        partial void ProcessFineTunesListVoicesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessFineTunesListVoicesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List all voices created from a fine-tune
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="id"></param>
        /// <param name="limit"></param>
        /// <param name="startingAfter"></param>
        /// <param name="endingBefore"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.PaginatedVoices> FineTunesListVoicesAsync(
            global::G.FineTunesListVoicesCartesiaVersion cartesiaVersion,
            string id,
            int? limit = default,
            string? startingAfter = default,
            string? endingBefore = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareFineTunesListVoicesArguments(
                httpClient: HttpClient,
                cartesiaVersion: ref cartesiaVersion,
                id: ref id,
                limit: ref limit,
                startingAfter: ref startingAfter,
                endingBefore: ref endingBefore);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_FineTunesListVoicesSecurityRequirements,
                operationName: "FineTunesListVoicesAsync");

            var cartesiaVersionValue = cartesiaVersion switch
            {
                global::G.FineTunesListVoicesCartesiaVersion.x20240610 => "2024-06-10",
                global::G.FineTunesListVoicesCartesiaVersion.x20241113 => "2024-11-13",
                global::G.FineTunesListVoicesCartesiaVersion.x20250416 => "2025-04-16",
                global::G.FineTunesListVoicesCartesiaVersion.x20251104 => "2025-11-04",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new global::G.PathBuilder(
                path: $"/fine-tunes/{id}/voices",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("limit", limit?.ToString())
                .AddOptionalParameter("starting_after", startingAfter)
                .AddOptionalParameter("ending_before", endingBefore) 
                ;
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
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

            __httpRequest.Headers.TryAddWithoutValidation("Cartesia-Version", cartesiaVersion.ToValueString());


            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareFineTunesListVoicesRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                cartesiaVersion: cartesiaVersion,
                id: id,
                limit: limit,
                startingAfter: startingAfter,
                endingBefore: endingBefore);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessFineTunesListVoicesResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessFineTunesListVoicesResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.PaginatedVoices.FromJson(__content, JsonSerializerOptions) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
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
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::G.PaginatedVoices.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

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
            }
        }
    }
}