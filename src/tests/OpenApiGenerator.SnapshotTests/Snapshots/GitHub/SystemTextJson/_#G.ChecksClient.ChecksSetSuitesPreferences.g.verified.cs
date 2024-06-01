//HintName: G.ChecksClient.ChecksSetSuitesPreferences.g.cs

#nullable enable

namespace G
{
    public partial class ChecksClient
    {
        /// <summary>
        /// Update repository preferences for check suites
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<CheckSuitePreference> ChecksSetSuitesPreferencesAsync(
            string owner,
            string repo,
            ChecksSetSuitesPreferencesRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Patch,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}/check-suites/preferences", global::System.UriKind.RelativeOrAbsolute));
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
                global::System.Text.Json.JsonSerializer.Deserialize<CheckSuitePreference?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update repository preferences for check suites
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="autoTriggerChecks"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<CheckSuitePreference> ChecksSetSuitesPreferencesAsync(
            string owner,
            string repo,
            global::System.Collections.Generic.IList<ChecksSetSuitesPreferencesRequestAutoTriggerChecks?>? autoTriggerChecks = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new ChecksSetSuitesPreferencesRequest
            {
                AutoTriggerChecks = autoTriggerChecks,
            };

            return await ChecksSetSuitesPreferencesAsync(
                owner: owner,
                repo: repo,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}