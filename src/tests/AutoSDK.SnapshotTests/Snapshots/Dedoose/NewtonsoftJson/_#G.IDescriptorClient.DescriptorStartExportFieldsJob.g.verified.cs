//HintName: G.IDescriptorClient.DescriptorStartExportFieldsJob.g.cs
#nullable enable

namespace G
{
    public partial interface IDescriptorClient
    {
        /// <summary>
        /// StartExportFieldsJob.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="setId"></param>
        /// <param name="fileExtension"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DescriptorStartExportFieldsJobResponse> DescriptorStartExportFieldsJobAsync(
            string? token = default,
            global::System.Guid projectId = default,
            global::System.Guid setId = default,
            string? fileExtension = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}