//HintName: G.UserClient.UserSendContactRequestEmail.g.cs

#nullable enable

namespace G
{
    public partial class UserClient
    {
        partial void PrepareUserSendContactRequestEmailArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref string? firstname,
            ref string? lastname,
            ref string? email,
            ref string? phone,
            ref string? institution,
            ref string? comments);
        partial void PrepareUserSendContactRequestEmailRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            string? firstname,
            string? lastname,
            string? email,
            string? phone,
            string? institution,
            string? comments);
        partial void ProcessUserSendContactRequestEmailResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUserSendContactRequestEmailResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// SendContactRequestEmail.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="firstname"></param>
        /// <param name="lastname"></param>
        /// <param name="email"></param>
        /// <param name="phone"></param>
        /// <param name="institution"></param>
        /// <param name="comments"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> UserSendContactRequestEmailAsync(
            string? token = default,
            string? firstname = default,
            string? lastname = default,
            string? email = default,
            string? phone = default,
            string? institution = default,
            string? comments = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareUserSendContactRequestEmailArguments(
                httpClient: _httpClient,
                token: ref token,
                firstname: ref firstname,
                lastname: ref lastname,
                email: ref email,
                phone: ref phone,
                institution: ref institution,
                comments: ref comments);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/user/sendcontactrequestemail",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("firstname", firstname) 
                .AddOptionalParameter("lastname", lastname) 
                .AddOptionalParameter("email", email) 
                .AddOptionalParameter("phone", phone) 
                .AddOptionalParameter("institution", institution) 
                .AddOptionalParameter("comments", comments) 
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
            PrepareUserSendContactRequestEmailRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                firstname: firstname,
                lastname: lastname,
                email: email,
                phone: phone,
                institution: institution,
                comments: comments);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessUserSendContactRequestEmailResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessUserSendContactRequestEmailResponseContent(
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

            return __content;
        }
    }
}