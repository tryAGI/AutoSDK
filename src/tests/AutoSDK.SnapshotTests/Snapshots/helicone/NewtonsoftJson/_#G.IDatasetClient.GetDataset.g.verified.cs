//HintName: G.IDatasetClient.GetDataset.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultPromptInputRecordArrayString> GetDatasetAsync(
            string datasetId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}