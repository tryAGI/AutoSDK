//HintName: G.RealtimeClient.CreateRealtimeSession.g.cs

#nullable enable

namespace G
{
    public partial class RealtimeClient
    {
        partial void PrepareCreateRealtimeSessionArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.RealtimeSessionCreateRequest request);
        partial void PrepareCreateRealtimeSessionRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.RealtimeSessionCreateRequest request);
        partial void ProcessCreateRealtimeSessionResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateRealtimeSessionResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create an ephemeral API token for use in client-side applications with the<br/>
        /// Realtime API. Can be configured with the same session parameters as the<br/>
        /// `session.update` client event.<br/>
        /// It responds with a session object, plus a `client_secret` key which contains<br/>
        /// a usable ephemeral API token that can be used to authenticate browser clients<br/>
        /// for the Realtime API.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.RealtimeSessionCreateResponse> CreateRealtimeSessionAsync(
            global::G.RealtimeSessionCreateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateRealtimeSessionArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/realtime/sessions",
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreateRealtimeSessionRequest(
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
            ProcessCreateRealtimeSessionResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

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
                ProcessCreateRealtimeSessionResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
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

                return
                    global::G.RealtimeSessionCreateResponse.FromJson(__content, JsonSerializerOptions) ??
                    throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
            }
            else
            {
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

                using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                return
                    await global::G.RealtimeSessionCreateResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }

        /// <summary>
        /// Create an ephemeral API token for use in client-side applications with the<br/>
        /// Realtime API. Can be configured with the same session parameters as the<br/>
        /// `session.update` client event.<br/>
        /// It responds with a session object, plus a `client_secret` key which contains<br/>
        /// a usable ephemeral API token that can be used to authenticate browser clients<br/>
        /// for the Realtime API.
        /// </summary>
        /// <param name="inputAudioFormat">
        /// The format of input audio. Options are `pcm16`, `g711_ulaw`, or `g711_alaw`.<br/>
        /// For `pcm16`, input audio must be 16-bit PCM at a 24kHz sample rate, <br/>
        /// single channel (mono), and little-endian byte order.
        /// </param>
        /// <param name="inputAudioTranscription">
        /// Configuration for input audio transcription, defaults to off and can be  set to `null` to turn off once on. Input audio transcription is not native to the model, since the model consumes audio directly. Transcription runs  asynchronously through [OpenAI Whisper transcription](https://platform.openai.com/docs/api-reference/audio/createTranscription) and should be treated as rough guidance rather than the representation understood by the model. The client can optionally set the language and prompt for transcription, these fields will be passed to the Whisper API.
        /// </param>
        /// <param name="instructions">
        /// The default system instructions (i.e. system message) prepended to model <br/>
        /// calls. This field allows the client to guide the model on desired <br/>
        /// responses. The model can be instructed on response content and format, <br/>
        /// (e.g. "be extremely succinct", "act friendly", "here are examples of good <br/>
        /// responses") and on audio behavior (e.g. "talk quickly", "inject emotion <br/>
        /// into your voice", "laugh frequently"). The instructions are not guaranteed <br/>
        /// to be followed by the model, but they provide guidance to the model on the <br/>
        /// desired behavior.<br/>
        /// Note that the server sets default instructions which will be used if this <br/>
        /// field is not set and are visible in the `session.created` event at the <br/>
        /// start of the session.
        /// </param>
        /// <param name="maxResponseOutputTokens">
        /// Maximum number of output tokens for a single assistant response,<br/>
        /// inclusive of tool calls. Provide an integer between 1 and 4096 to<br/>
        /// limit output tokens, or `inf` for the maximum available tokens for a<br/>
        /// given model. Defaults to `inf`.
        /// </param>
        /// <param name="modalities">
        /// The set of modalities the model can respond with. To disable audio,<br/>
        /// set this to ["text"].
        /// </param>
        /// <param name="model">
        /// The Realtime model used for this session.
        /// </param>
        /// <param name="outputAudioFormat">
        /// The format of output audio. Options are `pcm16`, `g711_ulaw`, or `g711_alaw`.<br/>
        /// For `pcm16`, output audio is sampled at a rate of 24kHz.
        /// </param>
        /// <param name="temperature">
        /// Sampling temperature for the model, limited to [0.6, 1.2]. Defaults to 0.8.
        /// </param>
        /// <param name="toolChoice">
        /// How the model chooses tools. Options are `auto`, `none`, `required`, or <br/>
        /// specify a function.
        /// </param>
        /// <param name="tools">
        /// Tools (functions) available to the model.
        /// </param>
        /// <param name="turnDetection">
        /// Configuration for turn detection. Can be set to `null` to turn off. Server <br/>
        /// VAD means that the model will detect the start and end of speech based on <br/>
        /// audio volume and respond at the end of user speech.
        /// </param>
        /// <param name="voice">
        /// The voice the model uses to respond. Voice cannot be changed during the <br/>
        /// session once the model has responded with audio at least once. Current <br/>
        /// voice options are `alloy`, `ash`, `ballad`, `coral`, `echo` `sage`, <br/>
        /// `shimmer` and `verse`.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.RealtimeSessionCreateResponse> CreateRealtimeSessionAsync(
            global::G.RealtimeSessionCreateRequestInputAudioFormat? inputAudioFormat = default,
            global::G.RealtimeSessionCreateRequestInputAudioTranscription? inputAudioTranscription = default,
            string? instructions = default,
            global::G.OneOf<int?, global::G.RealtimeSessionCreateRequestMaxResponseOutputTokens?>? maxResponseOutputTokens = default,
            global::System.Collections.Generic.IList<global::G.RealtimeSessionCreateRequestModalitie>? modalities = default,
            global::G.RealtimeSessionCreateRequestModel? model = default,
            global::G.RealtimeSessionCreateRequestOutputAudioFormat? outputAudioFormat = default,
            double? temperature = default,
            string? toolChoice = default,
            global::System.Collections.Generic.IList<global::G.RealtimeSessionCreateRequestTool>? tools = default,
            global::G.RealtimeSessionCreateRequestTurnDetection? turnDetection = default,
            global::G.RealtimeSessionCreateRequestVoice? voice = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.RealtimeSessionCreateRequest
            {
                InputAudioFormat = inputAudioFormat,
                InputAudioTranscription = inputAudioTranscription,
                Instructions = instructions,
                MaxResponseOutputTokens = maxResponseOutputTokens,
                Modalities = modalities,
                Model = model,
                OutputAudioFormat = outputAudioFormat,
                Temperature = temperature,
                ToolChoice = toolChoice,
                Tools = tools,
                TurnDetection = turnDetection,
                Voice = voice,
            };

            return await CreateRealtimeSessionAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}