//HintName: G.TagsClient.GetAllStreamTags.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class TagsClient
    {
        /// <summary>
        /// Gets the list of all stream tags that Twitch defines. You can also filter the list by one or more tag IDs.
        /// </summary>
        /// <param name="tagId"></param>
        /// <param name="first"></param>
        /// <param name="after"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<GetAllStreamTagsResponse> GetAllStreamTagsAsync(
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

            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::System.Text.Json.JsonSerializer.Deserialize<GetAllStreamTagsResponse>(content) ??
                throw new global::System.InvalidOperationException("Response deserialization failed for \"{content}\" ");
        }
    }
}