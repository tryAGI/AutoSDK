//HintName: G.ITemplatesClient.GetTemplatesByTemplateID.g.cs
#nullable enable

namespace G
{
    public partial interface ITemplatesClient
    {
        /// <summary>
        /// List all builds for a template
        /// </summary>
        /// <param name="templateID"></param>
        /// <param name="nextToken"></param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TemplateWithBuilds> GetTemplatesByTemplateIDAsync(
            string templateID,
            string? nextToken = default,
            int? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}