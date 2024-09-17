//HintName: G.IPipelinesClient.Index.g.cs
#nullable enable

namespace G
{
    public partial interface IPipelinesClient
    {
        /// <summary>
        /// Index<br/>
        /// Retrieve a paginated set of pipelines.
        /// </summary>
        /// <param name="skip">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PaginatedPipelineGet> IndexAsync(
            int? skip = 0,
            int? limit = 20,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}