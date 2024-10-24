﻿//HintName: G.TagClient.TagGetProjectTagsExportFileURLJobId.g.cs

#nullable enable

namespace G
{
    public partial class TagClient
    {
        partial void PrepareTagGetProjectTagsExportFileURLJobIdArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref global::System.Guid? projectId,
            ref string? fileExtension,
            ref bool? includeExcerpts,
            ref string? encryptedSymKey);
        partial void PrepareTagGetProjectTagsExportFileURLJobIdRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            global::System.Guid? projectId,
            string? fileExtension,
            bool? includeExcerpts,
            string? encryptedSymKey);
        partial void ProcessTagGetProjectTagsExportFileURLJobIdResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessTagGetProjectTagsExportFileURLJobIdResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// GetProjectTagsExportFileURLJobId.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="fileExtension"></param>
        /// <param name="includeExcerpts"></param>
        /// <param name="encryptedSymKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> TagGetProjectTagsExportFileURLJobIdAsync(
            string? token = default,
            global::System.Guid? projectId = default,
            string? fileExtension = default,
            bool? includeExcerpts = default,
            string? encryptedSymKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareTagGetProjectTagsExportFileURLJobIdArguments(
                httpClient: HttpClient,
                token: ref token,
                projectId: ref projectId,
                fileExtension: ref fileExtension,
                includeExcerpts: ref includeExcerpts,
                encryptedSymKey: ref encryptedSymKey);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/tag/getprojecttagsexportfileurljobid",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("projectId", projectId?.ToString()) 
                .AddOptionalParameter("fileExtension", fileExtension) 
                .AddOptionalParameter("includeExcerpts", includeExcerpts?.ToString()) 
                .AddOptionalParameter("encryptedSymKey", encryptedSymKey) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            if (token != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("token", token.ToString());
            }


            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareTagGetProjectTagsExportFileURLJobIdRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                token: token,
                projectId: projectId,
                fileExtension: fileExtension,
                includeExcerpts: includeExcerpts,
                encryptedSymKey: encryptedSymKey);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessTagGetProjectTagsExportFileURLJobIdResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessTagGetProjectTagsExportFileURLJobIdResponseContent(
                httpClient: HttpClient,
                httpResponseMessage: __response,
                content: ref __content);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::System.InvalidOperationException(__content, __ex);
            }

            return __content;
        }
    }
}