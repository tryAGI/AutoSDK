//HintName: G.ITemplatesClient.CreateTemplatesByTemplateIDBuildsByBuildID2.g.cs
#nullable enable

namespace G
{
    public partial interface ITemplatesClient
    {
        /// <summary>
        /// Start the build
        /// </summary>
        /// <param name="templateID"></param>
        /// <param name="buildID"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateTemplatesByTemplateIDBuildsByBuildID2Async(
            string templateID,
            string buildID,

            global::G.TemplateBuildStartV2 request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Start the build
        /// </summary>
        /// <param name="templateID"></param>
        /// <param name="buildID"></param>
        /// <param name="fromImage">
        /// Image to use as a base for the template build
        /// </param>
        /// <param name="fromTemplate">
        /// Template to use as a base for the template build
        /// </param>
        /// <param name="fromImageRegistry"></param>
        /// <param name="force">
        /// Whether the whole build should be forced to run regardless of the cache<br/>
        /// Default Value: false
        /// </param>
        /// <param name="steps">
        /// List of steps to execute in the template build<br/>
        /// Default Value: []
        /// </param>
        /// <param name="startCmd">
        /// Start command to execute in the template after the build
        /// </param>
        /// <param name="readyCmd">
        /// Ready check command to execute in the template after the build
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateTemplatesByTemplateIDBuildsByBuildID2Async(
            string templateID,
            string buildID,
            string? fromImage = default,
            string? fromTemplate = default,
            global::G.FromImageRegistry? fromImageRegistry = default,
            bool? force = default,
            global::System.Collections.Generic.IList<global::G.TemplateStep>? steps = default,
            string? startCmd = default,
            string? readyCmd = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}