//HintName: G.IVariationClient.GetVariationById.g.cs
#nullable enable

namespace G
{
    public partial interface IVariationClient
    {
        /// <summary>
        /// Get variation by ID<br/>
        /// This endpoint will get the variation by ID
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetVariationByIdResponse> GetVariationByIdAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}