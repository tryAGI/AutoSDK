//HintName: G.IUsersClient.UsersList.g.cs
#nullable enable

namespace G
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// List users<br/>
        /// Lists all users, in the order that they signed up on GitHub. This list includes personal user accounts and organization accounts.<br/>
        /// Note: Pagination is powered exclusively by the `since` parameter. Use the [Link header](https://docs.github.com/rest/guides/using-pagination-in-the-rest-api#using-link-headers) to get the URL for the next page of users.
        /// </summary>
        /// <param name="since"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.SimpleUser>> UsersListAsync(
            int since = default,
            int perPage = 30,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}