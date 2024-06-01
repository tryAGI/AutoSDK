//HintName: G.CopilotClient.CopilotAddCopilotSeatsForTeams.g.cs

#nullable enable

namespace G
{
    public partial class CopilotClient
    {
        /// <summary>
        /// Add teams to the Copilot subscription for an organization
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<CopilotAddCopilotSeatsForTeamsResponse> CopilotAddCopilotSeatsForTeamsAsync(
            string org,
            CopilotAddCopilotSeatsForTeamsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/orgs/{org}/copilot/billing/selected_teams", global::System.UriKind.RelativeOrAbsolute));
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
                global::System.Text.Json.JsonSerializer.Deserialize<CopilotAddCopilotSeatsForTeamsResponse?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Add teams to the Copilot subscription for an organization
        /// </summary>
        /// <param name="org"></param>
        /// <param name="selectedTeams"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<CopilotAddCopilotSeatsForTeamsResponse> CopilotAddCopilotSeatsForTeamsAsync(
            string org,
            global::System.Collections.Generic.IList<string> selectedTeams,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new CopilotAddCopilotSeatsForTeamsRequest
            {
                SelectedTeams = selectedTeams,
            };

            return await CopilotAddCopilotSeatsForTeamsAsync(
                org: org,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}