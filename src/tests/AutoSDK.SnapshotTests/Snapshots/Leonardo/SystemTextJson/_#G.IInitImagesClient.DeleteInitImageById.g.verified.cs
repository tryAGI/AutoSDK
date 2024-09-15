//HintName: G.IInitImagesClient.DeleteInitImageById.g.cs
#nullable enable

namespace G
{
    public partial interface IInitImagesClient
    {
        /// <summary>
        /// Delete init image<br/>
        /// This endpoint deletes an init image
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeleteInitImageByIdResponse> DeleteInitImageByIdAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}