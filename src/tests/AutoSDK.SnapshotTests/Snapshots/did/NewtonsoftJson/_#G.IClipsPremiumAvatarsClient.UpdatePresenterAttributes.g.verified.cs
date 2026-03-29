//HintName: G.IClipsPremiumAvatarsClient.UpdatePresenterAttributes.g.cs
#nullable enable

namespace G
{
    public partial interface IClipsPremiumAvatarsClient
    {
        /// <summary>
        /// Update a specific presenter attributes
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task UpdatePresenterAttributesAsync(
            string id,

            global::G.AllOf<global::G.UpdatePresenterAttributesRequestVariant1, global::G.UpdatePresenterAttributesRequestVariant2, global::G.UpdatePresenterAttributesRequestVariant3> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a specific presenter attributes
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task UpdatePresenterAttributesAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}