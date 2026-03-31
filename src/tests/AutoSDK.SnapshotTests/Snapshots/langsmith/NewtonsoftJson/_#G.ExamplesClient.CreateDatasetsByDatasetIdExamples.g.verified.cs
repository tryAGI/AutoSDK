//HintName: G.ExamplesClient.CreateDatasetsByDatasetIdExamples.g.cs

#nullable enable

namespace G
{
    public partial class ExamplesClient
    {
        partial void PrepareCreateDatasetsByDatasetIdExamplesArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.CreateDatasetsExamplesRequest request);
        partial void PrepareCreateDatasetsByDatasetIdExamplesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.CreateDatasetsExamplesRequest request);
        partial void ProcessCreateDatasetsByDatasetIdExamplesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Upload Examples<br/>
        /// This endpoint allows clients to upload examples to a specified dataset by sending a multipart/form-data POST request.<br/>
        /// Each form part contains either JSON-encoded data or binary attachment files associated with an example.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task CreateDatasetsByDatasetIdExamplesAsync(

            global::G.CreateDatasetsExamplesRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateDatasetsByDatasetIdExamplesArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/datasets/{dataset_id}/examples",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif
            using var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
            var __contentx_exampleId_ = new global::System.Net.Http.ByteArrayContent(request.x_exampleId_ ?? global::System.Array.Empty<byte>());
            __httpRequestContent.Add(
                content: __contentx_exampleId_,
                name: "\"{example_id}\"",
                fileName: request.x_exampleId_name != null ? $"\"{request.x_exampleId_name}\"" : string.Empty);
            if (__contentx_exampleId_.Headers.ContentDisposition != null)
            {
                __contentx_exampleId_.Headers.ContentDisposition.FileNameStar = null;
            }
            var __contentx_exampleId_Inputs = new global::System.Net.Http.ByteArrayContent(request.x_exampleId_Inputs ?? global::System.Array.Empty<byte>());
            __httpRequestContent.Add(
                content: __contentx_exampleId_Inputs,
                name: "\"{example_id}.inputs\"",
                fileName: request.x_exampleId_Inputsname != null ? $"\"{request.x_exampleId_Inputsname}\"" : string.Empty);
            if (__contentx_exampleId_Inputs.Headers.ContentDisposition != null)
            {
                __contentx_exampleId_Inputs.Headers.ContentDisposition.FileNameStar = null;
            }
            if (request.x_exampleId_Outputs != default)
            {

                var __contentx_exampleId_Outputs = new global::System.Net.Http.ByteArrayContent(request.x_exampleId_Outputs ?? global::System.Array.Empty<byte>());
                __httpRequestContent.Add(
                    content: __contentx_exampleId_Outputs,
                    name: "\"{example_id}.outputs\"",
                    fileName: request.x_exampleId_Outputsname != null ? $"\"{request.x_exampleId_Outputsname}\"" : string.Empty);
                if (__contentx_exampleId_Outputs.Headers.ContentDisposition != null)
                {
                    __contentx_exampleId_Outputs.Headers.ContentDisposition.FileNameStar = null;
                }
            } 
            if (request.x_exampleId_Attachments_name_ != default)
            {

                var __contentx_exampleId_Attachments_name_ = new global::System.Net.Http.ByteArrayContent(request.x_exampleId_Attachments_name_ ?? global::System.Array.Empty<byte>());
                __httpRequestContent.Add(
                    content: __contentx_exampleId_Attachments_name_,
                    name: "\"{example_id}.attachments.{name}\"",
                    fileName: request.x_exampleId_Attachments_name_name != null ? $"\"{request.x_exampleId_Attachments_name_name}\"" : string.Empty);
                if (__contentx_exampleId_Attachments_name_.Headers.ContentDisposition != null)
                {
                    __contentx_exampleId_Attachments_name_.Headers.ContentDisposition.FileNameStar = null;
                }
            }
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreateDatasetsByDatasetIdExamplesRequest(
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
            ProcessCreateDatasetsByDatasetIdExamplesResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Bad Request
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::G.ApiException(
                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_400,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_400,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Forbidden
            if ((int)__response.StatusCode == 403)
            {
                string? __content_403 = null;
                global::System.Exception? __exception_403 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_403 = __ex;
                }

                throw new global::G.ApiException(
                    message: __content_403 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_403,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_403,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Conflict
            if ((int)__response.StatusCode == 409)
            {
                string? __content_409 = null;
                global::System.Exception? __exception_409 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_409 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_409 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_409 = __ex;
                }

                throw new global::G.ApiException(
                    message: __content_409 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_409,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_409,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Unprocessable Entity
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::System.Exception? __exception_422 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_422 = __ex;
                }

                throw new global::G.ApiException(
                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_422,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_422,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                }
                catch (global::System.Exception __ex)
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
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();

                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

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
            }
        }
        /// <summary>
        /// Upload Examples<br/>
        /// This endpoint allows clients to upload examples to a specified dataset by sending a multipart/form-data POST request.<br/>
        /// Each form part contains either JSON-encoded data or binary attachment files associated with an example.
        /// </summary>
        /// <param name="x_exampleId_">
        /// The Example info as JSON. Can have fields 'metadata', 'split', 'use_source_run_io', 'source_run_id', 'created_at', 'modified_at'
        /// </param>
        /// <param name="x_exampleId_name">
        /// The Example info as JSON. Can have fields 'metadata', 'split', 'use_source_run_io', 'source_run_id', 'created_at', 'modified_at'
        /// </param>
        /// <param name="x_exampleId_Inputs">
        /// The Example inputs as JSON
        /// </param>
        /// <param name="x_exampleId_Inputsname">
        /// The Example inputs as JSON
        /// </param>
        /// <param name="x_exampleId_Outputs">
        /// THe Example outputs as JSON
        /// </param>
        /// <param name="x_exampleId_Outputsname">
        /// THe Example outputs as JSON
        /// </param>
        /// <param name="x_exampleId_Attachments_name_">
        /// File attachment named {name}
        /// </param>
        /// <param name="x_exampleId_Attachments_name_name">
        /// File attachment named {name}
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task CreateDatasetsByDatasetIdExamplesAsync(
            byte[] x_exampleId_,
            string x_exampleId_name,
            byte[] x_exampleId_Inputs,
            string x_exampleId_Inputsname,
            byte[]? x_exampleId_Outputs = default,
            string? x_exampleId_Outputsname = default,
            byte[]? x_exampleId_Attachments_name_ = default,
            string? x_exampleId_Attachments_name_name = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            var __request = new global::G.CreateDatasetsExamplesRequest
            {
                x_exampleId_ = x_exampleId_,
                x_exampleId_name = x_exampleId_name,
                x_exampleId_Inputs = x_exampleId_Inputs,
                x_exampleId_Inputsname = x_exampleId_Inputsname,
                x_exampleId_Outputs = x_exampleId_Outputs,
                x_exampleId_Outputsname = x_exampleId_Outputsname,
                x_exampleId_Attachments_name_ = x_exampleId_Attachments_name_,
                x_exampleId_Attachments_name_name = x_exampleId_Attachments_name_name,
            };

            await CreateDatasetsByDatasetIdExamplesAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}