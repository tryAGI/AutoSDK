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
        /// </summary>
        public bool ReadResponseAsString { get; set; }

        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; }


        /// <summary>
        /// Convert text into lifelike speech using a voice of your choice.
        /// </summary>
        public TextToSpeechClient TextToSpeech { get; }

        /// <summary>
        /// Create speech by combining the style and content of an audio file you upload with a voice of your choice.
        /// </summary>
        public SpeechToSpeechClient SpeechToSpeech { get; }

        /// <summary>
        /// Transcribe your audio files with detailed speaker annotations and precise timestamps using our cutting-edge model.
        /// </summary>
        public SpeechToTextClient SpeechToText { get; }

        /// <summary>
        /// Force align an audio file to a text transcript to get precise word-level and character level timing information. Response is a list of characters with their start and end times as milliseconds elapsed from the start of the recording.
        /// </summary>
        public ForcedAlignmentClient ForcedAlignment { get; }

        /// <summary>
        /// Access the different models of the platform.
        /// </summary>
        public ModelsClient Models { get; }

        /// <summary>
        /// Access to voices created either by you or ElevenLabs.
        /// </summary>
        public VoicesClient Voices { get; }

        /// <summary>
        /// Access to your samples. A sample is any audio file you attached to a voice. A voice can have one or more samples.
        /// </summary>
        public SamplesClient Samples { get; }

        /// <summary>
        /// Accesses your speech history. Your speech history is a list of all your created audio including its metadata using our text-to-speech and speech-to-speech models.
        /// </summary>
        public SpeechHistoryClient SpeechHistory { get; }

        /// <summary>
        /// Access, create and convert Studio Projects programmatically, only specifically whitelisted accounts can access the Projects API. If you need access please contact our sales team.
        /// </summary>
        public StudiosClient Studios { get; }

        /// <summary>
        /// 
        /// </summary>
        public SoundGenerationClient SoundGeneration { get; }

        /// <summary>
        /// 
        /// </summary>
        public AudioIsolationClient AudioIsolation { get; }

        /// <summary>
        /// 
        /// </summary>
        public TextToDialogueClient TextToDialogue { get; }

        /// <summary>
        /// 
        /// </summary>
        public VoiceGenerationClient VoiceGeneration { get; }

        /// <summary>
        /// 
        /// </summary>
        public TextToVoiceClient TextToVoice { get; }

        /// <summary>
        /// 
        /// </summary>
        public UserClient User { get; }

        /// <summary>
        /// 
        /// </summary>
        public StudioClient Studio { get; }

        /// <summary>
        /// 
        /// </summary>
        public ProjectsClient Projects { get; }

        /// <summary>
        /// 
        /// </summary>
        public DubbingClient Dubbing { get; }

        /// <summary>
        /// 
        /// </summary>
        public ResourceClient Resource { get; }

        /// <summary>
        /// 
        /// </summary>
        public SegmentClient Segment { get; }

        /// <summary>
        /// 
        /// </summary>
        public EnterpriseClient Enterprise { get; }

        /// <summary>
        /// 
        /// </summary>
        public AudioNativeClient AudioNative { get; }

        /// <summary>
        /// 
        /// </summary>
        public UsageClient Usage { get; }

        /// <summary>
        /// 
        /// </summary>
        public PronunciationDictionaryClient PronunciationDictionary { get; }

        /// <summary>
        /// 
        /// </summary>
        public WorkspaceClient Workspace { get; }

        /// <summary>
        /// 
        /// </summary>
        public ConversationalAIClient ConversationalAI { get; }

        /// <summary>
        /// 
        /// </summary>
        public PvcVoicesClient PvcVoices { get; }

    }
}