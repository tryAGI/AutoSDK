//HintName: G.ModelClient.CreateModel.g.cs

#nullable enable

namespace G
{
    public partial class ModelClient
    {
        partial void PrepareCreateModelArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.CreateModelRequest request);
        partial void PrepareCreateModelRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.CreateModelRequest request);
        partial void ProcessCreateModelResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateModelResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create Model
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreateModelResponse> CreateModelAsync(

            global::G.CreateModelRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateModelArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/model",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            using var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
            if (request.Visibility != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Visibility?.ToValueString()}"),
                    name: "\"visibility\"");
            } 
            if (request.Type != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Type.ToValueString()}"),
                    name: "\"type\"");
            }
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent($"{request.Title}"),
                name: "\"title\"");
            if (request.Description != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Description}"),
                    name: "\"description\"");
            } 
            if (request.CoverImage != default)
            {

                var __contentCoverImage = new global::System.Net.Http.ByteArrayContent(request.CoverImage ?? global::System.Array.Empty<byte>());
                __httpRequestContent.Add(
                    content: __contentCoverImage,
                    name: "\"cover_image\"",
                    fileName: request.CoverImagename != null ? $"\"{request.CoverImagename}\"" : string.Empty);
                if (__contentCoverImage.Headers.ContentDisposition != null)
                {
                    __contentCoverImage.Headers.ContentDisposition.FileNameStar = null;
                }
            } 
            if (request.TrainMode != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.TrainMode.ToValueString()}"),
                    name: "\"train_mode\"");
            }
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent(request.Voices.ToString() ?? string.Empty),
                name: "\"voices\"");
            if (request.Texts != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent(request.Texts?.ToString() ?? string.Empty),
                    name: "\"texts\"");
            } 
            if (request.Tags != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent(request.Tags?.ToString() ?? string.Empty),
                    name: "\"tags\"");
            } 
            if (request.EnhanceAudioQuality != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.EnhanceAudioQuality}"),
                    name: "\"enhance_audio_quality\"");
            }
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreateModelRequest(
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
            ProcessCreateModelResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // No permission -- see authorization schemes
            if ((int)__response.StatusCode == 401)
            {
                string? __content_401 = null;
                global::System.Exception? __exception_401 = null;
                global::G.CreateModelResponse2? __value_401 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_401 = global::G.CreateModelResponse2.FromJson(__content_401, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_401 = global::G.CreateModelResponse2.FromJson(__content_401, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_401 = __ex;
                }

                throw new global::G.ApiException<global::G.CreateModelResponse2>(
                    message: __content_401 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_401,
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
            // 
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::System.Exception? __exception_422 = null;
                global::System.Collections.Generic.IList<global::G.CreateModelResponseItem>? __value_422 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_422 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::G.CreateModelResponseItem>?>(__content_422, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_422 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::G.CreateModelResponseItem>?>(__content_422, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_422 = __ex;
                }

                throw new global::G.ApiException<global::System.Collections.Generic.IList<global::G.CreateModelResponseItem>>(
                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_422,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_422,
                    ResponseObject = __value_422,
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
                ProcessCreateModelResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.CreateModelResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.CreateModelResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Create Model
        /// </summary>
        /// <param name="visibility">
        /// Model visibility, public will be shown in the discovery page, unlist allows anyone with the link to access, private only be visible to the creator<br/>
        /// Default Value: public
        /// </param>
        /// <param name="type">
        /// Model type, tts is for text to speech
        /// </param>
        /// <param name="title">
        /// Model title or name
        /// </param>
        /// <param name="description">
        /// Model description<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="coverImage">
        /// Model cover image, this is required if the model is public<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="coverImagename">
        /// Model cover image, this is required if the model is public<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="trainMode">
        /// Model train mode, for TTS model, fast means model instantly available after creation
        /// </param>
        /// <param name="voices">
        /// Upload voices files that will be used to tune the model
        /// </param>
        /// <param name="texts">
        /// Texts corresponding to the voices, if unspecified, ASR will be performed on the voices<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="tags">
        /// Model tags
        /// </param>
        /// <param name="enhanceAudioQuality">
        /// Enhance audio quality<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreateModelResponse> CreateModelAsync(
            string title,
            global::G.AnyOf<global::System.Collections.Generic.IList<byte[]>, byte[]> voices,
            global::G.CreateModelRequestVisibility? visibility = default,
            global::G.CreateModelRequestType type = default,
            string? description = default,
            byte[]? coverImage = default,
            string? coverImagename = default,
            global::G.CreateModelRequestTrainMode trainMode = default,
            global::G.AnyOf<global::System.Collections.Generic.IList<string>, string, object>? texts = default,
            global::G.AnyOf<global::System.Collections.Generic.IList<string>, string, object>? tags = default,
            bool? enhanceAudioQuality = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.CreateModelRequest
            {
                Visibility = visibility,
                Type = type,
                Title = title,
                Description = description,
                CoverImage = coverImage,
                CoverImagename = coverImagename,
                TrainMode = trainMode,
                Voices = voices,
                Texts = texts,
                Tags = tags,
                EnhanceAudioQuality = enhanceAudioQuality,
            };

            return await CreateModelAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}