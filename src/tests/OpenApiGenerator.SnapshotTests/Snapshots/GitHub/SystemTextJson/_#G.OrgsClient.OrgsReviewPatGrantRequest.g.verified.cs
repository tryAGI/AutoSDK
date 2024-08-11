//HintName: G.OrgsClient.OrgsReviewPatGrantRequest.g.cs

#nullable enable

namespace G
{
    public partial class OrgsClient
    {
        partial void PrepareOrgsReviewPatGrantRequestArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref int patRequestId,
            global::G.OrgsReviewPatGrantRequestRequest request);
        partial void PrepareOrgsReviewPatGrantRequestRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            int patRequestId,
            global::G.OrgsReviewPatGrantRequestRequest request);
        partial void ProcessOrgsReviewPatGrantRequestResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessOrgsReviewPatGrantRequestResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Review a request to access organization resources with a fine-grained personal access token<br/>
        /// Approves or denies a pending request to access organization resources via a fine-grained personal access token.<br/>
        /// Only GitHub Apps can use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="patRequestId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.BasicError> OrgsReviewPatGrantRequestAsync(
            string org,
            int patRequestId,
            global::G.OrgsReviewPatGrantRequestRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareOrgsReviewPatGrantRequestArguments(
                httpClient: _httpClient,
                org: ref org,
                patRequestId: ref patRequestId,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/orgs/{org}/personal-access-token-requests/{patRequestId}", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: global::System.Text.Json.JsonSerializer.Serialize(request, _jsonSerializerOptions),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareOrgsReviewPatGrantRequestRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                org: org,
                patRequestId: patRequestId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessOrgsReviewPatGrantRequestResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessOrgsReviewPatGrantRequestResponseContent(
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
        /// Review a request to access organization resources with a fine-grained personal access token<br/>
        /// Approves or denies a pending request to access organization resources via a fine-grained personal access token.<br/>
        /// Only GitHub Apps can use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="patRequestId"></param>
        /// <param name="action">
        /// Action to apply to the request.
        /// </param>
        /// <param name="reason">
        /// Reason for approving or denying the request. Max 1024 characters.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.BasicError> OrgsReviewPatGrantRequestAsync(
            string org,
            int patRequestId,
            global::G.OrgsReviewPatGrantRequestRequestAction action,
            string? reason = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.OrgsReviewPatGrantRequestRequest
            {
                Action = action,
                Reason = reason,
            };

            return await OrgsReviewPatGrantRequestAsync(
                org: org,
                patRequestId: patRequestId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}