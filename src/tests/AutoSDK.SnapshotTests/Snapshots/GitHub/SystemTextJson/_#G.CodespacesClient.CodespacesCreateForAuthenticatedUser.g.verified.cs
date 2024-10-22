//HintName: G.CodespacesClient.CodespacesCreateForAuthenticatedUser.g.cs

#nullable enable

namespace G
{
    public partial class CodespacesClient
    {
        partial void PrepareCodespacesCreateForAuthenticatedUserArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.OneOf<global::G.CodespacesCreateForAuthenticatedUserRequestVariant1, global::G.CodespacesCreateForAuthenticatedUserRequestVariant2> request);
        partial void PrepareCodespacesCreateForAuthenticatedUserRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.OneOf<global::G.CodespacesCreateForAuthenticatedUserRequestVariant1, global::G.CodespacesCreateForAuthenticatedUserRequestVariant2> request);
        partial void ProcessCodespacesCreateForAuthenticatedUserResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCodespacesCreateForAuthenticatedUserResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a codespace for the authenticated user<br/>
        /// Creates a new codespace, owned by the authenticated user.<br/>
        /// This endpoint requires either a `repository_id` OR a `pull_request` but not both.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `codespace` scope to use this endpoint.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Codespace> CodespacesCreateForAuthenticatedUserAsync(
            global::G.OneOf<global::G.CodespacesCreateForAuthenticatedUserRequestVariant1, global::G.CodespacesCreateForAuthenticatedUserRequestVariant2> request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareCodespacesCreateForAuthenticatedUserArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/user/codespaces",
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
            PrepareCodespacesCreateForAuthenticatedUserRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCodespacesCreateForAuthenticatedUserResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessCodespacesCreateForAuthenticatedUserResponseContent(
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
                global::G.Codespace.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create a codespace for the authenticated user<br/>
        /// Creates a new codespace, owned by the authenticated user.<br/>
        /// This endpoint requires either a `repository_id` OR a `pull_request` but not both.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `codespace` scope to use this endpoint.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Codespace> CodespacesCreateForAuthenticatedUserAsync(
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.OneOf<global::G.CodespacesCreateForAuthenticatedUserRequestVariant1, global::G.CodespacesCreateForAuthenticatedUserRequestVariant2>
            {
            };

            return await CodespacesCreateForAuthenticatedUserAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}