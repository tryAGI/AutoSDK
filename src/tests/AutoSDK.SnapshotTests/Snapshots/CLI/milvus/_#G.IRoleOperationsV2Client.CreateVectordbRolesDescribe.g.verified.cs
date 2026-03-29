//HintName: G.IRoleOperationsV2Client.CreateVectordbRolesDescribe.g.cs
#nullable enable

namespace G
{
    public partial interface IRoleOperationsV2Client
    {
        /// <summary>
        /// Describe Role<br/>
        /// This operation describes the details of a specified role.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="authorization"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Privileges> CreateVectordbRolesDescribeAsync(

            global::G.RoleName request,
            int? requestTimeout = default,
            string? authorization = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Describe Role<br/>
        /// This operation describes the details of a specified role.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="authorization"></param>
        /// <param name="roleName1">
        /// The name of the role.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Privileges> CreateVectordbRolesDescribeAsync(
            string roleName1,
            int? requestTimeout = default,
            string? authorization = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}