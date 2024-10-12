//HintName: G.IDescriptorClient.DescriptorStartImportDescriptorsJob.g.cs
#nullable enable

namespace G
{
    public partial interface IDescriptorClient
    {
        /// <summary>
        /// StartImportDescriptorsJob.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="setId"></param>
        /// <param name="descriptorInfos"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> DescriptorStartImportDescriptorsJobAsync(
            string? token = default,
            global::System.Guid? projectId = default,
            global::System.Guid? userId = default,
            global::System.Guid? setId = default,
            global::System.Collections.Generic.IList<global::G.DescriptorInfo>? descriptorInfos = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}