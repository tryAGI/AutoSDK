//HintName: G.ISingleClient.GetCurrentLocation.g.cs
#nullable enable

namespace G
{
    public partial interface ISingleClient
    {
        /// <summary>
        /// Returns the current location.<br/>
        /// Returns the current location.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> GetCurrentLocationAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}