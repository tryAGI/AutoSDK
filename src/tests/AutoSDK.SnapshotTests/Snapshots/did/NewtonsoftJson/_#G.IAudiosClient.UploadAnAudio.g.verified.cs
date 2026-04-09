//HintName: G.IAudiosClient.UploadAnAudio.g.cs
#nullable enable

namespace G
{
    public partial interface IAudiosClient
    {
        /// <summary>
        /// Upload audio file<br/>
        /// Upload an audio file to a temporary storage before creating an animation.<br/>
        /// The audio is uploaded using multipart/form-data. the filename directive is optional and if provided should contain up to 50 valid characters long.<br/>
        /// The resulting file is stored as a .wav file in a 16kHz sample rate.<br/>
        /// Valid characters: a-z A-Z 0-9 . _ -<br/>
        /// Supported mime types: "audio/, video/"<br/>
        /// Storage duration: 24-48H
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.UploadAnAudioResponse> UploadAnAudioAsync(

            global::G.UploadAnAudioRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload audio file<br/>
        /// Upload an audio file to a temporary storage before creating an animation.<br/>
        /// The audio is uploaded using multipart/form-data. the filename directive is optional and if provided should contain up to 50 valid characters long.<br/>
        /// The resulting file is stored as a .wav file in a 16kHz sample rate.<br/>
        /// Valid characters: a-z A-Z 0-9 . _ -<br/>
        /// Supported mime types: "audio/, video/"<br/>
        /// Storage duration: 24-48H
        /// </summary>
        /// <param name="audio">
        /// The uploaded audio file, the file must not exceed 6MB in size.
        /// </param>
        /// <param name="audioname">
        /// The uploaded audio file, the file must not exceed 6MB in size.
        /// </param>
        /// <param name="sourceUrl"></param>
        /// <param name="resultUrl">
        /// A URL to upload the audio to. If provided, the audio will be uploaded to this URL instead of the default bucket. https presigned URL supported. S3 presigned urls should have the putObject permission with content type audio/wav.
        /// </param>
        /// <param name="persist"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UploadAnAudioResponse> UploadAnAudioAsync(
            byte[]? audio = default,
            string? audioname = default,
            string? sourceUrl = default,
            string? resultUrl = default,
            string? persist = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}