//HintName: G.IViewsClient.Delete.g.cs
#nullable enable

namespace G
{
    public partial interface IViewsClient
    {
        /// <summary>
        /// Delete view<br/>
        /// Delete a specific view by ID.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}