//HintName: G.IUserOperationsV2Client.CreateVectordbUsersDescribe.g.cs
#nullable enable

namespace G
{
    public partial interface IUserOperationsV2Client
    {
        /// <summary>
        /// Describe User<br/>
        /// This operation describes the detailed information of a specific user.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="authorization"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateVectordbUsersDescribeResponse> CreateVectordbUsersDescribeAsync(

            global::G.CreateVectordbUsersDescribeRequest request,
            int? requestTimeout = default,
            string? authorization = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Describe User<br/>
        /// This operation describes the detailed information of a specific user.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="authorization"></param>
        /// <param name="userName">
        ///   The name of the user to describe.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateVectordbUsersDescribeResponse> CreateVectordbUsersDescribeAsync(
            string userName,
            int? requestTimeout = default,
            string? authorization = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}