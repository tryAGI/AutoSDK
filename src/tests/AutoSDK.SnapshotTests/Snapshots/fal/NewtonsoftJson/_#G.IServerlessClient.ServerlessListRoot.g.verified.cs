//HintName: G.IServerlessClient.ServerlessListRoot.g.cs
#nullable enable

namespace G
{
    public partial interface IServerlessClient
    {
        /// <summary>
        /// List files (root)<br/>
        /// Lists files and folders in the root of your project storage.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.ServerlessListRootResponseItem>> ServerlessListRootAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}