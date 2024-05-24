//HintName: G.AdminClient.AdminAddNewUserToAccount.g.cs

#nullable enable

namespace G
{
    public partial class AdminClient
    {
        /// <summary>
        /// AddNewUserToAccount.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="accountId"></param>
        /// <param name="username"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        /// <param name="phone"></param>
        /// <param name="encryptedPass"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task AdminAddNewUserToAccountAsync(
            string token,
            string accountId,
            string username,
            string firstName,
            string lastName,
            string email,
            string phone,
            string encryptedPass,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/api/v1/admin/addnewusertoaccount?accountId={accountId}&username={username}&firstName={firstName}&lastName={lastName}&email={email}&phone={phone}&encryptedPass={encryptedPass}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}