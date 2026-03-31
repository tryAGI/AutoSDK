//HintName: G.SubpackageEmbedClient.Create.g.cs

#nullable enable

namespace G
{
    public partial class SubpackageEmbedClient
    {
        partial void PrepareCreateArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string xApiKey,
            global::G.CreateRequest9 request);
        partial void PrepareCreateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string xApiKey,
            global::G.CreateRequest9 request);
        partial void ProcessCreateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create embeddings for text, image, and audio<br/>
        /// &lt;Note title="Note"&gt;<br/>
        ///   This endpoint will be deprecated in a future version. Migrate to the [Embed API v2](/v1.3/api-reference/create-embeddings-v2) for continued support and access to new features.<br/>
        /// &lt;/Note&gt;<br/>
        /// This method creates embeddings for text, image, and audio content.<br/>
        /// Ensure your media files meet the following requirements:<br/>
        /// - [Audio files](/v1.3/docs/concepts/models/marengo#audio-requirements).<br/>
        /// - [Image files](/v1.3/docs/concepts/models/marengo#image-requirements).<br/>
        /// Parameters for embeddings:<br/>
        /// - **Common parameters**:<br/>
        ///   - `model_name`: The video understanding model you want to use. Example: "marengo3.0".<br/>
        /// - **Text embeddings**:<br/>
        ///   - `text`: Text for which to create an embedding.<br/>
        /// - **Image embeddings**:<br/>
        ///   Provide one of the following:<br/>
        ///   - `image_url`: Publicly accessible URL of your image file.<br/>
        ///   - `image_file`:  Local image file.<br/>
        /// - **Audio embeddings**:<br/>
        ///   Provide one of the following:<br/>
        ///   - `audio_url`: Publicly accessible URL of your audio file.<br/>
        ///   - `audio_file`: Local audio file.<br/>
        /// &lt;Note title="Notes"&gt;<br/>
        /// - The Marengo video understanding model generates embeddings for all modalities in the same latent space. This shared space enables any-to-any searches across different types of content.<br/>
        /// - You can create multiple types of embeddings in a single API call.<br/>
        /// - Audio embeddings combine generic sound and human speech in a single embedding. For videos with transcriptions, you can retrieve transcriptions and then [create text embeddings](/v1.3/api-reference/create-embeddings-v1/text-image-audio-embeddings/create-text-image-audio-embeddings) from these<br/>
        /// - This endpoint is rate-limited. For details, see the [Rate limits](/v1.3/docs/get-started/rate-limits) page.<br/>
        /// &lt;/Note&gt;
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.EmbeddingResponse> CreateAsync(
            string xApiKey,

            global::G.CreateRequest9 request,
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
                path: "/embed",
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
            if (request.Text != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Text}"),
                    name: "\"text\"");
            } 
            if (request.TextTruncate != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.TextTruncate}"),
                    name: "\"text_truncate\"");
            } 
            if (request.ImageUrl != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ImageUrl}"),
                    name: "\"image_url\"");
            } 
            if (request.ImageFile != default)
            {

                var __contentImageFile = new global::System.Net.Http.ByteArrayContent(request.ImageFile ?? global::System.Array.Empty<byte>());
                __httpRequestContent.Add(
                    content: __contentImageFile,
                    name: "\"image_file\"",
                    fileName: request.ImageFilename != null ? $"\"{request.ImageFilename}\"" : string.Empty);
                if (__contentImageFile.Headers.ContentDisposition != null)
                {
                    __contentImageFile.Headers.ContentDisposition.FileNameStar = null;
                }
            } 
            if (request.AudioUrl != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.AudioUrl}"),
                    name: "\"audio_url\"");
            } 
            if (request.AudioFile != default)
            {

                var __contentAudioFile = new global::System.Net.Http.ByteArrayContent(request.AudioFile ?? global::System.Array.Empty<byte>());
                __httpRequestContent.Add(
                    content: __contentAudioFile,
                    name: "\"audio_file\"",
                    fileName: request.AudioFilename != null ? $"\"{request.AudioFilename}\"" : string.Empty);
                if (__contentAudioFile.Headers.ContentDisposition != null)
                {
                    __contentAudioFile.Headers.ContentDisposition.FileNameStar = null;
                }
            } 
            if (request.AudioStartOffsetSec != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.AudioStartOffsetSec}"),
                    name: "\"audio_start_offset_sec\"");
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
                global::G.CreateTextImageAudioEmbeddingRequestBadRequestError? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::G.CreateTextImageAudioEmbeddingRequestBadRequestError.FromJson(__content_400, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_400 = global::G.CreateTextImageAudioEmbeddingRequestBadRequestError.FromJson(__content_400, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::G.ApiException<global::G.CreateTextImageAudioEmbeddingRequestBadRequestError>(
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
                        global::G.EmbeddingResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.EmbeddingResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Create embeddings for text, image, and audio<br/>
        /// &lt;Note title="Note"&gt;<br/>
        ///   This endpoint will be deprecated in a future version. Migrate to the [Embed API v2](/v1.3/api-reference/create-embeddings-v2) for continued support and access to new features.<br/>
        /// &lt;/Note&gt;<br/>
        /// This method creates embeddings for text, image, and audio content.<br/>
        /// Ensure your media files meet the following requirements:<br/>
        /// - [Audio files](/v1.3/docs/concepts/models/marengo#audio-requirements).<br/>
        /// - [Image files](/v1.3/docs/concepts/models/marengo#image-requirements).<br/>
        /// Parameters for embeddings:<br/>
        /// - **Common parameters**:<br/>
        ///   - `model_name`: The video understanding model you want to use. Example: "marengo3.0".<br/>
        /// - **Text embeddings**:<br/>
        ///   - `text`: Text for which to create an embedding.<br/>
        /// - **Image embeddings**:<br/>
        ///   Provide one of the following:<br/>
        ///   - `image_url`: Publicly accessible URL of your image file.<br/>
        ///   - `image_file`:  Local image file.<br/>
        /// - **Audio embeddings**:<br/>
        ///   Provide one of the following:<br/>
        ///   - `audio_url`: Publicly accessible URL of your audio file.<br/>
        ///   - `audio_file`: Local audio file.<br/>
        /// &lt;Note title="Notes"&gt;<br/>
        /// - The Marengo video understanding model generates embeddings for all modalities in the same latent space. This shared space enables any-to-any searches across different types of content.<br/>
        /// - You can create multiple types of embeddings in a single API call.<br/>
        /// - Audio embeddings combine generic sound and human speech in a single embedding. For videos with transcriptions, you can retrieve transcriptions and then [create text embeddings](/v1.3/api-reference/create-embeddings-v1/text-image-audio-embeddings/create-text-image-audio-embeddings) from these<br/>
        /// - This endpoint is rate-limited. For details, see the [Rate limits](/v1.3/docs/get-started/rate-limits) page.<br/>
        /// &lt;/Note&gt;
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="modelName">
        /// The name of the model you want to use. The following models are available:<br/>
        ///   - `marengo3.0`: Enhanced model with sports intelligence and extended content support.<br/>
        ///   - `Marengo-retrieval-2.7`: **Deprecation notice**: Starting mid-March 2026, your videos will be automatically reindexed to Marengo 3.0. Marengo 2.7 will be deprecated once reindexing completes. See the [Migration guide](/v1.3/docs/get-started/migration-guide) for details.
        /// </param>
        /// <param name="text">
        /// The text for which you wish to create an embedding.<br/>
        /// **Example**: "Man with a dog crossing the street"
        /// </param>
        /// <param name="textTruncate">
        /// Specifies how the platform handles text that exceeds token limits.<br/>
        /// **Available options by model version**:<br/>
        /// **Marengo 3.0**: This parameter is deprecated. The platform automatically truncates text exceeding 500 tokens from the end.<br/>
        /// **Marengo 2.7**: Specifies truncation method for text exceeding 77 tokens:<br/>
        /// - `start`: Removes tokens from the beginning<br/>
        /// - `end`: Removes tokens from the end (default)<br/>
        /// - `none`: Returns an error if the text is longer than the maximum token limit.<br/>
        /// **Default**: `end`<br/>
        /// Default Value: end
        /// </param>
        /// <param name="imageUrl">
        /// The publicly accessible URL of the image for which you wish to create an embedding. This parameter is required for image embeddings if `image_file` is not provided.
        /// </param>
        /// <param name="imageFile">
        /// The image file for which you wish to create an embedding as a local file. This parameter is required for image embeddings if `image_url` is not provided.
        /// </param>
        /// <param name="imageFilename">
        /// The image file for which you wish to create an embedding as a local file. This parameter is required for image embeddings if `image_url` is not provided.
        /// </param>
        /// <param name="audioUrl">
        /// The publicly accessible URL of the audio file for which you wish to creae an embedding. This parameter is required for audio embeddings if `audio_file` is not provided.
        /// </param>
        /// <param name="audioFile">
        /// The audio file for which you wish to create an embedding as a local file. This parameter is required for audio embeddings if `audio_url` is not provided.
        /// </param>
        /// <param name="audioFilename">
        /// The audio file for which you wish to create an embedding as a local file. This parameter is required for audio embeddings if `audio_url` is not provided.
        /// </param>
        /// <param name="audioStartOffsetSec">
        /// Specifies the start time, in seconds, from which the platform generates the audio embeddings. This parameter allows you to skip the initial portion of the audio during processing.<br/>
        /// **Default**: `0`.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.EmbeddingResponse> CreateAsync(
            string xApiKey,
            string modelName,
            string? text = default,
            string? textTruncate = default,
            string? imageUrl = default,
            byte[]? imageFile = default,
            string? imageFilename = default,
            string? audioUrl = default,
            byte[]? audioFile = default,
            string? audioFilename = default,
            double? audioStartOffsetSec = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            var __request = new global::G.CreateRequest9
            {
                ModelName = modelName,
                Text = text,
                TextTruncate = textTruncate,
                ImageUrl = imageUrl,
                ImageFile = imageFile,
                ImageFilename = imageFilename,
                AudioUrl = audioUrl,
                AudioFile = audioFile,
                AudioFilename = audioFilename,
                AudioStartOffsetSec = audioStartOffsetSec,
            };

            return await CreateAsync(
                xApiKey: xApiKey,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}