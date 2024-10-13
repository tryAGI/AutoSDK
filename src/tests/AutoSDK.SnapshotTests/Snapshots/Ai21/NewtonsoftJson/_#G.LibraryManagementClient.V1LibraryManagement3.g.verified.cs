//HintName: G.LibraryManagementClient.V1LibraryManagement3.g.cs

#nullable enable

namespace G
{
    public partial class LibraryManagementClient
    {
        partial void PrepareV1LibraryManagement3Arguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid fileId,
            global::G.FilesUpdateRequest request);
        partial void PrepareV1LibraryManagement3Request(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid fileId,
            global::G.FilesUpdateRequest request);
        partial void ProcessV1LibraryManagement3Response(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessV1LibraryManagement3ResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update File<br/>
        /// Update the specified parameters of a specific document in the user's library.<br/>
        /// This operation currently supports updating the publicUrl and labels parameters.<br/>
        /// &gt; **This operation overwrites the specified items with the new data you provide.**<br/>
        /// &gt; If you wish to add new labels to the labels list without removing the existing ones,<br/>
        /// &gt; you must submit a labels list that includes both the current and new labels.**<br/>
        /// &gt;<br/>
        /// &gt; For instance, if the current labels are "Label A" and "Label B", and you wish to<br/>
        /// &gt; add "New Label C" and "New Label D" to the list, you must specify `"labels": ["Label A", "Label B", "New Label C", "New Label D"]`.
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> V1LibraryManagement3Async(
            global::System.Guid fileId,
            global::G.FilesUpdateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareV1LibraryManagement3Arguments(
                httpClient: _httpClient,
                fileId: ref fileId,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/studio/v1/library/files/{fileId}",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var _authorization in _authorizations)
            {
                if (_authorization.Type == "Http" ||
                    _authorization.Type == "OAuth2")
                {
                    httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: _authorization.Name,
                        parameter: _authorization.Value);
                }
                else if (_authorization.Type == "ApiKey" &&
                         _authorization.Location == "Header")
                {
                    httpRequest.Headers.Add(_authorization.Name, _authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareV1LibraryManagement3Request(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                fileId: fileId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessV1LibraryManagement3Response(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessV1LibraryManagement3ResponseContent(
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

        /// <summary>
        /// Update File<br/>
        /// Update the specified parameters of a specific document in the user's library.<br/>
        /// This operation currently supports updating the publicUrl and labels parameters.<br/>
        /// &gt; **This operation overwrites the specified items with the new data you provide.**<br/>
        /// &gt; If you wish to add new labels to the labels list without removing the existing ones,<br/>
        /// &gt; you must submit a labels list that includes both the current and new labels.**<br/>
        /// &gt;<br/>
        /// &gt; For instance, if the current labels are "Label A" and "Label B", and you wish to<br/>
        /// &gt; add "New Label C" and "New Label D" to the list, you must specify `"labels": ["Label A", "Label B", "New Label C", "New Label D"]`.
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="publicUrl">
        /// The public URL of the file, if any. This URL is not validated by<br/>
        /// AI21 or used in any way. It is strictly a piece of metadata that you can<br/>
        /// optionally attach to a file.
        /// </param>
        /// <param name="labels">
        /// Any labels to associate with this file. Separate multiple labels with commas. If<br/>
        /// provided, will overwrite all existing labels.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> V1LibraryManagement3Async(
            global::System.Guid fileId,
            string? publicUrl = default,
            global::System.Collections.Generic.IList<string>? labels = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.FilesUpdateRequest
            {
                PublicUrl = publicUrl,
                Labels = labels,
            };

            return await V1LibraryManagement3Async(
                fileId: fileId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}