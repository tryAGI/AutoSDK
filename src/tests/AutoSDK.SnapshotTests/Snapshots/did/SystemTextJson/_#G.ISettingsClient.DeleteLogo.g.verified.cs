//HintName: G.ISettingsClient.DeleteLogo.g.cs
#nullable enable

namespace G
{
    public partial interface ISettingsClient
    {
        /// <summary>
        /// Delete logo
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteLogoAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}