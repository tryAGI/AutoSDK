//HintName: G.IApi.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the documentation for the ElevenLabs API. You can use this API to use our service programmatically, this is done by using your API key. You can find your API key in the dashboard at https://elevenlabs.io/app/settings/api-keys.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IApi : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::G.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }

        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public AgentsPlatformClient AgentsPlatform { get; }

        /// <summary>
        /// 
        /// </summary>
        public AudioIsolationClient AudioIsolation { get; }

        /// <summary>
        /// 
        /// </summary>
        public AudioNativeClient AudioNative { get; }

        /// <summary>
        /// 
        /// </summary>
        public ConversationalAiClient ConversationalAi { get; }

        /// <summary>
        /// 
        /// </summary>
        public ConversationalAi2Client ConversationalAi2 { get; }

        /// <summary>
        /// 
        /// </summary>
        public DubbingClient Dubbing { get; }

        /// <summary>
        /// 
        /// </summary>
        public ForcedAlignmentClient ForcedAlignment { get; }

        /// <summary>
        /// 
        /// </summary>
        public HistoryClient History { get; }

        /// <summary>
        /// Access the different models of the platform.
        /// </summary>
        public ModelsClient Models { get; }

        /// <summary>
        /// 
        /// </summary>
        public MusicClient Music { get; }

        /// <summary>
        /// 
        /// </summary>
        public MusicGenerationClient MusicGeneration { get; }

        /// <summary>
        /// 
        /// </summary>
        public PronunciationDictionariesClient PronunciationDictionaries { get; }

        /// <summary>
        /// 
        /// </summary>
        public PronunciationDictionaryClient PronunciationDictionary { get; }

        /// <summary>
        /// 
        /// </summary>
        public PvcVoicesClient PvcVoices { get; }

        /// <summary>
        /// Access to your samples. A sample is any audio file you attached to a voice. A voice can have one or more samples.
        /// </summary>
        public SamplesClient Samples { get; }

        /// <summary>
        /// 
        /// </summary>
        public SingleUseTokenClient SingleUseToken { get; }

        /// <summary>
        /// 
        /// </summary>
        public SpeechToSpeechClient SpeechToSpeech { get; }

        /// <summary>
        /// Transcribe your audio files with detailed speaker annotations and precise timestamps using our cutting-edge model.
        /// </summary>
        public SpeechToTextClient SpeechToText { get; }

        /// <summary>
        /// 
        /// </summary>
        public SpeechToText2Client SpeechToText2 { get; }

        /// <summary>
        /// 
        /// </summary>
        public StudioClient Studio { get; }

        /// <summary>
        /// 
        /// </summary>
        public TextToDialogueClient TextToDialogue { get; }

        /// <summary>
        /// 
        /// </summary>
        public TextToSoundEffectsClient TextToSoundEffects { get; }

        /// <summary>
        /// 
        /// </summary>
        public TextToSpeechClient TextToSpeech { get; }

        /// <summary>
        /// 
        /// </summary>
        public TextToVoiceClient TextToVoice { get; }

        /// <summary>
        /// 
        /// </summary>
        public TextToVoice2Client TextToVoice2 { get; }

        /// <summary>
        /// 
        /// </summary>
        public UsageClient Usage { get; }

        /// <summary>
        /// 
        /// </summary>
        public UserClient User { get; }

        /// <summary>
        /// Access to voices created either by you or ElevenLabs.
        /// </summary>
        public VoicesClient Voices { get; }

        /// <summary>
        /// 
        /// </summary>
        public WebhooksClient Webhooks { get; }

        /// <summary>
        /// Access to workspace related endpoints.
        /// </summary>
        public WorkspaceClient Workspace { get; }

    }
}