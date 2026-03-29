//HintName: G.IAgentClient.SearchDocs.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultStringString> SearchDocsAsync(

            global::G.SearchDocsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="query"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultStringString> SearchDocsAsync(
            string query,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}