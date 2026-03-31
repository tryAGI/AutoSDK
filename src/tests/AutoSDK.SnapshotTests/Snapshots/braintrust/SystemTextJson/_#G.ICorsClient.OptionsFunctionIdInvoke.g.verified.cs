//HintName: G.ICorsClient.OptionsFunctionIdInvoke.g.cs
#nullable enable

namespace G
{
    public partial interface ICorsClient
    {
        /// <summary>
        /// Enable CORS (`/v1/function/{function_id}/invoke`)<br/>
        /// Enable CORS
        /// </summary>
        /// <param name="functionId">
        /// Function id
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task OptionsFunctionIdInvokeAsync(
            global::System.Guid functionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}