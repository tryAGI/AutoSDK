//HintName: G.ActionsClient.ActionsSetAllowedActionsOrganization.g.cs

#nullable enable

namespace G
{
    public partial class ActionsClient
    {
        /// <summary>
        /// Set allowed actions and reusable workflows for an organization
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task ActionsSetAllowedActionsOrganizationAsync(
            string org,
            SelectedActions request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/orgs/{org}/actions/permissions/selected-actions", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::System.Text.Json.JsonSerializer.Serialize(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }

        /// <summary>
        /// Set allowed actions and reusable workflows for an organization
        /// </summary>
        /// <param name="org"></param>
        /// <param name="githubOwnedAllowed"></param>
        /// <param name="verifiedAllowed"></param>
        /// <param name="patternsAllowed"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task ActionsSetAllowedActionsOrganizationAsync(
            string org,
            bool githubOwnedAllowed = default,
            bool verifiedAllowed = default,
            global::System.Collections.Generic.IList<string?>? patternsAllowed = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new SelectedActions
            {
                GithubOwnedAllowed = githubOwnedAllowed,
                VerifiedAllowed = verifiedAllowed,
                PatternsAllowed = patternsAllowed,
            };

            await ActionsSetAllowedActionsOrganizationAsync(
                org: org,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}