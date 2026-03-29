//HintName: G.IServiceClient.ReadRootHealthGet.g.cs
#nullable enable

namespace G
{
    public partial interface IServiceClient
    {
        /// <summary>
        /// Read Root
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ReadRootHealthGetAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}