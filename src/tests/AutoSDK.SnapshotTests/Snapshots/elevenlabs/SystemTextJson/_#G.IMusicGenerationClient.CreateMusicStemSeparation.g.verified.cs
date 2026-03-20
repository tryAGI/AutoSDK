//HintName: G.IMusicGenerationClient.CreateMusicStemSeparation.g.cs
#nullable enable

namespace G
{
    public partial interface IMusicGenerationClient
    {
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
        global::System.Threading.Tasks.Task<byte[]> CreateMusicStemSeparationAsync(

            global::G.BodyStemSeparationV1MusicStemSeparationPost request,
            global::G.AllowedOutputFormats? outputFormat = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
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
        global::System.Threading.Tasks.Task<byte[]> CreateMusicStemSeparationAsync(
            byte[] file,
            string filename,
            global::G.AllowedOutputFormats? outputFormat = default,
            string? xiApiKey = default,
            global::G.BodyStemSeparationV1MusicStemSeparationPostStemVariationId? stemVariationId = default,
            bool? signWithC2pa = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}