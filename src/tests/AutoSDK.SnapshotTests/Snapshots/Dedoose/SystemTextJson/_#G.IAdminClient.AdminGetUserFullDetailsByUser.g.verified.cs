//HintName: G.IAdminClient.AdminGetUserFullDetailsByUser.g.cs
#nullable enable

namespace G
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// GetUserFullDetailsByUser.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AdminGetUserFullDetailsByUserResponse> AdminGetUserFullDetailsByUserAsync(
            string? token = default,
            global::System.Guid userId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}