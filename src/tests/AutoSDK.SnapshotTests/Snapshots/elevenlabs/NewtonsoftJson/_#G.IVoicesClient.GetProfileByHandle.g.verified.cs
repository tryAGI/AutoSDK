//HintName: G.IVoicesClient.GetProfileByHandle.g.cs
#nullable enable

namespace G
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// Get A Profile Page<br/>
        /// Gets a profile page based on a handle
        /// </summary>
        /// <param name="handle">
        /// Handle for a VA's profile page
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ProfilePageResponseModel> GetProfileByHandleAsync(
            string handle,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}