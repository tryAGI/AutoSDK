//HintName: G.ReposClient.ReposListForAuthenticatedUser.g.cs

#nullable enable

namespace G
{
    public partial class ReposClient
    {
        /// <summary>
        /// List repositories for the authenticated user
        /// </summary>
        /// <param name="visibility"></param>
        /// <param name="affiliation"></param>
        /// <param name="type"></param>
        /// <param name="sort"></param>
        /// <param name="direction"></param>
        /// <param name="perPage"></param>
        /// <param name="page"></param>
        /// <param name="since"></param>
        /// <param name="before"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task ReposListForAuthenticatedUserAsync(
            ReposListForAuthenticatedUserVisibility visibility,
            string affiliation,
            ReposListForAuthenticatedUserType type,
            ReposListForAuthenticatedUserSort sort,
            ReposListForAuthenticatedUserDirection direction,
            int perPage,
            int page,
            global::System.DateTime since,
            global::System.DateTime before,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var visibilityValue = visibility switch
            {
                ReposListForAuthenticatedUserVisibility.All => "all",
                ReposListForAuthenticatedUserVisibility.Public => "public",
                ReposListForAuthenticatedUserVisibility.Private => "private",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var typeValue = type switch
            {
                ReposListForAuthenticatedUserType.All => "all",
                ReposListForAuthenticatedUserType.Owner => "owner",
                ReposListForAuthenticatedUserType.Public => "public",
                ReposListForAuthenticatedUserType.Private => "private",
                ReposListForAuthenticatedUserType.Member => "member",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var sortValue = sort switch
            {
                ReposListForAuthenticatedUserSort.Created => "created",
                ReposListForAuthenticatedUserSort.Updated => "updated",
                ReposListForAuthenticatedUserSort.Pushed => "pushed",
                ReposListForAuthenticatedUserSort.FullName => "full_name",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var directionValue = direction switch
            {
                ReposListForAuthenticatedUserDirection.Asc => "asc",
                ReposListForAuthenticatedUserDirection.Desc => "desc",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/user/repos?visibility={visibilityValue}&affiliation={affiliation}&type={typeValue}&sort={sortValue}&direction={directionValue}&per_page={perPage}&page={page}&since={since}&before={before}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}