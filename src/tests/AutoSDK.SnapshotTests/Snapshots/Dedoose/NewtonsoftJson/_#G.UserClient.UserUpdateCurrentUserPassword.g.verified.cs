//HintName: G.UserClient.UserUpdateCurrentUserPassword.g.cs

#nullable enable

namespace G
{
    public partial class UserClient
    {
        partial void PrepareUserUpdateCurrentUserPasswordArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref global::System.Guid? userId,
            ref string? encryptedPass);
        partial void PrepareUserUpdateCurrentUserPasswordRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            global::System.Guid? userId,
            string? encryptedPass);
        partial void ProcessUserUpdateCurrentUserPasswordResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUserUpdateCurrentUserPasswordResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// UpdateCurrentUserPassword.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="userId"></param>
        /// <param name="encryptedPass"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> UserUpdateCurrentUserPasswordAsync(
            string? token = default,
            global::System.Guid? userId = default,
            string? encryptedPass = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareUserUpdateCurrentUserPasswordArguments(
                httpClient: HttpClient,
                token: ref token,
                userId: ref userId,
                encryptedPass: ref encryptedPass);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/user/updatecurrentuserpassword",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("userId", userId?.ToString()) 
                .AddOptionalParameter("encryptedPass", encryptedPass) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            if (token != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("token", token.ToString());
            }


            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareUserUpdateCurrentUserPasswordRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                token: token,
                userId: userId,
                encryptedPass: encryptedPass);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessUserUpdateCurrentUserPasswordResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessUserUpdateCurrentUserPasswordResponseContent(
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

            return __content;
        }
    }
}