//HintName: G.ITemplatesClient.TemplatesSetCurrentTemplateFromSnapshot.g.cs
#nullable enable

namespace G
{
    public partial interface ITemplatesClient
    {
        /// <summary>
        /// Set current template from snapshot (Cloud-only)<br/>
        /// Updates the current working version of a template from a snapshot
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="templateVersion"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TemplatesSetCurrentTemplateFromSnapshotResponse> TemplatesSetCurrentTemplateFromSnapshotAsync(
            string projectId,
            string templateVersion,

            object request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set current template from snapshot (Cloud-only)<br/>
        /// Updates the current working version of a template from a snapshot
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="templateVersion"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TemplatesSetCurrentTemplateFromSnapshotResponse> TemplatesSetCurrentTemplateFromSnapshotAsync(
            string projectId,
            string templateVersion,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}