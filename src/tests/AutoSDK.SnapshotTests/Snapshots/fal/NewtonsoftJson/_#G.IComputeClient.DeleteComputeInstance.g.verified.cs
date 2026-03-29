//HintName: G.IComputeClient.DeleteComputeInstance.g.cs
#nullable enable

namespace G
{
    public partial interface IComputeClient
    {
        /// <summary>
        /// Delete Compute Instance<br/>
        /// Deletes a specific compute instance by its ID. This action is irreversible.<br/>
        /// **Requirements:**<br/>
        /// - Requires compute permissions (extra_permissions.compute = true)<br/>
        /// - Authentication required via admin API key<br/>
        /// - Instance must belong to the authenticated user's workspace<br/>
        /// **Key Features:**<br/>
        /// - Permanently remove compute instances<br/>
        /// - Free up compute resources<br/>
        /// - Stop billing for the instance<br/>
        /// - Clean up unused resources<br/>
        /// **Important:**<br/>
        /// - This action cannot be undone<br/>
        /// - All data on the instance will be lost<br/>
        /// - Instance will be immediately terminated<br/>
        /// - Billing stops after deletion<br/>
        /// **Common Use Cases:**<br/>
        /// - Clean up completed workloads<br/>
        /// - Remove failed or stuck instances<br/>
        /// - Manage compute costs<br/>
        /// - Free up quota for new instances<br/>
        /// See [fal.ai docs](https://docs.fal.ai/compute) for more details.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the compute instance<br/>
        /// Example: inst_abc123xyz
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteComputeInstanceAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}