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
                client: HttpClient);
            PrepareOrgsReviewPatGrantRequestArguments(
                httpClient: HttpClient,
                org: ref org,
                patRequestId: ref patRequestId,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/orgs/{org}/personal-access-token-requests/{patRequestId}",
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
            PrepareOrgsReviewPatGrantRequestRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                org: org,
                patRequestId: patRequestId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessOrgsReviewPatGrantRequestResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessOrgsReviewPatGrantRequestResponseContent(
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
            var __request = new global::G.OrgsReviewPatGrantRequestRequest
            {
                Action = action,
                Reason = reason,
            };

            return await OrgsReviewPatGrantRequestAsync(
                org: org,
                patRequestId: patRequestId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}