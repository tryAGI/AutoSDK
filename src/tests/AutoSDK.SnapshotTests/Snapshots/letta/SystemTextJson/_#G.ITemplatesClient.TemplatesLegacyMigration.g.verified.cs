//HintName: G.ITemplatesClient.TemplatesLegacyMigration.g.cs
#nullable enable

namespace G
{
    public partial interface ITemplatesClient
    {
        /// <summary>
        /// Migrate template from legacy project (Cloud-only)<br/>
        /// Migrates a template from a legacy project to the default project. Only works if the template is currently in a legacy project.
        /// </summary>
        /// <param name="templateId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TemplatesLegacyMigrationResponse> TemplatesLegacyMigrationAsync(
            string templateId,

            object request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Migrate template from legacy project (Cloud-only)<br/>
        /// Migrates a template from a legacy project to the default project. Only works if the template is currently in a legacy project.
        /// </summary>
        /// <param name="templateId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TemplatesLegacyMigrationResponse> TemplatesLegacyMigrationAsync(
            string templateId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}