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
        /// <exception cref="global::G.ApiException"></exception>
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
                client: HttpClient);
            PrepareExportStartExcerptsExportArguments(
                httpClient: HttpClient,
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

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/export/startexcerptsexport",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("projectId", projectId?.ToString()) 
                .AddOptionalParameter("FileExtension", fileExtension) 
                .AddOptionalParameter("ExCopyMode", exCopyMode?.ToString()) 
                .AddOptionalParameter("SortMode", sortMode?.ToString()) 
                .AddOptionalParameter("ExRange", exRange?.ToString()) 
                .AddOptionalParameter("ExCreator", exCreator?.ToString()) 
                .AddOptionalParameter("ExDate", exDate?.ToString()) 
                .AddOptionalParameter("DesInfo", desInfo?.ToString()) 
                .AddOptionalParameter("DocTitle", docTitle?.ToString()) 
                .AddOptionalParameter("DocCreator", docCreator?.ToString()) 
                .AddOptionalParameter("DocDate", docDate?.ToString()) 
                .AddOptionalParameter("TagApplied", tagApplied?.ToString()) 
                .AddOptionalParameter("TagWeight", tagWeight?.ToString()) 
                .AddOptionalParameter("TagRange", tagRange?.ToString()) 
                .AddOptionalParameter("Memos", memos?.ToString()) 
                .AddOptionalParameter("symKeyEncrypted", symKeyEncrypted) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            if (token != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("token", token.ToString());
            }

            var __httpRequestContentBody = global::Newtonsoft.Json.JsonConvert.SerializeObject(request, JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareExportStartExcerptsExportRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
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

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessExportStartExcerptsExportResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Token is null.
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                string? __value_400 = null;
                if (ReadResponseAsString)
                {
                    __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_400 = global::Newtonsoft.Json.JsonConvert.DeserializeObject<string?>(__content_400, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_400 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_400 = global::Newtonsoft.Json.JsonSerializer.Create(JsonSerializerOptions).Deserialize<string?>(new global::Newtonsoft.Json.JsonTextReader(new global::System.IO.StreamReader(__contentStream_400)));
                }

                throw new global::G.ApiException<string>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_400,
                    ResponseObject = __value_400,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Token is invalid.
            if ((int)__response.StatusCode == 401)
            {
                string? __content_401 = null;
                string? __value_401 = null;
                if (ReadResponseAsString)
                {
                    __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_401 = global::Newtonsoft.Json.JsonConvert.DeserializeObject<string?>(__content_401, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_401 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_401 = global::Newtonsoft.Json.JsonSerializer.Create(JsonSerializerOptions).Deserialize<string?>(new global::Newtonsoft.Json.JsonTextReader(new global::System.IO.StreamReader(__contentStream_401)));
                }

                throw new global::G.ApiException<string>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_401,
                    ResponseObject = __value_401,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessExportStartExcerptsExportResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
                {
                    throw new global::G.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }

                return __content;
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
                {
                    throw new global::G.ApiException(
                        message: __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }

                var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

                return __content;
            }
        }
    }
}