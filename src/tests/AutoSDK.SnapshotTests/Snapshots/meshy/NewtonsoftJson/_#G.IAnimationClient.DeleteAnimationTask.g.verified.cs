//HintName: G.IAnimationClient.DeleteAnimationTask.g.cs
#nullable enable

namespace G
{
    public partial interface IAnimationClient
    {
        /// <summary>
        /// Delete an Animation task
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAnimationTaskAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}