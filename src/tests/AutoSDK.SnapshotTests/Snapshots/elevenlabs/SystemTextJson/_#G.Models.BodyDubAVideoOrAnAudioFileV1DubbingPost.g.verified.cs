//HintName: G.Models.BodyDubAVideoOrAnAudioFileV1DubbingPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyDubAVideoOrAnAudioFileV1DubbingPost
    {
        /// <summary>
        /// A list of file paths to audio recordings intended for voice cloning
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        public byte[]? File { get; set; }

        /// <summary>
        /// CSV file containing transcription/translation metadata
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("csv_file")]
        public byte[]? CsvFile { get; set; }

        /// <summary>
        /// For use only with csv input
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("foreground_audio_file")]
        public byte[]? ForegroundAudioFile { get; set; }

        /// <summary>
        /// For use only with csv input
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background_audio_file")]
        public byte[]? BackgroundAudioFile { get; set; }

        /// <summary>
        /// Name of the dubbing project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// URL of the source video/audio file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_url")]
        public string? SourceUrl { get; set; }

        /// <summary>
        /// Source language. Expects a valid iso639-1 or iso639-3 language code.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_lang")]
        public string? SourceLang { get; set; }

        /// <summary>
        /// The Target language to dub the content into. Expects a valid iso639-1 or iso639-3 language code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_lang")]
        public string? TargetLang { get; set; }

        /// <summary>
        /// [Experimental] An accent to apply when selecting voices from the library and to use to inform translation of the dialect to prefer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_accent")]
        public string? TargetAccent { get; set; }

        /// <summary>
        /// Number of speakers to use for the dubbing. Set to 0 to automatically detect the number of speakers<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_speakers")]
        public int? NumSpeakers { get; set; }

        /// <summary>
        /// Whether to apply watermark to the output video.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("watermark")]
        public bool? Watermark { get; set; }

        /// <summary>
        /// Start time of the source video/audio file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public int? StartTime { get; set; }

        /// <summary>
        /// End time of the source video/audio file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public int? EndTime { get; set; }

        /// <summary>
        /// Whether to use the highest resolution available.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("highest_resolution")]
        public bool? HighestResolution { get; set; }

        /// <summary>
        /// An advanced setting. Whether to drop background audio from the final dub. This can improve dub quality where it's known that audio shouldn't have a background track such as for speeches or monologues.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("drop_background_audio")]
        public bool? DropBackgroundAudio { get; set; }

        /// <summary>
        /// [BETA] Whether transcripts should have profanities censored with the words '[censored]'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_profanity_filter")]
        public bool? UseProfanityFilter { get; set; }

        /// <summary>
        /// Whether to prepare dub for edits in dubbing studio or edits as a dubbing resource.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dubbing_studio")]
        public bool? DubbingStudio { get; set; }

        /// <summary>
        /// Instead of using a voice clone in dubbing, use a similar voice from the ElevenLabs Voice Library. Voices used from the library will contribute towards a workspace's custom voices limit, and if there aren't enough available slots the dub will fail. Using this feature requires the caller to have the 'add_voice_from_voice_library' permission on their workspace to access new voices.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable_voice_cloning")]
        public bool? DisableVoiceCloning { get; set; }

        /// <summary>
        /// The mode in which to run this Dubbing job. Defaults to automatic, use manual if specifically providing a CSV transcript to use. Note that manual mode is experimental and production use is strongly discouraged.<br/>
        /// Default Value: automatic
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BodyDubAVideoOrAnAudioFileV1DubbingPostModeJsonConverter))]
        public global::G.BodyDubAVideoOrAnAudioFileV1DubbingPostMode? Mode { get; set; }

        /// <summary>
        /// Frames per second to use when parsing a CSV file for dubbing. If not provided, FPS will be inferred from timecodes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("csv_fps")]
        public double? CsvFps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyDubAVideoOrAnAudioFileV1DubbingPost" /> class.
        /// </summary>
        /// <param name="file">
        /// A list of file paths to audio recordings intended for voice cloning
        /// </param>
        /// <param name="csvFile">
        /// CSV file containing transcription/translation metadata
        /// </param>
        /// <param name="foregroundAudioFile">
        /// For use only with csv input
        /// </param>
        /// <param name="backgroundAudioFile">
        /// For use only with csv input
        /// </param>
        /// <param name="name">
        /// Name of the dubbing project.
        /// </param>
        /// <param name="sourceUrl">
        /// URL of the source video/audio file.
        /// </param>
        /// <param name="sourceLang">
        /// Source language. Expects a valid iso639-1 or iso639-3 language code.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="targetLang">
        /// The Target language to dub the content into. Expects a valid iso639-1 or iso639-3 language code.
        /// </param>
        /// <param name="targetAccent">
        /// [Experimental] An accent to apply when selecting voices from the library and to use to inform translation of the dialect to prefer.
        /// </param>
        /// <param name="numSpeakers">
        /// Number of speakers to use for the dubbing. Set to 0 to automatically detect the number of speakers<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="watermark">
        /// Whether to apply watermark to the output video.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="startTime">
        /// Start time of the source video/audio file.
        /// </param>
        /// <param name="endTime">
        /// End time of the source video/audio file.
        /// </param>
        /// <param name="highestResolution">
        /// Whether to use the highest resolution available.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="dropBackgroundAudio">
        /// An advanced setting. Whether to drop background audio from the final dub. This can improve dub quality where it's known that audio shouldn't have a background track such as for speeches or monologues.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="useProfanityFilter">
        /// [BETA] Whether transcripts should have profanities censored with the words '[censored]'
        /// </param>
        /// <param name="dubbingStudio">
        /// Whether to prepare dub for edits in dubbing studio or edits as a dubbing resource.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="disableVoiceCloning">
        /// Instead of using a voice clone in dubbing, use a similar voice from the ElevenLabs Voice Library. Voices used from the library will contribute towards a workspace's custom voices limit, and if there aren't enough available slots the dub will fail. Using this feature requires the caller to have the 'add_voice_from_voice_library' permission on their workspace to access new voices.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="mode">
        /// The mode in which to run this Dubbing job. Defaults to automatic, use manual if specifically providing a CSV transcript to use. Note that manual mode is experimental and production use is strongly discouraged.<br/>
        /// Default Value: automatic
        /// </param>
        /// <param name="csvFps">
        /// Frames per second to use when parsing a CSV file for dubbing. If not provided, FPS will be inferred from timecodes.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyDubAVideoOrAnAudioFileV1DubbingPost(
            byte[]? file,
            byte[]? csvFile,
            byte[]? foregroundAudioFile,
            byte[]? backgroundAudioFile,
            string? name,
            string? sourceUrl,
            string? sourceLang,
            string? targetLang,
            string? targetAccent,
            int? numSpeakers,
            bool? watermark,
            int? startTime,
            int? endTime,
            bool? highestResolution,
            bool? dropBackgroundAudio,
            bool? useProfanityFilter,
            bool? dubbingStudio,
            bool? disableVoiceCloning,
            global::G.BodyDubAVideoOrAnAudioFileV1DubbingPostMode? mode,
            double? csvFps)
        {
            this.File = file;
            this.CsvFile = csvFile;
            this.ForegroundAudioFile = foregroundAudioFile;
            this.BackgroundAudioFile = backgroundAudioFile;
            this.Name = name;
            this.SourceUrl = sourceUrl;
            this.SourceLang = sourceLang;
            this.TargetLang = targetLang;
            this.TargetAccent = targetAccent;
            this.NumSpeakers = numSpeakers;
            this.Watermark = watermark;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.HighestResolution = highestResolution;
            this.DropBackgroundAudio = dropBackgroundAudio;
            this.UseProfanityFilter = useProfanityFilter;
            this.DubbingStudio = dubbingStudio;
            this.DisableVoiceCloning = disableVoiceCloning;
            this.Mode = mode;
            this.CsvFps = csvFps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyDubAVideoOrAnAudioFileV1DubbingPost" /> class.
        /// </summary>
        public BodyDubAVideoOrAnAudioFileV1DubbingPost()
        {
        }
    }
}