//HintName: G.IViewsClient.DeleteAll.g.cs
#nullable enable

namespace G
{
    public partial interface IViewsClient
    {
        /// <summary>
        /// Delete all project views<br/>
        /// Delete all views for a specific project.
        /// </summary>
        /// <param name="project"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAllAsync(
            int project,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}