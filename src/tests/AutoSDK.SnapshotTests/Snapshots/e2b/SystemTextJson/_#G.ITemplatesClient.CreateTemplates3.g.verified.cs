//HintName: G.ITemplatesClient.CreateTemplates3.g.cs
#nullable enable

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
        global::System.Threading.Tasks.Task<global::G.TemplateLegacy> CreateTemplates3Async(

            global::G.TemplateBuildRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new template
        /// </summary>
        /// <param name="alias">
        /// Alias of the template
        /// </param>
        /// <param name="dockerfile">
        /// Dockerfile for the template
        /// </param>
        /// <param name="teamID">
        /// Identifier of the team
        /// </param>
        /// <param name="startCmd">
        /// Start command to execute in the template after the build
        /// </param>
        /// <param name="readyCmd">
        /// Ready check command to execute in the template after the build
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
        global::System.Threading.Tasks.Task<global::G.TemplateLegacy> CreateTemplates3Async(
            string dockerfile,
            string? alias = default,
            string? teamID = default,
            string? startCmd = default,
            string? readyCmd = default,
            int? cpuCount = default,
            int? memoryMB = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}