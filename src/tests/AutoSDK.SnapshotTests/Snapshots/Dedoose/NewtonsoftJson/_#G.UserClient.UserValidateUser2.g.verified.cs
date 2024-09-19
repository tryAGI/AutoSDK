//HintName: G.UserClient.UserValidateUser2.g.cs

#nullable enable

namespace G
{
    public partial class UserClient
    {
        partial void PrepareUserValidateUser2Arguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref string? username,
            ref string? rsaEncryptedPass,
            ref global::System.Guid? connectionKey);
        partial void PrepareUserValidateUser2Request(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            string? username,
            string? rsaEncryptedPass,
            global::System.Guid? connectionKey);
        partial void ProcessUserValidateUser2Response(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUserValidateUser2ResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// ValidateUser2.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="username"></param>
        /// <param name="rsaEncryptedPass"></param>
        /// <param name="connectionKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ValidateUserResult> UserValidateUser2Async(
            string? token = default,
            string? username = default,
            string? rsaEncryptedPass = default,
            global::System.Guid? connectionKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareUserValidateUser2Arguments(
                httpClient: _httpClient,
                token: ref token,
                username: ref username,
                rsaEncryptedPass: ref rsaEncryptedPass,
                connectionKey: ref connectionKey);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/user/validateuser2",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("username", username) 
                .AddOptionalParameter("rsaEncryptedPass", rsaEncryptedPass) 
                .AddOptionalParameter("connectionKey", connectionKey?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareUserValidateUser2Request(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                username: username,
                rsaEncryptedPass: rsaEncryptedPass,
                connectionKey: connectionKey);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessUserValidateUser2Response(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessUserValidateUser2ResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ValidateUserResult?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}