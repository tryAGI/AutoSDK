//HintName: G.IDataSetClient.DataSetGetDataSetsByProject.g.cs
#nullable enable

namespace G
{
    public partial interface IDataSetClient
    {
        /// <summary>
        /// GetDataSetsByProject.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.DataSetVO>> DataSetGetDataSetsByProjectAsync(
            string? token = default,
            global::System.Guid projectId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}