//HintName: G.IApi.ListFilesV1OpenaiFilesGet.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// List Files
        /// </summary>
        /// <param name="after"></param>
        /// <param name="purpose"></param>
        /// <param name="order"></param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="xiApiKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ListFilesV1OpenaiFilesGetAsync(
            string? after = default,
            string? purpose = default,
            string? order = default,
            int? limit = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}