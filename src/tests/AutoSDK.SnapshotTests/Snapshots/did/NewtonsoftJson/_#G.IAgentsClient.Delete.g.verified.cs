//HintName: G.IAgentsClient.Delete.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Delete an Agent<br/>
        /// Deletes an existing Agent.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AllOf<global::G.DeleteResponseVariant1, global::G.DeleteResponseVariant2>> DeleteAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}