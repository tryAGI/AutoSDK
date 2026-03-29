//HintName: G.ITemplatesClient.CreateTemplates.g.cs
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
        global::System.Threading.Tasks.Task<global::G.TemplateRequestResponseV3> CreateTemplatesAsync(

            global::G.TemplateBuildRequestV3 request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new template
        /// </summary>
        /// <param name="name">
        /// Name of the template. Can include a tag with colon separator (e.g. "my-template" or "my-template:v1"). If tag is included, it will be treated as if the tag was provided in the tags array.
        /// </param>
        /// <param name="tags">
        /// Tags to assign to the template build
        /// </param>
        /// <param name="cpuCount">
        /// CPU cores for the sandbox
        /// </param>
        /// <param name="memoryMB">
        /// Memory for the sandbox in MiB
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TemplateRequestResponseV3> CreateTemplatesAsync(
            string? name = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            int? cpuCount = default,
            int? memoryMB = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}