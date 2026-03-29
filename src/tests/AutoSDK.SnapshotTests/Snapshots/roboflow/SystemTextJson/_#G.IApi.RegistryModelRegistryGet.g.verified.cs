//HintName: G.IApi.RegistryModelRegistryGet.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Get model keys<br/>
        /// Get the ID of each loaded model
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ModelsDescriptions> RegistryModelRegistryGetAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}