//HintName: G.IVoicesClient.GetAProfilePageProfileHandleGet.g.cs
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
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ProfilePageResponseModel> GetAProfilePageProfileHandleGetAsync(
            string handle,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}