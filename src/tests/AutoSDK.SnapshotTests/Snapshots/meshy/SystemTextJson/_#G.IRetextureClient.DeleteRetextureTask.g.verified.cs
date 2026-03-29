//HintName: G.IRetextureClient.DeleteRetextureTask.g.cs
#nullable enable

namespace G
{
    public partial interface IRetextureClient
    {
        /// <summary>
        /// Delete a Retexture task
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteRetextureTaskAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}