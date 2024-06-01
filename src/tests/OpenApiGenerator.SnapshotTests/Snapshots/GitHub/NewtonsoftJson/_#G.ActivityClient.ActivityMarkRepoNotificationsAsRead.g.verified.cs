//HintName: G.ActivityClient.ActivityMarkRepoNotificationsAsRead.g.cs

#nullable enable

namespace G
{
    public partial class ActivityClient
    {
        /// <summary>
        /// Mark repository notifications as read
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<ActivityMarkRepoNotificationsAsReadResponse> ActivityMarkRepoNotificationsAsReadAsync(
            string owner,
            string repo,
            ActivityMarkRepoNotificationsAsReadRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}/notifications", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::Newtonsoft.Json.JsonConvert.SerializeObject(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<ActivityMarkRepoNotificationsAsReadResponse?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Mark repository notifications as read
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="lastReadAt"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<ActivityMarkRepoNotificationsAsReadResponse> ActivityMarkRepoNotificationsAsReadAsync(
            string owner,
            string repo,
            global::System.DateTime lastReadAt = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new ActivityMarkRepoNotificationsAsReadRequest
            {
                LastReadAt = lastReadAt,
            };

            return await ActivityMarkRepoNotificationsAsReadAsync(
                owner: owner,
                repo: repo,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}