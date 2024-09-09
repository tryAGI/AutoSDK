//HintName: G.ExtensionsClient.GetExtensionConfigurationSegment.g.cs

#nullable enable

namespace G
{
    public partial class ExtensionsClient
    {
        partial void PrepareGetExtensionConfigurationSegmentArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? broadcasterId,
            ref string extensionId,
            ref global::G.GetExtensionConfigurationSegmentSegment segment);
        partial void PrepareGetExtensionConfigurationSegmentRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? broadcasterId,
            string extensionId,
            global::G.GetExtensionConfigurationSegmentSegment segment);
        partial void ProcessGetExtensionConfigurationSegmentResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetExtensionConfigurationSegmentResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Gets the specified configuration segment from the specified extension.<br/>
        /// Gets the specified configuration segment from the specified extension.<br/>
        /// **Rate Limits**: You may retrieve each segment a maximum of 20 times per minute.<br/>
        /// __Authorization:__<br/>
        /// Requires a signed JSON Web Token (JWT) created by an Extension Backend Service (EBS). For signing requirements, see [Signing the JWT](https://dev.twitch.tv/docs/extensions/building/#signing-the-jwt). The signed JWT must include the `role`, `user_id`, and `exp` fields (see [JWT Schema](https://dev.twitch.tv/docs/extensions/reference/#jwt-schema)). The `role` field must be set to _external_.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="extensionId"></param>
        /// <param name="segment"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.GetExtensionConfigurationSegmentResponse> GetExtensionConfigurationSegmentAsync(
            string extensionId,
            global::G.GetExtensionConfigurationSegmentSegment segment,
            string? broadcasterId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareGetExtensionConfigurationSegmentArguments(
                httpClient: _httpClient,
                broadcasterId: ref broadcasterId,
                extensionId: ref extensionId,
                segment: ref segment);

            var segmentValue = segment switch
            {
                global::G.GetExtensionConfigurationSegmentSegment.Broadcaster => "broadcaster",
                global::G.GetExtensionConfigurationSegmentSegment.Developer => "developer",
                global::G.GetExtensionConfigurationSegmentSegment.Global => "global",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/extensions/configurations?broadcaster_id={broadcasterId}&extension_id={extensionId}&segment={(global::System.Uri.EscapeDataString(segmentValue.ToString() ?? string.Empty))}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareGetExtensionConfigurationSegmentRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                broadcasterId: broadcasterId,
                extensionId: extensionId,
                segment: segment);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessGetExtensionConfigurationSegmentResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGetExtensionConfigurationSegmentResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.GetExtensionConfigurationSegmentResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}