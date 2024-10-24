﻿//HintName: G.TagClient.TagStartGetTagsFromImportJob.g.cs

#nullable enable

namespace G
{
    public partial class TagClient
    {
        partial void PrepareTagStartGetTagsFromImportJobArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref string? fileURL);
        partial void PrepareTagStartGetTagsFromImportJobRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            string? fileURL);
        partial void ProcessTagStartGetTagsFromImportJobResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessTagStartGetTagsFromImportJobResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// StartGetTagsFromImportJob.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="fileURL"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> TagStartGetTagsFromImportJobAsync(
            string? token = default,
            string? fileURL = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareTagStartGetTagsFromImportJobArguments(
                httpClient: HttpClient,
                token: ref token,
                fileURL: ref fileURL);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/tag/startgettagsfromimportjob",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("fileURL", fileURL) 
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
            PrepareTagStartGetTagsFromImportJobRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                token: token,
                fileURL: fileURL);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessTagStartGetTagsFromImportJobResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessTagStartGetTagsFromImportJobResponseContent(
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