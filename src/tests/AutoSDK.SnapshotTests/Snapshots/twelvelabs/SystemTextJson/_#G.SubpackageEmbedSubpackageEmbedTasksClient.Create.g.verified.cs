//HintName: G.SubpackageEmbedSubpackageEmbedTasksClient.Create.g.cs

#nullable enable

namespace G
{
    public partial class SubpackageEmbedSubpackageEmbedTasksClient
    {
        partial void PrepareCreateArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string xApiKey,
            global::G.CreateRequest8 request);
        partial void PrepareCreateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string xApiKey,
            global::G.CreateRequest8 request);
        partial void ProcessCreateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a video embedding task<br/>
        /// &lt;Note title="Note"&gt;<br/>
        ///   This endpoint will be deprecated in a future version. Migrate to the [Embed API v2](/v1.3/api-reference/create-embeddings-v2) for continued support and access to new features.<br/>
        /// &lt;/Note&gt;<br/>
        /// This method creates a new video embedding task that uploads a video to the platform and creates one or multiple video embeddings.<br/>
        /// &lt;Note title="Note"&gt;<br/>
        /// This endpoint is rate-limited. For details, see the [Rate limits](/v1.3/docs/get-started/rate-limits) page.<br/>
        /// &lt;/Note&gt;<br/>
        /// Upload options:<br/>
        /// - **Local file**: Use the `video_file` parameter<br/>
        /// - **Publicly accessible URL**: Use the `video_url` parameter.<br/>
        /// Specify at least one option. If both are provided, `video_url` takes precedence.<br/>
        /// Your video files must meet the [requirements](/v1.3/docs/concepts/models/marengo#video-file-requirements).<br/>
        /// This endpoint allows you to upload files up to 2 GB in size.  To upload larger files, use the [Multipart Upload API](/v1.3/api-reference/upload-content/multipart-uploads)<br/>
        /// &lt;Note title="Notes"&gt;<br/>
        /// - The Marengo video understanding model generates embeddings for all modalities in the same latent space. This shared space enables any-to-any searches across different types of content.<br/>
        /// - Video embeddings are stored for seven days.<br/>
        /// &lt;/Note&gt;
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.EmbedTasksCreateResponse200> CreateAsync(
            string xApiKey,

            global::G.CreateRequest8 request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateArguments(
                httpClient: HttpClient,
                xApiKey: ref xApiKey,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/embed/tasks",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            __httpRequest.Headers.TryAddWithoutValidation("x-api-key", xApiKey.ToString());

            using var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent($"{xApiKey}"),
                name: "\"x-api-key\"");
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent($"{request.ModelName}"),
                name: "\"model_name\"");
            if (request.VideoFile != default)
            {

                var __contentVideoFile = new global::System.Net.Http.ByteArrayContent(request.VideoFile ?? global::System.Array.Empty<byte>());
                __httpRequestContent.Add(
                    content: __contentVideoFile,
                    name: "\"video_file\"",
                    fileName: request.VideoFilename != null ? $"\"{request.VideoFilename}\"" : string.Empty);
                if (__contentVideoFile.Headers.ContentDisposition != null)
                {
                    __contentVideoFile.Headers.ContentDisposition.FileNameStar = null;
                }
            } 
            if (request.VideoUrl != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.VideoUrl}"),
                    name: "\"video_url\"");
            } 
            if (request.VideoStartOffsetSec != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.VideoStartOffsetSec}"),
                    name: "\"video_start_offset_sec\"");
            } 
            if (request.VideoEndOffsetSec != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.VideoEndOffsetSec}"),
                    name: "\"video_end_offset_sec\"");
            } 
            if (request.VideoClipLength != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.VideoClipLength}"),
                    name: "\"video_clip_length\"");
            } 
            if (request.VideoEmbeddingScope != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"[{string.Join(",", global::System.Linq.Enumerable.Select(request.VideoEmbeddingScope, x => x.ToValueString()))}]"),
                    name: "\"video_embedding_scope\"");
            }
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreateRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                xApiKey: xApiKey,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // The request has failed.
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                global::G.CreateVideoEmbeddingTaskRequestBadRequestError? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::G.CreateVideoEmbeddingTaskRequestBadRequestError.FromJson(__content_400, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_400 = global::G.CreateVideoEmbeddingTaskRequestBadRequestError.FromJson(__content_400, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::G.ApiException<global::G.CreateVideoEmbeddingTaskRequestBadRequestError>(
                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_400,
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
                ProcessCreateResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.EmbedTasksCreateResponse200.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.EmbedTasksCreateResponse200.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
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
        /// Create a video embedding task<br/>
        /// &lt;Note title="Note"&gt;<br/>
        ///   This endpoint will be deprecated in a future version. Migrate to the [Embed API v2](/v1.3/api-reference/create-embeddings-v2) for continued support and access to new features.<br/>
        /// &lt;/Note&gt;<br/>
        /// This method creates a new video embedding task that uploads a video to the platform and creates one or multiple video embeddings.<br/>
        /// &lt;Note title="Note"&gt;<br/>
        /// This endpoint is rate-limited. For details, see the [Rate limits](/v1.3/docs/get-started/rate-limits) page.<br/>
        /// &lt;/Note&gt;<br/>
        /// Upload options:<br/>
        /// - **Local file**: Use the `video_file` parameter<br/>
        /// - **Publicly accessible URL**: Use the `video_url` parameter.<br/>
        /// Specify at least one option. If both are provided, `video_url` takes precedence.<br/>
        /// Your video files must meet the [requirements](/v1.3/docs/concepts/models/marengo#video-file-requirements).<br/>
        /// This endpoint allows you to upload files up to 2 GB in size.  To upload larger files, use the [Multipart Upload API](/v1.3/api-reference/upload-content/multipart-uploads)<br/>
        /// &lt;Note title="Notes"&gt;<br/>
        /// - The Marengo video understanding model generates embeddings for all modalities in the same latent space. This shared space enables any-to-any searches across different types of content.<br/>
        /// - Video embeddings are stored for seven days.<br/>
        /// &lt;/Note&gt;
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="modelName">
        /// The name of the model you want to use. The following models are available:<br/>
        ///   - `marengo3.0`: Enhanced model with sports intelligence and extended content support.<br/>
        ///   - `Marengo-retrieval-2.7`: **Deprecation notice**: Starting mid-March 2026, your videos will be automatically reindexed to Marengo 3.0. Marengo 2.7 will be deprecated once reindexing completes. See the [Migration guide](/v1.3/docs/get-started/migration-guide) for details.
        /// </param>
        /// <param name="videoFile">
        /// Specify this parameter to upload a video from your local file system.
        /// </param>
        /// <param name="videoFilename">
        /// Specify this parameter to upload a video from your local file system.
        /// </param>
        /// <param name="videoUrl">
        /// Specify this parameter to upload a video from a publicly accessible URL.
        /// </param>
        /// <param name="videoStartOffsetSec">
        /// The start offset in seconds from the beginning of the video where processing should begin. Specifying 0 means starting from the beginning of the video.<br/>
        /// **Default**: 0<br/>
        /// **Min**: 0<br/>
        /// **Max**: Duration of the video minus video_clip_length
        /// </param>
        /// <param name="videoEndOffsetSec">
        /// The end offset in seconds from the beginning of the video where processing should stop.<br/>
        /// Ensure the following when you specify this parameter:<br/>
        /// - The end offset does not exceed the total duration of the video file.<br/>
        /// - The end offset is greater than the start offset.<br/>
        /// - You must set both the start and end offsets. Setting only one of these offsets is not permitted, resulting in an error.<br/>
        /// **Min**: video_start_offset + video_clip_length<br/>
        /// **Max**: Duration of the video file
        /// </param>
        /// <param name="videoClipLength">
        /// The desired duration in seconds for each clip for which the platform generates an embedding. Ensure that the clip length does not exceed the interval between the start and end offsets.<br/>
        /// **Default**: 6<br/>
        /// **Min**: 2<br/>
        /// **Max**: 10
        /// </param>
        /// <param name="videoEmbeddingScope">
        /// Defines the scope of video embedding generation. Valid values are the following:<br/>
        /// - `clip`: Creates embeddings for each video segment of `video_clip_length` seconds, from `video_start_offset_sec` to `video_end_offset_sec`.<br/>
        /// - `clip` and `video`: Creates embeddings for video segments and the entire video. Use the `video` scope for videos up to 10-30 seconds to maintain optimal performance.<br/>
        /// To create embeddings for segments and the entire video in the same request, include this parameter twice as shown below:<br/>
        /// ```json<br/>
        /// --form video_embedding_scope=clip \<br/>
        /// --form video_embedding_scope=video<br/>
        /// ```<br/>
        /// **Default**: `clip`
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.EmbedTasksCreateResponse200> CreateAsync(
            string xApiKey,
            string modelName,
            byte[]? videoFile = default,
            string? videoFilename = default,
            string? videoUrl = default,
            double? videoStartOffsetSec = default,
            double? videoEndOffsetSec = default,
            double? videoClipLength = default,
            global::System.Collections.Generic.IList<global::G.EmbedTasksPostRequestBodyContentMultipartFormDataSchemaVideoEmbeddingScopeItems>? videoEmbeddingScope = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.CreateRequest8
            {
                ModelName = modelName,
                VideoFile = videoFile,
                VideoFilename = videoFilename,
                VideoUrl = videoUrl,
                VideoStartOffsetSec = videoStartOffsetSec,
                VideoEndOffsetSec = videoEndOffsetSec,
                VideoClipLength = videoClipLength,
                VideoEmbeddingScope = videoEmbeddingScope,
            };

            return await CreateAsync(
                xApiKey: xApiKey,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}