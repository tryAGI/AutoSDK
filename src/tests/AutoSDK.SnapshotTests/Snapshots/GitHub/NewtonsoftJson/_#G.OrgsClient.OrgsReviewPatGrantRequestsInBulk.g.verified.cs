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
                client: HttpClient);
            PrepareOrgsReviewPatGrantRequestsInBulkArguments(
                httpClient: HttpClient,
                org: ref org,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/orgs/{org}/personal-access-token-requests",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareOrgsReviewPatGrantRequestsInBulkRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                org: org,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessOrgsReviewPatGrantRequestsInBulkResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessOrgsReviewPatGrantRequestsInBulkResponseContent(
                httpClient: HttpClient,
                httpResponseMessage: __response,
                content: ref __content);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::System.InvalidOperationException(__content, __ex);
            }

            return
                global::G.BasicError.FromJson(__content, JsonSerializerOptions) ??
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
            var __request = new global::G.OrgsReviewPatGrantRequestsInBulkRequest
            {
                PatRequestIds = patRequestIds,
                Action = action,
                Reason = reason,
            };

            return await OrgsReviewPatGrantRequestsInBulkAsync(
                org: org,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}