//HintName: G.IDescriptorClient.DescriptorGetDesDataFromFileJobResult.g.cs
#nullable enable

namespace G
{
    public partial interface IDescriptorClient
    {
        /// <summary>
        /// GetDesDataFromFileJobResult.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DescriptorGetDesDataFromFileJobResultResponse> DescriptorGetDesDataFromFileJobResultAsync(
            string? token = default,
            global::System.Guid jobId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}