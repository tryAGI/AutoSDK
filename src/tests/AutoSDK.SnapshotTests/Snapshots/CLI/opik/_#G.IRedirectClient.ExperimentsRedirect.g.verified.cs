//HintName: G.IRedirectClient.ExperimentsRedirect.g.cs
#nullable enable

namespace G
{
    public partial interface IRedirectClient
    {
        /// <summary>
        /// Create experiment redirect url<br/>
        /// Create experiment redirect url
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="experimentId"></param>
        /// <param name="workspaceName"></param>
        /// <param name="path"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task ExperimentsRedirectAsync(
            global::System.Guid datasetId,
            global::System.Guid experimentId,
            string path,
            string? workspaceName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}