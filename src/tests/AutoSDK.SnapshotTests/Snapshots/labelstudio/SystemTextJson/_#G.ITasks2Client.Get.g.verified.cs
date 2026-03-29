//HintName: G.ITasks2Client.Get.g.cs
#nullable enable

namespace G
{
    public partial interface ITasks2Client
    {
        /// <summary>
        /// Get task<br/>
        /// Get task data, metadata, annotations and other attributes for a specific labeling task by task ID.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.RoleBasedTask> GetAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}