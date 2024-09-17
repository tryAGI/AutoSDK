//HintName: G.IPointersClient.Index.g.cs
#nullable enable

namespace G
{
    public partial interface IPointersClient
    {
        /// <summary>
        /// Index<br/>
        /// Retrieve a paginated set of pipeline pointers that satisfy query parameters.<br/>
        /// Users are authorised to query for pointers:<br/>
        /// -related to a given pipeline family<br/>
        ///     `pipeline_name=marjory92/falcon`
        /// </summary>
        /// <param name="pipelineName"></param>
        /// <param name="skip">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="orderBy"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PaginatedPointerGet> IndexAsync(
            string? pipelineName = default,
            int? skip = 0,
            int? limit = 20,
            string? orderBy = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}