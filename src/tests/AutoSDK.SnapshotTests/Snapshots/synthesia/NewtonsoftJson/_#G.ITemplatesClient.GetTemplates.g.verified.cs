//HintName: G.ITemplatesClient.GetTemplates.g.cs
#nullable enable

namespace G
{
    public partial interface ITemplatesClient
    {
        /// <summary>
        /// List templates<br/>
        /// Use the List templates endpoint to get an overview of all templates in Synthesia STUDIO, as well as the variables that may be provided when using them.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="source">
        /// Default Value: [synthesia, workspace]
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TemplateListResponse> GetTemplatesAsync(
            int? limit = default,
            int? offset = default,
            global::System.Collections.Generic.IList<global::G.GetTemplatesSourceItem>? source = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}