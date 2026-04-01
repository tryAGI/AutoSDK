//HintName: G.MusicClient.SeparateStems.g.cs

#nullable enable

namespace G
{
    public partial class MusicClient
    {
        partial void PrepareSeparateStemsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::G.AllowedOutputFormats? outputFormat,
            ref string? xiApiKey,
            global::G.BodyStemSeparationV1MusicStemSeparationPost request);
        partial void PrepareSeparateStemsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.AllowedOutputFormats? outputFormat,
            string? xiApiKey,
            global::G.BodyStemSeparationV1MusicStemSeparationPost request);
        partial void ProcessSeparateStemsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessSeparateStemsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref byte[] content);

        /// <summary>
        /// Stem Separation<br/>
        /// Separate an audio file into individual stems. This endpoint might have high latency, depending on the length of the audio file.
        /// </summary>
        /// <param name="outputFormat">
        /// Output format of the generated audio. Formatted as codec_sample_rate_bitrate. So an mp3 with 22.05kHz sample rate at 32kbs is represented as mp3_22050_32. MP3 with 192kbps bitrate requires you to be subscribed to Creator tier or above. PCM with 44.1kHz sample rate requires you to be subscribed to Pro tier or above. Note that the μ-law format (sometimes written mu-law, often approximated as u-law) is commonly used for Twilio audio inputs.<br/>
        /// Default Value: mp3_44100_128
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<byte[]> SeparateStemsAsync(

            global::G.BodyStemSeparationV1MusicStemSeparationPost request,
            global::G.AllowedOutputFormats? outputFormat = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareSeparateStemsArguments(
                httpClient: HttpClient,
                outputFormat: ref outputFormat,
                xiApiKey: ref xiApiKey,
                request: request);

            var outputFormatValue = outputFormat switch
            {
                global::G.AllowedOutputFormats.Mp32205032 => "mp3_22050_32",
                global::G.AllowedOutputFormats.Mp32400048 => "mp3_24000_48",
                global::G.AllowedOutputFormats.Mp34410032 => "mp3_44100_32",
                global::G.AllowedOutputFormats.Mp34410064 => "mp3_44100_64",
                global::G.AllowedOutputFormats.Mp34410096 => "mp3_44100_96",
                global::G.AllowedOutputFormats.Mp344100128 => "mp3_44100_128",
                global::G.AllowedOutputFormats.Mp344100192 => "mp3_44100_192",
                global::G.AllowedOutputFormats.Pcm8000 => "pcm_8000",
                global::G.AllowedOutputFormats.Pcm16000 => "pcm_16000",
                global::G.AllowedOutputFormats.Pcm22050 => "pcm_22050",
                global::G.AllowedOutputFormats.Pcm24000 => "pcm_24000",
                global::G.AllowedOutputFormats.Pcm32000 => "pcm_32000",
                global::G.AllowedOutputFormats.Pcm44100 => "pcm_44100",
                global::G.AllowedOutputFormats.Pcm48000 => "pcm_48000",
                global::G.AllowedOutputFormats.Ulaw8000 => "ulaw_8000",
                global::G.AllowedOutputFormats.Alaw8000 => "alaw_8000",
                global::G.AllowedOutputFormats.Opus4800032 => "opus_48000_32",
                global::G.AllowedOutputFormats.Opus4800064 => "opus_48000_64",
                global::G.AllowedOutputFormats.Opus4800096 => "opus_48000_96",
                global::G.AllowedOutputFormats.Opus48000128 => "opus_48000_128",
                global::G.AllowedOutputFormats.Opus48000192 => "opus_48000_192",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/music/stem-separation",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("output_format", outputFormat?.ToValueString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            if (xiApiKey != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("xi-api-key", xiApiKey.ToString());
            }

            using var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
            if (outputFormat != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{outputFormat?.ToValueString()}"),
                    name: "\"output_format\"");
            } 
            if (xiApiKey != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{xiApiKey}"),
                    name: "\"xi-api-key\"");
            }
            var __contentFile = new global::System.Net.Http.ByteArrayContent(request.File ?? global::System.Array.Empty<byte>());
            __httpRequestContent.Add(
                content: __contentFile,
                name: "\"file\"",
                fileName: request.Filename != null ? $"\"{request.Filename}\"" : string.Empty);
            if (__contentFile.Headers.ContentDisposition != null)
            {
                __contentFile.Headers.ContentDisposition.FileNameStar = null;
            }
            if (request.StemVariationId != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.StemVariationId?.ToValueString()}"),
                    name: "\"stem_variation_id\"");
            } 
            if (request.SignWithC2pa != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.SignWithC2pa}"),
                    name: "\"sign_with_c2pa\"");
            }
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareSeparateStemsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                outputFormat: outputFormat,
                xiApiKey: xiApiKey,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessSeparateStemsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Validation Error
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::System.Exception? __exception_422 = null;
                global::G.HTTPValidationError? __value_422 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_422 = global::G.HTTPValidationError.FromJson(__content_422, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_422 = global::G.HTTPValidationError.FromJson(__content_422, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_422 = __ex;
                }

                throw new global::G.ApiException<global::G.HTTPValidationError>(
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
                var __content = await __response.Content.ReadAsByteArrayAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessSeparateStemsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return __content;
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
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();

                    var __content = await __response.Content.ReadAsByteArrayAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return __content;
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
        /// Stem Separation<br/>
        /// Separate an audio file into individual stems. This endpoint might have high latency, depending on the length of the audio file.
        /// </summary>
        /// <param name="outputFormat">
        /// Output format of the generated audio. Formatted as codec_sample_rate_bitrate. So an mp3 with 22.05kHz sample rate at 32kbs is represented as mp3_22050_32. MP3 with 192kbps bitrate requires you to be subscribed to Creator tier or above. PCM with 44.1kHz sample rate requires you to be subscribed to Pro tier or above. Note that the μ-law format (sometimes written mu-law, often approximated as u-law) is commonly used for Twilio audio inputs.<br/>
        /// Default Value: mp3_44100_128
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="file">
        /// The audio file to separate into stems.
        /// </param>
        /// <param name="filename">
        /// The audio file to separate into stems.
        /// </param>
        /// <param name="stemVariationId">
        /// The id of the stem variation to use.<br/>
        /// Default Value: six_stems_v1
        /// </param>
        /// <param name="signWithC2pa">
        /// Whether to sign the generated song with C2PA. Applicable only for mp3 files.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<byte[]> SeparateStemsAsync(
            byte[] file,
            string filename,
            global::G.AllowedOutputFormats? outputFormat = default,
            string? xiApiKey = default,
            global::G.BodyStemSeparationV1MusicStemSeparationPostStemVariationId? stemVariationId = default,
            bool? signWithC2pa = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.BodyStemSeparationV1MusicStemSeparationPost
            {
                File = file,
                Filename = filename,
                StemVariationId = stemVariationId,
                SignWithC2pa = signWithC2pa,
            };

            return await SeparateStemsAsync(
                outputFormat: outputFormat,
                xiApiKey: xiApiKey,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}