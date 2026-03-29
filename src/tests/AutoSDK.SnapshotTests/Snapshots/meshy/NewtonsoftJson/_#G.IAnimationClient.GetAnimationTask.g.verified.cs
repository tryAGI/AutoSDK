//HintName: G.IAnimationClient.GetAnimationTask.g.cs
#nullable enable

namespace G
{
    public partial interface IAnimationClient
    {
        /// <summary>
        /// Retrieve an Animation task
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnimationTask> GetAnimationTaskAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}