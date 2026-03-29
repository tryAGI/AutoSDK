//HintName: G.ITextTo3dClient.DeleteTextTo3DTask.g.cs
#nullable enable

namespace G
{
    public partial interface ITextTo3dClient
    {
        /// <summary>
        /// Delete a Text to 3D task
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteTextTo3DTaskAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}