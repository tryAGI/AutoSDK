//HintName: G.ISingleClient.GetCurrentCountry.g.cs
#nullable enable

namespace G
{
    public partial interface ISingleClient
    {
        /// <summary>
        /// Returns the current country.<br/>
        /// Returns the current country.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetCurrentCountryAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}