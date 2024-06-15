//HintName: G.TagsClient.GetAllStreamTags.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class TagsClient
    {
        /// <summary>
        /// Gets the list of all stream tags that Twitch defines. You can also filter the list by one or more tag IDs.<br/>
        /// **IMPORTANT** Twitch is moving from Twitch-defined tags to channel-defined tags. **IMPORTANT** As of February 28, 2023, this endpoint returns an empty array. On July 13, 2023, it will return a 410 response.<br/>
        /// Gets a list of all stream tags that Twitch defines. The broadcaster may apply any of these to their channel except automatic tags. For an online list of the possible tags, see [List of All Tags](https://www.twitch.tv/directory/all/tags).<br/>
        /// __Authorization:__<br/>
        /// Requires an [app access token](https://dev.twitch.tv/docs/authentication#app-access-tokens) or [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens).
        /// </summary>
        /// <param name="tagId"></param>
        /// <param name="first"></param>
        /// <param name="after"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        public async global::System.Threading.Tasks.Task<global::G.GetAllStreamTagsResponse> GetAllStreamTagsAsync(
            global::System.Collections.Generic.IList<string> tagId,
            int first,
            string after,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/tags/streams?{string.Join("&", tagId.Select(static x => $"tagId={x}"))}&first={first}&after={after}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.GetAllStreamTagsResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}