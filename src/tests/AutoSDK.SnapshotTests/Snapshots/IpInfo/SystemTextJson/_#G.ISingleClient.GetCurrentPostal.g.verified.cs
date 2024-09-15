//HintName: G.ISingleClient.GetCurrentPostal.g.cs
#nullable enable

namespace G
{
    public partial interface ISingleClient
    {
        /// <summary>
        /// Returns the current postal.<br/>
        /// Returns the current postal.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> GetCurrentPostalAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}