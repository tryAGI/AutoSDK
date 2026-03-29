//HintName: G.IApi.DeleteAgent.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Delete an agent<br/>
        /// Delete a cloud agent. This action is permanent and cannot be undone.
        /// </summary>
        /// <param name="id">
        /// Example: bc_abc123
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeleteAgentResponse> DeleteAgentAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}