//HintName: G.IDescriptorClient.DescriptorGetProjectDescriptorFieldValues.g.cs
#nullable enable

namespace G
{
    public partial interface IDescriptorClient
    {
        /// <summary>
        /// GetProjectDescriptorFieldValues.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.DescriptorValueDTO>> DescriptorGetProjectDescriptorFieldValuesAsync(
            string? token = default,
            global::System.Guid projectId = default,
            int page = default,
            int pageSize = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}