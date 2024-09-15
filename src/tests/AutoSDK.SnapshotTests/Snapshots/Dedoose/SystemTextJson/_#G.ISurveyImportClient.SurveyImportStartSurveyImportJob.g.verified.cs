//HintName: G.ISurveyImportClient.SurveyImportStartSurveyImportJob.g.cs
#nullable enable

namespace G
{
    public partial interface ISurveyImportClient
    {
        /// <summary>
        /// StartSurveyImportJob.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="surveyUploadedFileURL"></param>
        /// <param name="encryptedSymKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> SurveyImportStartSurveyImportJobAsync(
            string? token = default,
            global::System.Guid projectId = default,
            string? surveyUploadedFileURL = default,
            string? encryptedSymKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}