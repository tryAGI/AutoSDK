//HintName: G.ITextToImageClient.GetTextToImageTask.g.cs
#nullable enable

namespace G
{
    public partial interface ITextToImageClient
    {
        /// <summary>
        /// Retrieve a Text to Image task
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TextToImageTask> GetTextToImageTaskAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}