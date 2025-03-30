//HintName: G.ExamplesClient.EditDatasetsByDatasetIdExamples.g.cs

#nullable enable

namespace G
{
    public partial class ExamplesClient
    {
        partial void PrepareEditDatasetsByDatasetIdExamplesArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.Request2 request);
        partial void PrepareEditDatasetsByDatasetIdExamplesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.Request2 request);
        partial void ProcessEditDatasetsByDatasetIdExamplesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Update Examples<br/>
        /// This endpoint allows clients to update existing examples in a specified dataset by sending a multipart/form-data PATCH request.<br/>
        /// Each form part contains either JSON-encoded data or binary attachment files to update an example.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task EditDatasetsByDatasetIdExamplesAsync(
            global::G.Request2 request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareEditDatasetsByDatasetIdExamplesArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/datasets/{dataset_id}/examples",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif
            using var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
            __httpRequestContent.Add(
                content: new global::System.Net.Http.ByteArrayContent(request.x_exampleId_ ?? global::System.Array.Empty<byte>()),
                name: "{example_id}",
                fileName: request.x_exampleId_name ?? string.Empty);
            if (request.x_exampleId_Inputs != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.ByteArrayContent(request.x_exampleId_Inputs ?? global::System.Array.Empty<byte>()),
                    name: "{example_id}.inputs",
                    fileName: request.x_exampleId_Inputsname ?? string.Empty);
            } 
            if (request.x_exampleId_Outputs != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.ByteArrayContent(request.x_exampleId_Outputs ?? global::System.Array.Empty<byte>()),
                    name: "{example_id}.outputs",
                    fileName: request.x_exampleId_Outputsname ?? string.Empty);
            } 
            if (request.x_exampleId_AttachmentsOperations != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.ByteArrayContent(request.x_exampleId_AttachmentsOperations ?? global::System.Array.Empty<byte>()),
                    name: "{example_id}.attachments_operations",
                    fileName: request.x_exampleId_AttachmentsOperationsname ?? string.Empty);
            } 
            if (request.x_exampleId_Attachment_name_ != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.ByteArrayContent(request.x_exampleId_Attachment_name_ ?? global::System.Array.Empty<byte>()),
                    name: "{example_id}.attachment.{name}",
                    fileName: request.x_exampleId_Attachment_name_name ?? string.Empty);
            }
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareEditDatasetsByDatasetIdExamplesRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessEditDatasetsByDatasetIdExamplesResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
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
        }

        /// <summary>
        /// Update Examples<br/>
        /// This endpoint allows clients to update existing examples in a specified dataset by sending a multipart/form-data PATCH request.<br/>
        /// Each form part contains either JSON-encoded data or binary attachment files to update an example.
        /// </summary>
        /// <param name="x_exampleId_">
        /// The Example update info as JSON. Can have fields 'metadata', 'split'
        /// </param>
        /// <param name="x_exampleId_name">
        /// The Example update info as JSON. Can have fields 'metadata', 'split'
        /// </param>
        /// <param name="x_exampleId_Inputs">
        /// The updated Example inputs as JSON
        /// </param>
        /// <param name="x_exampleId_Inputsname">
        /// The updated Example inputs as JSON
        /// </param>
        /// <param name="x_exampleId_Outputs">
        /// The updated Example outputs as JSON
        /// </param>
        /// <param name="x_exampleId_Outputsname">
        /// The updated Example outputs as JSON
        /// </param>
        /// <param name="x_exampleId_AttachmentsOperations">
        /// JSON describing attachment operations (retain, rename)
        /// </param>
        /// <param name="x_exampleId_AttachmentsOperationsname">
        /// JSON describing attachment operations (retain, rename)
        /// </param>
        /// <param name="x_exampleId_Attachment_name_">
        /// New file attachment named {name}
        /// </param>
        /// <param name="x_exampleId_Attachment_name_name">
        /// New file attachment named {name}
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task EditDatasetsByDatasetIdExamplesAsync(
            byte[] x_exampleId_,
            string x_exampleId_name,
            byte[]? x_exampleId_Inputs = default,
            string? x_exampleId_Inputsname = default,
            byte[]? x_exampleId_Outputs = default,
            string? x_exampleId_Outputsname = default,
            byte[]? x_exampleId_AttachmentsOperations = default,
            string? x_exampleId_AttachmentsOperationsname = default,
            byte[]? x_exampleId_Attachment_name_ = default,
            string? x_exampleId_Attachment_name_name = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.Request2
            {
                x_exampleId_ = x_exampleId_,
                x_exampleId_name = x_exampleId_name,
                x_exampleId_Inputs = x_exampleId_Inputs,
                x_exampleId_Inputsname = x_exampleId_Inputsname,
                x_exampleId_Outputs = x_exampleId_Outputs,
                x_exampleId_Outputsname = x_exampleId_Outputsname,
                x_exampleId_AttachmentsOperations = x_exampleId_AttachmentsOperations,
                x_exampleId_AttachmentsOperationsname = x_exampleId_AttachmentsOperationsname,
                x_exampleId_Attachment_name_ = x_exampleId_Attachment_name_,
                x_exampleId_Attachment_name_name = x_exampleId_Attachment_name_name,
            };

            await EditDatasetsByDatasetIdExamplesAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}