//HintName: G.ITemplatesClient.GetTemplatesByTemplateId.g.cs
#nullable enable

namespace G
{
    public partial interface ITemplatesClient
    {
        /// <summary>
        /// Retrieve a template<br/>
        /// You can use Retrieve a template endpoint to pull information on a template. In particular, you may use it to find out the variables available for customisation.
        /// </summary>
        /// <param name="templateId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TemplateResponse> GetTemplatesByTemplateIdAsync(
            string templateId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}