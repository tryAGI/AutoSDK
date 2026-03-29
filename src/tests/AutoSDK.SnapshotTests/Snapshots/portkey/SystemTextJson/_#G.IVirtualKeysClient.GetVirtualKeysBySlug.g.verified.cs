//HintName: G.IVirtualKeysClient.GetVirtualKeysBySlug.g.cs
#nullable enable

namespace G
{
    public partial interface IVirtualKeysClient
    {
        /// <summary>
        /// Get a Virtual Key
        /// </summary>
        /// <param name="slug"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.VirtualKeys> GetVirtualKeysBySlugAsync(
            string slug,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}