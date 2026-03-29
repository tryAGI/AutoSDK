//HintName: G.ITextTo3dClient.GetTextTo3DTask.g.cs
#nullable enable

namespace G
{
    public partial interface ITextTo3dClient
    {
        /// <summary>
        /// Retrieve a Text to 3D task
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TextTo3DTask> GetTextTo3DTaskAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}