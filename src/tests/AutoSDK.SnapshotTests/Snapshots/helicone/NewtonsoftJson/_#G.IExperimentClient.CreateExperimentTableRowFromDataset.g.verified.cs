//HintName: G.IExperimentClient.CreateExperimentTableRowFromDataset.g.cs
#nullable enable

namespace G
{
    public partial interface IExperimentClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="experimentId"></param>
        /// <param name="datasetId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultNullString> CreateExperimentTableRowFromDatasetAsync(
            string experimentId,
            string datasetId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}