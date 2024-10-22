//HintName: G.ExtensionsClient.SetExtensionConfigurationSegment.g.cs

#nullable enable

namespace G
{
    public partial class ExtensionsClient
    {
        partial void PrepareSetExtensionConfigurationSegmentArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.SetExtensionConfigurationSegmentBody request);
        partial void PrepareSetExtensionConfigurationSegmentRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.SetExtensionConfigurationSegmentBody request);
        partial void ProcessSetExtensionConfigurationSegmentResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Updates a configuration segment.<br/>
        /// Updates a configuration segment. The segment is limited to 5 KB. Extensions that are active on a channel do not receive the updated configuration.<br/>
        /// **Rate Limits**: You may update the configuration a maximum of 20 times per minute.<br/>
        /// __Authorization:__<br/>
        /// Requires a signed JSON Web Token (JWT) created by an Extension Backend Service (EBS). For signing requirements, see [Signing the JWT](https://dev.twitch.tv/docs/extensions/building/#signing-the-jwt). The signed JWT must include the `role`, `user_id`, and `exp` fields (see [JWT Schema](https://dev.twitch.tv/docs/extensions/reference/#jwt-schema)). The `role` field must be set to _external_.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task SetExtensionConfigurationSegmentAsync(
            global::G.SetExtensionConfigurationSegmentBody request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareSetExtensionConfigurationSegmentArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/extensions/configurations",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
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
            PrepareSetExtensionConfigurationSegmentRequest(
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
            ProcessSetExtensionConfigurationSegmentResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            __response.EnsureSuccessStatusCode();
        }

        /// <summary>
        /// Updates a configuration segment.<br/>
        /// Updates a configuration segment. The segment is limited to 5 KB. Extensions that are active on a channel do not receive the updated configuration.<br/>
        /// **Rate Limits**: You may update the configuration a maximum of 20 times per minute.<br/>
        /// __Authorization:__<br/>
        /// Requires a signed JSON Web Token (JWT) created by an Extension Backend Service (EBS). For signing requirements, see [Signing the JWT](https://dev.twitch.tv/docs/extensions/building/#signing-the-jwt). The signed JWT must include the `role`, `user_id`, and `exp` fields (see [JWT Schema](https://dev.twitch.tv/docs/extensions/reference/#jwt-schema)). The `role` field must be set to _external_.
        /// </summary>
        /// <param name="extensionId">
        /// The ID of the extension to update.
        /// </param>
        /// <param name="segment">
        /// The configuration segment to update. Possible case-sensitive values are:  <br/>
        ///   <br/>
        /// * broadcaster<br/>
        /// * developer<br/>
        /// * global
        /// </param>
        /// <param name="broadcasterId">
        /// The ID of the broadcaster that installed the extension. Include this field only if the `segment` is set to developer or broadcaster.
        /// </param>
        /// <param name="content">
        /// The contents of the segment. This string may be a plain-text string or a string-encoded JSON object.
        /// </param>
        /// <param name="version">
        /// The version number that identifies this definition of the segment’s data. If not specified, the latest definition is updated.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task SetExtensionConfigurationSegmentAsync(
            string extensionId,
            global::G.SetExtensionConfigurationSegmentBodySegment segment,
            string? broadcasterId = default,
            string? content = default,
            string? version = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.SetExtensionConfigurationSegmentBody
            {
                ExtensionId = extensionId,
                Segment = segment,
                BroadcasterId = broadcasterId,
                Content = content,
                Version = version,
            };

            await SetExtensionConfigurationSegmentAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}