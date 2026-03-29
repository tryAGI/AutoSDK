//HintName: G.IUserOperationsV2Client.CreateVectordbUsersGrantRole.g.cs
#nullable enable

namespace G
{
    public partial interface IUserOperationsV2Client
    {
        /// <summary>
        /// Grant Role To User<br/>
        /// This operation grants a specified role to the current user. Once granted the role, the user gets permissions allowed for the current role and can perform certain operations.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="authorization"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateVectordbUsersGrantRoleAsync(
            int? requestTimeout = default,
            string? authorization = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}