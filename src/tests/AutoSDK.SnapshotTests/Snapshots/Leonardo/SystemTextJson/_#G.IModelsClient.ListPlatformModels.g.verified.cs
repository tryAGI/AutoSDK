//HintName: G.IModelsClient.ListPlatformModels.g.cs
#nullable enable

namespace G
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// List Platform Models<br/>
        /// Get a list of public Platform Models available for use with generations.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListPlatformModelsResponse> ListPlatformModelsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}