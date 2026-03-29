//HintName: G.IEditClient.DeleteTemplate.g.cs
#nullable enable

namespace G
{
    public partial interface IEditClient
    {
        /// <summary>
        /// Delete Template<br/>
        /// Delete a template by its template id.<br/>
        /// **Base URL:** &lt;a href="#"&gt;https://api.shotstack.io/edit/{version}&lt;/a&gt;
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteTemplateAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}