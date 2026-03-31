//HintName: G.IAgentsClient.Get.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Get an Agent<br/>
        /// Returns details for a specific Agent.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AllOf<global::G.GetResponseVariant1, global::G.GetResponseVariant2>> GetAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}