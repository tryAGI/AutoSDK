//HintName: G.IMetadataClient.MetadataGetStatus.g.cs
#nullable enable

namespace G
{
    public partial interface IMetadataClient
    {
        /// <summary>
        /// Gets your Letta Cloud status
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.MetadataGetStatusResponse> MetadataGetStatusAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}