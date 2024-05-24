//HintName: G.UserClient.UserSendContactRequestEmail.g.cs

#nullable enable

namespace G
{
    public partial class UserClient
    {
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
        public async global::System.Threading.Tasks.Task UserSendContactRequestEmailAsync(
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
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/api/v1/user/sendcontactrequestemail?firstname={firstname}&lastname={lastname}&email={email}&phone={phone}&institution={institution}&comments={comments}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}