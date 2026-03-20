//HintName: G.IApi.InferenceDeployV1InferenceDeployDeployIdPost.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Inference Deploy
        /// </summary>
        /// <param name="deployId"></param>
        /// <param name="xDeepinfraSource"></param>
        /// <param name="userAgent"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> InferenceDeployV1InferenceDeployDeployIdPostAsync(
            string deployId,
            string? xDeepinfraSource = default,
            string? userAgent = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}