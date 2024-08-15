//HintName: G.OrgsClient.OrgsReviewPatGrantRequestsInBulk.g.cs

#nullable enable

namespace G
{
    public partial class OrgsClient
    {
        partial void PrepareOrgsReviewPatGrantRequestsInBulkArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            global::G.OrgsReviewPatGrantRequestsInBulkRequest request);
        partial void PrepareOrgsReviewPatGrantRequestsInBulkRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            global::G.OrgsReviewPatGrantRequestsInBulkRequest request);
        partial void ProcessOrgsReviewPatGrantRequestsInBulkResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessOrgsReviewPatGrantRequestsInBulkResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Review requests to access organization resources with fine-grained personal access tokens<br/>
        /// Approves or denies multiple pending requests to access organization resources via a fine-grained personal access token.<br/>
        /// Only GitHub Apps can use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.BasicError> OrgsReviewPatGrantRequestsInBulkAsync(
            string org,
            global::G.OrgsReviewPatGrantRequestsInBulkRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareOrgsReviewPatGrantRequestsInBulkArguments(
                httpClient: _httpClient,
                org: ref org,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/orgs/{org}/personal-access-token-requests", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, _jsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareOrgsReviewPatGrantRequestsInBulkRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                org: org,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessOrgsReviewPatGrantRequestsInBulkResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessOrgsReviewPatGrantRequestsInBulkResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.BasicError?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Review requests to access organization resources with fine-grained personal access tokens<br/>
        /// Approves or denies multiple pending requests to access organization resources via a fine-grained personal access token.<br/>
        /// Only GitHub Apps can use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="patRequestIds">
        /// Unique identifiers of the requests for access via fine-grained personal access token. Must be formed of between 1 and 100 `pat_request_id` values.
        /// </param>
        /// <param name="action">
        /// Action to apply to the requests.
        /// </param>
        /// <param name="reason">
        /// Reason for approving or denying the requests. Max 1024 characters.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.BasicError> OrgsReviewPatGrantRequestsInBulkAsync(
            string org,
            global::G.OrgsReviewPatGrantRequestsInBulkRequestAction action,
            global::System.Collections.Generic.IList<int>? patRequestIds = default,
            string? reason = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.OrgsReviewPatGrantRequestsInBulkRequest
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