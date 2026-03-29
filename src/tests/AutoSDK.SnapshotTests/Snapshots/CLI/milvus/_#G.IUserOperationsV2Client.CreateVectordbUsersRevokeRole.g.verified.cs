//HintName: G.IUserOperationsV2Client.CreateVectordbUsersRevokeRole.g.cs
#nullable enable

namespace G
{
    public partial interface IUserOperationsV2Client
    {
        /// <summary>
        /// Revoker Role From User<br/>
        /// This operation revokes a privilege granted to the current role.<br/>
        /// &gt; Notes<br/>
        /// &gt; To complete this operation, you need to enable authentication on your Milvus instance. For details, refer to [Authenticate User Access](https://milvus.io/docs/authenticate.md).
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="authorization"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateVectordbUsersRevokeRoleAsync(
            int? requestTimeout = default,
            string? authorization = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}