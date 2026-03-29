//HintName: G.IUserOperationsV2Client.CreateVectordbUsersDrop.g.cs
#nullable enable

namespace G
{
    public partial interface IUserOperationsV2Client
    {
        /// <summary>
        /// Drop User<br/>
        /// This operation deletes an existing user.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="authorization"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateVectordbUsersDropAsync(

            global::G.UserName request,
            int? requestTimeout = default,
            string? authorization = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Drop User<br/>
        /// This operation deletes an existing user.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="authorization"></param>
        /// <param name="userName1">
        /// The name of the target user. The value should start with a letter and can only contain underline, letters and numbers.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateVectordbUsersDropAsync(
            string userName1,
            int? requestTimeout = default,
            string? authorization = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}