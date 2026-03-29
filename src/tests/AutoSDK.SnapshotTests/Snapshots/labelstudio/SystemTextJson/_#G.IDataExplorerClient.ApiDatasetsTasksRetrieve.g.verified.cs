//HintName: G.IDataExplorerClient.ApiDatasetsTasksRetrieve.g.cs
#nullable enable

namespace G
{
    public partial interface IDataExplorerClient
    {
        /// <summary>
        /// Get Data Explorer tasks list<br/>
        ///     Retrieve a list of Data Explorer tasks with pagination for a specific view or dataset, by using filters and ordering.<br/>
        ///     
        /// </summary>
        /// <param name="dataset"></param>
        /// <param name="maxThreshold"></param>
        /// <param name="minThreshold"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="view"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DatasetView> ApiDatasetsTasksRetrieveAsync(
            int? dataset = default,
            double? maxThreshold = default,
            double? minThreshold = default,
            int? page = default,
            int? pageSize = default,
            int? view = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}