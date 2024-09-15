//HintName: G.ISingleClient.GetCurrentCity.g.cs
#nullable enable

namespace G
{
    public partial interface ISingleClient
    {
        /// <summary>
        /// Returns the current city.<br/>
        /// Returns the current city.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> GetCurrentCityAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}