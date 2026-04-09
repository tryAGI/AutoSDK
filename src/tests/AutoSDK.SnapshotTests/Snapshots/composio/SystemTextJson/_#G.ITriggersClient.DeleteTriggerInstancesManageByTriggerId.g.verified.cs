//HintName: G.ITriggersClient.DeleteTriggerInstancesManageByTriggerId.g.cs
#nullable enable

namespace G
{
    public partial interface ITriggersClient
    {
        /// <summary>
        /// Delete a trigger<br/>
        /// Permanently deletes a trigger instance. This stops the trigger from listening for events and removes it from your project. Use the PATCH endpoint with status "disable" if you want to temporarily pause a trigger instead.
        /// </summary>
        /// <param name="triggerId">
        /// The ID of the trigger instance to delete
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeleteTriggerInstancesManageByTriggerIdResponse> DeleteTriggerInstancesManageByTriggerIdAsync(
            string triggerId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}