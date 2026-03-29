//HintName: G.IViewsClient.Get.g.cs
#nullable enable

namespace G
{
    public partial interface IViewsClient
    {
        /// <summary>
        /// Get view details<br/>
        /// Get the details about a specific view in the data manager
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.View> GetAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}