//HintName: G.IImagesClient.DeleteImage.g.cs
#nullable enable

namespace G
{
    public partial interface IImagesClient
    {
        /// <summary>
        /// Delete image
        /// </summary>
        /// <param name="assetID"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteImageAsync(
            global::System.Guid assetID,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}