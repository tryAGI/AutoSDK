//HintName: G.UserClient.UserAddNewUserToAccount.g.cs

#nullable enable

namespace G
{
    public partial class UserClient
    {
        /// <summary>
        /// AddNewUserToAccount.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="username"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        /// <param name="phone"></param>
        /// <param name="encryptedPass"></param>
        /// <param name="groupId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<UserServiceAddNewUserToAccountControllerOutput> UserAddNewUserToAccountAsync(
            string token,
            string projectId,
            string username,
            string firstName,
            string lastName,
            string email,
            string phone,
            string encryptedPass,
            string groupId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/api/v1/user/addnewusertoaccount?projectId={projectId}&username={username}&firstName={firstName}&lastName={lastName}&email={email}&phone={phone}&encryptedPass={encryptedPass}&groupId={groupId}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::System.Text.Json.JsonSerializer.Deserialize<UserServiceAddNewUserToAccountControllerOutput>(content) ??
                throw new global::System.InvalidOperationException("Response deserialization failed for \"{content}\" ");
        }
    }
}