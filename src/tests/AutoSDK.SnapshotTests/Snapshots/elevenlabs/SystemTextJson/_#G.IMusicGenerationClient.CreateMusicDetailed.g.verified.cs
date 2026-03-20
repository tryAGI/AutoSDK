//HintName: G.IMusicGenerationClient.CreateMusicDetailed.g.cs
#nullable enable

namespace G
{
    public partial interface IMusicGenerationClient
    {

        /// <summary>
        /// Compose Music With A Detailed Response<br/>
        /// Compose a song from a prompt or a composition plan.
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
        global::System.Threading.Tasks.Task<byte[]> CreateMusicDetailedAsync(

            global::G.BodyComposeMusicWithADetailedResponseV1MusicDetailedPost request,
            global::G.AllowedOutputFormats? outputFormat = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Compose Music With A Detailed Response<br/>
        /// Compose a song from a prompt or a composition plan.
        /// </summary>
        /// <param name="outputFormat">
        /// Output format of the generated audio. Formatted as codec_sample_rate_bitrate. So an mp3 with 22.05kHz sample rate at 32kbs is represented as mp3_22050_32. MP3 with 192kbps bitrate requires you to be subscribed to Creator tier or above. PCM with 44.1kHz sample rate requires you to be subscribed to Pro tier or above. Note that the μ-law format (sometimes written mu-law, often approximated as u-law) is commonly used for Twilio audio inputs.<br/>
        /// Default Value: mp3_44100_128
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="prompt">
        /// A simple text prompt to generate a song from. Cannot be used in conjunction with `composition_plan`.
        /// </param>
        /// <param name="compositionPlan">
        /// A detailed composition plan to guide music generation. Cannot be used in conjunction with `prompt`.
        /// </param>
        /// <param name="musicLengthMs">
        /// The length of the song to generate in milliseconds. Used only in conjunction with `prompt`. Must be between 3000ms and 600000ms. Optional - if not provided, the model will choose a length based on the prompt.
        /// </param>
        /// <param name="modelId">
        /// The model to use for the generation.<br/>
        /// Default Value: music_v1
        /// </param>
        /// <param name="seed">
        /// Random seed to initialize the music generation process. Providing the same seed with the same parameters can help achieve more consistent results, but exact reproducibility is not guaranteed and outputs may change across system updates. Cannot be used in conjunction with prompt.
        /// </param>
        /// <param name="forceInstrumental">
        /// If true, guarantees that the generated song will be instrumental. If false, the song may or may not be instrumental depending on the `prompt`. Can only be used with `prompt`.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="finetuneId">
        /// The ID of the finetune to use for the generation
        /// </param>
        /// <param name="usePhoneticNames">
        /// If true, proper names in the prompt will be phonetically spelled in the lyrics for better pronunciation by the music model. The original names will be restored in word timestamps.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="respectSectionsDurations">
        /// Controls how strictly section durations in the `composition_plan` are enforced. Only used with `composition_plan`. When set to true, the model will precisely respect each section's `duration_ms` from the plan. When set to false, the model may adjust individual section durations which will generally lead to better generation quality and improved latency, while always preserving the total song duration from the plan.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="storeForInpainting">
        /// Whether to store the generated song for inpainting. Only available to enterprise clients with access to the inpainting feature.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="withTimestamps">
        /// Whether to return the timestamps of the words in the generated song.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="signWithC2pa">
        /// Whether to sign the generated song with C2PA. Applicable only for mp3 files.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<byte[]> CreateMusicDetailedAsync(
            global::G.AllowedOutputFormats? outputFormat = default,
            string? xiApiKey = default,
            string? prompt = default,
            global::G.MusicPrompt? compositionPlan = default,
            int? musicLengthMs = default,
            global::G.BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelId? modelId = default,
            int? seed = default,
            bool? forceInstrumental = default,
            string? finetuneId = default,
            bool? usePhoneticNames = default,
            bool? respectSectionsDurations = default,
            bool? storeForInpainting = default,
            bool? withTimestamps = default,
            bool? signWithC2pa = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}