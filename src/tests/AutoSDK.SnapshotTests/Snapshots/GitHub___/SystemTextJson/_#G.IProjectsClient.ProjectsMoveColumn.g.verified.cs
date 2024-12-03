//HintName: G.IProjectsClient.ProjectsMoveColumn.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Move a project column
        /// </summary>
        /// <param name="columnId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ProjectsMoveColumnResponse> ProjectsMoveColumnAsync(
            int columnId,
            global::G.ProjectsMoveColumnRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Move a project column
        /// </summary>
        /// <param name="columnId"></param>
        /// <param name="position">
        /// The position of the column in a project. Can be one of: `first`, `last`, or `after:&lt;column_id&gt;` to place after the specified column.<br/>
        /// Example: last
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ProjectsMoveColumnResponse> ProjectsMoveColumnAsync(
            int columnId,
            string position,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}