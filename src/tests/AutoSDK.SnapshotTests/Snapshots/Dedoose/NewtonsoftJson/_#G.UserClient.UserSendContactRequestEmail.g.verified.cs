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
                client: HttpClient);
            PrepareUserSendContactRequestEmailArguments(
                httpClient: HttpClient,
                token: ref token,
                firstname: ref firstname,
                lastname: ref lastname,
                email: ref email,
                phone: ref phone,
                institution: ref institution,
                comments: ref comments);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/user/sendcontactrequestemail",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("firstname", firstname) 
                .AddOptionalParameter("lastname", lastname) 
                .AddOptionalParameter("email", email) 
                .AddOptionalParameter("phone", phone) 
                .AddOptionalParameter("institution", institution) 
                .AddOptionalParameter("comments", comments) 
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
            PrepareUserSendContactRequestEmailRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                token: token,
                firstname: firstname,
                lastname: lastname,
                email: email,
                phone: phone,
                institution: institution,
                comments: comments);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessUserSendContactRequestEmailResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessUserSendContactRequestEmailResponseContent(
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
            else
            {
                __response.EnsureSuccessStatusCode();
                using var __responseStream = await __response.Content.ReadAsStreamAsync().ConfigureAwait(false);

            using var __streamReader = new global::System.IO.StreamReader(__responseStream);
            using var __jsonReader = new global::Newtonsoft.Json.JsonTextReader(__streamReader);
            var __serializer = global::Newtonsoft.Json.JsonSerializer.Create(JsonSerializerOptions);
            var __responseValue = __serializer.Deserialize<string?>(__jsonReader);

                return
                    __responseValue ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }
    }
}