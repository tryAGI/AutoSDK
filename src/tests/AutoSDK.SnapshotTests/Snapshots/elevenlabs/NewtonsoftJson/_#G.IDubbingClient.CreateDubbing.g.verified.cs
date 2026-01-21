//HintName: G.IDubbingClient.CreateDubbing.g.cs
#nullable enable

namespace G
{
    public partial interface IDubbingClient
    {
        /// <summary>
        /// Dub A Video Or An Audio File<br/>
        /// Dubs a provided audio or video file into given language.
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DoDubbingResponseModel> CreateDubbingAsync(
            global::G.BodyDubAVideoOrAnAudioFileV1DubbingPost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Dub A Video Or An Audio File<br/>
        /// Dubs a provided audio or video file into given language.
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DoDubbingResponseModel> CreateDubbingAsync(
            string? xiApiKey = default,
            byte[]? file = default,
            byte[]? csvFile = default,
            byte[]? foregroundAudioFile = default,
            byte[]? backgroundAudioFile = default,
            string? name = default,
            string? sourceUrl = default,
            string? sourceLang = default,
            string? targetLang = default,
            int? numSpeakers = default,
            bool? watermark = default,
            int? startTime = default,
            int? endTime = default,
            bool? highestResolution = default,
            bool? dropBackgroundAudio = default,
            bool? useProfanityFilter = default,
            bool? dubbingStudio = default,
            bool? disableVoiceCloning = default,
            string? mode = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}