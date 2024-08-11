//HintName: G.ReposClient.ReposListWebhookDeliveries.g.cs

#nullable enable

namespace G
{
    public partial class ReposClient
    {
        partial void PrepareReposListWebhookDeliveriesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref int hookId,
            ref int perPage,
            ref string? cursor,
            ref bool redelivery);
        partial void PrepareReposListWebhookDeliveriesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            int hookId,
            int perPage,
            string? cursor,
            bool redelivery);
        partial void ProcessReposListWebhookDeliveriesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReposListWebhookDeliveriesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List deliveries for a repository webhook<br/>
        /// Returns a list of webhook deliveries for a webhook configured in a repository.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="hookId"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="redelivery"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.HookDeliveryItem>> ReposListWebhookDeliveriesAsync(
            string owner,
            string repo,
            int hookId,
            int perPage,
            string? cursor,
            bool redelivery,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareReposListWebhookDeliveriesArguments(
                httpClient: _httpClient,
                owner: ref owner,
                repo: ref repo,
                hookId: ref hookId,
                perPage: ref perPage,
                cursor: ref cursor,
                redelivery: ref redelivery);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/repos/{owner}/{repo}/hooks/{hookId}/deliveries?per_page={perPage}&cursor={cursor}&redelivery={redelivery}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareReposListWebhookDeliveriesRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                owner: owner,
                repo: repo,
                hookId: hookId,
                perPage: perPage,
                cursor: cursor,
                redelivery: redelivery);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessReposListWebhookDeliveriesResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessReposListWebhookDeliveriesResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<global::G.HookDeliveryItem>?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}