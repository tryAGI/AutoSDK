//HintName: G.IServiceClient.Livez.g.cs
#nullable enable

namespace G
{
    public partial interface IServiceClient
    {
        /// <summary>
        /// Kubernetes livez endpoint<br/>
        /// An endpoint for health checking used in Kubernetes.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> LivezAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}