//HintName: G.IMetaClient.MetaGetZen.g.cs
#nullable enable

namespace G
{
    public partial interface IMetaClient
    {
        /// <summary>
        /// Get the Zen of GitHub<br/>
        /// Get a random sentence from the Zen of GitHub
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> MetaGetZenAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}