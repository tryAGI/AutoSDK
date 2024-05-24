//HintName: G.UsersClient.UsersGetContextForUser.g.cs

#nullable enable

namespace G
{
    public partial class UsersClient
    {
        /// <summary>
        /// Get contextual information for a user
        /// </summary>
        /// <param name="username"></param>
        /// <param name="subjectType"></param>
        /// <param name="subjectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<Hovercard> UsersGetContextForUserAsync(
            string username,
            UsersGetContextForUserSubjectType subjectType,
            string subjectId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var subjectTypeValue = subjectType switch
            {
                UsersGetContextForUserSubjectType.Organization => "organization",
                UsersGetContextForUserSubjectType.Repository => "repository",
                UsersGetContextForUserSubjectType.Issue => "issue",
                UsersGetContextForUserSubjectType.PullRequest => "pull_request",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/users/{username}/hovercard?subject_type={subjectTypeValue}&subject_id={subjectId}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<Hovercard>(content) ??
                throw new global::System.InvalidOperationException("Response deserialization failed for \"{content}\" ");
        }
    }
}