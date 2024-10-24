﻿//HintName: G.UserClient.UserValidate2Factor.g.cs

#nullable enable

namespace G
{
    public partial class UserClient
    {
        partial void PrepareUserValidate2FactorArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref string? username,
            ref global::System.Guid? connectionKey,
            ref string? encryptedAuthToken);
        partial void PrepareUserValidate2FactorRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            string? username,
            global::System.Guid? connectionKey,
            string? encryptedAuthToken);
        partial void ProcessUserValidate2FactorResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUserValidate2FactorResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Validate2Factor.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="username"></param>
        /// <param name="connectionKey"></param>
        /// <param name="encryptedAuthToken"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.User> UserValidate2FactorAsync(
            string? token = default,
            string? username = default,
            global::System.Guid? connectionKey = default,
            string? encryptedAuthToken = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareUserValidate2FactorArguments(
                httpClient: HttpClient,
                token: ref token,
                username: ref username,
                connectionKey: ref connectionKey,
                encryptedAuthToken: ref encryptedAuthToken);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/user/validate2factor",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("username", username) 
                .AddOptionalParameter("connectionKey", connectionKey?.ToString()) 
                .AddOptionalParameter("encryptedAuthToken", encryptedAuthToken) 
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
            PrepareUserValidate2FactorRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                token: token,
                username: username,
                connectionKey: connectionKey,
                encryptedAuthToken: encryptedAuthToken);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessUserValidate2FactorResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessUserValidate2FactorResponseContent(
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
                global::G.User.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}