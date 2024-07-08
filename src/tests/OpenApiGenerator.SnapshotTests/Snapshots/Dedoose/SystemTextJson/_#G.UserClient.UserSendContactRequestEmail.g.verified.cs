//HintName: G.UserClient.UserSendContactRequestEmail.g.cs

#nullable enable

namespace G
{
    public partial class UserClient
    {
        partial void PrepareUserSendContactRequestEmailArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string token,
            ref string firstname,
            ref string lastname,
            ref string email,
            ref string phone,
            ref string institution,
            ref string comments);
        partial void PrepareUserSendContactRequestEmailRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string token,
            string firstname,
            string lastname,
            string email,
            string phone,
            string institution,
            string comments);
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
        public async global::System.Threading.Tasks.Task<object> UserSendContactRequestEmailAsync(
            string token,
            string firstname,
            string lastname,
            string email,
            string phone,
            string institution,
            string comments,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/user/sendcontactrequestemail?firstname={firstname}&lastname={lastname}&email={email}&phone={phone}&institution={institution}&comments={comments}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::System.Text.Json.JsonSerializer.Deserialize<object?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}