//HintName: G.SurveyImportClient.SurveyImportStartSurveyImportJob.g.cs

#nullable enable

namespace G
{
    public partial class SurveyImportClient
    {
        partial void PrepareSurveyImportStartSurveyImportJobArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref global::System.Guid? projectId,
            ref string? surveyUploadedFileURL,
            ref string? encryptedSymKey);
        partial void PrepareSurveyImportStartSurveyImportJobRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            global::System.Guid? projectId,
            string? surveyUploadedFileURL,
            string? encryptedSymKey);
        partial void ProcessSurveyImportStartSurveyImportJobResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessSurveyImportStartSurveyImportJobResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// StartSurveyImportJob.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="surveyUploadedFileURL"></param>
        /// <param name="encryptedSymKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> SurveyImportStartSurveyImportJobAsync(
            string? token = default,
            global::System.Guid? projectId = default,
            string? surveyUploadedFileURL = default,
            string? encryptedSymKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareSurveyImportStartSurveyImportJobArguments(
                httpClient: _httpClient,
                token: ref token,
                projectId: ref projectId,
                surveyUploadedFileURL: ref surveyUploadedFileURL,
                encryptedSymKey: ref encryptedSymKey);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/surveyimport/startsurveyimportjob",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("projectId", projectId?.ToString()) 
                .AddOptionalParameter("surveyUploadedFileURL", surveyUploadedFileURL) 
                .AddOptionalParameter("encryptedSymKey", encryptedSymKey) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareSurveyImportStartSurveyImportJobRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                projectId: projectId,
                surveyUploadedFileURL: surveyUploadedFileURL,
                encryptedSymKey: encryptedSymKey);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessSurveyImportStartSurveyImportJobResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessSurveyImportStartSurveyImportJobResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return __content;
        }
    }
}