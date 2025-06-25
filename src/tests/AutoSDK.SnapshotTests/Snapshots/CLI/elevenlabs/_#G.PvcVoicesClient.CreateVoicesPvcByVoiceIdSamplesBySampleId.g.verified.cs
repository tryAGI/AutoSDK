//HintName: G.PvcVoicesClient.CreateVoicesPvcByVoiceIdSamplesBySampleId.g.cs

#nullable enable

namespace G
{
    public partial class PvcVoicesClient
    {
        partial void PrepareCreateVoicesPvcByVoiceIdSamplesBySampleIdArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string voiceId,
            ref string sampleId,
            ref string? xiApiKey,
            global::G.BodyUpdatePVCVoiceSampleV1VoicesPvcVoiceIdSamplesSampleIdPost request);
        partial void PrepareCreateVoicesPvcByVoiceIdSamplesBySampleIdRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string voiceId,
            string sampleId,
            string? xiApiKey,
            global::G.BodyUpdatePVCVoiceSampleV1VoicesPvcVoiceIdSamplesSampleIdPost request);
        partial void ProcessCreateVoicesPvcByVoiceIdSamplesBySampleIdResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateVoicesPvcByVoiceIdSamplesBySampleIdResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update Pvc Voice Sample<br/>
        /// Update a PVC voice sample - apply noise removal, or select speaker.
        /// </summary>
        /// <param name="voiceId">
        /// Voice ID to be used, you can use https://api.elevenlabs.io/v1/voices to list all the available voices.<br/>
        /// Example: 21m00Tcm4TlvDq8ikWAM
        /// </param>
        /// <param name="sampleId">
        /// Sample ID to be used<br/>
        /// Example: VW7YKqPnjY4h39yTbx2L
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.AddVoiceResponseModel> CreateVoicesPvcByVoiceIdSamplesBySampleIdAsync(
            string voiceId,
            string sampleId,
            global::G.BodyUpdatePVCVoiceSampleV1VoicesPvcVoiceIdSamplesSampleIdPost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateVoicesPvcByVoiceIdSamplesBySampleIdArguments(
                httpClient: HttpClient,
                voiceId: ref voiceId,
                sampleId: ref sampleId,
                xiApiKey: ref xiApiKey,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/v1/voices/pvc/{voiceId}/samples/{sampleId}",
                baseUri: HttpClient.BaseAddress); 
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

            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreateVoicesPvcByVoiceIdSamplesBySampleIdRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                voiceId: voiceId,
                sampleId: sampleId,
                xiApiKey: xiApiKey,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateVoicesPvcByVoiceIdSamplesBySampleIdResponse(
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
                        var __contentStream_422 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                        __value_422 = await global::G.HTTPValidationError.FromJsonStreamAsync(__contentStream_422, JsonSerializerOptions).ConfigureAwait(false);
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
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessCreateVoicesPvcByVoiceIdSamplesBySampleIdResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.AddVoiceResponseModel.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.AddVoiceResponseModel.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Update Pvc Voice Sample<br/>
        /// Update a PVC voice sample - apply noise removal, or select speaker.
        /// </summary>
        /// <param name="voiceId">
        /// Voice ID to be used, you can use https://api.elevenlabs.io/v1/voices to list all the available voices.<br/>
        /// Example: 21m00Tcm4TlvDq8ikWAM
        /// </param>
        /// <param name="sampleId">
        /// Sample ID to be used<br/>
        /// Example: VW7YKqPnjY4h39yTbx2L
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="removeBackgroundNoise">
        /// If set will remove background noise for voice samples using our audio isolation model. If the samples do not include background noise, it can make the quality worse.<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </param>
        /// <param name="selectedSpeakerIds">
        /// Speaker IDs to be used for PVC training. Make sure you send all the speaker IDs you want to use for PVC training in one request because the last request will override the previous ones.<br/>
        /// Example: speaker_0
        /// </param>
        /// <param name="trimStartTime">
        /// The start time of the audio to be used for PVC training. Time should be in milliseconds<br/>
        /// Example: 0
        /// </param>
        /// <param name="trimEndTime">
        /// The end time of the audio to be used for PVC training. Time should be in milliseconds<br/>
        /// Example: 10
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.AddVoiceResponseModel> CreateVoicesPvcByVoiceIdSamplesBySampleIdAsync(
            string voiceId,
            string sampleId,
            string? xiApiKey = default,
            bool? removeBackgroundNoise = default,
            global::System.Collections.Generic.IList<string>? selectedSpeakerIds = default,
            int? trimStartTime = default,
            int? trimEndTime = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.BodyUpdatePVCVoiceSampleV1VoicesPvcVoiceIdSamplesSampleIdPost
            {
                RemoveBackgroundNoise = removeBackgroundNoise,
                SelectedSpeakerIds = selectedSpeakerIds,
                TrimStartTime = trimStartTime,
                TrimEndTime = trimEndTime,
            };

            return await CreateVoicesPvcByVoiceIdSamplesBySampleIdAsync(
                voiceId: voiceId,
                sampleId: sampleId,
                xiApiKey: xiApiKey,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}