//HintName: G.IInitImagesClient.GetInitImageById.g.cs
#nullable enable

namespace G
{
    public partial interface IInitImagesClient
    {
        /// <summary>
        /// Get single init image<br/>
        /// This endpoint will return a single init image
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetInitImageByIdResponse> GetInitImageByIdAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}