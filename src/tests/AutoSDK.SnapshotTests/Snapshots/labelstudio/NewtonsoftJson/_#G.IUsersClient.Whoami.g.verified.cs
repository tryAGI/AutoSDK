//HintName: G.IUsersClient.Whoami.g.cs
#nullable enable

namespace G
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Retrieve my user<br/>
        /// Retrieve details of the account that you are using to access the API.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.WhoAmIUser> WhoamiAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}