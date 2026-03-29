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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TemplatesLegacyMigrationResponse> TemplatesLegacyMigrationAsync(
            string templateId,

            object request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Migrate template from legacy project (Cloud-only)<br/>
        /// Migrates a template from a legacy project to the default project. Only works if the template is currently in a legacy project.
        /// </summary>
        /// <param name="templateId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TemplatesLegacyMigrationResponse> TemplatesLegacyMigrationAsync(
            string templateId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}