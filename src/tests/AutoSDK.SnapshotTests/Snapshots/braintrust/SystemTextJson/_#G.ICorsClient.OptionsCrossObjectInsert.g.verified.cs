//HintName: G.ICorsClient.OptionsCrossObjectInsert.g.cs
#nullable enable

namespace G
{
    public partial interface ICorsClient
    {
        /// <summary>
        /// Enable CORS (`/v1/insert`)<br/>
        /// Enable CORS
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task OptionsCrossObjectInsertAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}