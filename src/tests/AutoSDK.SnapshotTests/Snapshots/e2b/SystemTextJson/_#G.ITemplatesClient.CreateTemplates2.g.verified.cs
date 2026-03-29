//HintName: G.ITemplatesClient.CreateTemplates2.g.cs
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace G
{
    public partial interface ITemplatesClient
    {
        /// <summary>
        /// Create a new template
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.TemplateLegacy> CreateTemplates2Async(

            global::G.TemplateBuildRequestV2 request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new template
        /// </summary>
        /// <param name="alias">
        /// Alias of the template
        /// </param>
        /// <param name="cpuCount">
        /// CPU cores for the sandbox
        /// </param>
        /// <param name="memoryMB">
        /// Memory for the sandbox in MiB
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.TemplateLegacy> CreateTemplates2Async(
            string alias,
            int? cpuCount = default,
            int? memoryMB = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}