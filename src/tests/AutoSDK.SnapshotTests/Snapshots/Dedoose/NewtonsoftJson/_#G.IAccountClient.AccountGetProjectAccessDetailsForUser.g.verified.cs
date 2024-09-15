//HintName: G.IAccountClient.AccountGetProjectAccessDetailsForUser.g.cs
#nullable enable

namespace G
{
    public partial interface IAccountClient
    {
        /// <summary>
        /// GetProjectAccessDetailsForUser.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.AccountGetProjectAccessDetailsForUserResponseItem>> AccountGetProjectAccessDetailsForUserAsync(
            string? token = default,
            global::System.Guid userId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}