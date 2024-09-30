//HintName: G.ErrorClient.ErrorProcessUIError.g.cs

#nullable enable

namespace G
{
    public partial class ErrorClient
    {
        partial void PrepareErrorProcessUIErrorArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref string? projectId,
            ref string? userId,
            ref string? workspace,
            ref string? errorCode,
            ref string? message,
            ref string? currentTarget,
            ref string? stacktrace);
        partial void PrepareErrorProcessUIErrorRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            string? projectId,
            string? userId,
            string? workspace,
            string? errorCode,
            string? message,
            string? currentTarget,
            string? stacktrace);
        partial void ProcessErrorProcessUIErrorResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessErrorProcessUIErrorResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// ProcessUIError.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="workspace"></param>
        /// <param name="errorCode"></param>
        /// <param name="message"></param>
        /// <param name="currentTarget"></param>
        /// <param name="stacktrace"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ErrorProcessUIErrorResponse> ErrorProcessUIErrorAsync(
            string? token = default,
            string? projectId = default,
            string? userId = default,
            string? workspace = default,
            string? errorCode = default,
            string? message = default,
            string? currentTarget = default,
            string? stacktrace = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareErrorProcessUIErrorArguments(
                httpClient: _httpClient,
                token: ref token,
                projectId: ref projectId,
                userId: ref userId,
                workspace: ref workspace,
                errorCode: ref errorCode,
                message: ref message,
                currentTarget: ref currentTarget,
                stacktrace: ref stacktrace);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/error/processuierror",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("projectId", projectId) 
                .AddOptionalParameter("userId", userId) 
                .AddOptionalParameter("workspace", workspace) 
                .AddOptionalParameter("errorCode", errorCode) 
                .AddOptionalParameter("message", message) 
                .AddOptionalParameter("currentTarget", currentTarget) 
                .AddOptionalParameter("stacktrace", stacktrace) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            if (token != default)
            {
                httpRequest.Headers.TryAddWithoutValidation("token", token.ToString());
            }


            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareErrorProcessUIErrorRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                projectId: projectId,
                userId: userId,
                workspace: workspace,
                errorCode: errorCode,
                message: message,
                currentTarget: currentTarget,
                stacktrace: stacktrace);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessErrorProcessUIErrorResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessErrorProcessUIErrorResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.ErrorProcessUIErrorResponse?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}