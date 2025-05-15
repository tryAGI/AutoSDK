//HintName: G.IApi.DeployCreateV1DeployPost.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Deploy Create
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeployResult> DeployCreateV1DeployPostAsync(
            global::G.DeployModelIn request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Deploy Create
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="provider"></param>
        /// <param name="modelName">
        /// model name in specified provider
        /// </param>
        /// <param name="version">
        /// A specific revision, if left empty uses the last one
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeployResult> DeployCreateV1DeployPostAsync(
            string modelName,
            string? xiApiKey = default,
            global::G.ModelProvider? provider = default,
            string? version = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}