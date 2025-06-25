﻿//HintName: G.Models.BodyDubAVideoOrAnAudioFileV1DubbingPost.g.cs

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
        /// A list of file paths to audio recordings intended for voice cloning
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// CSV file containing transcription/translation metadata
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("csv_file")]
        public byte[]? CsvFile { get; set; }

        /// <summary>
        /// CSV file containing transcription/translation metadata
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("csv_filename")]
        public string? CsvFilename { get; set; }

        /// <summary>
        /// For use only with csv input
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("foreground_audio_file")]
        public byte[]? ForegroundAudioFile { get; set; }

        /// <summary>
        /// For use only with csv input
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("foreground_audio_filename")]
        public string? ForegroundAudioFilename { get; set; }

        /// <summary>
        /// For use only with csv input
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background_audio_file")]
        public byte[]? BackgroundAudioFile { get; set; }

        /// <summary>
        /// For use only with csv input
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background_audio_filename")]
        public string? BackgroundAudioFilename { get; set; }

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
        /// Source language.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_lang")]
        public string? SourceLang { get; set; }

        /// <summary>
        /// The Target language to dub the content into.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_lang")]
        public string? TargetLang { get; set; }

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
        /// [BETA] Instead of using a voice clone in dubbing, use a similar voice from the ElevenLabs Voice Library.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable_voice_cloning")]
        public bool? DisableVoiceCloning { get; set; }

        /// <summary>
        /// automatic or manual. Manual mode is only supported when creating a dubbing studio project<br/>
        /// Default Value: automatic
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        public string? Mode { get; set; }

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
        /// <param name="filename">
        /// A list of file paths to audio recordings intended for voice cloning
        /// </param>
        /// <param name="csvFile">
        /// CSV file containing transcription/translation metadata
        /// </param>
        /// <param name="csvFilename">
        /// CSV file containing transcription/translation metadata
        /// </param>
        /// <param name="foregroundAudioFile">
        /// For use only with csv input
        /// </param>
        /// <param name="foregroundAudioFilename">
        /// For use only with csv input
        /// </param>
        /// <param name="backgroundAudioFile">
        /// For use only with csv input
        /// </param>
        /// <param name="backgroundAudioFilename">
        /// For use only with csv input
        /// </param>
        /// <param name="name">
        /// Name of the dubbing project.
        /// </param>
        /// <param name="sourceUrl">
        /// URL of the source video/audio file.
        /// </param>
        /// <param name="sourceLang">
        /// Source language.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="targetLang">
        /// The Target language to dub the content into.
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
        /// [BETA] Instead of using a voice clone in dubbing, use a similar voice from the ElevenLabs Voice Library.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="mode">
        /// automatic or manual. Manual mode is only supported when creating a dubbing studio project<br/>
        /// Default Value: automatic
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyDubAVideoOrAnAudioFileV1DubbingPost(
            byte[]? file,
            string? filename,
            byte[]? csvFile,
            string? csvFilename,
            byte[]? foregroundAudioFile,
            string? foregroundAudioFilename,
            byte[]? backgroundAudioFile,
            string? backgroundAudioFilename,
            string? name,
            string? sourceUrl,
            string? sourceLang,
            string? targetLang,
            int? numSpeakers,
            bool? watermark,
            int? startTime,
            int? endTime,
            bool? highestResolution,
            bool? dropBackgroundAudio,
            bool? useProfanityFilter,
            bool? dubbingStudio,
            bool? disableVoiceCloning,
            string? mode)
        {
            this.File = file;
            this.Filename = filename;
            this.CsvFile = csvFile;
            this.CsvFilename = csvFilename;
            this.ForegroundAudioFile = foregroundAudioFile;
            this.ForegroundAudioFilename = foregroundAudioFilename;
            this.BackgroundAudioFile = backgroundAudioFile;
            this.BackgroundAudioFilename = backgroundAudioFilename;
            this.Name = name;
            this.SourceUrl = sourceUrl;
            this.SourceLang = sourceLang;
            this.TargetLang = targetLang;
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
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyDubAVideoOrAnAudioFileV1DubbingPost" /> class.
        /// </summary>
        public BodyDubAVideoOrAnAudioFileV1DubbingPost()
        {
        }
    }
}