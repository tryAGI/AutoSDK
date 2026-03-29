//HintName: G.IToolsClient.AddBaseTools.g.cs
#nullable enable

namespace G
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// Upsert Base Tools<br/>
        /// Upsert base tools
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Tool>> AddBaseToolsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}