//HintName: G.InteractionsClient.InteractionsSetRestrictionsForAuthenticatedUser.g.cs

#nullable enable

namespace G
{
    public partial class InteractionsClient
    {
        /// <summary>
        /// Set interaction restrictions for your public repositories
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<InteractionLimitResponse> InteractionsSetRestrictionsForAuthenticatedUserAsync(
            InteractionLimit request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + "/user/interaction-limits", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::Newtonsoft.Json.JsonConvert.SerializeObject(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<InteractionLimitResponse>(content) ??
                throw new global::System.InvalidOperationException("Response deserialization failed for \"{content}\" ");
        }

        /// <summary>
        /// Set interaction restrictions for your public repositories
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="expiry"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<InteractionLimitResponse> InteractionsSetRestrictionsForAuthenticatedUserAsync(
            InteractionLimitLimit limit,
            InteractionLimitExpiry? expiry = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new InteractionLimit
            {
                Limit = limit,
                Expiry = expiry,
            };

            return await InteractionsSetRestrictionsForAuthenticatedUserAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}