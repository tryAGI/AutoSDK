//HintName: G.ActivityClient.ActivitySetRepoSubscription.g.cs

#nullable enable

namespace G
{
    public partial class ActivityClient
    {
        /// <summary>
        /// Set a repository subscription
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<RepositorySubscription> ActivitySetRepoSubscriptionAsync(
            string owner,
            string repo,
            ActivitySetRepoSubscriptionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}/subscription", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::System.Text.Json.JsonSerializer.Serialize(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::System.Text.Json.JsonSerializer.Deserialize<RepositorySubscription?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Set a repository subscription
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="subscribed"></param>
        /// <param name="ignored"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<RepositorySubscription> ActivitySetRepoSubscriptionAsync(
            string owner,
            string repo,
            bool subscribed = default,
            bool ignored = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new ActivitySetRepoSubscriptionRequest
            {
                Subscribed = subscribed,
                Ignored = ignored,
            };

            return await ActivitySetRepoSubscriptionAsync(
                owner: owner,
                repo: repo,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}