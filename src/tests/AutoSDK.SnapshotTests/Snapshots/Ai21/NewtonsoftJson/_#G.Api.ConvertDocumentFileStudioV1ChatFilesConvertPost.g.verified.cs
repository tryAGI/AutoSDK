//HintName: G.Api.ConvertDocumentFileStudioV1ChatFilesConvertPost.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        partial void PrepareConvertDocumentFileStudioV1ChatFilesConvertPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? requestStartTime,
            global::G.BodyConvertDocumentFileStudioV1ChatFilesConvertPost request);
        partial void PrepareConvertDocumentFileStudioV1ChatFilesConvertPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? requestStartTime,
            global::G.BodyConvertDocumentFileStudioV1ChatFilesConvertPost request);
        partial void ProcessConvertDocumentFileStudioV1ChatFilesConvertPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessConvertDocumentFileStudioV1ChatFilesConvertPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Convert Document File
        /// </summary>
        /// <param name="requestStartTime">
        /// Default Value: 1730898830008
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> ConvertDocumentFileStudioV1ChatFilesConvertPostAsync(
            global::G.BodyConvertDocumentFileStudioV1ChatFilesConvertPost request,
            int? requestStartTime = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareConvertDocumentFileStudioV1ChatFilesConvertPostArguments(
                httpClient: HttpClient,
                requestStartTime: ref requestStartTime,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/studio/v1/chat/files/convert",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("request_start_time", requestStartTime?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
            using var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
            if (requestStartTime != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{requestStartTime}"),
                    name: "request_start_time");
            } 
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent($"[{string.Join(",", global::System.Linq.Enumerable.Select(request.Files, x => x))}]"),
                name: "files");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareConvertDocumentFileStudioV1ChatFilesConvertPostRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                requestStartTime: requestStartTime,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessConvertDocumentFileStudioV1ChatFilesConvertPostResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessConvertDocumentFileStudioV1ChatFilesConvertPostResponseContent(
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

        /// <summary>
        /// Convert Document File
        /// </summary>
        /// <param name="requestStartTime">
        /// Default Value: 1730898830008
        /// </param>
        /// <param name="files"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> ConvertDocumentFileStudioV1ChatFilesConvertPostAsync(
            global::System.Collections.Generic.IList<byte[]> files,
            int? requestStartTime = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.BodyConvertDocumentFileStudioV1ChatFilesConvertPost
            {
                Files = files,
            };

            return await ConvertDocumentFileStudioV1ChatFilesConvertPostAsync(
                requestStartTime: requestStartTime,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}