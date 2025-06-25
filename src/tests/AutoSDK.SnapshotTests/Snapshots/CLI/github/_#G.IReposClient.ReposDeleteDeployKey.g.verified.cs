//HintName: G.IReposClient.ReposDeleteDeployKey.g.cs
#nullable enable

namespace G
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Delete a deploy key<br/>
        /// Deploy keys are immutable. If you need to update a key, remove the key and create a new one instead.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="keyId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task ReposDeleteDeployKeyAsync(
            string owner,
            string repo,
            int keyId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}