//HintName: G.ExamplesClient.EditDatasetsByDatasetIdExamples.g.cs

#nullable enable

namespace G
{
    public partial class ExamplesClient
    {
        partial void PrepareEditDatasetsByDatasetIdExamplesArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.PatchDatasetsExamplesRequest request);
        partial void PrepareEditDatasetsByDatasetIdExamplesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.PatchDatasetsExamplesRequest request);
        partial void ProcessEditDatasetsByDatasetIdExamplesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Update Examples<br/>
        /// This endpoint allows clients to update existing examples in a specified dataset by sending a multipart/form-data PATCH request.<br/>
        /// Each form part contains either JSON-encoded data or binary attachment files to update an example.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task EditDatasetsByDatasetIdExamplesAsync(

            global::G.PatchDatasetsExamplesRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareEditDatasetsByDatasetIdExamplesArguments(
                httpClient: HttpClient,
                request: request);

            using var __timeoutCancellationTokenSource = global::G.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::G.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::G.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {
                            var __pathBuilder = new global::G.PathBuilder(
                                path: "/datasets/{dataset_id}/examples",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::G.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: new global::System.Net.Http.HttpMethod("PATCH"),
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif
                            var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
                            var __contentx_exampleId_ = new global::System.Net.Http.ByteArrayContent(request.x_exampleId_ ?? global::System.Array.Empty<byte>());
                            __httpRequestContent.Add(
                                content: __contentx_exampleId_,
                                name: "\"{example_id}\"",
                                fileName: request.x_exampleId_name != null ? $"\"{request.x_exampleId_name}\"" : string.Empty);
                            if (__contentx_exampleId_.Headers.ContentDisposition != null)
                            {
                                __contentx_exampleId_.Headers.ContentDisposition.FileNameStar = null;
                            }
                            if (request.x_exampleId_Inputs != default)
                            {

                                var __contentx_exampleId_Inputs = new global::System.Net.Http.ByteArrayContent(request.x_exampleId_Inputs ?? global::System.Array.Empty<byte>());
                                __httpRequestContent.Add(
                                    content: __contentx_exampleId_Inputs,
                                    name: "\"{example_id}.inputs\"",
                                    fileName: request.x_exampleId_Inputsname != null ? $"\"{request.x_exampleId_Inputsname}\"" : string.Empty);
                                if (__contentx_exampleId_Inputs.Headers.ContentDisposition != null)
                                {
                                    __contentx_exampleId_Inputs.Headers.ContentDisposition.FileNameStar = null;
                                }
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
                            if (request.x_exampleId_AttachmentsOperations != default)
                            {

                                var __contentx_exampleId_AttachmentsOperations = new global::System.Net.Http.ByteArrayContent(request.x_exampleId_AttachmentsOperations ?? global::System.Array.Empty<byte>());
                                __httpRequestContent.Add(
                                    content: __contentx_exampleId_AttachmentsOperations,
                                    name: "\"{example_id}.attachments_operations\"",
                                    fileName: request.x_exampleId_AttachmentsOperationsname != null ? $"\"{request.x_exampleId_AttachmentsOperationsname}\"" : string.Empty);
                                if (__contentx_exampleId_AttachmentsOperations.Headers.ContentDisposition != null)
                                {
                                    __contentx_exampleId_AttachmentsOperations.Headers.ContentDisposition.FileNameStar = null;
                                }
                            } 
                            if (request.x_exampleId_Attachment_name_ != default)
                            {

                                var __contentx_exampleId_Attachment_name_ = new global::System.Net.Http.ByteArrayContent(request.x_exampleId_Attachment_name_ ?? global::System.Array.Empty<byte>());
                                __httpRequestContent.Add(
                                    content: __contentx_exampleId_Attachment_name_,
                                    name: "\"{example_id}.attachment.{name}\"",
                                    fileName: request.x_exampleId_Attachment_name_name != null ? $"\"{request.x_exampleId_Attachment_name_name}\"" : string.Empty);
                                if (__contentx_exampleId_Attachment_name_.Headers.ContentDisposition != null)
                                {
                                    __contentx_exampleId_Attachment_name_.Headers.ContentDisposition.FileNameStar = null;
                                }
                            }
                            __httpRequest.Content = __httpRequestContent;
                global::G.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareEditDatasetsByDatasetIdExamplesRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::G.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::G.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "editDatasetsByDatasetIdExamples",
                                methodName: "EditDatasetsByDatasetIdExamplesAsync",
                                pathTemplate: "\"/datasets/{dataset_id}/examples\"",
                                httpMethod: "PATCH",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::G.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::G.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "editDatasetsByDatasetIdExamples",
                                methodName: "EditDatasetsByDatasetIdExamplesAsync",
                                pathTemplate: "\"/datasets/{dataset_id}/examples\"",
                                httpMethod: "PATCH",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::G.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::G.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        await global::G.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::G.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "editDatasetsByDatasetIdExamples",
                                methodName: "EditDatasetsByDatasetIdExamplesAsync",
                                pathTemplate: "\"/datasets/{dataset_id}/examples\"",
                                httpMethod: "PATCH",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::G.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessEditDatasetsByDatasetIdExamplesResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::G.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::G.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "editDatasetsByDatasetIdExamples",
                                methodName: "EditDatasetsByDatasetIdExamplesAsync",
                                pathTemplate: "\"/datasets/{dataset_id}/examples\"",
                                httpMethod: "PATCH",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::G.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::G.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "editDatasetsByDatasetIdExamples",
                                methodName: "EditDatasetsByDatasetIdExamplesAsync",
                                pathTemplate: "\"/datasets/{dataset_id}/examples\"",
                                httpMethod: "PATCH",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // Bad Request
                            if ((int)__response.StatusCode == 400)
                            {
                                string? __content_400 = null;
                                global::System.Exception? __exception_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
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
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                    else
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
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
                            // Not Found
                            if ((int)__response.StatusCode == 404)
                            {
                                string? __content_404 = null;
                                global::System.Exception? __exception_404 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                    else
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_404 = __ex;
                                }

                                throw new global::G.ApiException(
                                    message: __content_404 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_404,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_404,
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
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_409 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                    else
                                    {
                                        __content_409 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
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
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                    else
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
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

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
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
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
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
            }
            finally
            {
                __httpRequest?.Dispose();
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
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
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.PatchDatasetsExamplesRequest
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
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}