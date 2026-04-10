//HintName: G.ITemplatesClient.CreateTemplatesByTemplateID.g.cs
#nullable enable

namespace G
{
    public partial interface ITemplatesClient
    {
        /// <summary>
        /// Rebuild an template
        /// </summary>
        /// <param name="templateID"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.TemplateLegacy> CreateTemplatesByTemplateIDAsync(
            string templateID,

            global::G.TemplateBuildRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rebuild an template
        /// </summary>
        /// <param name="templateID"></param>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.TemplateLegacy> CreateTemplatesByTemplateIDAsync(
            string templateID,
            string dockerfile,
            string? alias = default,
            string? teamID = default,
            string? startCmd = default,
            string? readyCmd = default,
            int? cpuCount = default,
            int? memoryMB = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}