//HintName: G.IExperimentClient.GetExperimentTableMetadata.g.cs
#nullable enable

namespace G
{
    public partial interface IExperimentClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="experimentTableId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultExperimentTableSimplifiedString> GetExperimentTableMetadataAsync(
            string experimentTableId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}