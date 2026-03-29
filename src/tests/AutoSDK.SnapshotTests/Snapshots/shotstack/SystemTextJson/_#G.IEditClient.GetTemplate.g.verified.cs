//HintName: G.IEditClient.GetTemplate.g.cs
#nullable enable

namespace G
{
    public partial interface IEditClient
    {
        /// <summary>
        /// Retrieve Template<br/>
        /// Retrieve a template by template id.<br/>
        /// **Base URL:** &lt;a href="#"&gt;https://api.shotstack.io/edit/{version}&lt;/a&gt;
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TemplateDataResponse> GetTemplateAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}