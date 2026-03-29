//HintName: G.ISettingsClient.GetLogo.g.cs
#nullable enable

namespace G
{
    public partial interface ISettingsClient
    {
        /// <summary>
        /// Get logo
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetLogoResponse2> GetLogoAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}