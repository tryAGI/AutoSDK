//HintName: G.IGuardClient.GetGuards.g.cs
#nullable enable

namespace G
{
    public partial interface IGuardClient
    {
        /// <summary>
        /// Fetches the configuration for all Guards the user has access to.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Guard>> GetGuardsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}