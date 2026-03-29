//HintName: G.IAgentsClient.AgentsTemplates.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// List Templates<br/>
        /// List of public, Cartesia-provided agent templates to help you get started.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetTemplatesResponse> AgentsTemplatesAsync(
            global::G.AgentsTemplatesCartesiaVersion cartesiaVersion,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}