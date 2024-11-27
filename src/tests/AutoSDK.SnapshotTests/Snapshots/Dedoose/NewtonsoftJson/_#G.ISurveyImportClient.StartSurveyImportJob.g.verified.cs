//HintName: G.ISurveyImportClient.StartSurveyImportJob.g.cs
#nullable enable

namespace G
{
    public partial interface ISurveyImportClient
    {
        /// <summary>
        /// StartSurveyImportJob<br/>
        /// StartSurveyImportJob
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> StartSurveyImportJobAsync(
            global::G.StartSurveyImportJobRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// StartSurveyImportJob<br/>
        /// StartSurveyImportJob
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="surveyUploadedFileURL"></param>
        /// <param name="encryptedSymKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> StartSurveyImportJobAsync(
            global::System.Guid projectId,
            string surveyUploadedFileURL,
            string encryptedSymKey,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}