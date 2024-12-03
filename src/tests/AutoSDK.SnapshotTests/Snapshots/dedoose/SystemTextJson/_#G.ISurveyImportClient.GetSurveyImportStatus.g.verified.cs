//HintName: G.ISurveyImportClient.GetSurveyImportStatus.g.cs
#nullable enable

namespace G
{
    public partial interface ISurveyImportClient
    {
        /// <summary>
        /// GetSurveyImportStatus<br/>
        /// GetSurveyImportStatus
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.SurveyImportStatusVO> GetSurveyImportStatusAsync(
            global::G.GetSurveyImportStatusRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GetSurveyImportStatus<br/>
        /// GetSurveyImportStatus
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.SurveyImportStatusVO> GetSurveyImportStatusAsync(
            string jobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}