//HintName: G.ITemplatesClient.DeleteTemplatesByTemplateID.g.cs
#nullable enable

namespace G
{
    public partial interface ITemplatesClient
    {
        /// <summary>
        /// Delete a template
        /// </summary>
        /// <param name="templateID"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteTemplatesByTemplateIDAsync(
            string templateID,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}