//HintName: G.ITemplateAPIClient.V2TemplateId.g.cs
#nullable enable

namespace G
{
    public partial interface ITemplateAPIClient
    {
        /// <summary>
        /// v2/template/&lt;id&gt;<br/>
        /// v2/template/&lt;id&gt;
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task V2TemplateIdAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}