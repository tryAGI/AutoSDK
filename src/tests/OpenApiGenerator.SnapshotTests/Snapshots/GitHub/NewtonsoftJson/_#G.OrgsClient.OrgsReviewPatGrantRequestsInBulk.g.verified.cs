//HintName: G.OrgsClient.OrgsReviewPatGrantRequestsInBulk.g.cs

#nullable enable

namespace G
{
    public partial class OrgsClient
    {
        /// <summary>
        /// Review requests to access organization resources with fine-grained personal access tokens
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<BasicError> OrgsReviewPatGrantRequestsInBulkAsync(
            string org,
            OrgsReviewPatGrantRequestsInBulkRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/orgs/{org}/personal-access-token-requests", global::System.UriKind.RelativeOrAbsolute));
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<BasicError?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Review requests to access organization resources with fine-grained personal access tokens
        /// </summary>
        /// <param name="org"></param>
        /// <param name="patRequestIds"></param>
        /// <param name="action"></param>
        /// <param name="reason"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<BasicError> OrgsReviewPatGrantRequestsInBulkAsync(
            string org,
            OrgsReviewPatGrantRequestsInBulkRequestAction action,
            global::System.Collections.Generic.IList<int>? patRequestIds = default,
            string? reason = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new OrgsReviewPatGrantRequestsInBulkRequest
            {
                PatRequestIds = patRequestIds,
                Action = action,
                Reason = reason,
            };

            return await OrgsReviewPatGrantRequestsInBulkAsync(
                org: org,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}