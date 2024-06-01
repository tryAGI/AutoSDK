//HintName: G.UsersClient.UsersUpdateAuthenticated.g.cs

#nullable enable

namespace G
{
    public partial class UsersClient
    {
        /// <summary>
        /// Update the authenticated user
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<PrivateUser> UsersUpdateAuthenticatedAsync(
            UsersUpdateAuthenticatedRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Patch,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + "/user", global::System.UriKind.RelativeOrAbsolute));
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
                global::System.Text.Json.JsonSerializer.Deserialize<PrivateUser?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update the authenticated user
        /// </summary>
        /// <param name="name"></param>
        /// <param name="email"></param>
        /// <param name="blog"></param>
        /// <param name="twitterUsername"></param>
        /// <param name="company"></param>
        /// <param name="location"></param>
        /// <param name="hireable"></param>
        /// <param name="bio"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<PrivateUser> UsersUpdateAuthenticatedAsync(
            string? name = default,
            string? email = default,
            string? blog = default,
            string? twitterUsername = default,
            string? company = default,
            string? location = default,
            bool hireable = default,
            string? bio = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new UsersUpdateAuthenticatedRequest
            {
                Name = name,
                Email = email,
                Blog = blog,
                TwitterUsername = twitterUsername,
                Company = company,
                Location = location,
                Hireable = hireable,
                Bio = bio,
            };

            return await UsersUpdateAuthenticatedAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}