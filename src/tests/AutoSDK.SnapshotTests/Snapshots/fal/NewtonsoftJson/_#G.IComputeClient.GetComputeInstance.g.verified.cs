//HintName: G.IComputeClient.GetComputeInstance.g.cs
#nullable enable

namespace G
{
    public partial interface IComputeClient
    {
        /// <summary>
        /// Get Compute Instance<br/>
        /// Retrieves detailed information about a specific compute instance by its ID.<br/>
        /// **Requirements:**<br/>
        /// - Requires compute permissions (extra_permissions.compute = true)<br/>
        /// - Authentication required via admin API key<br/>
        /// - Instance must belong to the authenticated user's workspace<br/>
        /// **Key Features:**<br/>
        /// - Get current instance status and configuration<br/>
        /// - Access instance IP address when available<br/>
        /// - View region and sector placement<br/>
        /// - Check creator information<br/>
        /// **Common Use Cases:**<br/>
        /// - Monitor specific instance status<br/>
        /// - Retrieve connection details (IP address)<br/>
        /// - Check instance readiness before use<br/>
        /// - Audit instance configuration<br/>
        /// See [fal.ai docs](https://docs.fal.ai/compute) for more details.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the compute instance<br/>
        /// Example: inst_abc123xyz
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetComputeInstanceResponse> GetComputeInstanceAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}