//HintName: G.IDescriptorClient.DescriptorStartGetDesDataFromFileJob.g.cs
#nullable enable

namespace G
{
    public partial interface IDescriptorClient
    {
        /// <summary>
        /// StartGetDesDataFromFileJob.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="localFileURL"></param>
        /// <param name="setId"></param>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DescriptorStartGetDesDataFromFileJobResponse> DescriptorStartGetDesDataFromFileJobAsync(
            string? token = default,
            string? localFileURL = default,
            global::System.Guid? setId = default,
            global::System.Guid? projectId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}