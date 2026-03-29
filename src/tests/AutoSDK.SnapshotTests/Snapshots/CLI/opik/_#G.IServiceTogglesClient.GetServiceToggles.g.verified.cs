//HintName: G.IServiceTogglesClient.GetServiceToggles.g.cs
#nullable enable

namespace G
{
    public partial interface IServiceTogglesClient
    {
        /// <summary>
        /// Get Service Toggles<br/>
        /// Get Service Toggles
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ServiceTogglesConfig> GetServiceTogglesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}