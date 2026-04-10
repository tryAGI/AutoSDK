//HintName: G.IDataExplorerClient.ApiDatasetsImportCreate.g.cs
#nullable enable

namespace G
{
    public partial interface IDataExplorerClient
    {
        /// <summary>
        /// Export candidate tasks to project<br/>
        ///     Export Candidate task for a specific dataset to project.<br/>
        ///     
        /// </summary>
        /// <param name="additionalFilters"></param>
        /// <param name="dataset"></param>
        /// <param name="excluded"></param>
        /// <param name="included"></param>
        /// <param name="project"></param>
        /// <param name="view"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task ApiDatasetsImportCreateAsync(
            object? additionalFilters = default,
            int? dataset = default,
            object? excluded = default,
            object? included = default,
            int? project = default,
            int? view = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}