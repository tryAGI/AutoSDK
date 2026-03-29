//HintName: G.IEditClient.GetTemplates.g.cs
#nullable enable

namespace G
{
    public partial interface IEditClient
    {
        /// <summary>
        /// List Templates<br/>
        /// Retrieve a list of templates stored against a users account and stage.<br/>
        /// **Base URL:** &lt;a href="#"&gt;https://api.shotstack.io/edit/{version}&lt;/a&gt;
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TemplateListResponse> GetTemplatesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}