﻿//HintName: G.ExcerptClient.ExcerptAddDocumentExcerptWithTags.g.cs

#nullable enable

namespace G
{
    public partial class ExcerptClient
    {
        partial void PrepareExcerptAddDocumentExcerptWithTagsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref global::System.Guid? projectId,
            ref global::System.Guid? userId,
            ref global::System.Guid? resourceId,
            ref string? title,
            ref string? description,
            ref int? startIndex,
            ref int? endIndex,
            ref string? excerptText,
            global::System.Collections.Generic.IList<global::G.TagAppSimple>? tagApps);
        partial void PrepareExcerptAddDocumentExcerptWithTagsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            global::System.Guid? projectId,
            global::System.Guid? userId,
            global::System.Guid? resourceId,
            string? title,
            string? description,
            int? startIndex,
            int? endIndex,
            string? excerptText,
            global::System.Collections.Generic.IList<global::G.TagAppSimple>? tagApps);
        partial void ProcessExcerptAddDocumentExcerptWithTagsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessExcerptAddDocumentExcerptWithTagsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// AddDocumentExcerptWithTags.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="resourceId"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="startIndex"></param>
        /// <param name="endIndex"></param>
        /// <param name="excerptText"></param>
        /// <param name="tagApps"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ExcerptWithTagApps> ExcerptAddDocumentExcerptWithTagsAsync(
            string? token = default,
            global::System.Guid? projectId = default,
            global::System.Guid? userId = default,
            global::System.Guid? resourceId = default,
            string? title = default,
            string? description = default,
            int? startIndex = default,
            int? endIndex = default,
            string? excerptText = default,
            global::System.Collections.Generic.IList<global::G.TagAppSimple>? tagApps = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareExcerptAddDocumentExcerptWithTagsArguments(
                httpClient: HttpClient,
                token: ref token,
                projectId: ref projectId,
                userId: ref userId,
                resourceId: ref resourceId,
                title: ref title,
                description: ref description,
                startIndex: ref startIndex,
                endIndex: ref endIndex,
                excerptText: ref excerptText,
                tagApps: tagApps);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/excerpt/adddocumentexcerptwithtags",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("projectId", projectId?.ToString()) 
                .AddOptionalParameter("userId", userId?.ToString()) 
                .AddOptionalParameter("resourceId", resourceId?.ToString()) 
                .AddOptionalParameter("title", title) 
                .AddOptionalParameter("description", description) 
                .AddOptionalParameter("startIndex", startIndex?.ToString()) 
                .AddOptionalParameter("endIndex", endIndex?.ToString()) 
                .AddOptionalParameter("excerptText", excerptText) 
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
            PrepareExcerptAddDocumentExcerptWithTagsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                token: token,
                projectId: projectId,
                userId: userId,
                resourceId: resourceId,
                title: title,
                description: description,
                startIndex: startIndex,
                endIndex: endIndex,
                excerptText: excerptText,
                tagApps: tagApps);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessExcerptAddDocumentExcerptWithTagsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessExcerptAddDocumentExcerptWithTagsResponseContent(
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

            return
                global::G.ExcerptWithTagApps.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}