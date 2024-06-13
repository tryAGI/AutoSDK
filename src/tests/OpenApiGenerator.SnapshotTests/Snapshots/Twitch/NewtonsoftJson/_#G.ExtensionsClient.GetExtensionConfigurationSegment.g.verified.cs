//HintName: G.ExtensionsClient.GetExtensionConfigurationSegment.g.cs

#nullable enable

namespace G
{
    public partial class ExtensionsClient
    {
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
            string broadcasterId,
            string extensionId,
            global::G.GetExtensionConfigurationSegmentSegment segment,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var segmentValue = segment switch
            {
                global::G.GetExtensionConfigurationSegmentSegment.Broadcaster => "broadcaster",
                global::G.GetExtensionConfigurationSegmentSegment.Developer => "developer",
                global::G.GetExtensionConfigurationSegmentSegment.Global => "global",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/extensions/configurations?broadcaster_id={broadcasterId}&extension_id={extensionId}&segment={segmentValue}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.GetExtensionConfigurationSegmentResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}