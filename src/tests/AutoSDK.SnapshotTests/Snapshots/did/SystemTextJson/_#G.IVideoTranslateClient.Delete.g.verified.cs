//HintName: G.IVideoTranslateClient.Delete.g.cs
#nullable enable

namespace G
{
    public partial interface IVideoTranslateClient
    {
        /// <summary>
        /// Delete a specific Video Translate
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}