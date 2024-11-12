//HintName: G.IUserClient.UserDoesUserEmailExist.g.cs
#nullable enable

namespace G
{
    public partial interface IUserClient
    {
        /// <summary>
        /// DoesUserEmailExist.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<bool> UserDoesUserEmailExistAsync(
            string? email = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}