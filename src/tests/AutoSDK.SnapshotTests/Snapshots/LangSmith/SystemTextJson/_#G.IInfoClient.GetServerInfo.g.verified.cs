//HintName: G.IInfoClient.GetServerInfo.g.cs
#nullable enable

namespace G
{
    public partial interface IInfoClient
    {
        /// <summary>
        /// Get Server Info<br/>
        /// Get information about the current deployment of LangSmith.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.InfoGetResponse> GetServerInfoAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}