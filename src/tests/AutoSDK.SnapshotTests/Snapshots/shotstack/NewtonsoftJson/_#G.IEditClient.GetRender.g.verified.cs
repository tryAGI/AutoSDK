//HintName: G.IEditClient.GetRender.g.cs
#nullable enable

namespace G
{
    public partial interface IEditClient
    {
        /// <summary>
        /// Get Render Status<br/>
        /// Get the rendering status, temporary asset url and details of a render by ID.<br/>
        /// **Base URL:** &lt;a href="#"&gt;https://api.shotstack.io/edit/{version}&lt;/a&gt;
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.RenderResponse> GetRenderAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}