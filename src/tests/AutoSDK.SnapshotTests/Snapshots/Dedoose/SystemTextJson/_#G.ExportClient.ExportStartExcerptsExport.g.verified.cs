//HintName: G.ExportClient.ExportStartExcerptsExport.g.cs

#nullable enable

namespace G
{
    public partial class ExportClient
    {
        partial void PrepareExportStartExcerptsExportArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref global::System.Guid? projectId,
            ref string? fileExtension,
            ref int? exCopyMode,
            ref int? sortMode,
            ref bool? exRange,
            ref bool? exCreator,
            ref bool? exDate,
            ref bool? desInfo,
            ref bool? docTitle,
            ref bool? docCreator,
            ref bool? docDate,
            ref bool? tagApplied,
            ref bool? tagWeight,
            ref bool? tagRange,
            ref bool? memos,
            ref string? symKeyEncrypted,
            global::System.Collections.Generic.IList<global::System.Guid> request);
        partial void PrepareExportStartExcerptsExportRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            global::System.Guid? projectId,
            string? fileExtension,
            int? exCopyMode,
            int? sortMode,
            bool? exRange,
            bool? exCreator,
            bool? exDate,
            bool? desInfo,
            bool? docTitle,
            bool? docCreator,
            bool? docDate,
            bool? tagApplied,
            bool? tagWeight,
            bool? tagRange,
            bool? memos,
            string? symKeyEncrypted,
            global::System.Collections.Generic.IList<global::System.Guid> request);
        partial void ProcessExportStartExcerptsExportResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessExportStartExcerptsExportResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// StartExcerptsExport.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="fileExtension"></param>
        /// <param name="exCopyMode"></param>
        /// <param name="sortMode"></param>
        /// <param name="exRange"></param>
        /// <param name="exCreator"></param>
        /// <param name="exDate"></param>
        /// <param name="desInfo"></param>
        /// <param name="docTitle"></param>
        /// <param name="docCreator"></param>
        /// <param name="docDate"></param>
        /// <param name="tagApplied"></param>
        /// <param name="tagWeight"></param>
        /// <param name="tagRange"></param>
        /// <param name="memos"></param>
        /// <param name="symKeyEncrypted"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> ExportStartExcerptsExportAsync(
            global::System.Collections.Generic.IList<global::System.Guid> request,
            string? token = default,
            global::System.Guid? projectId = default,
            string? fileExtension = default,
            int? exCopyMode = default,
            int? sortMode = default,
            bool? exRange = default,
            bool? exCreator = default,
            bool? exDate = default,
            bool? desInfo = default,
            bool? docTitle = default,
            bool? docCreator = default,
            bool? docDate = default,
            bool? tagApplied = default,
            bool? tagWeight = default,
            bool? tagRange = default,
            bool? memos = default,
            string? symKeyEncrypted = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareExportStartExcerptsExportArguments(
                httpClient: _httpClient,
                token: ref token,
                projectId: ref projectId,
                fileExtension: ref fileExtension,
                exCopyMode: ref exCopyMode,
                sortMode: ref sortMode,
                exRange: ref exRange,
                exCreator: ref exCreator,
                exDate: ref exDate,
                desInfo: ref desInfo,
                docTitle: ref docTitle,
                docCreator: ref docCreator,
                docDate: ref docDate,
                tagApplied: ref tagApplied,
                tagWeight: ref tagWeight,
                tagRange: ref tagRange,
                memos: ref memos,
                symKeyEncrypted: ref symKeyEncrypted,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/export/startexcerptsexport?projectId={projectId}&FileExtension={fileExtension}&ExCopyMode={exCopyMode}&SortMode={sortMode}&ExRange={exRange}&ExCreator={exCreator}&ExDate={exDate}&DesInfo={desInfo}&DocTitle={docTitle}&DocCreator={docCreator}&DocDate={docDate}&TagApplied={tagApplied}&TagWeight={tagWeight}&TagRange={tagRange}&Memos={memos}&symKeyEncrypted={symKeyEncrypted}", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareExportStartExcerptsExportRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                projectId: projectId,
                fileExtension: fileExtension,
                exCopyMode: exCopyMode,
                sortMode: sortMode,
                exRange: exRange,
                exCreator: exCreator,
                exDate: exDate,
                desInfo: desInfo,
                docTitle: docTitle,
                docCreator: docCreator,
                docDate: docDate,
                tagApplied: tagApplied,
                tagWeight: tagWeight,
                tagRange: tagRange,
                memos: memos,
                symKeyEncrypted: symKeyEncrypted,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessExportStartExcerptsExportResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessExportStartExcerptsExportResponseContent(
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