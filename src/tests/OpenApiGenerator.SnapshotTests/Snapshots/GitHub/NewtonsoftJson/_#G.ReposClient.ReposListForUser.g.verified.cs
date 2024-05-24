//HintName: G.ReposClient.ReposListForUser.g.cs

#nullable enable

namespace G
{
    public partial class ReposClient
    {
        /// <summary>
        /// List repositories for a user
        /// </summary>
        /// <param name="username"></param>
        /// <param name="type"></param>
        /// <param name="sort"></param>
        /// <param name="direction"></param>
        /// <param name="perPage"></param>
        /// <param name="page"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task ReposListForUserAsync(
            string username,
            ReposListForUserType type,
            ReposListForUserSort sort,
            ReposListForUserDirection direction,
            int perPage,
            int page,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var typeValue = type switch
            {
                ReposListForUserType.All => "all",
                ReposListForUserType.Owner => "owner",
                ReposListForUserType.Member => "member",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var sortValue = sort switch
            {
                ReposListForUserSort.Created => "created",
                ReposListForUserSort.Updated => "updated",
                ReposListForUserSort.Pushed => "pushed",
                ReposListForUserSort.FullName => "full_name",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var directionValue = direction switch
            {
                ReposListForUserDirection.Asc => "asc",
                ReposListForUserDirection.Desc => "desc",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/users/{username}/repos?type={typeValue}&sort={sortValue}&direction={directionValue}&per_page={perPage}&page={page}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}