//HintName: G.IAnimationsClient.GetAnimation.g.cs
#nullable enable

namespace G
{
    public partial interface IAnimationsClient
    {
        /// <summary>
        /// Get a specific animation
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.GetAnimationResponse> GetAnimationAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}