//HintName: G.ActionsClient.ActionsAddCustomLabelsToSelfHostedRunnerForOrg.g.cs

#nullable enable

namespace G
{
    public partial class ActionsClient
    {
        /// <summary>
        /// Add custom labels to a self-hosted runner for an organization
        /// </summary>
        /// <param name="org"></param>
        /// <param name="runnerId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<ActionsAddCustomLabelsToSelfHostedRunnerForOrgResponse> ActionsAddCustomLabelsToSelfHostedRunnerForOrgAsync(
            string org,
            int runnerId,
            ActionsAddCustomLabelsToSelfHostedRunnerForOrgRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/orgs/{org}/actions/runners/{runnerId}/labels", global::System.UriKind.RelativeOrAbsolute));
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<ActionsAddCustomLabelsToSelfHostedRunnerForOrgResponse?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Add custom labels to a self-hosted runner for an organization
        /// </summary>
        /// <param name="org"></param>
        /// <param name="runnerId"></param>
        /// <param name="labels"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<ActionsAddCustomLabelsToSelfHostedRunnerForOrgResponse> ActionsAddCustomLabelsToSelfHostedRunnerForOrgAsync(
            string org,
            int runnerId,
            global::System.Collections.Generic.IList<string> labels,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new ActionsAddCustomLabelsToSelfHostedRunnerForOrgRequest
            {
                Labels = labels,
            };

            return await ActionsAddCustomLabelsToSelfHostedRunnerForOrgAsync(
                org: org,
                runnerId: runnerId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}