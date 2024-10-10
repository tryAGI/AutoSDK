//HintName: G.IApi.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the documentation for the ElevenLabs API. You can use this API to use our service programmatically, this is done by using your xi-api-key. &lt;br/&gt; You can view your xi-api-key using the 'Profile' tab on https://elevenlabs.io. Our API is experimental so all endpoints are subject to change.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IApi : global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        global::Newtonsoft.Json.JsonSerializerSettings JsonSerializerOptions { get; set; }


        /// <summary>
        /// Convert text into lifelike speech using a voice of your choice.
        /// </summary>
        public TextToSpeechClient TextToSpeech { get; }

        /// <summary>
        /// Create speech by combining the style and content of an audio file you upload with a voice of your choice.
        /// </summary>
        public SpeechToSpeechClient SpeechToSpeech { get; }

        /// <summary>
        /// Access the different models of the platform.
        /// </summary>
        public ModelsClient Models { get; }

        /// <summary>
        /// Access to voices created either by you or us.
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
        /// Access, create and convert Projects programmatically, only specifically whitelisted accounts can access the Projects API. If you need access please contact our sales team.
        /// </summary>
        public ProjectsClient Projects { get; }

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
        public VoiceGenerationClient VoiceGeneration { get; }

        /// <summary>
        /// 
        /// </summary>
        public UserClient User { get; }

        /// <summary>
        /// 
        /// </summary>
        public DubbingClient Dubbing { get; }

        /// <summary>
        /// 
        /// </summary>
        public WorkspaceClient Workspace { get; }

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

    }
}