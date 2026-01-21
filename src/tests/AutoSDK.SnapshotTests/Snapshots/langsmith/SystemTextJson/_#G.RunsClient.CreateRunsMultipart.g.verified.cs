//HintName: G.RunsClient.CreateRunsMultipart.g.cs

#nullable enable

namespace G
{
    public partial class RunsClient
    {
        partial void PrepareCreateRunsMultipartArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.Request3 request);
        partial void PrepareCreateRunsMultipartRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.Request3 request);
        partial void ProcessCreateRunsMultipartResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateRunsMultipartResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Ingest Runs (Multipart)<br/>
        /// Ingests multiple runs, feedback objects, and binary attachments in a single `multipart/form-data` request.  \<br/>
        /// **Part‑name pattern**: `&lt;event&gt;.&lt;run_id&gt;[.&lt;field&gt;]` where `event` ∈ {`post`, `patch`, `feedback`, `attachment`}.  \<br/>
        /// * `post|patch.&lt;run_id&gt;` – JSON run payload.  \<br/>
        /// * `post|patch.&lt;run_id&gt;.&lt;field&gt;` – out‑of‑band run data (`inputs`, `outputs`, `events`, `error`, `extra`, `serialized`).  \<br/>
        /// * `feedback.&lt;run_id&gt;` – JSON feedback payload (must include `trace_id`).  \<br/>
        /// * `attachment.&lt;run_id&gt;.&lt;filename&gt;` – arbitrary binary attachment stored in S3.  \<br/>
        /// **Headers**: every part must set `Content-Type` **and** either a `Content-Length` header or `length` parameter. Per‑part `Content-Encoding` is **not** allowed; the top‑level request may be `Content-Encoding: zstd`.  \<br/>
        /// **Best performance** for high‑volume ingestion.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<string, string>> CreateRunsMultipartAsync(
            global::G.Request3 request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateRunsMultipartArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/runs/multipart",
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
            if (request.Post_runId_ != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.ByteArrayContent(request.Post_runId_ ?? global::System.Array.Empty<byte>()),
                    name: "post.{run_id}",
                    fileName: request.Post_runId_name ?? string.Empty);
            } 
            if (request.Patch_runId_ != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.ByteArrayContent(request.Patch_runId_ ?? global::System.Array.Empty<byte>()),
                    name: "patch.{run_id}",
                    fileName: request.Patch_runId_name ?? string.Empty);
            } 
            if (request.Post_runId_Inputs != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.ByteArrayContent(request.Post_runId_Inputs ?? global::System.Array.Empty<byte>()),
                    name: "post.{run_id}.inputs",
                    fileName: request.Post_runId_Inputsname ?? string.Empty);
            } 
            if (request.Patch_runId_Outputs != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.ByteArrayContent(request.Patch_runId_Outputs ?? global::System.Array.Empty<byte>()),
                    name: "patch.{run_id}.outputs",
                    fileName: request.Patch_runId_Outputsname ?? string.Empty);
            } 
            if (request.Feedback_runId_ != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.ByteArrayContent(request.Feedback_runId_ ?? global::System.Array.Empty<byte>()),
                    name: "feedback.{run_id}",
                    fileName: request.Feedback_runId_name ?? string.Empty);
            } 
            if (request.Attachment_runId__filename_ != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.ByteArrayContent(request.Attachment_runId__filename_ ?? global::System.Array.Empty<byte>()),
                    name: "attachment.{run_id}.{filename}",
                    fileName: request.Attachment_runId__filename_name ?? string.Empty);
            }
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreateRunsMultipartRequest(
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
            ProcessCreateRunsMultipartResponse(
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
                        var __contentStream_400 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
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
                        var __contentStream_403 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
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
                        var __contentStream_409 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
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
                        var __contentStream_422 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
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
            // Too Many Requests
            if ((int)__response.StatusCode == 429)
            {
                string? __content_429 = null;
                global::System.Exception? __exception_429 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_429 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        var __contentStream_429 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_429 = __ex;
                }

                throw new global::G.ApiException(
                    message: __content_429 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_429,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_429,
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
                ProcessCreateRunsMultipartResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.Dictionary<string, string>?>(__content, JsonSerializerOptions) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
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

                    return
                        await global::System.Text.Json.JsonSerializer.DeserializeAsync<global::System.Collections.Generic.Dictionary<string, string>?>(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
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
        }

        /// <summary>
        /// Ingest Runs (Multipart)<br/>
        /// Ingests multiple runs, feedback objects, and binary attachments in a single `multipart/form-data` request.  \<br/>
        /// **Part‑name pattern**: `&lt;event&gt;.&lt;run_id&gt;[.&lt;field&gt;]` where `event` ∈ {`post`, `patch`, `feedback`, `attachment`}.  \<br/>
        /// * `post|patch.&lt;run_id&gt;` – JSON run payload.  \<br/>
        /// * `post|patch.&lt;run_id&gt;.&lt;field&gt;` – out‑of‑band run data (`inputs`, `outputs`, `events`, `error`, `extra`, `serialized`).  \<br/>
        /// * `feedback.&lt;run_id&gt;` – JSON feedback payload (must include `trace_id`).  \<br/>
        /// * `attachment.&lt;run_id&gt;.&lt;filename&gt;` – arbitrary binary attachment stored in S3.  \<br/>
        /// **Headers**: every part must set `Content-Type` **and** either a `Content-Length` header or `length` parameter. Per‑part `Content-Encoding` is **not** allowed; the top‑level request may be `Content-Encoding: zstd`.  \<br/>
        /// **Best performance** for high‑volume ingestion.
        /// </summary>
        /// <param name="post_runId_">
        /// Run to create (JSON)
        /// </param>
        /// <param name="post_runId_name">
        /// Run to create (JSON)
        /// </param>
        /// <param name="patch_runId_">
        /// Run to update (JSON)
        /// </param>
        /// <param name="patch_runId_name">
        /// Run to update (JSON)
        /// </param>
        /// <param name="post_runId_Inputs">
        /// Large inputs object (JSON) stored out‑of‑band
        /// </param>
        /// <param name="post_runId_Inputsname">
        /// Large inputs object (JSON) stored out‑of‑band
        /// </param>
        /// <param name="patch_runId_Outputs">
        /// Large outputs object (JSON) stored out‑of‑band
        /// </param>
        /// <param name="patch_runId_Outputsname">
        /// Large outputs object (JSON) stored out‑of‑band
        /// </param>
        /// <param name="feedback_runId_">
        /// Feedback object (JSON) – must include trace_id
        /// </param>
        /// <param name="feedback_runId_name">
        /// Feedback object (JSON) – must include trace_id
        /// </param>
        /// <param name="attachment_runId__filename_">
        /// Binary attachment linked to run {run_id}
        /// </param>
        /// <param name="attachment_runId__filename_name">
        /// Binary attachment linked to run {run_id}
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<string, string>> CreateRunsMultipartAsync(
            byte[]? post_runId_ = default,
            string? post_runId_name = default,
            byte[]? patch_runId_ = default,
            string? patch_runId_name = default,
            byte[]? post_runId_Inputs = default,
            string? post_runId_Inputsname = default,
            byte[]? patch_runId_Outputs = default,
            string? patch_runId_Outputsname = default,
            byte[]? feedback_runId_ = default,
            string? feedback_runId_name = default,
            byte[]? attachment_runId__filename_ = default,
            string? attachment_runId__filename_name = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.Request3
            {
                Post_runId_ = post_runId_,
                Post_runId_name = post_runId_name,
                Patch_runId_ = patch_runId_,
                Patch_runId_name = patch_runId_name,
                Post_runId_Inputs = post_runId_Inputs,
                Post_runId_Inputsname = post_runId_Inputsname,
                Patch_runId_Outputs = patch_runId_Outputs,
                Patch_runId_Outputsname = patch_runId_Outputsname,
                Feedback_runId_ = feedback_runId_,
                Feedback_runId_name = feedback_runId_name,
                Attachment_runId__filename_ = attachment_runId__filename_,
                Attachment_runId__filename_name = attachment_runId__filename_name,
            };

            return await CreateRunsMultipartAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}